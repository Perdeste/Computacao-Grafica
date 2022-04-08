namespace _3DGEN
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericPV_x = new System.Windows.Forms.NumericUpDown();
            this.TÍTULO = new System.Windows.Forms.Label();
            this.painelDesenho = new System.Windows.Forms.Panel();
            this.textBoxTeste = new System.Windows.Forms.TextBox();
            this.numericPV_y = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.numericPV_z = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPV = new System.Windows.Forms.GroupBox();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.groupBoxPlano = new System.Windows.Forms.GroupBox();
            this.numericPlanoPonto1_x = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto2_x = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto3_z = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto1_y = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto3_y = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto2_y = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto3_x = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto1_z = new System.Windows.Forms.NumericUpDown();
            this.numericPlanoPonto2_z = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_z)).BeginInit();
            this.groupBoxPV.SuspendLayout();
            this.groupBoxEntrada.SuspendLayout();
            this.groupBoxPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_z)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPV_x
            // 
            this.numericPV_x.AllowDrop = true;
            this.numericPV_x.Location = new System.Drawing.Point(12, 43);
            this.numericPV_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPV_x.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPV_x.Name = "numericPV_x";
            this.numericPV_x.Size = new System.Drawing.Size(82, 34);
            this.numericPV_x.TabIndex = 0;
            // 
            // TÍTULO
            // 
            this.TÍTULO.AutoSize = true;
            this.TÍTULO.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TÍTULO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TÍTULO.Location = new System.Drawing.Point(12, 9);
            this.TÍTULO.Name = "TÍTULO";
            this.TÍTULO.Size = new System.Drawing.Size(366, 45);
            this.TÍTULO.TabIndex = 1;
            this.TÍTULO.Text = "CG - 3D GENERATOR";
            // 
            // painelDesenho
            // 
            this.painelDesenho.BackColor = System.Drawing.SystemColors.WindowText;
            this.painelDesenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDesenho.Location = new System.Drawing.Point(398, 24);
            this.painelDesenho.Name = "painelDesenho";
            this.painelDesenho.Size = new System.Drawing.Size(800, 600);
            this.painelDesenho.TabIndex = 2;
            this.painelDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.painelDesenho_Paint);
            // 
            // textBoxTeste
            // 
            this.textBoxTeste.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTeste.Location = new System.Drawing.Point(12, 539);
            this.textBoxTeste.Multiline = true;
            this.textBoxTeste.Name = "textBoxTeste";
            this.textBoxTeste.Size = new System.Drawing.Size(345, 73);
            this.textBoxTeste.TabIndex = 14;
            // 
            // numericPV_y
            // 
            this.numericPV_y.AllowDrop = true;
            this.numericPV_y.Location = new System.Drawing.Point(126, 43);
            this.numericPV_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPV_y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPV_y.Name = "numericPV_y";
            this.numericPV_y.Size = new System.Drawing.Size(82, 34);
            this.numericPV_y.TabIndex = 4;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Lime;
            this.buttonGenerate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(12, 467);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(345, 47);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Gerar";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.generate_Click);
            // 
            // numericPV_z
            // 
            this.numericPV_z.AllowDrop = true;
            this.numericPV_z.Location = new System.Drawing.Point(242, 43);
            this.numericPV_z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPV_z.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPV_z.Name = "numericPV_z";
            this.numericPV_z.Size = new System.Drawing.Size(82, 34);
            this.numericPV_z.TabIndex = 7;
            // 
            // groupBoxPV
            // 
            this.groupBoxPV.Controls.Add(this.numericPV_x);
            this.groupBoxPV.Controls.Add(this.numericPV_y);
            this.groupBoxPV.Controls.Add(this.numericPV_z);
            this.groupBoxPV.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPV.Location = new System.Drawing.Point(12, 160);
            this.groupBoxPV.Name = "groupBoxPV";
            this.groupBoxPV.Size = new System.Drawing.Size(345, 99);
            this.groupBoxPV.TabIndex = 13;
            this.groupBoxPV.TabStop = false;
            this.groupBoxPV.Text = "Ponto De Vista";
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Controls.Add(this.buttonOK);
            this.groupBoxEntrada.Controls.Add(this.textBoxEntrada);
            this.groupBoxEntrada.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEntrada.Location = new System.Drawing.Point(12, 69);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(345, 85);
            this.groupBoxEntrada.TabIndex = 14;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Arquivo De Entrada";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Red;
            this.buttonOK.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(285, 33);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(54, 34);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEntrada.Location = new System.Drawing.Point(12, 33);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.PlaceholderText = "Digite o nome do arquivo .txt";
            this.textBoxEntrada.Size = new System.Drawing.Size(267, 34);
            this.textBoxEntrada.TabIndex = 12;
            // 
            // groupBoxPlano
            // 
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto1_x);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto2_x);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto3_z);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto1_y);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto3_y);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto2_y);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto3_x);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto1_z);
            this.groupBoxPlano.Controls.Add(this.numericPlanoPonto2_z);
            this.groupBoxPlano.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPlano.Location = new System.Drawing.Point(12, 265);
            this.groupBoxPlano.Name = "groupBoxPlano";
            this.groupBoxPlano.Size = new System.Drawing.Size(345, 196);
            this.groupBoxPlano.TabIndex = 14;
            this.groupBoxPlano.TabStop = false;
            this.groupBoxPlano.Text = "Plano";
            // 
            // numericPlanoPonto1_x
            // 
            this.numericPlanoPonto1_x.AllowDrop = true;
            this.numericPlanoPonto1_x.Location = new System.Drawing.Point(12, 43);
            this.numericPlanoPonto1_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto1_x.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto1_x.Name = "numericPlanoPonto1_x";
            this.numericPlanoPonto1_x.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto1_x.TabIndex = 0;
            // 
            // numericPlanoPonto2_x
            // 
            this.numericPlanoPonto2_x.AllowDrop = true;
            this.numericPlanoPonto2_x.Location = new System.Drawing.Point(12, 89);
            this.numericPlanoPonto2_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto2_x.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto2_x.Name = "numericPlanoPonto2_x";
            this.numericPlanoPonto2_x.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto2_x.TabIndex = 3;
            // 
            // numericPlanoPonto3_z
            // 
            this.numericPlanoPonto3_z.AllowDrop = true;
            this.numericPlanoPonto3_z.Location = new System.Drawing.Point(242, 139);
            this.numericPlanoPonto3_z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto3_z.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto3_z.Name = "numericPlanoPonto3_z";
            this.numericPlanoPonto3_z.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto3_z.TabIndex = 11;
            // 
            // numericPlanoPonto1_y
            // 
            this.numericPlanoPonto1_y.AllowDrop = true;
            this.numericPlanoPonto1_y.Location = new System.Drawing.Point(126, 43);
            this.numericPlanoPonto1_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto1_y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto1_y.Name = "numericPlanoPonto1_y";
            this.numericPlanoPonto1_y.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto1_y.TabIndex = 4;
            // 
            // numericPlanoPonto3_y
            // 
            this.numericPlanoPonto3_y.AllowDrop = true;
            this.numericPlanoPonto3_y.Location = new System.Drawing.Point(126, 139);
            this.numericPlanoPonto3_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto3_y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto3_y.Name = "numericPlanoPonto3_y";
            this.numericPlanoPonto3_y.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto3_y.TabIndex = 10;
            // 
            // numericPlanoPonto2_y
            // 
            this.numericPlanoPonto2_y.AllowDrop = true;
            this.numericPlanoPonto2_y.Location = new System.Drawing.Point(126, 89);
            this.numericPlanoPonto2_y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto2_y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto2_y.Name = "numericPlanoPonto2_y";
            this.numericPlanoPonto2_y.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto2_y.TabIndex = 5;
            // 
            // numericPlanoPonto3_x
            // 
            this.numericPlanoPonto3_x.AllowDrop = true;
            this.numericPlanoPonto3_x.Location = new System.Drawing.Point(12, 139);
            this.numericPlanoPonto3_x.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto3_x.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto3_x.Name = "numericPlanoPonto3_x";
            this.numericPlanoPonto3_x.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto3_x.TabIndex = 9;
            // 
            // numericPlanoPonto1_z
            // 
            this.numericPlanoPonto1_z.AllowDrop = true;
            this.numericPlanoPonto1_z.Location = new System.Drawing.Point(242, 43);
            this.numericPlanoPonto1_z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto1_z.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto1_z.Name = "numericPlanoPonto1_z";
            this.numericPlanoPonto1_z.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto1_z.TabIndex = 7;
            // 
            // numericPlanoPonto2_z
            // 
            this.numericPlanoPonto2_z.AllowDrop = true;
            this.numericPlanoPonto2_z.Location = new System.Drawing.Point(242, 89);
            this.numericPlanoPonto2_z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPlanoPonto2_z.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericPlanoPonto2_z.Name = "numericPlanoPonto2_z";
            this.numericPlanoPonto2_z.Size = new System.Drawing.Size(82, 34);
            this.numericPlanoPonto2_z.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 644);
            this.Controls.Add(this.textBoxTeste);
            this.Controls.Add(this.groupBoxPlano);
            this.Controls.Add(this.groupBoxEntrada);
            this.Controls.Add(this.groupBoxPV);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.painelDesenho);
            this.Controls.Add(this.TÍTULO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Main";
            this.Text = "3D Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPV_z)).EndInit();
            this.groupBoxPV.ResumeLayout(false);
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.groupBoxPlano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto3_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto1_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlanoPonto2_z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericPV_x;
        private Label TÍTULO;
        private Panel painelDesenho;
        private NumericUpDown numericPV_y;
        private Button buttonGenerate;
        private NumericUpDown numericPV_z;
        private GroupBox groupBoxPV;
        private GroupBox groupBoxEntrada;
        private GroupBox groupBoxPlano;
        private NumericUpDown numericPlanoPonto1_x;
        private NumericUpDown numericPlanoPonto2_x;
        private NumericUpDown numericPlanoPonto3_z;
        private NumericUpDown numericPlanoPonto1_y;
        private NumericUpDown numericPlanoPonto3_y;
        private NumericUpDown numericPlanoPonto2_y;
        private NumericUpDown numericPlanoPonto3_x;
        private NumericUpDown numericPlanoPonto1_z;
        private NumericUpDown numericPlanoPonto2_z;
        private TextBox textBoxEntrada;
        private Button buttonOK;
        private TextBox textBoxTeste;
    }
}