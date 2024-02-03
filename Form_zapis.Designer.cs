namespace WindowsFormsApp2
{
    partial class Form_zapis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_zapis));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_rejestracja = new System.Windows.Forms.Button();
            this.text_data_wizyty = new System.Windows.Forms.DateTimePicker();
            this.box_lekarz = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_pesel = new System.Windows.Forms.TextBox();
            this.text_imie = new System.Windows.Forms.TextBox();
            this.text_nazwisko = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_loadpacjent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IMIĘ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAZWISKO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LEKARZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DZIEŃ WIZYTY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // button_rejestracja
            // 
            this.button_rejestracja.Location = new System.Drawing.Point(409, 203);
            this.button_rejestracja.Name = "button_rejestracja";
            this.button_rejestracja.Size = new System.Drawing.Size(328, 46);
            this.button_rejestracja.TabIndex = 6;
            this.button_rejestracja.Text = "ZAREJESTRUJ WIZYTE";
            this.button_rejestracja.UseVisualStyleBackColor = true;
            this.button_rejestracja.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_data_wizyty
            // 
            this.text_data_wizyty.Location = new System.Drawing.Point(537, 104);
            this.text_data_wizyty.Name = "text_data_wizyty";
            this.text_data_wizyty.Size = new System.Drawing.Size(200, 20);
            this.text_data_wizyty.TabIndex = 7;
            // 
            // box_lekarz
            // 
            this.box_lekarz.FormattingEnabled = true;
            this.box_lekarz.Items.AddRange(new object[] {
            "Dr. Michał Wiśniewski",
            "Dr. Dominik Lak",
            "Dr. Magdalena Opos",
            "Dr. Halina Piorun"});
            this.box_lekarz.Location = new System.Drawing.Point(537, 47);
            this.box_lekarz.Name = "box_lekarz";
            this.box_lekarz.Size = new System.Drawing.Size(200, 21);
            this.box_lekarz.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Powrót do Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_pesel
            // 
            this.text_pesel.Location = new System.Drawing.Point(149, 56);
            this.text_pesel.Name = "text_pesel";
            this.text_pesel.Size = new System.Drawing.Size(170, 20);
            this.text_pesel.TabIndex = 10;
            // 
            // text_imie
            // 
            this.text_imie.Location = new System.Drawing.Point(149, 101);
            this.text_imie.Name = "text_imie";
            this.text_imie.Size = new System.Drawing.Size(170, 20);
            this.text_imie.TabIndex = 11;
            // 
            // text_nazwisko
            // 
            this.text_nazwisko.Location = new System.Drawing.Point(149, 144);
            this.text_nazwisko.Name = "text_nazwisko";
            this.text_nazwisko.Size = new System.Drawing.Size(170, 20);
            this.text_nazwisko.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(51, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dane Pacjenta";
            // 
            // button_loadpacjent
            // 
            this.button_loadpacjent.Location = new System.Drawing.Point(55, 203);
            this.button_loadpacjent.Name = "button_loadpacjent";
            this.button_loadpacjent.Size = new System.Drawing.Size(264, 46);
            this.button_loadpacjent.TabIndex = 14;
            this.button_loadpacjent.Text = "Załaduj pacjenta z bazy";
            this.button_loadpacjent.UseVisualStyleBackColor = true;
            this.button_loadpacjent.Click += new System.EventHandler(this.button_loadpacjent_Click);
            // 
            // Form_zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_loadpacjent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_nazwisko);
            this.Controls.Add(this.text_imie);
            this.Controls.Add(this.text_pesel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.box_lekarz);
            this.Controls.Add(this.text_data_wizyty);
            this.Controls.Add(this.button_rejestracja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_zapis";
            this.Text = "Form_zapis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_rejestracja;
        private System.Windows.Forms.DateTimePicker text_data_wizyty;
        private System.Windows.Forms.ComboBox box_lekarz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_pesel;
        private System.Windows.Forms.TextBox text_imie;
        private System.Windows.Forms.TextBox text_nazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_loadpacjent;
    }
}