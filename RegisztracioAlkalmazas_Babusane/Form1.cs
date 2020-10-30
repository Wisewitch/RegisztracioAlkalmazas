using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas_Babusane
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dateTimePicker_SzulDatum.MaxDate = DateTime.Today;
            dateTimePicker_SzulDatum.Format = DateTimePickerFormat.Custom;
            dateTimePicker_SzulDatum.CustomFormat = dateTimePicker_SzulDatum.CustomFormat;
        }

        static List<Regadatok> regadatok = new List<Regadatok>();
        static int adatsor = -1;


        private void button_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Ujhobbi.Text.Trim()))
            {
                MessageBox.Show("A Hobbi mező kitöltése kötelező.", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Ujhobbi.Focus();
                return;
            } 

            string hobbi = textBox_Ujhobbi.Text.Trim();
            

            if (listBox_Hobbi.Items.Contains(hobbi))
            {
                MessageBox.Show("Ez a hobbi már szerepel a listában");

            }
            else
            {
                MessageBox.Show("Új elem hozzáadva");
                listBox_Hobbi.Items.Add(hobbi);
                textBox_Ujhobbi.Text = "";
                textBox_Ujhobbi.Focus();
            }


        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (String.IsNullOrWhiteSpace(textBox_Nev.Text))
            {
                MessageBox.Show("A Név mező kitöltése kötelező", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nev.Focus();
                return;
            }

            string nev = textBox_Nev.Text.Trim();


            DateTime datum = dateTimePicker_SzulDatum.Value;

            DateTime maidatum = DateTime.Now;

            if (datum > maidatum)
            {
                MessageBox.Show("A születési dátumod nem lehet a jövöben", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime szuldatum = dateTimePicker_SzulDatum.Value;
            }


            string nem = "";

            if (!radioButton_No.Checked && !radioButton_Ffi.Checked)
            {
                MessageBox.Show("Nem választttad ki a nemed.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (radioButton_Ffi.Checked)
            {
                nem = "Férfi";
            }
            else if (radioButton_No.Checked)
            {
                nem = "Nő";
            }

            string hobbi = listBox_Hobbi.SelectedItems.ToString();

            Regadatok regadat = new Regadatok(nev, datum, nem, hobbi);

            regadatok.Add(regadat);


            if (result != DialogResult.OK)
            {
                return;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (Regadatok item in regadatok)
                    {
                        sw.WriteLine(string.Format("{0};{1};{2};{3};", item.Nev, item.Szuldatum, item.Nem, item.Hobbi));
                    }
                    MessageBox.Show("Sikeres mentés.");
                }
            }
            catch (IOException)
            {
                MessageBox.Show(" Hiba történt a kiírás közben");
            }
        }



        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK)
            {
                MessageBox.Show("Nem választott ki filet, nem fog betöltődni.");
                return;
            }


            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        string nev = sor[0];
                        DateTime szuldatum = Convert.ToDateTime(sor[1]);
                        string nem = sor[2];
                        string hobbi = sor[3];
                        Regadatok regadat = new Regadatok(nev, szuldatum, nem, hobbi);
                        regadatok.Add(regadat);
                        adatsor++;
                    }
                    MessageBox.Show("Sikeres beolvasás!");

                    textBox_Nev.Clear();

                    textBox_Nev.Text = regadatok[adatsor].Nev;
                    dateTimePicker_SzulDatum.Value = regadatok[adatsor].Szuldatum;

                    if (regadatok[adatsor].Nem == "Férfi")
                    {
                        radioButton_Ffi.Checked = true;
                    }

                    if (regadatok[adatsor].Nem == "Nő")
                    {
                        radioButton_No.Checked = true;
                    }


                    listBox_Hobbi.Items.Clear();
                    listBox_Hobbi.Items.Add("Varrás");
                    listBox_Hobbi.Items.Add("Edzés");
                    listBox_Hobbi.Items.Add("Olvasás");
                    listBox_Hobbi.Items.Add(regadatok[adatsor].Hobbi);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Hiba a fájl megnyitása során.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a fájl feldolgozása közben.");
            }
        }
    }
}
