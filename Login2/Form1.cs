using Login2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCriarBancoDados_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroDal.CriarBancoSQLite();
                btnCriarBancoDados.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroDal.CriarTabelaSQlite();
                btnCriarTabela.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = CadastroDal.GetClientes();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnIncluirDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a incluir");
                return;
            }
            try
            {
                Cliente cli = new Cliente();
                cli.Id = Convert.ToInt32(txtID.Text);
                cli.Nome = txtNome.Text;
                cli.Telefone = txtTelefone.Text;

                CadastroDal.Add(cli);

                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a atualizar");
                return;
            }

            try
            {
                Cliente cli = new Cliente();
                cli.Id = Convert.ToInt32(txtID.Text);
                cli.Nome = txtNome.Text;
                cli.Telefone = txtTelefone.Text;

                CadastroDal.Update(cli);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluirDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Informe o ID do cliente a ser Excluído");
                return;
            }
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);
                CadastroDal.Delete(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnLocalizarDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Informe o ID do cliente a ser Localizado");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtID.Text);

                dt = CadastroDal.GetCliente(codigo);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            const string mensagem = "Deseja Encerrar ?";
            const string titulo = "Encerrar";
            var resultado = MessageBox.Show(mensagem, titulo,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtTelefone.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimpaDados()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtTelefone.Text = row.Cells["Telefone"].Value.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            // worksheet = workbook.Sheets["novo"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[i, 1] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Relatorio_Cadastro";
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();

            MessageBox.Show("O arquivo foi criado com Sucesso ", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\Relatorios\";

            try { 
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

            di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            finally { }

            var textoRelatorio = txtRelatorio.Text;

            if(textoRelatorio != null)
            {
                StreamWriter sw = new StreamWriter("c:\\Relatorios\\Relatorio.txt");
                sw.WriteLine(textoRelatorio);
                sw.Close();

                MessageBox.Show("O arquivo foi criado no caminho: c:\\Relatorios\\Relatorio ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Impossivel Exportar Relatorio Vazio.", "Prenchimento Obrigatorio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
