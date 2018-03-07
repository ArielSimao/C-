using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace ProjetoSalario
{
    public partial class MainWindow : Window
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Funcionario funcionario;

            try { funcionario = criaFuncionario(); }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Salário inválido inválido", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            funcionarios.Add(funcionario);
            dtgFuncionarios.ItemsSource = null;
            dtgFuncionarios.ItemsSource = funcionarios;

            lblSarioFixo.Content = "R$ " + funcionario.salarioLiquidoProp.ToString("N", new CultureInfo("pt-BR"));
        }

        private Funcionario criaFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = txtNome.Text;
            funcionario.salBruto = Double.Parse(txtSalarioBruto.Text);

            funcionario.comissaoProp = rdbComissao.IsChecked.Value;
            funcionario.ajudaCustoProp = rdbAjudaCusto.IsChecked.Value;
            funcionario.impostoP = chkImposto.IsChecked.Value;
            funcionario.valeTransporteProp = chkValeTransporte.IsChecked.Value;

            return funcionario;
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtSalarioBruto.Clear();
            rdbAjudaCusto.IsChecked = false;
            rdbComissao.IsChecked = false;
            chkImposto.IsChecked = false;
            chkValeTransporte.IsChecked = false;
            lblSarioFixo.Content = "";

        }
    }
}