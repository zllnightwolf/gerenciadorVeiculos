namespace gerenciadorVeiculos.View
{
    partial class TelaBuscarVeiculo
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
            button1 = new Button();
            tabPage1 = new TabPage();
            textBoxCor = new TextBox();
            textBoxPlaca = new TextBox();
            textBoxNome = new TextBox();
            textBoxAno = new TextBox();
            textBoxModelo = new TextBox();
            textBoxMarca = new TextBox();
            textBoxCodigo = new TextBox();
            label8 = new Label();
            btnBuscar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 30);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 1;
            label1.Text = "Buscar Veículos";
            // 
            // button1
            // 
            button1.Font = new Font("LEMON MILK Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1378, 135);
            button1.Name = "button1";
            button1.Size = new Size(122, 31);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(textBoxCor);
            tabPage1.Controls.Add(textBoxPlaca);
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(textBoxAno);
            tabPage1.Controls.Add(textBoxModelo);
            tabPage1.Controls.Add(textBoxMarca);
            tabPage1.Controls.Add(textBoxCodigo);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(754, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Por Código";
            // 
            // textBoxCor
            // 
            textBoxCor.Location = new Point(480, 227);
            textBoxCor.Name = "textBoxCor";
            textBoxCor.Size = new Size(189, 23);
            textBoxCor.TabIndex = 14;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(480, 170);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(189, 23);
            textBoxPlaca.TabIndex = 11;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(188, 109);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(178, 23);
            textBoxNome.TabIndex = 10;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(188, 165);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(178, 23);
            textBoxAno.TabIndex = 9;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(188, 222);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(178, 23);
            textBoxModelo.TabIndex = 8;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(480, 109);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(189, 23);
            textBoxMarca.TabIndex = 7;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(188, 36);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(178, 23);
            textBoxCodigo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(128, 166);
            label8.Name = "label8";
            label8.Size = new Size(37, 17);
            label8.TabIndex = 13;
            label8.Text = "Ano:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("LEMON MILK Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(512, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(157, 38);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(423, 228);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 5;
            label7.Text = "Cor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(413, 171);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 4;
            label6.Text = "Placa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(106, 218);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 3;
            label5.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(408, 115);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 2;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 1;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(179, 17);
            label2.TabIndex = 0;
            label2.Text = "Digíte o Código do Veículo:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(762, 344);
            tabControl1.TabIndex = 0;
            // 
            // TelaBuscarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 474);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "TelaBuscarVeiculo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaBuscarVeiculo";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TabPage tabPage1;
        private TextBox textBoxCor;
        private TextBox textBoxPlaca;
        private TextBox textBoxNome;
        private TextBox textBoxAno;
        private TextBox textBoxModelo;
        private TextBox textBoxMarca;
        private TextBox textBoxCodigo;
        private Label label8;
        private Button btnBuscar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabControl tabControl1;
    }
}