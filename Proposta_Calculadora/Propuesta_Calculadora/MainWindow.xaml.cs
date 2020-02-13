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

namespace Propuesta_Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    static class Globals
    {
        public static double valor1 = 0.0;
        public static double valor2 = 0.0;
        public static string operacio;
        public static char signsum = '+';
        public static char signres = '-';
        public static char signmul = '*';
        public static char signdiv = '/';
        public static char signigu = '=';
        public static bool Esnumeric;
        public static string box = "";
        public static string block = "";
    }

    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txMostrar.Text = "";
            txRecoge.Text = "0";
        }

        //Aquesta validació no cal, perquè introduïm les dades per teclat numèric
        public void Valida()
        {
            Double num;
            Globals.Esnumeric = Double.TryParse(txRecoge.Text, out num);

            if (txRecoge.Text == "")
            {
                MessageBox.Show("Informe un valor numérico");
            }
            else if (Globals.Esnumeric == false)
            {
                MessageBox.Show("El valor introducido no es numérico");
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            Globals.operacio = "essum";

            Globals.valor1 = Convert.ToDouble(txRecoge.Text);
            txMostrar.Text = ($"{txRecoge.Text} {Globals.signsum}");
            txRecoge.Text = "0";
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            Globals.operacio = "esres";

            Globals.valor1 = Convert.ToDouble(txRecoge.Text);
            txMostrar.Text = ($"{txRecoge.Text} {Globals.signres}");
            txRecoge.Text = "0";
        }

        private void btnNum1_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "1";
            //txMostrar.Text += "1";
        }

        private void btnNum2_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "2";
            //txMostrar.Text += "2";
        }

        private void btnNum3_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "3";
            //txMostrar.Text += "3";
        }

        private void btnNum4_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "4";
            //txMostrar.Text += "4";
        }

        private void btnNum5_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "5";
            //txMostrar.Text += "5";
        }

        private void btnNum6_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "6";
            //txMostrar.Text += "6";
        }

        private void btnNum7_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "7";
            //txMostrar.Text += "7";
        }

        private void btnNum8_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "8";
            //txMostrar.Text += "8";
        }

        private void btnNum9_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text == "0")
            {
                txRecoge.Text = "";
            }
            txRecoge.Text += "9";
            //txMostrar.Text += "9";
        }

        private void btnNum0_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text != "0")
            {
                txRecoge.Text += "0";
                //txMostrar.Text += "0";
            }
            else if (txRecoge.Text == "0")
            {
                txRecoge.Text = "0";
            }
        }

        private void btnComa_Click(object sender, RoutedEventArgs e)
        {
            if (txRecoge.Text.Contains(",") == false)
            {
                txRecoge.Text += ",";
                //txMostrar.Text += ",";
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            Globals.operacio = "esdiv";

            Globals.valor1 = Convert.ToDouble(txRecoge.Text);
            txMostrar.Text = ($"{txRecoge.Text} {Globals.signdiv}");
            txRecoge.Text = "0";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            Globals.operacio = "esmul";

            Globals.valor1 = Convert.ToDouble(txRecoge.Text);
            txMostrar.Text = ($"{txRecoge.Text} {Globals.signmul}");
            txRecoge.Text = "0";
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (Globals.operacio == "essum")
            {
                Globals.valor2 = Convert.ToDouble(txRecoge.Text);
                txRecoge.Text = Convert.ToString(Globals.valor1 + Globals.valor2);
                txMostrar.Text = ($"{txMostrar.Text} {Globals.valor2} {Globals.signigu}");
            }
            else if (Globals.operacio == "esres")
            {
                Globals.valor2 = Convert.ToDouble(txRecoge.Text);
                txRecoge.Text = Convert.ToString(Globals.valor1 - Globals.valor2);
                txMostrar.Text = ($"{txMostrar.Text} {Globals.valor2} {Globals.signigu}");
            }
            else if (Globals.operacio == "esdiv")
            {
                Globals.valor2 = Convert.ToDouble(txRecoge.Text);
                txRecoge.Text = Convert.ToString(Globals.valor1 / Globals.valor2);
                txMostrar.Text = ($"{txMostrar.Text} {Globals.valor2} {Globals.signigu}");
            }
            else if (Globals.operacio == "esmul")
            {
                Globals.valor2 = Convert.ToDouble(txRecoge.Text);
                txRecoge.Text = Convert.ToString(Globals.valor1 * Globals.valor2);
                txMostrar.Text = ($"{txMostrar.Text} {Globals.valor2} {Globals.signigu}");
            }
        }
    }
}
