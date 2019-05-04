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
    /// Logica di interazione per MalattiaCuore.xaml
    /// </summary>
    public partial class MalattiaCuore : Window
    {
        public MalattiaCuore()
        {
            InitializeComponent();
            txt_battiti.MaxLength = 3;
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
                int battiti = Convert.ToInt32(txt_battiti.Text);
                string risultato = CardioAnalisiLibrary.DataCardio.FreqCardiacaRiposo(battiti);
                lbl_risultato.Content = risultato;
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nell'inserimento dei dati ! CONTROLLA");
            }
        }
    }
}
