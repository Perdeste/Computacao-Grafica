using System.Drawing;

namespace _3DGEN
{
    public partial class Main : Form
    {
        List<Vertice> verticeList = new List<Vertice>();
        List<Aresta> arestasList = new List<Aresta>();
        float xmin = float.MaxValue;
        float xmax = float.MinValue;

        float ymin = float.MaxValue;
        float ymax = float.MinValue;
        public Main()
        {
            InitializeComponent();

        }
 
        private float[,] Mobject() //Retorna uma matriz 4 x (número de Vértices)
        {
            float[,] saida = new float[4,verticeList.Count];
            for (int i = 0; i < verticeList.Count; i++)
            {
                saida[0, i] = verticeList[i].x;
                saida[1, i] = verticeList[i].y;
                saida[2, i] = verticeList[i].z;
                saida[3, i] = 1;
            }

            /*for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < verticeList.Count; b++)
                {
                    textBoxTeste.AppendText(saida[a,b].ToString() + " ");
                }
                textBoxTeste.AppendText("\r\n");
            }*/

            return saida;
        }

        private float[,] Mper() //Retorna uma matriz 4 x 4
        {
            Vertice pontoVista = new Vertice(Convert.ToInt32(numericPV_x.Value),Convert.ToInt32(numericPV_y.Value),Convert.ToInt32(numericPV_z.Value));
            Vertice pontoA = new Vertice(Convert.ToInt32(numericPlanoPonto1_x.Value), Convert.ToInt32(numericPlanoPonto1_y.Value),Convert.ToInt32(numericPlanoPonto1_z.Value));
            Vertice pontoB = new Vertice(Convert.ToInt32(numericPlanoPonto2_x.Value), Convert.ToInt32(numericPlanoPonto2_y.Value), Convert.ToInt32(numericPlanoPonto2_z.Value));
            Vertice pontoC = new Vertice(Convert.ToInt32(numericPlanoPonto3_x.Value), Convert.ToInt32(numericPlanoPonto3_y.Value), Convert.ToInt32(numericPlanoPonto3_z.Value));

            float[] vetorAB = {(pontoB.x - pontoA.x),(pontoB.y - pontoA.y),(pontoB.z - pontoA.z)};
            float[] vetorAC = {(pontoC.x - pontoA.x), (pontoC.y - pontoA.y), (pontoC.z - pontoA.z)};

            float i = (vetorAB[1] * vetorAC[2]) - (vetorAB[2] * vetorAC[1]);
            float j = (vetorAB[2] * vetorAC[0]) - (vetorAB[0] * vetorAC[2]);
            float k = (vetorAB[0] * vetorAC[1]) - (vetorAB[1] * vetorAC[0]);

            float d0 = pontoA.x*i + pontoA.y*j + pontoA.z*k;
            float d1 = pontoVista.x*i + pontoVista.y*j + pontoVista.z*k;
            float d = d0 - d1;

            float[,] saida = {
                {d + (pontoVista.x * i), pontoVista.x * j,pontoVista.x * k,-(pontoVista.x * d0)},
                {pontoVista.y * i, d + (pontoVista.y * j), pontoVista.y * k, -(pontoVista.y * d0)},
                {pontoVista.z * i, pontoVista.z * j, d + (pontoVista.z * k), -(pontoVista.z * d0)},
                {i, j, k, -d1}
            };

            /*for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    textBoxTeste.AppendText(saida[a,b].ToString() + " ");
                }
                textBoxTeste.AppendText("\r\n");
            }*/
            

            return saida;
        }

        private void MobjectLinha() //Calcula o M', porém guarda os valores de x e y dos vértice no verticeList
        {
            float[,] saida = produtoMatriz(Mper(),Mobject());

            /*for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < verticeList.Count; b++)
                {
                    textBoxTeste.AppendText(saida[a,b].ToString() + " ");
                }
                textBoxTeste.AppendText("\r\n");
            }*/

            for (int i = 0; i < verticeList.Count; i++)
            {
                verticeList[i].x = saida[0, i] / saida[3, i];
                if(verticeList[i].x <= xmin) xmin = verticeList[i].x;
                if(verticeList[i].x > xmax) xmax = verticeList[i].x;

                verticeList[i].y = saida[1, i] / saida[3, i];
                if (verticeList[i].y <= ymin) ymin = verticeList[i].y;
                if (verticeList[i].y > ymax) ymax = verticeList[i].y;

                verticeList[i].z = 1;
            }

            /*textBoxTeste.AppendText(xmin.ToString() + " " + ymin.ToString() + " " + xmax.ToString() + " " + ymax.ToString() + "\r\n");

            foreach (Vertice vertice in verticeList)
            {
                textBoxTeste.AppendText(vertice.x.ToString() + " " + vertice.y.ToString() + " " + vertice.z.ToString() + "\r\n");
            }*/
        }

        private float[,] Tviewport() //Calcula o vetor 3 x 3 viewport
        {
            float Sx = 800 / (xmax - xmin);
            float Sy = 600 / (ymax - ymin);
            float[,] saida =
            {
                {Sx,0,-Sx * xmin},
                {0,-Sy,Sy * ymax},
                {0,0,1}
            };

            /*for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    textBoxTeste.AppendText(saida[a,b].ToString() + " ");
                }
                textBoxTeste.AppendText("\r\n");
            }*/

            return saida;
        }

        private void MobjectDCS() //Calcula 
        {
            float[,] MobjectWCS = new float[3,verticeList.Count];

            for (int i = 0; i < verticeList.Count; i++)
            {
                MobjectWCS[0, i] = verticeList[i].x;
                MobjectWCS[1, i] = verticeList[i].y;
                MobjectWCS[2, i] = verticeList[i].z;
            }

            float[,] saida = produtoMatriz(Tviewport(),MobjectWCS);

            for (int i = 0; i < verticeList.Count; i++)
            {
                verticeList[i].x = saida[0, i];
                verticeList[i].y = saida[1, i];
                verticeList[i].z = 1;
            }

        }

        private float[,] produtoMatriz(float[,] matrizA, float[,] matrizB)
        {
            float[,] saida = new float[matrizA.GetLength(0),matrizB.GetLength(1)];
            float valor = 0;
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    valor = 0;
                    for (int k = 0; k < matrizA.GetLength(0); k++)
                    {
                        valor = valor + (matrizA[i, k] * matrizB[k,j]);
                    }
                    saida[i, j] = valor;
                }
            }
            return saida;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            MobjectLinha();
            MobjectDCS();

            /*foreach (Vertice vertice in verticeList)
            {
                textBoxTeste.AppendText(vertice.x.ToString() + ", " + vertice.y.ToString() + ", " + vertice.z.ToString() + "\r\n");
            }*/
            painelDesenho.Refresh();
        }

        private void painelDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Aresta aresta in arestasList)
            {
                Vertice A = verticeList[aresta.getVerticeA()];
                Vertice B = verticeList[aresta.getVerticeB()];
                g.DrawLine(new Pen(Color.White, 2), A.x, A.y, B.x, B.y);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                verticeList.Clear();
                arestasList.Clear();

                string entrada = "D:\\UEM\\CG\\" + textBoxEntrada.Text + ".txt";

                string[] linhas = System.IO.File.ReadAllLines(entrada);

                buttonOK.BackColor = Color.GreenYellow;

                foreach (string line in linhas)
                {
                    string[] buffer = line.Split(',');
                    if (buffer.Length == 2)
                    {
                        int verticeA = Convert.ToInt32(buffer[0]);
                        int verticeB = Convert.ToInt32(buffer[1]);
                        arestasList.Add(new Aresta(verticeA, verticeB));
                    }
                    else
                    {
                        int x = Convert.ToInt32(buffer[0]);
                        int y = Convert.ToInt32(buffer[1]);
                        int z = Convert.ToInt32(buffer[2]);
                        verticeList.Add(new Vertice(x, y, z));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                buttonOK.BackColor = Color.Red;
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}