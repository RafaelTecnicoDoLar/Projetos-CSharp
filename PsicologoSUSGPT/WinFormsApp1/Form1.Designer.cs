namespace WinFormsApp1
{
    partial class Form1
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
            Letreiro = new Label();
            Chorro = new Button();
            label1 = new Label();
            Depressao = new Button();
            Tristeza = new Button();
            Chifre = new Button();
            Separrou = new Button();
            Saudade = new Button();
            Limpar = new Button();
            Solidao = new Button();
            SuspendLayout();
            // 
            // Letreiro
            // 
            Letreiro.AutoSize = true;
            Letreiro.Location = new Point(70, 236);
            Letreiro.Name = "Letreiro";
            Letreiro.Size = new Size(127, 15);
            Letreiro.TabIndex = 1;
            Letreiro.Text = "Clique em uma opção!";
            Letreiro.Click += Letreiro_Click;
            // 
            // Chorro
            // 
            Chorro.Location = new Point(78, 27);
            Chorro.Name = "Chorro";
            Chorro.Size = new Size(106, 23);
            Chorro.TabIndex = 3;
            Chorro.Text = "Chorro";
            Chorro.UseVisualStyleBackColor = true;
            Chorro.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = "Qual são os sintomas";
            // 
            // Depressao
            // 
            Depressao.Location = new Point(78, 85);
            Depressao.Name = "Depressao";
            Depressao.Size = new Size(106, 23);
            Depressao.TabIndex = 5;
            Depressao.Text = "Depressão";
            Depressao.UseVisualStyleBackColor = true;
            Depressao.Click += Depressao_Click;
            // 
            // Tristeza
            // 
            Tristeza.Location = new Point(78, 56);
            Tristeza.Name = "Tristeza";
            Tristeza.Size = new Size(106, 23);
            Tristeza.TabIndex = 6;
            Tristeza.Text = "Tristeza";
            Tristeza.UseVisualStyleBackColor = true;
            Tristeza.Click += Tristeza_Click;
            // 
            // Chifre
            // 
            Chifre.Location = new Point(78, 114);
            Chifre.Name = "Chifre";
            Chifre.Size = new Size(106, 23);
            Chifre.TabIndex = 7;
            Chifre.Text = "Tomou Chifre";
            Chifre.UseVisualStyleBackColor = true;
            Chifre.Click += Chifre_Click;
            // 
            // Separrou
            // 
            Separrou.Location = new Point(78, 143);
            Separrou.Name = "Separrou";
            Separrou.Size = new Size(106, 23);
            Separrou.TabIndex = 8;
            Separrou.Text = "Separou";
            Separrou.UseVisualStyleBackColor = true;
            Separrou.Click += Separrou_Click;
            // 
            // Saudade
            // 
            Saudade.Location = new Point(78, 172);
            Saudade.Name = "Saudade";
            Saudade.Size = new Size(106, 23);
            Saudade.TabIndex = 9;
            Saudade.Text = "Saudade da EX";
            Saudade.UseVisualStyleBackColor = true;
            Saudade.Click += Saudade_Click;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(146, 265);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(106, 23);
            Limpar.TabIndex = 10;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += button1_Click_1;
            // 
            // Solidao
            // 
            Solidao.Location = new Point(78, 201);
            Solidao.Name = "Solidao";
            Solidao.Size = new Size(106, 23);
            Solidao.TabIndex = 11;
            Solidao.Text = "Solidão";
            Solidao.UseVisualStyleBackColor = true;
            Solidao.Click += Solidao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 300);
            Controls.Add(Solidao);
            Controls.Add(Limpar);
            Controls.Add(Saudade);
            Controls.Add(Separrou);
            Controls.Add(Chifre);
            Controls.Add(Tristeza);
            Controls.Add(Depressao);
            Controls.Add(label1);
            Controls.Add(Chorro);
            Controls.Add(Letreiro);
            Name = "Form1";
            Text = "Psicóloco SUS GPT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Letreiro;
        private Button Chorro;
        private Label label1;
        private Button Depressao;
        private Button Tristeza;
        private Button Chifre;
        private Button Separrou;
        private Button Saudade;
        private Button Limpar;
        private Button Solidao;
    }
}
