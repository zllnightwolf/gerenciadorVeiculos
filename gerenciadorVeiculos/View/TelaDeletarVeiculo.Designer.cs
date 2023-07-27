namespace gerenciadorVeiculos.View
{
    partial class TelaDeletarVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnDeletar = new Button();
            btnBuscar = new Button();
            textBoxCor = new TextBox();
            textBoxModelo = new TextBox();
            textBoxMarca = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxPlaca = new TextBox();
            textBoxAno = new TextBox();
            textBoxNome = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            textBoxCodigoVer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 22);
            label1.Name = "label1";
            label1.Size = new Size(285, 38);
            label1.TabIndex = 0;
            label1.Text = "Deletar Veículo";
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("LEMON MILK Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletar.Location = new Point(324, 404);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(133, 53);
            btnDeletar.TabIndex = 32;
            btnDeletar.Text = "deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("LEMON MILK Bold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(472, 131);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 25);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBoxCor
            // 
            textBoxCor.Location = new Point(472, 349);
            textBoxCor.Name = "textBoxCor";
            textBoxCor.Size = new Size(208, 23);
            textBoxCor.TabIndex = 30;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(144, 344);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(216, 23);
            textBoxModelo.TabIndex = 29;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(472, 234);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(208, 23);
            textBoxMarca.TabIndex = 28;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(261, 133);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(169, 23);
            textBoxCodigo.TabIndex = 27;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(472, 293);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(208, 23);
            textBoxPlaca.TabIndex = 26;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(144, 293);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(217, 23);
            textBoxAno.TabIndex = 25;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(144, 235);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(217, 23);
            textBoxNome.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(79, 345);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 23;
            label8.Text = "Modelo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(413, 299);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 22;
            label7.Text = "Placa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(423, 350);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 21;
            label6.Text = "Cor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(101, 294);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 20;
            label5.Text = "Ano:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(408, 235);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 19;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 240);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 18;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 96);
            label2.Name = "label2";
            label2.Size = new Size(294, 17);
            label2.TabIndex = 17;
            label2.Text = "Digite o código do veículo que deseja deletar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(82, 194);
            label9.Name = "label9";
            label9.Size = new Size(56, 17);
            label9.TabIndex = 33;
            label9.Text = "Código:";
            // 
            // textBoxCodigoVer
            // 
            textBoxCodigoVer.Location = new Point(144, 188);
            textBoxCodigoVer.Name = "textBoxCodigoVer";
            textBoxCodigoVer.Size = new Size(101, 23);
            textBoxCodigoVer.TabIndex = 34;
            // 
            // TelaDeletarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(810, 477);
            Controls.Add(textBoxCodigoVer);
            Controls.Add(label9);
            Controls.Add(btnDeletar);
            Controls.Add(btnBuscar);
            Controls.Add(textBoxCor);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxPlaca);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxNome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaDeletarVeiculo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeletarVeiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDeletar;
        private Button btnBuscar;
        private TextBox textBoxCor;
        private TextBox textBoxModelo;
        private TextBox textBoxMarca;
        private TextBox textBoxCodigo;
        private TextBox textBoxPlaca;
        private TextBox textBoxAno;
        private TextBox textBoxNome;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private TextBox textBoxCodigoVer;
    }
}