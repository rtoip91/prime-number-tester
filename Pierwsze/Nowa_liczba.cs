using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsze
{
    public partial class Nowa_liczba : Form
    {

       List<Zadanie> zadaniaa = new List<Zadanie>();
        Form1 temporary = null;

        public Nowa_liczba()
        {
            InitializeComponent();
        }

        public Nowa_liczba(List<Zadanie> zadania, Form1 forma)
        {
            this.zadaniaa = zadania;
            temporary = forma;
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 if (textBox1.Text != string.Empty)
                 {
                     BigInteger liczba = BigInteger.Parse(textBox1.Text);
                     Zadanie zad = new Zadanie(liczba);
                     zadaniaa.Add(zad);
                     temporary.odswierz();
                     Dispose();
                 }
                 else
                 {
                     MessageBox.Show("Nie podano liczby !!!");
                 }
             }
             catch
             {
                 MessageBox.Show("Podano nieprawidłową liczbę");
             }
         }
    }
}
