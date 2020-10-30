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



        private void button_Add_Click(object sender, EventArgs e)
        {
             string ujhobbi = textBox_Ujhobbi.Text.Trim();


            if (listBox_Hobbi.Items.Contains(ujhobbi))
            {
                MessageBox.Show("Ez a hobbi már szerepel a listában");
            }
            else
            {
                listBox_Hobbi.Items.Add(ujhobbi);
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
                MessageBox.Show("A születési détumod nem lehet a jövöben", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime szuldatum = dateTimePicker_SzulDatum.Value;
            }



            string nem = "";


            if (radioButton_Ffi.Checked)
            {
                nem = "Férfi";
            }
            else if (radioButton_No.Checked)
            {
                nem = "Nő";
            }

            string hobbi = listBox_Hobbi.SelectedItem.ToString();

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

            textBox_Nev.Clear();
            listBox_Hobbi.Items.Clear();

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
                        string ujhobbi = sor[3];
                        Regadatok regadat = new Regadatok(nev, szuldatum, nem, ujhobbi);
                        regadatok.Add(regadat);
                    }
                    MessageBox.Show("Sikeres beolvasás!");
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
            
            textBox_Nev.Text = regadatok[0].Nev;
            dateTimePicker_SzulDatum.Value = regadatok[0].Szuldatum;

            if (regadatok[0].Nem == "Férfi")
            {
                radioButton_Ffi.Checked = true;
            }

            if (regadatok[0].Nem == "Nő")
            {
                radioButton_No.Checked = true;
            }

            listBox_Hobbi.Items.Add(regadatok[0].Hobbi);
        }
    }
}
