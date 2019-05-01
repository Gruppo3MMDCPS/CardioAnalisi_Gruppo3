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
    /// Logica di interazione per HRV.xaml
    /// </summary>
    public partial class HRV : Window
    {
        List<double> tempotraduebattiti;
        CardioAnalisiLibrary.DataCardio data;
        public HRV()
        {
            InitializeComponent();
            tempotraduebattiti = new List<double>();
            data = new CardioAnalisiLibrary.DataCardio();
        }

        private void Btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tempotraduebattiti.Add(Convert.ToDouble(txt_battiti.Text));
                lbl_listalive.Content = lbl_listalive.Content + " " + txt_battiti.Text;
            }
            catch
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
                txt_battiti.Clear();
            }
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            tempotraduebattiti = new List<double>();
            lbl_listalive.Content = "";
            lbl_risultato.Content = ""; ;
        }

        private void Btn_HRV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double risultato = data.HRV(tempotraduebattiti);
                lbl_risultato.Content = risultato;
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
    }
}
