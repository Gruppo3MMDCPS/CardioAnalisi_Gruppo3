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

namespace CardioAnalisi_WPF
{
    /// <summary>
    /// Logica di interazione per SpesaEnergetica.xaml
    /// </summary>
    public partial class SpesaEnergetica : Window
    {
        string tipoallenamento;
        public SpesaEnergetica()
        {
            InitializeComponent();
            btn_calcolo.IsEnabled = false;
            txt_kgpesocorporeo.MaxLength = 3;
            txt_kmpercorso.MaxLength = 2;
        }

        private void Btn_calcolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double risultato = 0;
                int km = Convert.ToInt32(txt_kmpercorso.Text);
                int kg = Convert.ToInt32(txt_kgpesocorporeo.Text);
                if (tipoallenamento == "CORSA")
                {
                    risultato = CardioAnalisiLibrary.DataCardio.SpesaEnergeticaCorsa(km, kg);
                }
                if (tipoallenamento == "CAMMINATA")
                {
                    risultato = CardioAnalisiLibrary.DataCardio.SpesaEnergeticaCamminata(km, kg);
                }
                lbl_risultato.Content = risultato;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }

        private void Btn_corsa_Click(object sender, RoutedEventArgs e)
        {
            btn_camminata.IsEnabled = false;
            tipoallenamento = "CORSA";
            btn_calcolo.IsEnabled = true;
        }

        private void Btn_camminata_Click(object sender, RoutedEventArgs e)
        {
            btn_corsa.IsEnabled = false;
            tipoallenamento = "CAMMINATA";
            btn_calcolo.IsEnabled = true;
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
