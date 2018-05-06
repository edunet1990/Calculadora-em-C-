using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
       public string[] Numeros = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", };
        string[] Simbolos = new string[] { "+", "-", "x", "÷", "%"};
        bool VerificaSeHaMaisDeUmNum = false, VerificaSeENumero = true, verificaSeEOSegundoNumero = false,DepoisDeIgual = false;
        string ResultDisplay, NumerosDigitiados,Calculo;
        int N1 = 0,N2 = 0, Resultado = 0, ContaQtosNumerosCal = 0;

        //Metodo que mostra os dados digitados na tela
        void MostraDados(string dado)
        {
            if (DepoisDeIgual) //Serve para quando digitarmos outros números depois de ter clicado em igual ele zerar
            {
                LimpaDados();
            }

            if (VerificaSeHaMaisDeUmNum == false)
            {
                
                if (VerificaSeENumero)
                {
                    NumerosDigitiados = dado;
                    ResultDisplay = dado;
                    Display.Text = ResultDisplay;
                    VerificaSeHaMaisDeUmNum = true;
                    
                }
                else
                {
                    ResultDisplay = ResultDisplay + dado;
                    Display.Text = ResultDisplay;
                }

            }
            else
            {
                
                if (VerificaSeENumero)
                {
                    NumerosDigitiados += dado;
                    ResultDisplay = ResultDisplay + dado;
                    Display.Text = ResultDisplay;
                    VerificaSeHaMaisDeUmNum = true;
                    
                }
                else
                {
                    ResultDisplay = ResultDisplay + dado;
                    Display.Text = ResultDisplay;
                }
                
            }
             

        }

        //Captura Dados
        void CapturaDados()
        {
            if (DepoisDeIgual) // para capturar os dados depois de igual
            {
                N1 = Resultado;
                N2 = Convert.ToInt32(NumerosDigitiados);
            }
            else
            {

            
            if (!(NumerosDigitiados == "")) //Esse IF é para quando clicarmos em igual duas vezes seguidas ele não capturar nada
            {
                if (verificaSeEOSegundoNumero == false)
                {
                    if (VerificaSeENumero)
                    {
                        if (ContaQtosNumerosCal == 0)
                        {
                            N1 = Convert.ToInt32(NumerosDigitiados);
                            NumerosDigitiados = "";
                            verificaSeEOSegundoNumero = true;
                            ContaQtosNumerosCal++;
                        }

                    }

                }
                else
                {
                    if (ContaQtosNumerosCal == 1)
                    {
                        N2 = Convert.ToInt32(NumerosDigitiados);
                        NumerosDigitiados = "";
                        ContaQtosNumerosCal++;

                    }
                    else if (ContaQtosNumerosCal > 1)
                    {
                        N1 = Resultado;
                        N2 = Convert.ToInt32(NumerosDigitiados);
                        NumerosDigitiados = "";

                    }
                }

            }

            }

        }

        //Calculo
        void Adicao()
        {
            Resultado = N1 + N2;

            Display.Text = Resultado.ToString();
        }

        void Subtracao()
        {
            Resultado = N1 - N2;

            Display.Text = Resultado.ToString();
        }

        void Multiplicacao()
        {
            Resultado = N1 * N2;

            Display.Text = Resultado.ToString();
        }

        void Divisao()
        {
            Resultado = N1 / N2;

            Display.Text = Resultado.ToString();
        }
        //Metodo para limpar
        void LimpaDados()
        {
            NumerosDigitiados = "";
            N1 = 0;
            N2 = 0;
            Display.Text = Numeros[0];
            ResultDisplay = "";
            ContaQtosNumerosCal = 0;
            verificaSeEOSegundoNumero = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[1]);
           
        }

        private void n2_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[2]);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[3]);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[4]);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[5]);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[6]);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[7]);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[8]);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = true;
            MostraDados(Numeros[9]);
        }

        private void c_Click(object sender, EventArgs e)
        {
            Resultado = 0;
            LimpaDados();
           
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            CapturaDados();

            switch (Calculo)
            {
                case "+":
                    Adicao();
                    break;

                case "-":
                    Subtracao();
                    break;

                case "x":
                    Multiplicacao();
                    break;

                case "÷":
                    Divisao();
                    break;
            }

            DepoisDeIgual = true;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            MostraDados(Numeros[0]);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = false;
            MostraDados(Simbolos[3]);
            CapturaDados();
            Calculo = Simbolos[3];
        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = false;
            MostraDados(Simbolos[2]);
            CapturaDados();
            Calculo = Simbolos[2];
        }

        private void subtrai_Click(object sender, EventArgs e)
        {
            VerificaSeENumero = false;
            MostraDados(Simbolos[1]);
            CapturaDados();
            Calculo = Simbolos[1];
        }

        private void adiciona_Click(object sender, EventArgs e)
        {
          
            if (ContaQtosNumerosCal > 0)
            {
                CapturaDados();
                Adicao();
                ResultDisplay = "";


            }
            else
            {
                CapturaDados();
                MostraDados(Simbolos[0]);
                Calculo = Simbolos[0];
                VerificaSeENumero = false;
            }
            
        }
    }
}
