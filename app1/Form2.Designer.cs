using System.Text.Json;
namespace app1
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            AdicionarTarefa = new Button();
            conteudo = new TextBox();
            titulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            ObterDados = new Button();
            SalvarDados = new Button();
            carregarDados = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Salmon;
            pictureBox1.Location = new Point(-3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 459);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 44);
            button1.Name = "button1";
            button1.Size = new Size(199, 62);
            button1.TabIndex = 1;
            button1.Text = "Adicioanr";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 215);
            button2.Name = "button2";
            button2.Size = new Size(199, 62);
            button2.TabIndex = 2;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AdicionarTarefa);
            groupBox1.Controls.Add(conteudo);
            groupBox1.Controls.Add(titulo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(354, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 281);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // AdicionarTarefa
            // 
            AdicionarTarefa.Location = new Point(22, 219);
            AdicionarTarefa.Name = "AdicionarTarefa";
            AdicionarTarefa.Size = new Size(186, 40);
            AdicionarTarefa.TabIndex = 4;
            AdicionarTarefa.Text = "Adicionar";
            AdicionarTarefa.UseVisualStyleBackColor = true;
            AdicionarTarefa.Click += AdicionarTarefa_Click;
            // 
            // conteudo
            // 
            conteudo.Location = new Point(22, 99);
            conteudo.Multiline = true;
            conteudo.Name = "conteudo";
            conteudo.Size = new Size(186, 101);
            conteudo.TabIndex = 3;
            // 
            // titulo
            // 
            titulo.Location = new Point(20, 46);
            titulo.Name = "titulo";
            titulo.Size = new Size(186, 23);
            titulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Conteudo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(257, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(507, 394);
            listBox1.TabIndex = 5;
            // 
            // ObterDados
            // 
            ObterDados.Location = new Point(12, 134);
            ObterDados.Name = "ObterDados";
            ObterDados.Size = new Size(199, 62);
            ObterDados.TabIndex = 6;
            ObterDados.Text = "Obter dados";
            ObterDados.UseVisualStyleBackColor = true;
            ObterDados.Click += ObterDados_Click;
            // 
            // SalvarDados
            // 
            SalvarDados.Location = new Point(12, 392);
            SalvarDados.Name = "SalvarDados";
            SalvarDados.Size = new Size(83, 46);
            SalvarDados.TabIndex = 7;
            SalvarDados.Text = "Salvar";
            SalvarDados.UseVisualStyleBackColor = true;
            SalvarDados.Click += SalvarDados_Click;
            // 
            // carregarDados
            // 
            carregarDados.Location = new Point(128, 392);
            carregarDados.Name = "carregarDados";
            carregarDados.Size = new Size(83, 46);
            carregarDados.TabIndex = 8;
            carregarDados.Text = "Carregar";
            carregarDados.UseVisualStyleBackColor = true;
            carregarDados.Click += carregarDados_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(carregarDados);
            Controls.Add(SalvarDados);
            Controls.Add(ObterDados);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private GroupBox groupBox1;
        private Button AdicionarTarefa;
        private TextBox conteudo;
        private TextBox titulo;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Button ObterDados;
        private Button SalvarDados;
        private Button carregarDados;
    }
}