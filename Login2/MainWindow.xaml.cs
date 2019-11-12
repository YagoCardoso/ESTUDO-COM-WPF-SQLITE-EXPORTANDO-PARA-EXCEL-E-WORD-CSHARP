using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CliqueDoBotao(Object sender, RoutedEventArgs e)
        {

            if (txt_usuario.Text == "master" && txt_senha.Password == "yago")
            {
               Home home = new Home();
                home.Show();


                MainWindow login = new MainWindow();
                login.Close();


            }
            else
            {
                MessageBox.Show("Dados Incorretos", "Acesso negado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
