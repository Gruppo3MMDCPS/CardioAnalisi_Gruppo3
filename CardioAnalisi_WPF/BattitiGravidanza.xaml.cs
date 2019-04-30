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
    /// Logica di interazione per BattitiGravidanza.xaml
    /// </summary>
    public partial class BattitiGravidanza : Window
    {
        CardioAnalisiLibrary.DataCardio data;
        public BattitiGravidanza()
        {
            InitializeComponent();
            data = new CardioAnalisiLibrary.DataCardio();
        }

        private void Btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            lbl_risultato.Content = data.Gravidanza();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
