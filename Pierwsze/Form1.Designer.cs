﻿namespace Pierwsze
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Sprawdz_Button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Liczba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Dodania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Algorytm1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.liczb1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzDodania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzObliczen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Algorytm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wynik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dodaj_Button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CleanButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(250, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Postęp";
            // 
            // Sprawdz_Button
            // 
            this.Sprawdz_Button.Location = new System.Drawing.Point(26, 241);
            this.Sprawdz_Button.Name = "Sprawdz_Button";
            this.Sprawdz_Button.Size = new System.Drawing.Size(184, 22);
            this.Sprawdz_Button.TabIndex = 4;
            this.Sprawdz_Button.Text = "Sprawdź";
            this.Sprawdz_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sprawdz_Button.UseVisualStyleBackColor = true;
            this.Sprawdz_Button.Click += new System.EventHandler(this.Sprawdz_Button_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Liczba,
            this.Data_Dodania,
            this.Algorytm1,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(26, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 152);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Liczba
            // 
            this.Liczba.Text = "Liczba";
            this.Liczba.Width = 243;
            // 
            // Data_Dodania
            // 
            this.Data_Dodania.Text = "Czas Dodania";
            this.Data_Dodania.Width = 145;
            // 
            // Algorytm1
            // 
            this.Algorytm1.Text = "Algorytm";
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.liczb1,
            this.CzDodania,
            this.CzObliczen,
            this.Algorytm,
            this.Wynik,
            this.columnHeader2});
            this.listView2.Location = new System.Drawing.Point(26, 292);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(512, 182);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // liczb1
            // 
            this.liczb1.Text = "Liczba";
            this.liczb1.Width = 131;
            // 
            // CzDodania
            // 
            this.CzDodania.Text = "Czas Dodania";
            this.CzDodania.Width = 89;
            // 
            // CzObliczen
            // 
            this.CzObliczen.Text = "Czas Obliczeń";
            this.CzObliczen.Width = 91;
            // 
            // Algorytm
            // 
            this.Algorytm.DisplayIndex = 4;
            this.Algorytm.Text = "Algorytm";
            this.Algorytm.Width = 64;
            // 
            // Wynik
            // 
            this.Wynik.DisplayIndex = 3;
            this.Wynik.Text = "Wynik";
            this.Wynik.Width = 76;
            // 
            // Dodaj_Button
            // 
            this.Dodaj_Button.Location = new System.Drawing.Point(556, 26);
            this.Dodaj_Button.Name = "Dodaj_Button";
            this.Dodaj_Button.Size = new System.Drawing.Size(117, 23);
            this.Dodaj_Button.TabIndex = 7;
            this.Dodaj_Button.Text = "Dodaj";
            this.Dodaj_Button.UseVisualStyleBackColor = true;
            this.Dodaj_Button.Click += new System.EventHandler(this.Dodaj_Button_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(556, 292);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(117, 23);
            this.CleanButton.TabIndex = 8;
            this.CleanButton.Text = "Wyczyść";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wątki";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wątki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.Dodaj_Button);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Sprawdz_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(711, 548);
            this.MinimumSize = new System.Drawing.Size(711, 548);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprawdzanie Pierwszosci Liczb";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sprawdz_Button;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button Dodaj_Button;
        private System.Windows.Forms.ColumnHeader Liczba;
        private System.Windows.Forms.ColumnHeader Data_Dodania;
        private System.Windows.Forms.ColumnHeader liczb1;
        private System.Windows.Forms.ColumnHeader CzDodania;
        private System.Windows.Forms.ColumnHeader CzObliczen;
        private System.Windows.Forms.ColumnHeader Wynik;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ColumnHeader Algorytm1;
        private System.Windows.Forms.ColumnHeader Algorytm;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

