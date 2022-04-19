using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DGEN
{
    internal class Faces
    {
        List<int> verticesDaFace = new List<int>();
        bool visivel = false;

        public void addVertice(int vertice)
        {
            verticesDaFace.Add(vertice);
        }

        public void setVisibilidade(bool entrada)
        {
            visivel = entrada;
        }

        public bool getVisibilidade()
        {
            return visivel;
        }

        public List<int> getverticesDaFace()
        {
            return verticesDaFace;
        }


    }
}
