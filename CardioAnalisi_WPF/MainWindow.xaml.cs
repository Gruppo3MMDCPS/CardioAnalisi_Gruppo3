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

namespace CardioAnalisi_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MaxBattiti max;
        CalorieBruciate cal;
        CalcoloBattitiPalestra pal;
        MalattiaCuore mal;
        SpesaEnergetica spe;
        MediaGiornaliera med;
        BattitiARiposo rip;
        OrdineCrescente ord;
        HRV hrv;
        BattitiGravidanza gra;

        public MainWindow()
        {
            InitializeComponent();
            max = new MaxBattiti();
            pal = new CalcoloBattitiPalestra();
            mal = new MalattiaCuore();
            cal = new CalorieBruciate();
            spe = new SpesaEnergetica();
            med = new MediaGiornaliera();
            rip = new BattitiARiposo();
            ord = new OrdineCrescente();
            hrv = new HRV();
            gra = new BattitiGravidanza();
        }
        private void Btn_maxbattiti_Click(object sender, RoutedEventArgs e)
        {
            max.Show();
            this.Close();

        }

        private void Btn_maxminbattitipalestra_Click(object sender, RoutedEventArgs e)
        {
            pal.Show();
            this.Close();
        }

        private void Btn_soffriqualcosa_Click(object sender, RoutedEventArgs e)
        {
            mal.Show();
            this.Close();
        }

        private void Btn_calorie_Click(object sender, RoutedEventArgs e)
        {
            cal.Show();
            this.Close();
        }

        private void Btn_spesaenergetica_Click(object sender, RoutedEventArgs e)
        {
            spe.Show();
            this.Close();
        }

        private void Btn_mediabatti_Click(object sender, RoutedEventArgs e)
        {
            med.Show();
            this.Close();
        }

        private void Btn_calcolobattitoariposo_Click(object sender, RoutedEventArgs e)
        {
            rip.Show();
            this.Close();
        }

        private void Btn_ordinecrescentebattiti_Click(object sender, RoutedEventArgs e)
        {
            ord.Show();
            this.Close();
        }

        private void Btn_HRV_Click(object sender, RoutedEventArgs e)
        {
            hrv.Show();
            this.Close();
        }

        private void Btn_gravidanza_Click(object sender, RoutedEventArgs e)
        {
            gra.Show();
            this.Close();
        }
    }
}
