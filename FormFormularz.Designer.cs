namespace WindowsFormsApp2
{
    partial class FormFormularz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormularz));
            this.buttun_backtomenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.box_plec = new System.Windows.Forms.ComboBox();
            this.label_plec = new System.Windows.Forms.Label();
            this.text_imie = new System.Windows.Forms.TextBox();
            this.text_nazwisko = new System.Windows.Forms.TextBox();
            this.text_numer = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_miasto = new System.Windows.Forms.TextBox();
            this.text_ulica = new System.Windows.Forms.TextBox();
            this.text_kodpoczt = new System.Windows.Forms.TextBox();
            this.button_rejestr = new System.Windows.Forms.Button();
            this.text_data = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.text_pesel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttun_backtomenu
            // 
            this.buttun_backtomenu.Location = new System.Drawing.Point(12, 12);
            this.buttun_backtomenu.Name = "buttun_backtomenu";
            this.buttun_backtomenu.Size = new System.Drawing.Size(118, 51);
            this.buttun_backtomenu.TabIndex = 0;
            this.buttun_backtomenu.Text = "Powrót do Menu";
            this.buttun_backtomenu.UseVisualStyleBackColor = true;
            this.buttun_backtomenu.Click += new System.EventHandler(this.buttun_backtomenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(96, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(96, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(96, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numer kontaktowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(96, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Miasto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(96, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ulica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(99, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "DANE PODSTAWOWE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(100, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "DANE ADRESOWE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(96, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(96, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Adres Email";
            // 
            // box_plec
            // 
            this.box_plec.FormattingEnabled = true;
            this.box_plec.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.box_plec.Location = new System.Drawing.Point(507, 97);
            this.box_plec.Name = "box_plec";
            this.box_plec.Size = new System.Drawing.Size(121, 21);
            this.box_plec.TabIndex = 11;
            this.box_plec.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_plec
            // 
            this.label_plec.AutoSize = true;
            this.label_plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_plec.Location = new System.Drawing.Point(445, 99);
            this.label_plec.Name = "label_plec";
            this.label_plec.Size = new System.Drawing.Size(40, 20);
            this.label_plec.TabIndex = 12;
            this.label_plec.Text = "Płeć";
            this.label_plec.Click += new System.EventHandler(this.label11_Click);
            // 
            // text_imie
            // 
            this.text_imie.Location = new System.Drawing.Point(242, 98);
            this.text_imie.Name = "text_imie";
            this.text_imie.Size = new System.Drawing.Size(151, 20);
            this.text_imie.TabIndex = 13;
            // 
            // text_nazwisko
            // 
            this.text_nazwisko.Location = new System.Drawing.Point(242, 132);
            this.text_nazwisko.Name = "text_nazwisko";
            this.text_nazwisko.Size = new System.Drawing.Size(151, 20);
            this.text_nazwisko.TabIndex = 14;
            // 
            // text_numer
            // 
            this.text_numer.Location = new System.Drawing.Point(242, 197);
            this.text_numer.Name = "text_numer";
            this.text_numer.Size = new System.Drawing.Size(151, 20);
            this.text_numer.TabIndex = 15;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(242, 227);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(151, 20);
            this.text_email.TabIndex = 16;
            // 
            // text_miasto
            // 
            this.text_miasto.Location = new System.Drawing.Point(242, 297);
            this.text_miasto.Name = "text_miasto";
            this.text_miasto.Size = new System.Drawing.Size(151, 20);
            this.text_miasto.TabIndex = 17;
            // 
            // text_ulica
            // 
            this.text_ulica.Location = new System.Drawing.Point(242, 337);
            this.text_ulica.Name = "text_ulica";
            this.text_ulica.Size = new System.Drawing.Size(151, 20);
            this.text_ulica.TabIndex = 18;
            // 
            // text_kodpoczt
            // 
            this.text_kodpoczt.Location = new System.Drawing.Point(242, 374);
            this.text_kodpoczt.Name = "text_kodpoczt";
            this.text_kodpoczt.Size = new System.Drawing.Size(151, 20);
            this.text_kodpoczt.TabIndex = 19;
            // 
            // button_rejestr
            // 
            this.button_rejestr.Location = new System.Drawing.Point(576, 352);
            this.button_rejestr.Name = "button_rejestr";
            this.button_rejestr.Size = new System.Drawing.Size(142, 77);
            this.button_rejestr.TabIndex = 20;
            this.button_rejestr.Text = "Zarejestruj";
            this.button_rejestr.UseVisualStyleBackColor = true;
            this.button_rejestr.Click += new System.EventHandler(this.button_rejestr_Click);
            // 
            // text_data
            // 
            this.text_data.Location = new System.Drawing.Point(443, 185);
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(200, 20);
            this.text_data.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(445, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Data narodzin";
            // 
            // text_pesel
            // 
            this.text_pesel.Location = new System.Drawing.Point(242, 166);
            this.text_pesel.Name = "text_pesel";
            this.text_pesel.Size = new System.Drawing.Size(151, 20);
            this.text_pesel.TabIndex = 23;
            // 
            // FormFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.text_pesel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.button_rejestr);
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
            this.Controls.Add(this.buttun_backtomenu);
            this.Name = "FormFormularz";
            this.Text = "Formularz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttun_backtomenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox box_plec;
        private System.Windows.Forms.Label label_plec;
        private System.Windows.Forms.TextBox text_imie;
        private System.Windows.Forms.TextBox text_nazwisko;
        private System.Windows.Forms.TextBox text_numer;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_miasto;
        private System.Windows.Forms.TextBox text_ulica;
        private System.Windows.Forms.TextBox text_kodpoczt;
        private System.Windows.Forms.Button button_rejestr;
        private System.Windows.Forms.DateTimePicker text_data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_pesel;
    }
}