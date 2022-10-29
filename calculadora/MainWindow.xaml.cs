using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace calculadora
{
    public partial class MainWindow : Window
    {

        string NumeroBotao = "";
        double n1 = 0;
        double n2 = 0;
        bool TeveResultado = false;
        int EscolhaEquacao = 0;
        double resultado = 0;
        double numeroSalvo = 0;
        public MainWindow()
        {
            InitializeComponent();
            tb_n1.Text = "0";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();

                if (tb_n1.Text != "0")
                {
                    NumeroBotao += "0";
                    tb_n1.Text = NumeroBotao;
                }
                else
                {
                    tb_n1.Text = "0";
                }
            }
            else
            {
                if(TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (tb_n1.Text != "0")
                    {
                        NumeroBotao += "0";
                        tb_n1.Text = NumeroBotao;
                    }
                    else
                    {
                        tb_n1.Text = "0";
                    }

                    resultado = 0;
                    TeveResultado = false;
                }
                else if (tb_n1.Text != "0")
                {
                    NumeroBotao += "0";
                    tb_n1.Text = NumeroBotao;
                }
                else
                {
                    tb_n1.Text = "0";
                }
            }

        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();

                if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "1";
                }
                else
                {
                    NumeroBotao += "1";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 1;
                }
                else
                {
                    numeroSalvo += 1;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.Contains("0", 0))
                    {
                        NumeroBotao = "1";
                    }
                    else
                    {
                        NumeroBotao += "1";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "1";
                }
                else
                {
                    NumeroBotao += "1";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 1;
                }
                else
                {
                    numeroSalvo += 1;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "2";
                }
                else
                {
                    NumeroBotao += "2";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 2;
                }
                else
                {
                    numeroSalvo += 2;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.Contains("0", 0))
                    {
                        NumeroBotao = "2";
                    }
                    else
                    {
                        NumeroBotao += "2";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "2";
                }
                else
                {
                    NumeroBotao += "2";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 2;
                }
                else
                {
                    numeroSalvo += 2;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "3";
                }
                else
                {
                    NumeroBotao += "3";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 3;
                }
                else
                {
                    numeroSalvo += 3;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.Contains("0", 0))
                    {
                        NumeroBotao = "3";
                    }
                    else
                    {
                        NumeroBotao += "3";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.Contains("0", 0))
                {
                    NumeroBotao = "3";
                }
                else
                {
                    NumeroBotao += "3";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 3;
                }
                else
                {
                    numeroSalvo += 3;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "4";
                }
                else
                {
                    NumeroBotao += "4";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 4;
                }
                else
                {
                    numeroSalvo += 4;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "4";
                    }
                    else
                    {
                        NumeroBotao += "4";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "4";
                }
                else
                {
                    NumeroBotao += "4";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 4;
                }
                else
                {
                    numeroSalvo += 4;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "5";
                }
                else
                {
                    NumeroBotao += "5";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 5;
                }
                else
                {
                    numeroSalvo += 5;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "5";
                    }
                    else
                    {
                        NumeroBotao += "5";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "5";
                }
                else
                {
                    NumeroBotao += "5";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 5;
                }
                else
                {
                    numeroSalvo += 5;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "6";
                }
                else
                {
                    NumeroBotao += "6";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 6;
                }
                else
                {
                    numeroSalvo += 6;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "6";
                    }
                    else
                    {
                        NumeroBotao += "6";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "6";
                }
                else
                {
                    NumeroBotao += "6";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 6;
                }
                else
                {
                    numeroSalvo += 6;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "7";
                }
                else
                {
                    NumeroBotao += "7";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 7;
                }
                else
                {
                    numeroSalvo += 7;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "7";
                    }
                    else
                    {
                        NumeroBotao += "7";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "7";
                }
                else
                {
                    NumeroBotao += "7";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 7;
                }
                else
                {
                    numeroSalvo += 7;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "8";
                }
                else
                {
                    NumeroBotao += "8";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 8;
                }
                else
                {
                    numeroSalvo += 8;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "8";
                    }
                    else
                    {
                        NumeroBotao += "8";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "8";
                }
                else
                {
                    NumeroBotao += "8";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 8;
                }
                else
                {
                    numeroSalvo += 8;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
                if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "9";
                }
                else
                {
                    NumeroBotao += "9";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 9;
                }
                else
                {
                    numeroSalvo += 9;
                }

                tb_n1.Text = NumeroBotao;
            }
            else
            {
                if (TeveResultado == true && resultado != 0)
                {
                    VoltarBotoesContas();

                    if (NumeroBotao.StartsWith("0"))
                    {
                        NumeroBotao = "9";
                    }
                    else
                    {
                        NumeroBotao += "9";
                    }
                    resultado = 0;
                    TeveResultado = false;
                }
                else if (NumeroBotao.StartsWith("0"))
                {
                    NumeroBotao = "9";
                }
                else
                {
                    NumeroBotao += "9";
                }

                if (numeroSalvo == 0)
                {
                    numeroSalvo = 9;
                }
                else
                {
                    numeroSalvo += 9;
                }

                tb_n1.Text = NumeroBotao;
            }
        }

        private void btn_virgula_Click(object sender, RoutedEventArgs e)
        {
            if (!NumeroBotao.Contains(","))
            {
                NumeroBotao += ",";
            }

            tb_n1.Text = NumeroBotao;

        }

        private void btn_divisao_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n2.Text.Contains("×") || tb_n2.Text.Contains("+") || tb_n2.Text.Contains("-"))
            {
                if (NumeroBotao != "" && tb_n2.Text.Contains("+") && TeveResultado == false)
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("×") && TeveResultado == false)
                {
                    n1 = n1 * double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("÷") && TeveResultado == false)
                {
                    n1 = n1 / double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("-") && TeveResultado == false)
                {
                    n1 = n1 - double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else
                {
                    tb_n2.Text = n1.ToString() + "÷";
                    NumeroBotao = "";
                    TeveResultado = false;

                }
            }
            else if (tb_n2.Text.Contains("÷") && !tb_n2.Text.Contains("="))
            {
                if (n1 == 0)
                {
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else
                {
                    n1 = n1 / double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "÷";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
            }
            else if (tb_n1.Text == "0")
            {
                NumeroBotao = "0";
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "÷";
            }
            else if (NumeroBotao == "")
            {
                tb_n2.Text = n1.ToString() + "÷";
                tb_n1.Text = n1.ToString();
                TeveResultado = false;
            }
            else
            {
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "÷";
                NumeroBotao = "";

                if (TeveResultado)
                {
                    n1 = resultado;

                    tb_n2.Text = $"{resultado} ÷";
                }
            }

            EscolhaEquacao = 1;
        }

        private void btn_multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n2.Text.Contains("÷") || tb_n2.Text.Contains("+") || tb_n2.Text.Contains("-"))
            {
                if (NumeroBotao != "" && tb_n2.Text.Contains("+") && TeveResultado == false)
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("×") && TeveResultado == false)
                {
                    n1 = n1 * double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("÷") && TeveResultado == false)
                {
                    n1 = n1 / double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("-") && TeveResultado == false)
                {
                    n1 = n1 - double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else
                {
                    tb_n2.Text = n1.ToString() + "×";
                    NumeroBotao = "";
                    TeveResultado = false;
                }
            }
            else if (tb_n2.Text.Contains("×") && !tb_n2.Text.Contains("="))
            {
                if (n1 == 0)
                {
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if(NumeroBotao == "")
                {
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                }
                else
                {
                    n1 = n1 * double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "×";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
            }
            else if (tb_n1.Text == "0")
            {
                NumeroBotao = "0";
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "×";
            }
            else if (NumeroBotao == "")
            {
                tb_n2.Text = n1.ToString() + "x";
                tb_n1.Text = n1.ToString();
                TeveResultado = false;
            }
            else
            {
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "×";
                NumeroBotao = "";

                if (TeveResultado)
                {
                    n1 = resultado;

                    tb_n2.Text = $"{resultado} ×";
                }
            }

            EscolhaEquacao = 2;
        }

        private void btn_subtrair_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n2.Text.Contains("×") || tb_n2.Text.Contains("+") || tb_n2.Text.Contains("÷"))
            {   
                if(NumeroBotao != "" && tb_n2.Text.Contains("+") && TeveResultado == false)
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("×") && TeveResultado == false)
                {
                    n1 = n1 * double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("÷") && TeveResultado == false)
                {
                    n1 = n1 / double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("-") && TeveResultado == false)
                {
                    n1 = n1 - double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else
                {
                    tb_n2.Text = n1.ToString() + "-";
                    NumeroBotao = "";
                    TeveResultado = false;
                }
            }
            else if (tb_n2.Text.Contains("-") && !tb_n2.Text.Contains("="))
            {
                if (n1 == 0)
                {
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao == "")
                {
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                }
                else
                {
                    n1 = n1 - double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "-";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
            }
            else if (tb_n1.Text == "0")
            {
                NumeroBotao = "0";
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "-";
            }
            else if (NumeroBotao == "")
            {
                tb_n2.Text = n1.ToString() + "-";
                tb_n1.Text = n1.ToString();
                TeveResultado = false;
            }
            else
            {
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "-";
                NumeroBotao = "";

                if (TeveResultado)
                {
                    n1 = resultado;
                    tb_n2.Text = $"{resultado} -";
                }
            }


            EscolhaEquacao = 3;
        }

        private void btn_somar_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n2.Text.Contains("×") || tb_n2.Text.Contains("-") || tb_n2.Text.Contains("÷"))
            {
                if (NumeroBotao != "" && tb_n2.Text.Contains("+") && TeveResultado == false)
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("×") && TeveResultado == false)
                {
                    n1 = n1 * double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("÷") && TeveResultado == false)
                {
                    n1 = n1 / double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao != "" && tb_n2.Text.Contains("+") && TeveResultado == false)
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else
                {
                    tb_n2.Text = n1.ToString() + "+";
                    NumeroBotao = "";
                    TeveResultado = false;
                }
                
            }
            else if (tb_n2.Text.Contains("+") && !tb_n2.Text.Contains("="))
            {
                if (n1 == 0)
                {
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
                else if (NumeroBotao == "")
                {
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    TeveResultado = false;
                }
                else
                {
                    n1 = n1 + double.Parse(NumeroBotao);
                    tb_n2.Text = n1.ToString() + "+";
                    tb_n1.Text = n1.ToString();
                    NumeroBotao = "";
                }
            }
            else if (tb_n1.Text == "0")
            {
                NumeroBotao = "0";
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "+";
            }
            else if (NumeroBotao == "")
            {
                tb_n2.Text = n1.ToString() + "+";
                tb_n1.Text = n1.ToString();
            }
            else
            {
                n1 = double.Parse(NumeroBotao);
                tb_n2.Text = n1.ToString() + "+";
                NumeroBotao = "";

                if (TeveResultado)
                {
                    n1 = resultado;
                    tb_n2.Text = $"{resultado} +";
                }
            }

            EscolhaEquacao = 4;
            
        }
        
        private void btn_resultado_Click(object sender, RoutedEventArgs e)
        {
            if(tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
            }

            if(EscolhaEquacao == 1){
                if (NumeroBotao == "")
                {
                    if (tb_n1.Text == resultado.ToString())
                    {
                        tb_n2.Text = $"{n1} ÷ {numeroSalvo} =";
                        resultado = numeroSalvo / n1;
                    }
                    else
                    {
                        resultado = n1 / n1;
                        tb_n2.Text = $"{n1} ÷ {n1} =";
                    }
                }
                else if (tb_n1.Text == resultado.ToString())
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 / n2;
                    tb_n2.Text = $"{n1} ÷ {n2} =";
                }
                else
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 / n2;
                    tb_n2.Text = $"{n1} ÷ {n2} =";
                }
            }
            else if (EscolhaEquacao == 2)
            {
                if (NumeroBotao == "")
                {
                    if (tb_n1.Text == resultado.ToString())
                    {
                        tb_n2.Text = $"{n1} × {numeroSalvo} =";
                        resultado = numeroSalvo * n1;
                    }
                    else
                    {
                        resultado = n1 * n1;
                        tb_n2.Text = $"{n1} × {n1} =";
                    }
                }
                else if (tb_n1.Text == resultado.ToString())
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 * n2;
                    tb_n2.Text = $"{n1} × {n2} =";
                }
                else
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 * n2;
                    tb_n2.Text = $"{n1} × {n2} =";
                }
            }
            else if (EscolhaEquacao == 3)
            {
                if (NumeroBotao == "")
                {
                    if (tb_n1.Text == resultado.ToString())
                    {
                        tb_n2.Text = $"{n1} - {numeroSalvo} =";
                        resultado = numeroSalvo - n1;
                    }
                    else
                    {
                        resultado = n1 - n1;
                        tb_n2.Text = $"{n1} - {n1} =";
                    }
                }
                else if (tb_n1.Text == resultado.ToString())
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 - n2;
                    tb_n2.Text = $"{n1} - {n2} =";
                }
                else
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 - n2;
                    tb_n2.Text = $"{n1} - {n2} =";
                }
            }
            else if (EscolhaEquacao == 4)
            {
                if (NumeroBotao == "")
                {
                    if (tb_n1.Text == resultado.ToString())
                    {      
                        tb_n2.Text = $"{n1} + {numeroSalvo} =";
                        resultado = numeroSalvo + n1;
                    }
                    else
                    {
                        resultado = n1 + n1;
                        tb_n2.Text = $"{n1} + {n1} =";
                    }
                }
                else if (tb_n1.Text == resultado.ToString())
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 + n2;
                    tb_n2.Text = $"{n1} + {n2} =";
                }
                else
                {
                    n2 = double.Parse(NumeroBotao);
                    resultado = n1 + n2;
                    tb_n2.Text = $"{n1} + {n2} =";
                } 
            }

            tb_n1.Text = resultado.ToString();
            n1 = resultado;
            TeveResultado = true;
            NumeroBotao = "";

            if(tb_n1.Text == "NaN")
            {
                btn_multiplicacao.IsEnabled = false;
                btn_divisao.IsEnabled = false;
                btn_somar.IsEnabled = false;
                btn_subtrair.IsEnabled = false;
                btn_virgula.IsEnabled = false;
            }
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {

            if (tb_n1.Text == "NaN")
            {

                VoltarBotoesContas();
            }
            else
            {
                NumeroBotao = "";
                n1 = 0;
                n2 = 0;
                TeveResultado = false;
                EscolhaEquacao = 0;
                resultado = 0;

                tb_n2.Text = "";
                tb_n1.Text = "0";
            }

        }

        private void btn_ce_Click(object sender, RoutedEventArgs e)
        {
            if (tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
            }
            else if(resultado != 0)
            {
                VoltarBotoesContas();
            }
            else
            {
                tb_n1.Text = "0";
                NumeroBotao = "0";
                numeroSalvo = 0;
            }

        }

        private void btn_D_Click(object sender, RoutedEventArgs e)
        {
            if(tb_n1.Text == "NaN")
            {
                VoltarBotoesContas();
            }
            else
            {
                if (NumeroBotao != "" && NumeroBotao.Length > 1)
                {
                    NumeroBotao = NumeroBotao.Remove(NumeroBotao.Length - 1);
                }
                else if (NumeroBotao != "" && NumeroBotao.Length == 1)
                {
                    NumeroBotao = "0";
                }

                tb_n1.Text = NumeroBotao;
            }

        }

        private void VoltarBotoesContas()
        {
            NumeroBotao = "";
            n1 = 0;
            n2 = 0;
            TeveResultado = false;
            EscolhaEquacao = 0;
            resultado = 0;

            tb_n2.Text = "";
            tb_n1.Text = "0";

            btn_multiplicacao.IsEnabled = true;
            btn_divisao.IsEnabled = true;
            btn_somar.IsEnabled = true;
            btn_subtrair.IsEnabled = true;
            btn_virgula.IsEnabled = true;
        }

        private void ClickPato(object sender, MouseButtonEventArgs e)
        {
            Stream audio = Properties.Resources.SomPato;
            SoundPlayer player = new SoundPlayer(audio);
            player.Play();
        }
    }
}
