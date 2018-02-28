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

namespace Login_Livros {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 
    public partial class MainWindow : Window {

       public static List<Livro> lista = new List<Livro>();

        public MainWindow() {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e) {
            Livro L1 = new Livro("As tranças do rei careca", "Matheus Carlos", DateTime.Parse("23/10/1580"));
            Livro L2 = new Livro("A mordida da mulher banguela", "Jonas", DateTime.Parse("01/01/2018"));
            Livro L3 = new Livro("Poeira em alto mar","Joáo Lobo", DateTime.Parse("12/07/1985"));

            lista.Add(L1);
            lista.Add(L2);
            lista.Add(L3);

            string nome = txtUsuario.Text;
            string senha = txtSenha.Password.ToString();
            Usuarios usu = new Usuarios(nome, senha);
            if ((usu.Nome == "ariel") && (usu.Senha == "simao")){
                MessageBox.Show("Usuario logado com sucesso!!!");
                Livros janela = new Livros(lista);
                janela.Show();
            }else {
                MessageBox.Show("Usuario ou Senha Inválidos!");
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e) {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
