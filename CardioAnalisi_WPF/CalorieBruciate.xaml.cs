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
    /// Logica di interazione per CalorieBruciate.xaml
    /// </summary>
    public partial class CalorieBruciate : Window
    {
        string sesso;
        CardioAnalisiLibrary.DataCardio data;
        public CalorieBruciate()
        {
            InitializeComponent();
            sesso = "";
            data = new CardioAnalisiLibrary.DataCardio();
            btn_calcolo.IsEnabled = false;
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            btn_Maschio.IsEnabled = true;
            btn_Femmina.IsEnabled = true;
            this.Close();
        }

        private void Btn_calcolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double risultato = 0;
                int eta = Convert.ToInt32(txt_eta.Text);
                int durata = Convert.ToInt32(txt_durata.Text);
                int frequenza = Convert.ToInt32(txt_frequenza.Text);
                int peso = Convert.ToInt32(txt_peso.Text);

                if (sesso == "M")
                {
                    risultato = CardioAnalisiLibrary.DataCardio.Calorie_Bruciate(sesso, frequenza, peso, eta, durata);
                }
                if (sesso == "F")
                {
                    risultato = CardioAnalisiLibrary.DataCardio.Calorie_Bruciate(sesso, frequenza, peso, eta, durata);
                }
                lbl_risultato.Content = risultato;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }

        private void Btn_Maschio_Click(object sender, RoutedEventArgs e)
        {
            sesso = "M";
            btn_Femmina.IsEnabled = false;
            btn_calcolo.IsEnabled = true;
        }

        private void Btn_Femmina_Click(object sender, RoutedEventArgs e)
        {
            sesso = "F";
            btn_Maschio.IsEnabled = false;
            btn_calcolo.IsEnabled = true;
        }
    }
}
