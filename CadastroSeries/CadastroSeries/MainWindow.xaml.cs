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

namespace CadastroSeries {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window {

        public List<Series> lista = new List<Series>();

        public MainWindow() {
            InitializeComponent();
        }

        private void limpaCampos() {
            txtDiretor.Text = "";
            txtGenero.Text = "";
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e) {
            string nome = txtNome.Text;
            string genero = txtGenero.Text;
            string diretor = txtDiretor.Text;

            Series netiflix = new Series(nome, genero, diretor);
            lista.Add(netiflix);

       
            dataGrid.ItemsSource = lista.OrderBy(user => user.Nome);
            limpaCampos();

        }

        private void button_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, SelectionChangedEventArgs e) {
            
           string ItemCombo = comboBox.Text;
            if (ItemCombo .Equals("Genero")) {
                MessageBox.Show("oedenando por genero");
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = lista.OrderBy(user => user.Genero);
            }
            if (ItemCombo.Equals("Diretor")) {
                MessageBox.Show("oedenando por diretor");
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = lista.OrderBy(user => user.Diretor);
            }
        }

        private void comboBox_DropDownOpened(object sender, EventArgs e) {
       /*     
       string ItemCombo = comboBox.Text;
        if (ItemCombo .Equals("Genero")) {
            MessageBox.Show("oedenando por genero");
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = lista.OrderBy(user => user.Genero);
        }
        if (ItemCombo.Equals("Diretor")) {
            MessageBox.Show("oedenando por diretor");
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = lista.OrderBy(user => user.Diretor);
        }*/
        }
    }
}
