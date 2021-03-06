﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
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
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(zad.get_algorytm());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(zad.get_watki());

            }

            listView2.Items.Clear();
            foreach (Zadanie zad in wykonane)
            {
                listView2.Items.Add(zad.get_liczba());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czasdodania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_czaswykonywania());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_algorytm());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_wynik());
                listView2.Items[listView2.Items.Count - 1].SubItems.Add(zad.get_watki());

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
            backgroundWorker2.RunWorkerAsync();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                backgroundWorker1.Dispose();
            }
            catch
            {
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            wykonane.Clear();
            odswierz();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int postep = 0;
            while (zadania.Count != 0)
            {
                Thread.Sleep(200);
                try
                {
                    postep = zadania[0].get_postęp();
                    if (postep >= 0 && postep <= 100)
                    {
                        backgroundWorker2.ReportProgress(postep);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    backgroundWorker2.ReportProgress(0);
                }
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger a = BigInteger.Parse (zadania[0].get_liczba());
            String liczbaa = BigIntRandom.NextRand(a).ToString();
            MessageBox.Show("Wylosowana liczba to: \n" + liczbaa +"\n ma "+liczbaa.Length+" cyfr");
        }

        
    }
}
