using com.sweet.LogicaNegocio;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using com.sweet.Entidades;
using com.tantaros.varios;

namespace DescuentosColaboradores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {


        ColaboradorBOL bOL = new ColaboradorBOL();
       
        public MainWindow()
        {
            InitializeComponent();
            dgTraspasos.ItemsSource = bOL.GetTraspasoGrid();
            cmbArticulos.ItemsSource = bOL.Articulos().Tables[0].DefaultView;
            cmbArticulos.DisplayMemberPath = bOL.Articulos().Tables[0].Columns["CODARTICULO"].ToString();
            cmbArticulos.DisplayMemberPath = bOL.Articulos().Tables[0].Columns["DESCRIPCION"].ToString();
            btnGuardarDescuento.Content = "Comprobar";


        }

        private void btnCargarDescuentos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.ExitCode = 0;
        }

        void BuscarColaborador()
        {            
            EColaborador colaborador = new EColaborador();
            colaborador = bOL.GetColaboradorID(int.Parse(txtIdColaborador.Text.ToString()));
            lblColaborador.Content = colaborador.NombreCorto.ToString();
            txtNombreLargo.Text = colaborador.NombreLargo.ToString();

        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            ETraspaso traspaso = (ETraspaso)dgTraspasos.SelectedItem;
            flyDescuento.IsOpen = true;
            dgTraspasos.IsEnabled = false;
            //dgTraspasos.Visibility = Visibility.Hidden;
            txtDescuento.Text = traspaso.Descuento.ToString();
            txtDescuento.IsEnabled = false;
            btnSalir.IsEnabled = false;
            btnSalir.Visibility = Visibility.Hidden;
            btnEnviar.Visibility = Visibility.Hidden;

        }


        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void flyDescuento_ClosingFinished(object sender, RoutedEventArgs e)
        {
            btnSalir.IsEnabled = true;
            btnSalir.Visibility = Visibility.Visible;
            btnEnviar.Visibility = Visibility.Visible;
            //dgTraspasos.Visibility = Visibility.Visible;
            dgTraspasos.IsEnabled = true;
            borrarDatosFly();
        }

        private void txtIdColaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return || e.Key == Key.Tab)
            {
                MessageBox.Show("Usted ha escrito : " + txtIdColaborador.Text.ToString());
                BuscarColaborador();
            }
        }

        void borrarDatosFly()
        {
            lblColaborador.Content = "";
            txtIdColaborador.Text = "";
            txtValor.Text = "";
            txtDescuento.Text = "";
        }

        private void btnSalirFly_Click(object sender, RoutedEventArgs e)
        {
            flyDescuento.IsOpen = false;
            borrarDatosFly();
        }

        private void btnGuardarDescuento_Click(object sender, RoutedEventArgs e)
        {
            bool isComplete = false;
            string codarticulo = string.Empty;
            string[] prueba1 = null;


            double precio = 0.00;
            ETraspaso traspaso = (ETraspaso)dgTraspasos.SelectedItem;
            com.tantaros.varios.Arreglos arreglos = new Arreglos();
            try
            {
                codarticulo = ((System.Data.DataRowView)cmbArticulos.SelectedItem).Row.ItemArray[0].ToString();
            }
            catch
            {
                MessageBox.Show("Debe escoger un producto de Articulos");
            }
            
            if(codarticulo != "")
            {
                prueba1 = bOL.ItemsKit(int.Parse(codarticulo));
            }

            string[] prueba2 = bOL.ItemsTraspaso(traspaso.Numero);
            MessageBox.Show("Prueba " + traspaso.Referencia.ToString() + " Array 1 : " + prueba1.Count() + "Array 2 : " + prueba2.Count());
            precio = bOL.PrecioDescuento(int.Parse(codarticulo), traspaso.Descuento);
            if(precio > 0)
            {
                txtValor.Text = " $: " + precio.ToString();
                txtValor.IsEnabled = false;
            }

            if (arreglos.ComparerArray(prueba1, prueba2))
            {
                MessageBox.Show("Son Iguales");
            }
            else
            {
                MessageBox.Show("No son Iguales");
            }
            
        }
    }
}
