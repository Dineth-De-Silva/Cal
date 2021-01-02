/*MIT License

Copyright (c) 2020 D. A. Dineth De Silva

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.IO;
using System.Media;
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
        private static SolidColorBrush DarkGray = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDEDEDE"));
        private static SolidColorBrush LightGray = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF0F0F0"));
        private static SolidColorBrush Red = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFEE397F"));
        private static SolidColorBrush Black = new SolidColorBrush(Colors.Black);
        private static bool Opactive = false;
        private static string LastOp;
        private static decimal LastIncrement;
        private static bool Eqactive = false;
        private static decimal Memory;
        private static bool MRCActive = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Memory.txt"))
            {
                StreamReader MemoryDataFile = new StreamReader("Memory.txt");
                Memory = Convert.ToDecimal(MemoryDataFile.ReadLine());
                MemoryDataFile.Close();
                if (Memory != 0)
                {
                    MemoryAvailable.Content = "M";
                }
                else
                {
                    MemoryAvailable.Content = " ";
                }
            }
            else
            {
                Memory = 0;
                MemoryAvailable.Content = " ";
                StreamWriter MemoryDataFile = new StreamWriter("Memory.txt");
                MemoryDataFile.Write("0");
                MemoryDataFile.Close();
            }
            if (File.Exists("Data.txt"))
            {
                StreamReader DataDataFile = new StreamReader("Data.txt");
                Past.Text = DataDataFile.ReadLine();
                Operator.Content = DataDataFile.ReadLine();
                Now.Text = DataDataFile.ReadLine();
                DataDataFile.Close();
            }
            else
            {
                Operator.Content = " ";
                Now.Text = "0";
                StreamWriter DataDataFile = new StreamWriter("Data.txt");
                DataDataFile.WriteLine();
                DataDataFile.WriteLine(" ");
                DataDataFile.WriteLine("0");
                DataDataFile.Close();
            }
        }

        private void EnterNumber(string Item)
        {
            if (Item.Equals("."))
            {
                if (!Now.Text.Contains("."))
                {
                    Now.Text += Item;
                }
            }
            else
            {
                if (Now.Text.Equals("0"))
                {
                    Now.Text = "";
                }
                decimal Try;
                bool Ok = decimal.TryParse(Now.Text + Item, out Try);
                if (Ok)
                {
                    Now.Text = Try.ToString();
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                }
            }
        }

        private void DoBeforeFirst()
        {
            Eqactive = false;
            MRCActive = false;
        }

        private void DoFirst()
        {
            if (Operator.Content.Equals("="))
            {
                Operator.Content = " ";
            }
            if (!Operator.Content.Equals("="))
            {
                if (Operator.Content.Equals(" "))
                {
                    Past.Text = Now.Text;
                    Now.Text = "0";
                }
                else
                {
                    string PastS;
                    if (Past.Text.Equals(""))
                    {
                        PastS = "0";
                    }
                    else
                    {
                        PastS = Past.Text;
                    }
                    decimal PastV;
                    decimal NowV;
                    bool Ok = decimal.TryParse(PastS, out PastV);
                    bool Ok2 = decimal.TryParse(Now.Text, out NowV);
                    if (Ok && Ok2)
                    {
                        decimal Value;
                        switch (Operator.Content)
                        {
                            case "+":
                                try
                                {
                                    Value = Convert.ToDecimal(PastV + NowV);
                                    Past.Text = Value.ToString();
                                    Now.Text = "0";
                                }
                                catch (OverflowException)
                                {
                                    SystemSounds.Exclamation.Play();
                                }
                                break;
                            case "–":
                                try
                                {
                                    Value = Convert.ToDecimal(PastV - NowV);
                                    Past.Text = Value.ToString();
                                    Now.Text = "0";
                                }
                                catch (OverflowException)
                                {
                                    SystemSounds.Exclamation.Play();
                                }
                                break;
                            case "×":
                                try
                                {
                                    Value = Convert.ToDecimal(PastV * NowV);
                                    Past.Text = Value.ToString();
                                    Now.Text = "0";
                                }
                                catch (OverflowException)
                                {
                                    SystemSounds.Exclamation.Play();
                                }
                                break;
                            case "÷":
                                try
                                {
                                    Value = Convert.ToDecimal(PastV / NowV);
                                    Past.Text = Value.ToString();
                                    Now.Text = "0";
                                }
                                catch (DivideByZeroException)
                                {
                                    Value = 0;
                                    Past.Text = Value.ToString();
                                    Now.Text = "0";
                                }
                                catch (OverflowException)
                                {
                                    SystemSounds.Exclamation.Play();
                                }
                                break;
                        }
                    }
                    else
                    {
                        SystemSounds.Exclamation.Play();
                    }
                }
            }
        }

        //Start Mouse Hover

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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
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
            Equalb.Background = Blue;
        }

        //End Mouse Hover

        private void MRC_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            Eqactive = false;
            if (MRCActive)
            {
                Memory = 0;
                MemoryAvailable.Content = " ";
            }
            else
            {
                Now.Text = Memory.ToString();
                MRCActive = true;
            }
        }

        private void M_M_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DoFirst();
                if (!Operator.Content.Equals("="))
                {
                    Operator.Content = "=";
                    Now.Text = Past.Text;
                    Past.Text = "";
                }
                Memory -= Convert.ToDecimal(Now.Text);
                Opactive = false;
                DoBeforeFirst();
                if (Memory != 0)
                {
                    MemoryAvailable.Content = "M";
                }
                else
                {
                    MemoryAvailable.Content = " ";
                }
            }
            catch (OverflowException)
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void M_P_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DoFirst();
                if (!Operator.Content.Equals("="))
                {
                    Operator.Content = "=";
                    Now.Text = Past.Text;
                    Past.Text = "";
                }
                Memory += Convert.ToDecimal(Now.Text);
                Opactive = false;
                DoBeforeFirst();
                if (Memory != 0)
                {
                    MemoryAvailable.Content = "M";
                }
                else
                {
                    MemoryAvailable.Content = " ";
                }
            }
            catch (OverflowException)
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void P_M_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            DoBeforeFirst();
            decimal AfterConverted = Convert.ToDecimal(Now.Text) * (-1);
            Now.Text = AfterConverted.ToString();
        }

        private void CE_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            DoBeforeFirst();
            Operator.Content = " ";
            Now.Text = "0";
            Past.Text = "";
        }

        private void n7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("7");
        }

        private void n8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("8");
        }

        private void n9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("9");
        }

        private void Percentage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            DoBeforeFirst();
            if(!Operator.Content.Equals(" ") && !Operator.Content.Equals("="))
            {
                decimal Value;
                switch (Operator.Content)
                {
                    case "+":
                        try
                        {
                            Value = (Convert.ToDecimal(Now.Text) / 100) * Convert.ToDecimal(Past.Text);
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                    case "–":
                        goto case "+";
                    case "×":
                        try
                        {
                            Value = Convert.ToDecimal(Now.Text) / 100;
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                    case "÷":
                        goto case "×";
                }
            }
            else
            {
                Now.Text = "0";
            }
        }

        private void Backspace_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            DoBeforeFirst();
            string TextAfterBackspace = Now.Text.Substring(0, Now.Text.Length - 1);
            if (TextAfterBackspace.Equals(""))
            {
                Now.Text = "0";
            }
            else
            {
                Now.Text = TextAfterBackspace;
            }
        }

        private void n4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("4");
        }

        private void n5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("5");
        }

        private void n6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("6");
        }

        private void Multiply_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            if (!Opactive)
            {
                DoFirst();
                Opactive = true;
            }
            Operator.Content = "×";
        }

        private void Divide_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            if (!Opactive)
            {
                DoFirst();
                Opactive = true;
            }
            Operator.Content = "÷";
        }

        private void n1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("1");
        }

        private void n2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("2");
        }

        private void n3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("3");
        }

        private void Substract_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            if (!Opactive)
            {
                DoFirst();
                Opactive = true;
            }
            Operator.Content = "–";
        }

        private void Add_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            if (!Opactive)
            {
                DoFirst();
                Opactive = true;
            }
            Operator.Content = "+";
        }

        private void n0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("0");
        }

        private void n00_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber("00");
        }

        private void ndot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoBeforeFirst();
            Opactive = false;
            EnterNumber(".");
        }

        private void Equal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Opactive = false;
            MRCActive = false;
            if (Eqactive)
            {
                decimal Value;
                switch (LastOp)
                {
                    case "+":
                        try
                        {
                            Value = Convert.ToDecimal(Convert.ToDecimal(Now.Text) + LastIncrement);
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                    case "–":
                        try
                        {
                            Value = Convert.ToDecimal(Convert.ToDecimal(Now.Text) - LastIncrement);
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                    case "×":
                        try
                        {
                            Value = Convert.ToDecimal(Convert.ToDecimal(Now.Text) * LastIncrement);
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                    case "÷":
                        try
                        {
                            Value = Convert.ToDecimal(Convert.ToDecimal(Now.Text) / LastIncrement);
                            Now.Text = Value.ToString();
                        }
                        catch (DivideByZeroException)
                        {
                            Value = 0;
                            Now.Text = Value.ToString();
                        }
                        catch (OverflowException)
                        {
                            SystemSounds.Exclamation.Play();
                        }
                        break;
                }
                ;
            }
            else
            {
                if (!Operator.Content.Equals(" ") && !Operator.Content.Equals("="))
                {
                    LastOp = Operator.Content.ToString();
                    LastIncrement = Convert.ToDecimal(Now.Text.ToString());
                }
                DoFirst();
                if (!Operator.Content.Equals("="))
                {
                    Operator.Content = "=";
                    Now.Text = Past.Text;
                    Past.Text = "";
                }
            }
            Eqactive = true;
        }

        private void CalWindow_Closed(object sender, EventArgs e)
        {
            StreamWriter MemoryDataFile = new StreamWriter("Memory.txt");
            MemoryDataFile.Write(Memory);
            MemoryDataFile.Close();
            StreamWriter DataDataFile = new StreamWriter("Data.txt");
            DataDataFile.WriteLine(Past.Text);
            DataDataFile.WriteLine(Operator.Content);
            DataDataFile.WriteLine(Now.Text);
            DataDataFile.Close();
        }

    }
}
