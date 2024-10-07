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

namespace Ucar_Meric_KleurenPaneel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Rood = "#FF0000";
        string Geel = "#FFFF00";
        string Blauw = "#0000FF";
        string Groen = "#008000";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter_Rood(object sender, MouseEventArgs e)
        {
            // https://stackoverflow.com/questions/10062376/creating-solidcolorbrush-from-hex-color-value
            hoofdscherm.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(Rood);
        }
        private void Image_MouseEnter_Geel(object sender, MouseEventArgs e)
        {
            hoofdscherm.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(Geel);
        }
        private void Image_MouseEnter_Blauw(object sender, MouseEventArgs e)
        {
            hoofdscherm.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(Blauw);
        }
        private void Image_MouseEnter_Groen(object sender, MouseEventArgs e)
        {
            hoofdscherm.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(Groen);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            hoofdscherm.Background = Brushes.LightGray;
        }

        private void Image_MouseDown_Rood(object sender, MouseButtonEventArgs e)
        {
            tb_kleurcode.Text = Rood;
        }

        private void Image_MouseDown_Geel(object sender, MouseButtonEventArgs e)
        {
            tb_kleurcode.Text = Geel;
        }

        private void Image_MouseDown_Groen(object sender, MouseButtonEventArgs e)
        {
            tb_kleurcode.Text = Groen;
        }

        private void Image_MouseDown_Blauw(object sender, MouseButtonEventArgs e)
        {
            tb_kleurcode.Text = Blauw;
        }
    }
}