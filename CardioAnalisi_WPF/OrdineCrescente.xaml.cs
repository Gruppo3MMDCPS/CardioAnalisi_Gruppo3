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
    /// Logica di interazione per OrdineCrescente.xaml
    /// </summary>
    public partial class OrdineCrescente : Window
    {
        CardioAnalisiLibrary.DataCardio data;
        List<int> battiti;
        public OrdineCrescente()
        {
            InitializeComponent();
            battiti = new List<int>();
            data = new CardioAnalisiLibrary.DataCardio();
        }

        private void Btn_ordinamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                battiti = data.OrdineCrescente(battiti);
                for (int i = 0; i < battiti.Count; i++)
                {
                    lbl_risultato.Content = lbl_risultato.Content + " " + battiti[i];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }

        private void Btn_aggiungi_Click(object sender, RoutedEventArgs e)
        {
            battiti.Add(Convert.ToInt32(txt_battiti.Text));
            lbl_listalive.Content = lbl_listalive.Content + " " + txt_battiti.Text;
        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            battiti = new List<int>();
            lbl_listalive.Content = "";
            lbl_risultato.Content = "";
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
