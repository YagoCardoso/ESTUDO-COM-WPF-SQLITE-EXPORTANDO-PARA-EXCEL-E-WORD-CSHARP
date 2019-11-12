using Login2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login2
{
    /// <summary>
    /// Lógica interna para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CadastroDal.CriarBancoSQLite();
                btnCriarBancoDados.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                CadastroDal.CriarTabelaSQlite();
                btnCriarTabela.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ExibirDados();
        }
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = CadastroDal.GetClientes();
                dgvDados.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
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
                dgvDados.DataContext = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            const string mensagem = "Deseja Encerrar ?";
            const string titulo = "Encerrar";
            var resultado = MessageBox.Show(mensagem, titulo, MessageBoxButton.YesNo,MessageBoxImage.Information);
            //if (resultado == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}

            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Desculpe pelo transtornos :(  , Podera terminar seu registro na proxima tela. ", "Bem Vindo", MessageBoxButton.OK, MessageBoxImage.Information);

            Form1 solucao = new Form1();
            solucao.Show();
        }

        //private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
        //        txtID.Text = row.Cells["Id"].Value.ToString();
        //        txtNome.Text = row.Cells["Nome"].Value.ToString();
        //        txtEmail.Text = row.Cells["Email"].Value.ToString();
        //    }
        //}
    }
}
