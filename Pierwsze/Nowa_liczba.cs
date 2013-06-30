using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
             Zadanie zad = null;
             try
             {
                 if (textBox1.Text != string.Empty)
                 {
                     BigInteger liczba = BigInteger.Parse(textBox1.Text);
                     if (comboBox1.SelectedIndex == 0)
                     {
                          zad = new Zadanie(liczba);
                          zadaniaa.Add(zad);
                          temporary.odswierz();
                          Dispose();
                     }
                     if (comboBox1.SelectedIndex == 1)
                     {
                         zad = new Miller(liczba);
                         zadaniaa.Add(zad);
                         temporary.odswierz();
                         Dispose();
                     }
                     if (comboBox1.SelectedIndex == -1)
                     {
                         MessageBox.Show("Nie wybrano algorytmu");
                         
                     }

                     
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

        // Wczytywanie z pliku
         private void button2_Click(object sender, EventArgs e)
         {
             string liczba_str =null;
             
             DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
             if (result == DialogResult.OK) // Test result.
             {
                 string file = openFileDialog1.FileName;
                 try
                 {
                     liczba_str = File.ReadAllText(file);
                     BigInteger liczba = BigInteger.Parse(liczba_str);
                     
                     Zadanie zad = new Zadanie(liczba);
                     zadaniaa.Add(zad);
                     temporary.odswierz();
                     Dispose();

                 }
                 catch (IOException)
                 {
                     MessageBox.Show("Nie udało się otworzyć pliku !");
                 }
                 catch (FormatException)
                 {
                     MessageBox.Show("Błędna zawartość pliku !!");
                 }
             }
            
         }
    }
}
