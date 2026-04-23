namespace Projecto_YII.Projecto.YII.View
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            panel1 = new Panel();
            pictureBoxActualizarDataGr = new PictureBox();
            textBoxID_Cliente = new TextBox();
            label3 = new Label();
            maskedTextBoxTelefoneCliente = new MaskedTextBox();
            label1 = new Label();
            textBoxPesqClientes = new TextBox();
            dataGridViewClientes = new DataGridView();
            textBoxEnderecoCliente = new TextBox();
            textBoxNomeCliente = new TextBox();
            buttonGuardarCliente = new Button();
            buttonRemoverCliente = new Button();
            buttonEditarCliente = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBoxActualizarDataGr);
            panel1.Controls.Add(textBoxID_Cliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(maskedTextBoxTelefoneCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPesqClientes);
            panel1.Controls.Add(dataGridViewClientes);
            panel1.Controls.Add(textBoxEnderecoCliente);
            panel1.Controls.Add(textBoxNomeCliente);
            panel1.Controls.Add(buttonGuardarCliente);
            panel1.Controls.Add(buttonRemoverCliente);
            panel1.Controls.Add(buttonEditarCliente);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 874);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBoxActualizarDataGr
            // 
            pictureBoxActualizarDataGr.Cursor = Cursors.Hand;
            pictureBoxActualizarDataGr.Image = (Image)resources.GetObject("pictureBoxActualizarDataGr.Image");
            pictureBoxActualizarDataGr.Location = new Point(860, 787);
            pictureBoxActualizarDataGr.Name = "pictureBoxActualizarDataGr";
            pictureBoxActualizarDataGr.Size = new Size(27, 26);
            pictureBoxActualizarDataGr.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxActualizarDataGr.TabIndex = 202;
            pictureBoxActualizarDataGr.TabStop = false;
            pictureBoxActualizarDataGr.Click += pictureBoxActualizarDataGr_Click;
            // 
            // textBoxID_Cliente
            // 
            textBoxID_Cliente.BorderStyle = BorderStyle.None;
            textBoxID_Cliente.Location = new Point(197, 219);
            textBoxID_Cliente.Name = "textBoxID_Cliente";
            textBoxID_Cliente.Size = new Size(125, 20);
            textBoxID_Cliente.TabIndex = 201;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 200;
            label3.Text = "Telefone";
            // 
            // maskedTextBoxTelefoneCliente
            // 
            maskedTextBoxTelefoneCliente.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxTelefoneCliente.Location = new Point(12, 217);
            maskedTextBoxTelefoneCliente.Mask = "(+244) 000-000-000";
            maskedTextBoxTelefoneCliente.Name = "maskedTextBoxTelefoneCliente";
            maskedTextBoxTelefoneCliente.Size = new Size(135, 27);
            maskedTextBoxTelefoneCliente.TabIndex = 199;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 177);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 197;
            label1.Text = "Código";
            // 
            // textBoxPesqClientes
            // 
            textBoxPesqClientes.BorderStyle = BorderStyle.FixedSingle;
            textBoxPesqClientes.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesqClientes.Location = new Point(12, 341);
            textBoxPesqClientes.Name = "textBoxPesqClientes";
            textBoxPesqClientes.Size = new Size(826, 26);
            textBoxPesqClientes.TabIndex = 196;
            textBoxPesqClientes.KeyPress += textBoxPesqClientes_KeyPress;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.BackgroundColor = Color.White;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(12, 395);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(826, 418);
            dataGridViewClientes.TabIndex = 195;
            dataGridViewClientes.DataBindingComplete += dataGridViewClientes_DataBindingComplete;
            // 
            // textBoxEnderecoCliente
            // 
            textBoxEnderecoCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxEnderecoCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEnderecoCliente.Location = new Point(12, 129);
            textBoxEnderecoCliente.Name = "textBoxEnderecoCliente";
            textBoxEnderecoCliente.Size = new Size(469, 26);
            textBoxEnderecoCliente.TabIndex = 194;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxNomeCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNomeCliente.Location = new Point(12, 45);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(469, 26);
            textBoxNomeCliente.TabIndex = 193;
            // 
            // buttonGuardarCliente
            // 
            buttonGuardarCliente.BackColor = Color.FromArgb(45, 45, 48);
            buttonGuardarCliente.FlatAppearance.BorderColor = Color.Gray;
            buttonGuardarCliente.FlatAppearance.MouseDownBackColor = Color.White;
            buttonGuardarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonGuardarCliente.FlatStyle = FlatStyle.Flat;
            buttonGuardarCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarCliente.ForeColor = Color.White;
            buttonGuardarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardarCliente.Location = new Point(12, 286);
            buttonGuardarCliente.Name = "buttonGuardarCliente";
            buttonGuardarCliente.Size = new Size(261, 31);
            buttonGuardarCliente.TabIndex = 192;
            buttonGuardarCliente.Text = "Guardar";
            buttonGuardarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuardarCliente.UseVisualStyleBackColor = false;
            buttonGuardarCliente.Click += buttonGuardarCliente_Click_1;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.FromArgb(45, 45, 48);
            buttonRemoverCliente.FlatAppearance.BorderColor = Color.Gray;
            buttonRemoverCliente.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRemoverCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonRemoverCliente.FlatStyle = FlatStyle.Flat;
            buttonRemoverCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRemoverCliente.ForeColor = Color.White;
            buttonRemoverCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoverCliente.Location = new Point(259, 819);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(219, 31);
            buttonRemoverCliente.TabIndex = 191;
            buttonRemoverCliente.Text = "Remover";
            buttonRemoverCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.BackColor = Color.FromArgb(45, 45, 48);
            buttonEditarCliente.FlatAppearance.BorderColor = Color.Gray;
            buttonEditarCliente.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEditarCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 156, 222);
            buttonEditarCliente.FlatStyle = FlatStyle.Flat;
            buttonEditarCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarCliente.ForeColor = Color.White;
            buttonEditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditarCliente.Location = new Point(12, 819);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(219, 31);
            buttonEditarCliente.TabIndex = 190;
            buttonEditarCliente.Text = "Editar";
            buttonEditarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditarCliente.UseVisualStyleBackColor = false;
            buttonEditarCliente.Click += buttonEditarCliente_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 258);
            pictureBox1.TabIndex = 188;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 92);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 187;
            label8.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 13);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 186;
            label10.Text = "Nome Completo";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 874);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientes";
            Load += FormClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxActualizarDataGr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonGuardarProducto;
        public TextBox textBoxMarcaProducto;
        private TextBox textBoxPesquisarProducto;
        private Panel panel1;
        private Label label3;
        public MaskedTextBox maskedTextBoxTelefoneCliente;
        private Label label1;
        private TextBox textBoxPesqClientes;
        public DataGridView dataGridViewClientes;
        public TextBox textBoxEnderecoCliente;
        public TextBox textBoxNomeCliente;
        private Button buttonGuardarCliente;
        private Button buttonRemoverCliente;
        private Button buttonEditarCliente;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label10;
        public TextBox textBoxID_Cliente;
        private PictureBox pictureBoxActualizarDataGr;
    }
}