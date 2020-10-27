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
            dateTimePicker_Szuldatum.MaxDate = DateTime.Today;
            dateTimePicker_Szuldatum.Format = DateTimePickerFormat.Custom;
            // Ensures no future dates are set.
          dateTimePicker_Szuldatum.CustomFormat = dateTimePicker_Szuldatum.CustomFormat;
          
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Name.Text)) 
            {                   
                MessageBox.Show(" A Név mező kitöltése kötelező", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Name.Focus();  
                return;
            }
            if (String.IsNullOrWhiteSpace(textBox_Ujhobbi.Text))
            {
                MessageBox.Show(" A Hobbi mező kitöltése kötelező", "Adatbeviteli hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Name.Focus();
                return;
            }
            string nev = textBox_Name.Text.Trim();
            string nem = "Férfi";
            if (radioButton_Ffi.Checked)
            {
                nem = "férfi";

            }
            else if (radioButton_No.Checked)
            {
                nem = "Nő";

            }
            DateTime szuldatum = (DateTime)dateTimePicker_Szuldatum.Value;
             

        string hobbi = textBox_Ujhobbi.Text;
            Regadatok regadat = new Regadatok(nev, szuldatum, nem, hobbi);            

            // alapállapotba állítjuk a mezőket             
            textBox_Name.Text = "";
            radioButton_Ffi.Checked = true;
            dateTimePicker_Szuldatum.Value = DateTime.Today;

            listBox_Hobbi.Items.Add(hobbi);

        }

        private void listBox_Hobbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regadatok regadat = (Regadatok)listBox_Hobbi.SelectedItem;           
            textBox_Name.Text = regadat.Nev;
            if (regadat.Nem.Equals("férfi"))
            {
                radioButton_Ffi.Checked = true;
            }
            else if (regadat.Nem.Equals("Nő"))
            {
                radioButton_No.Checked = true;
            }
            dateTimePicker_Szuldatum.Value = regadat.Szuldatum;
            textBox_Ujhobbi.Text = regadat.Hobbi;
            
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName)) // megnyitja és le is zárja a végén a filet
                {
                    for (int i = 0; i < listBox_Hobbi.Items.Count; i++)
                    {
                        Regadatok items = (Regadatok)listBox_Hobbi.Items[i];
                        sw.WriteLine(String.Format("{0};{1};{2};{3};", items.Nev, items.Nem, items.Szuldatum, items.Hobbi));
                    }
                 
                    MessageBox.Show("Sikeres mentés");

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
                using (var sr = new StreamReader(openFileDialog1.FileName))
                {
                    listBox_Hobbi.Items.Clear();
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        string nev = sor[0];                        
                       DateTime szuldatum = Convert.ToDateTime(sor[1]);
                        string nem = sor[2];
                        string hobbi = sor[3];
                        var regadat = new Regadatok(nev, szuldatum, nem,  hobbi);                       
                        listBox_Hobbi.Items.Add(regadat);
                    }
                    MessageBox.Show("Sikeres beolvasás!");
                }
            }
            //catch (FileNotFoundException) // file olvasási kivétel -  c# Exception hierarchy 
            //{                               
            //} 
            catch (IOException ex) // IO kivétel - az ex lehet itt is, mert blokk szintű 
            {
                // ex.StackTrace; // milyen kódrészeken mentünk végig, míg eljutottunk a hibához? 
                MessageBox.Show(" Hiba a file megnyitása során");
            }
            catch (Exception ex)  // általános kivétel - mindig ez kerül a végére
            {
                MessageBox.Show(" Hiba a file feldolgozása közben");

            }
        }
    }
}
