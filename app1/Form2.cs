using app1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form2 : Form
    {
        List<ModelTarefa> tarefa = new List<ModelTarefa>();


        public Form2()
        {
            InitializeComponent();

            listBox1.DataSource = tarefa;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = !groupBox1.Visible;
        }

        private void AdicionarTarefa_Click(object sender, EventArgs e)
        {
            if (titulo.Text == "")
            {
                MessageBox.Show("Favor digitar o titulo da tarefa");
            }
            else
            {


                tarefa.Add(new ModelTarefa(titulo.Text, conteudo.Text));
                listBox1.DataSource = null;
                listBox1.DataSource = tarefa;
                titulo.Clear();
                conteudo.Clear();

                groupBox1.Hide();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var valor = listBox1.SelectedIndex;

            if (valor < 0 || valor == null)
            {
                MessageBox.Show("Favor selecionar um item");
            }
            else
            {
                tarefa.RemoveAt(valor);
                listBox1.DataSource = null;
                listBox1.DataSource = tarefa;
            }


        }

        private void ObterDados_Click(object sender, EventArgs e)
        {
            var valor = listBox1.SelectedIndex;

            if (valor < 0)
            {
                MessageBox.Show("Favor selecionar um item");
            }
            else
            {
                MessageBox.Show(tarefa[valor].Conteudo);
            }
        }

        private void SalvarDados_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefiledialog = new SaveFileDialog())
            {
                savefiledialog.Filter = "Arquivo JSON (*.json)|*.json";
                savefiledialog.Title = "Local de salvamento";
                savefiledialog.DefaultExt = "json";
                savefiledialog.FileName = "dados";

                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    string caminho = savefiledialog.FileName;
                    try
                    {
                        string json = JsonSerializer.Serialize(tarefa, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(caminho, json);
                        MessageBox.Show("Arquivo JSON salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar o arquivo Erro : {ex}");
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada pelo Usuario", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void carregarDados_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.Filter = "Arquivos JSON (*.json)|*.json";
                openfiledialog.Title = "Carregar arquvio";

                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string caminho = openfiledialog.FileName;

                    try
                    {
                        string json = File.ReadAllText(caminho);

                        var meusDados = JsonSerializer.Deserialize<List<ModelTarefa>>(json);

                        if(meusDados != null)
                        {
                            tarefa.AddRange(meusDados);
                            listBox1.DataSource = null;
                            listBox1.DataSource = tarefa;
                        }



                        MessageBox.Show("Dados Carregados");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar arquivo ERRO: {ex}");
                    }

                }
                else
                {
                    MessageBox.Show("Cancelado pelo usuario");
                }
            }
        }
    }
}
