namespace gerenciadorVeiculos.View
{
    partial class TelaBuscarPorEspecificacao
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
            textBoxEspecificacao = new TextBox();
            btnBuscarEspec = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEspecificacao
            // 
            textBoxEspecificacao.Location = new Point(240, 111);
            textBoxEspecificacao.Name = "textBoxEspecificacao";
            textBoxEspecificacao.Size = new Size(309, 23);
            textBoxEspecificacao.TabIndex = 11;
            // 
            // btnBuscarEspec
            // 
            btnBuscarEspec.Font = new Font("LEMON MILK Bold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarEspec.Location = new Point(609, 104);
            btnBuscarEspec.Name = "btnBuscarEspec";
            btnBuscarEspec.Size = new Size(122, 31);
            btnBuscarEspec.TabIndex = 10;
            btnBuscarEspec.Text = "Buscar";
            btnBuscarEspec.UseVisualStyleBackColor = true;
            btnBuscarEspec.Click += btnBuscarEspec_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(64, 112);
            label9.Name = "label9";
            label9.Size = new Size(170, 17);
            label9.TabIndex = 9;
            label9.Text = "Digite o nome do Veículo:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column7, Column4, Column6, Column3 });
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(36, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 272);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.HeaderText = "Modelo";
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ano";
            Column7.Name = "Column7";
            // 
            // Column4
            // 
            Column4.HeaderText = "Placa";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cor";
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.HeaderText = "Marca";
            Column3.Name = "Column3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 34);
            label1.Name = "label1";
            label1.Size = new Size(611, 38);
            label1.TabIndex = 12;
            label1.Text = "Buscar Veículos Por Especificação";
            // 
            // TelaBuscarPorEspecificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxEspecificacao);
            Controls.Add(btnBuscarEspec);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "TelaBuscarPorEspecificacao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaBuscarPorEspecificacao";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEspecificacao;
        private Button btnBuscarEspec;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label1;
    }
}