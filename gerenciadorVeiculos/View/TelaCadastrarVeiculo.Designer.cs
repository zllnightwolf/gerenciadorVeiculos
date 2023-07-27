namespace gerenciadorVeiculos.View
{
    partial class TelaCadastrarVeiculo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxNome = new TextBox();
            textBoxMarca = new TextBox();
            textBoxAno = new TextBox();
            textBoxModelo = new TextBox();
            textBoxPlaca = new TextBox();
            textBoxCor = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 49);
            label1.Name = "label1";
            label1.Size = new Size(339, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Veículo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 149);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(432, 155);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(138, 202);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 3;
            label4.Text = "Ano:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(116, 252);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 4;
            label5.Text = "Modelo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(442, 252);
            label6.Name = "label6";
            label6.Size = new Size(34, 17);
            label6.TabIndex = 5;
            label6.Text = "Cor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(432, 202);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 6;
            label7.Text = "Placa:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(201, 149);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(174, 23);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(507, 148);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(167, 23);
            textBoxMarca.TabIndex = 8;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(201, 202);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(174, 23);
            textBoxAno.TabIndex = 9;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(201, 252);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(174, 23);
            textBoxModelo.TabIndex = 10;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(507, 196);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(167, 23);
            textBoxPlaca.TabIndex = 11;
            // 
            // textBoxCor
            // 
            textBoxCor.Location = new Point(507, 246);
            textBoxCor.Name = "textBoxCor";
            textBoxCor.Size = new Size(167, 23);
            textBoxCor.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(299, 334);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(216, 53);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaCadastrarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(textBoxCor);
            Controls.Add(textBoxPlaca);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastrarVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCadastrarVeiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxNome;
        private TextBox textBoxMarca;
        private TextBox textBoxAno;
        private TextBox textBoxModelo;
        private TextBox textBoxPlaca;
        private TextBox textBoxCor;
        private Button btnCadastrar;
    }
}