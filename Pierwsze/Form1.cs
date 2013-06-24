using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsze
{
    public partial class Form1 : Form
    {
        public List<Zadanie> zadania = new List<Zadanie>();
        public List<Zadanie> wykonane = new List<Zadanie>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public void odswierz()
        {
            listView1.Items.Clear();
            foreach (Zadanie zad in zadania)
            {
                listView1.Items.Add(zad.get_liczba());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(zad.get_czasdodania());
            }

            listView2.Items.Clear();
            foreach (Zadanie zad in wykonane)
            {
                listView2.Items.Add(zad.get_liczba());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czasdodania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czaswykonywania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_wynik());
            }
        }

        public void odswierz2()
        {
            //listView1.Items.Clear();
            foreach (Zadanie zad in zadania)
            {
                listView1.Items.Add(zad.get_liczba());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(zad.get_czasdodania());
            }

           // listView2.Items.Clear();
            foreach (Zadanie zad in wykonane)
            {
                listView2.Items.Add(zad.get_liczba());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czasdodania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czaswykonywania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_wynik());
            }
        }

        

        private void Dodaj_Button_Click(object sender, EventArgs e)
        {
            Nowa_liczba dodaj = new Nowa_liczba(zadania, this);
            dodaj.Show();
        }

        private void Sprawdz_Button_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (zadania.Count != 0)
            {
                zadania[0].licz();
                wykonane.Add(zadania[0]);
                zadania.RemoveAt(0);
                Action action = () => odswierz();
                this.Invoke(action);
                
            }
        }
    }
}
