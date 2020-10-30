namespace RegisztracioAlkalmazas_Babusane
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_SzulDatum = new System.Windows.Forms.Label();
            this.label_Nem = new System.Windows.Forms.Label();
            this.label_Honbi = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_SzulDatum = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Ffi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.listBox_Hobbi = new System.Windows.Forms.ListBox();
            this.textBox_Ujhobbi = new System.Windows.Forms.TextBox();
            this.label_Ujhobbi = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.Location = new System.Drawing.Point(171, 30);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(65, 29);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Név:";
            // 
            // label_SzulDatum
            // 
            this.label_SzulDatum.AutoSize = true;
            this.label_SzulDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SzulDatum.Location = new System.Drawing.Point(53, 84);
            this.label_SzulDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SzulDatum.Name = "label_SzulDatum";
            this.label_SzulDatum.Size = new System.Drawing.Size(206, 29);
            this.label_SzulDatum.TabIndex = 1;
            this.label_SzulDatum.Text = "Születési Dátum:";
            // 
            // label_Nem
            // 
            this.label_Nem.AutoSize = true;
            this.label_Nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Nem.Location = new System.Drawing.Point(161, 149);
            this.label_Nem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Nem.Name = "label_Nem";
            this.label_Nem.Size = new System.Drawing.Size(74, 29);
            this.label_Nem.TabIndex = 2;
            this.label_Nem.Text = "Nem:";
            // 
            // label_Honbi
            // 
            this.label_Honbi.AutoSize = true;
            this.label_Honbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Honbi.Location = new System.Drawing.Point(665, 30);
            this.label_Honbi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Honbi.Name = "label_Honbi";
            this.label_Honbi.Size = new System.Drawing.Size(188, 29);
            this.label_Honbi.TabIndex = 3;
            this.label_Honbi.Text = "Kedvenc hobbi:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(260, 30);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(265, 22);
            this.textBox_Nev.TabIndex = 4;
            // 
            // dateTimePicker_SzulDatum
            // 
            this.dateTimePicker_SzulDatum.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_SzulDatum.Checked = false;
            this.dateTimePicker_SzulDatum.Location = new System.Drawing.Point(260, 84);
            this.dateTimePicker_SzulDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_SzulDatum.MaxDate = new System.DateTime(2020, 10, 27, 0, 0, 0, 0);
            this.dateTimePicker_SzulDatum.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_SzulDatum.Name = "dateTimePicker_SzulDatum";
            this.dateTimePicker_SzulDatum.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_SzulDatum.TabIndex = 5;
            // 
            // radioButton_Ffi
            // 
            this.radioButton_Ffi.AutoSize = true;
            this.radioButton_Ffi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Ffi.Location = new System.Drawing.Point(276, 149);
            this.radioButton_Ffi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Ffi.Name = "radioButton_Ffi";
            this.radioButton_Ffi.Size = new System.Drawing.Size(84, 33);
            this.radioButton_Ffi.TabIndex = 6;
            this.radioButton_Ffi.TabStop = true;
            this.radioButton_Ffi.Text = "Férfi";
            this.radioButton_Ffi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_No.Location = new System.Drawing.Point(439, 149);
            this.radioButton_No.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(66, 33);
            this.radioButton_No.TabIndex = 7;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // listBox_Hobbi
            // 
            this.listBox_Hobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_Hobbi.FormattingEnabled = true;
            this.listBox_Hobbi.ItemHeight = 25;
            this.listBox_Hobbi.Items.AddRange(new object[] {
            "Varrás",
            "Edzés",
            "Olvasás"});
            this.listBox_Hobbi.Location = new System.Drawing.Point(671, 84);
            this.listBox_Hobbi.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Hobbi.Name = "listBox_Hobbi";
            this.listBox_Hobbi.Size = new System.Drawing.Size(215, 154);
            this.listBox_Hobbi.TabIndex = 8;
            // 
            // textBox_Ujhobbi
            // 
            this.textBox_Ujhobbi.Location = new System.Drawing.Point(670, 269);
            this.textBox_Ujhobbi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ujhobbi.Name = "textBox_Ujhobbi";
            this.textBox_Ujhobbi.Size = new System.Drawing.Size(216, 22);
            this.textBox_Ujhobbi.TabIndex = 9;
            // 
            // label_Ujhobbi
            // 
            this.label_Ujhobbi.AutoSize = true;
            this.label_Ujhobbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Ujhobbi.Location = new System.Drawing.Point(555, 262);
            this.label_Ujhobbi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ujhobbi.Name = "label_Ujhobbi";
            this.label_Ujhobbi.Size = new System.Drawing.Size(106, 29);
            this.label_Ujhobbi.TabIndex = 10;
            this.label_Ujhobbi.Text = "Új hobbi";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Add.Location = new System.Drawing.Point(709, 320);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(177, 37);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "Hozzáad";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Mentes.Location = new System.Drawing.Point(528, 436);
            this.button_Mentes.Margin = new System.Windows.Forms.Padding(4);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(196, 41);
            this.button_Mentes.TabIndex = 12;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Betoltes.Location = new System.Drawing.Point(763, 434);
            this.button_Betoltes.Margin = new System.Windows.Forms.Padding(4);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(220, 43);
            this.button_Betoltes.TabIndex = 13;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Regadatok";
            this.saveFileDialog1.Filter = "Szövegfile (*.txt)|*.txt|Minden file(*.*) | *.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Szövegfile (*.txt)|*.txt|Minden file(*.*) | *.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 498);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Ujhobbi);
            this.Controls.Add(this.textBox_Ujhobbi);
            this.Controls.Add(this.listBox_Hobbi);
            this.Controls.Add(this.radioButton_No);
            this.Controls.Add(this.radioButton_Ffi);
            this.Controls.Add(this.dateTimePicker_SzulDatum);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label_Honbi);
            this.Controls.Add(this.label_Nem);
            this.Controls.Add(this.label_SzulDatum);
            this.Controls.Add(this.label_Name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_SzulDatum;
        private System.Windows.Forms.Label label_Nem;
        private System.Windows.Forms.Label label_Honbi;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SzulDatum;
        private System.Windows.Forms.RadioButton radioButton_Ffi;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.ListBox listBox_Hobbi;
        private System.Windows.Forms.TextBox textBox_Ujhobbi;
        private System.Windows.Forms.Label label_Ujhobbi;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

