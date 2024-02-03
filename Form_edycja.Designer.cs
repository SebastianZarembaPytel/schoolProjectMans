namespace WindowsFormsApp2
{
    partial class Form_edycja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_edycja));
            this.button_menu = new System.Windows.Forms.Button();
            this.text_pesel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_data = new System.Windows.Forms.DateTimePicker();
            this.text_kodpoczt = new System.Windows.Forms.TextBox();
            this.text_ulica = new System.Windows.Forms.TextBox();
            this.text_miasto = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_numer = new System.Windows.Forms.TextBox();
            this.text_nazwisko = new System.Windows.Forms.TextBox();
            this.text_imie = new System.Windows.Forms.TextBox();
            this.label_plec = new System.Windows.Forms.Label();
            this.box_plec = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_zapiszzmiany = new System.Windows.Forms.Button();
            this.button_loaddata = new System.Windows.Forms.Button();
            this.text_loadpacjent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(12, 26);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(139, 64);
            this.button_menu.TabIndex = 0;
            this.button_menu.Text = "powrót do Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // text_pesel
            // 
            this.text_pesel.Location = new System.Drawing.Point(343, 138);
            this.text_pesel.Name = "text_pesel";
            this.text_pesel.Size = new System.Drawing.Size(151, 20);
            this.text_pesel.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(546, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Data narodzin";
            // 
            // text_data
            // 
            this.text_data.Location = new System.Drawing.Point(544, 157);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(200, 20);
            this.text_data.TabIndex = 43;
            // 
            // text_kodpoczt
            // 
            this.text_kodpoczt.Location = new System.Drawing.Point(343, 346);
            this.text_kodpoczt.Name = "text_kodpoczt";
            this.text_kodpoczt.Size = new System.Drawing.Size(151, 20);
            this.text_kodpoczt.TabIndex = 42;
            // 
            // text_ulica
            // 
            this.text_ulica.Location = new System.Drawing.Point(343, 309);
            this.text_ulica.Name = "text_ulica";
            this.text_ulica.Size = new System.Drawing.Size(151, 20);
            this.text_ulica.TabIndex = 41;
            // 
            // text_miasto
            // 
            this.text_miasto.Location = new System.Drawing.Point(343, 269);
            this.text_miasto.Name = "text_miasto";
            this.text_miasto.Size = new System.Drawing.Size(151, 20);
            this.text_miasto.TabIndex = 40;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(343, 199);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(151, 20);
            this.text_email.TabIndex = 39;
            // 
            // text_numer
            // 
            this.text_numer.Location = new System.Drawing.Point(343, 169);
            this.text_numer.Name = "text_numer";
            this.text_numer.Size = new System.Drawing.Size(151, 20);
            this.text_numer.TabIndex = 38;
            // 
            // text_nazwisko
            // 
            this.text_nazwisko.Location = new System.Drawing.Point(343, 104);
            this.text_nazwisko.Name = "text_nazwisko";
            this.text_nazwisko.Size = new System.Drawing.Size(151, 20);
            this.text_nazwisko.TabIndex = 37;
            // 
            // text_imie
            // 
            this.text_imie.Location = new System.Drawing.Point(343, 70);
            this.text_imie.Name = "text_imie";
            this.text_imie.Size = new System.Drawing.Size(151, 20);
            this.text_imie.TabIndex = 36;
            // 
            // label_plec
            // 
            this.label_plec.AutoSize = true;
            this.label_plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_plec.Location = new System.Drawing.Point(546, 71);
            this.label_plec.Name = "label_plec";
            this.label_plec.Size = new System.Drawing.Size(40, 20);
            this.label_plec.TabIndex = 35;
            this.label_plec.Text = "Płeć";
            // 
            // box_plec
            // 
            this.box_plec.FormattingEnabled = true;
            this.box_plec.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.box_plec.Location = new System.Drawing.Point(608, 69);
            this.box_plec.Name = "box_plec";
            this.box_plec.Size = new System.Drawing.Size(121, 21);
            this.box_plec.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(197, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Adres Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(197, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kod pocztowy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(201, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "DANE ADRESOWE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(200, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "DANE PODSTAWOWE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(197, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(197, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Miasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(197, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Numer kontaktowy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(197, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(197, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(197, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Imię";
            // 
            // button_zapiszzmiany
            // 
            this.button_zapiszzmiany.Location = new System.Drawing.Point(587, 346);
            this.button_zapiszzmiany.Name = "button_zapiszzmiany";
            this.button_zapiszzmiany.Size = new System.Drawing.Size(142, 55);
            this.button_zapiszzmiany.TabIndex = 46;
            this.button_zapiszzmiany.Text = "Zapisz zmiany";
            this.button_zapiszzmiany.UseVisualStyleBackColor = true;
            this.button_zapiszzmiany.Click += new System.EventHandler(this.button_zapiszzmiany_Click);
            // 
            // button_loaddata
            // 
            this.button_loaddata.Location = new System.Drawing.Point(23, 199);
            this.button_loaddata.Name = "button_loaddata";
            this.button_loaddata.Size = new System.Drawing.Size(114, 58);
            this.button_loaddata.TabIndex = 47;
            this.button_loaddata.Text = "Załaduj Dane Pacjenta (PESEL)";
            this.button_loaddata.UseVisualStyleBackColor = true;
            this.button_loaddata.Click += new System.EventHandler(this.button_loaddata_Click);
            // 
            // text_loadpacjent
            // 
            this.text_loadpacjent.Location = new System.Drawing.Point(23, 137);
            this.text_loadpacjent.Name = "text_loadpacjent";
            this.text_loadpacjent.Size = new System.Drawing.Size(114, 20);
            this.text_loadpacjent.TabIndex = 48;
            this.text_loadpacjent.TextChanged += new System.EventHandler(this.text_loadpacjent_TextChanged);
            // 
            // Form_edycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_loadpacjent);
            this.Controls.Add(this.button_loaddata);
            this.Controls.Add(this.button_zapiszzmiany);
            this.Controls.Add(this.text_pesel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.text_kodpoczt);
            this.Controls.Add(this.text_ulica);
            this.Controls.Add(this.text_miasto);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_numer);
            this.Controls.Add(this.text_nazwisko);
            this.Controls.Add(this.text_imie);
            this.Controls.Add(this.label_plec);
            this.Controls.Add(this.box_plec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_menu);
            this.Name = "Form_edycja";
            this.Text = "Form_edycja";
            this.Load += new System.EventHandler(this.Form_edycja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.TextBox text_pesel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker text_data;
        private System.Windows.Forms.TextBox text_kodpoczt;
        private System.Windows.Forms.TextBox text_ulica;
        private System.Windows.Forms.TextBox text_miasto;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_numer;
        private System.Windows.Forms.TextBox text_nazwisko;
        private System.Windows.Forms.TextBox text_imie;
        private System.Windows.Forms.Label label_plec;
        private System.Windows.Forms.ComboBox box_plec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_zapiszzmiany;
        private System.Windows.Forms.Button button_loaddata;
        private System.Windows.Forms.TextBox text_loadpacjent;
    }
}