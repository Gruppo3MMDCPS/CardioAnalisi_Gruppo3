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
    /// Logica di interazione per CalcoloBattitiPalestra.xaml
    /// </summary>
    public partial class CalcoloBattitiPalestra : Window
    {
        public CalcoloBattitiPalestra()
        {
            InitializeComponent();
            txt_eta.MaxLength = 3;
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Btn_calcolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int eta = Convert.ToInt32(txt_eta.Text);
                double max = CardioAnalisiLibrary.DataCardio.CalcoloFrequenzaMax(eta);
                double min = CardioAnalisiLibrary.DataCardio.CalcoloFrequenzaMin(eta);
                lbl_risultatomax.Content = max;
                lbl_risultatomin.Content = min;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }
    }
}
