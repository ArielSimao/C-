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
using System.Windows.Shapes;

namespace Login_Livros {
    /// <summary>
    /// Lógica interna para Livros.xaml
    /// </summary>
    public partial class Livros : Window {

        public Livros(List<Livro> lista) {
            InitializeComponent();
            dGrid.ItemsSource = lista.OrderBy(user => user.Autor);
        }
    }
}
