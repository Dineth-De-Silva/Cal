using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static SolidColorBrush Blue = new SolidColorBrush(Colors.DeepSkyBlue);
        private static SolidColorBrush LightBlue = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF8ABAE0"));
        private static SolidColorBrush DarkGray = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDEDEDE"));
        private static SolidColorBrush LightGray = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF0F0F0"));
        private static SolidColorBrush Red = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDC4B3E"));
        private static SolidColorBrush Black = new SolidColorBrush(Colors.Black);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MRC_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = Blue;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void M_M_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = Blue;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void M_P_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = Blue;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void P_M_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = Blue;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void CE_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = Red;
            CEt.Foreground = Black;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n7_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = Blue;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n8_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = Blue;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n9_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = Blue;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Percentage_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = Blue;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Backspace_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = Blue;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n4_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = Blue;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n5_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = Blue;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n6_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = Blue;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Multiply_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = Blue;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Divide_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = Blue;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n1_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = Blue;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n2_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = Blue;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n3_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = Blue;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = Blue;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void Substract_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = Blue;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n0_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = Blue;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void n00_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = Blue;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }

        private void ndot_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = Blue;
            Equalb.Background = LightBlue;
        }

        private void Equal_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = Blue;
        }

        private void NoHover_MouseMove(object sender, MouseEventArgs e)
        {
            //First Row
            MRCb.Background = DarkGray;
            M_Mb.Background = DarkGray;
            M_Pb.Background = DarkGray;
            P_Mb.Background = DarkGray;
            CEb.Background = DarkGray;
            CEt.Foreground = Red;
            //Second Row
            n7b.Background = LightGray;
            n8b.Background = LightGray;
            n9b.Background = LightGray;
            Percentageb.Background = DarkGray;
            Backspaceb.Background = DarkGray;
            //Third Row
            n4b.Background = LightGray;
            n5b.Background = LightGray;
            n6b.Background = LightGray;
            Multiplyb.Background = DarkGray;
            Divideb.Background = DarkGray;
            //Fourth Row
            n1b.Background = LightGray;
            n2b.Background = LightGray;
            n3b.Background = LightGray;
            Addb.Background = DarkGray;
            Substractb.Background = DarkGray;
            //Fifth Row
            n0b.Background = LightGray;
            n00b.Background = LightGray;
            ndotb.Background = LightGray;
            Equalb.Background = LightBlue;
        }
    }
}
