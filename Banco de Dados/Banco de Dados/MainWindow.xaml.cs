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

namespace Banco_de_Dados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Produtos produto = new Banco_de_Dados.Produtos();
            produto.descricao = txtdescricao.Text;
            produto.custo = double.Parse(txtcusto.Text);
            produto.fornecedor = txtfornecedor.Text;
            Conexao con = new Conexao();
            con.Produtos.Add(produto);
            con.SaveChanges();
            txtid.Text = produto.id.ToString();

            MessageBox.Show("Produto salvo com sucesso!!!");

        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            txtdescricao.Clear();
            txtcusto.Clear();
            txtfornecedor.Clear();
            txtdescricao.Focus();
        }
    }
}
