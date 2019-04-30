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
    /// Logica di interazione per MediaGiornaliera.xaml
    /// </summary>
    public partial class MediaGiornaliera : Window
    {
        List<int> battiti;
        CardioAnalisiLibrary.DataCardio data;
        public MediaGiornaliera()
        {
            InitializeComponent();
            data = new CardioAnalisiLibrary.DataCardio();
            battiti = new List<int>();
        }

        private void Btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {
            battiti.Add(Convert.ToInt32(txt_battiti.Text));
            lbl_listalive.Content = lbl_listalive.Content + " " + txt_battiti.Text;
        }

        private void Btn_calcolamedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double bat = data.CalcoloMediaBattitiGiornaliera(battiti);
                lbl_risultato.Content = bat;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            battiti = new List<int>();
            lbl_listalive.Content = "";
            lbl_risultato.Content = "";

        }
    }
}
