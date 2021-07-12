using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            { //int valor = 3;

                //if (valor==4)
                //{
                //    caixatt.Text = "OK";
                //}
                //else
                //{
                //    caixatt.Text = "não";


                //int valor = 1;
                //switch (valor)
                //{
                //    case 10:
                //        caixatt.Text = "primeirs opção";
                //        break;

                //    default: caixatt.Text = "Deu defeito";
                //        break;



                //for (int valor = 0; valor <=20; valor ++)
                // {
                //     lista.Items.Add(valor);
                // }
                //if (frase.EndsWith("."))
                //{
                //    frase = "tem o ponto";
                //}
                //else
                //{
                //    frase = frase + "$";
                //}
                //caixa_txt.Text = frase;
                //string frase = "testando a string.";
                //int x = frase.IndexOf("a");
                //caixa_txt.Text = x.ToString();



                //string nome = "Rafaela  Prado";
                //string apelido = "Martins";
                //// string nome_completo = nome.Insert(8, apelido);
                //string final = nome.Replace('a', '_'); 
                //caixa_txt.Text = final;

                //string nome = "Rafa";

                //Class1 p1 = new Class1();
                //p1.nome = "joão";
                //p1.idade = 17;
                //p1.cor_cabelo = "preto";

                //Class1 p2 = new Class1();
                //p2.idade = 16;
                //p2.nome = "joana";
                //p2.cor_cabelo = "azul";
                //caixa_txt.Text = p2.nome;


                //Class1 p1 = new Class1();
                //p1.nome = "rafa";
                //p1.falar();

                //Class1 p2 = new Class1();
                //p2.nome = "rafah";
                //p2.falar();

                //Class1 p3 = new Class1();
                //p3.nome = "rafah";
                //p3.idade = 15;
                //p3.apresentar();

            }
            pessoa p1 = new pessoa();
            p1.nome = "Rafaela";
            p1.apelido = "pradis";
            p1.identificar();

        }
    }
}
