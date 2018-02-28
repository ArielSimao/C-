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

namespace CLASSIFICA_WPF
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

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Cadastro jan2 = new Cadastro();
            jan2.Show();
        }

        private void btnAvaliar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Avaliar jan2 = new Avaliar();
            jan2.Show();

            
        }

        private void btnRanking_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Ranking jan2 = new Ranking();
            jan2.Show();
        }
    }
}
