namespace WindowsFormsApp2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button_formularz = new System.Windows.Forms.Button();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_listpacjent = new System.Windows.Forms.Button();
            this.button_zapis = new System.Windows.Forms.Button();
            this.button_lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_formularz
            // 
            this.button_formularz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_formularz.Location = new System.Drawing.Point(53, 102);
            this.button_formularz.Name = "button_formularz";
            this.button_formularz.Size = new System.Drawing.Size(254, 23);
            this.button_formularz.TabIndex = 0;
            this.button_formularz.Text = "Formularz Zgłoszeniowy";
            this.button_formularz.UseVisualStyleBackColor = false;
            this.button_formularz.Click += new System.EventHandler(this.button_formularz_Click);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.BackColor = System.Drawing.Color.Transparent;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_menu.Location = new System.Drawing.Point(165, 26);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(491, 39);
            this.label_menu.TabIndex = 1;
            this.label_menu.Text = "Menu Programu Przychodnia";
            this.label_menu.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_listpacjent
            // 
            this.button_listpacjent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_listpacjent.Location = new System.Drawing.Point(455, 102);
            this.button_listpacjent.Name = "button_listpacjent";
            this.button_listpacjent.Size = new System.Drawing.Size(254, 23);
            this.button_listpacjent.TabIndex = 2;
            this.button_listpacjent.Text = "Lista Pacjentów EDYCJA";
            this.button_listpacjent.UseVisualStyleBackColor = false;
            this.button_listpacjent.Click += new System.EventHandler(this.button_listpacjent_Click);
            // 
            // button_zapis
            // 
            this.button_zapis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_zapis.Location = new System.Drawing.Point(53, 171);
            this.button_zapis.Name = "button_zapis";
            this.button_zapis.Size = new System.Drawing.Size(254, 23);
            this.button_zapis.TabIndex = 3;
            this.button_zapis.Text = "Zapis do Lekarza";
            this.button_zapis.UseVisualStyleBackColor = false;
            this.button_zapis.Click += new System.EventHandler(this.button_zapis_Click);
            // 
            // button_lista
            // 
            this.button_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_lista.Location = new System.Drawing.Point(455, 171);
            this.button_lista.Name = "button_lista";
            this.button_lista.Size = new System.Drawing.Size(254, 23);
            this.button_lista.TabIndex = 4;
            this.button_lista.Text = "Lista Zapisów do Lekarza";
            this.button_lista.UseVisualStyleBackColor = false;
            this.button_lista.Click += new System.EventHandler(this.button_lista_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_lista);
            this.Controls.Add(this.button_zapis);
            this.Controls.Add(this.button_listpacjent);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.button_formularz);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_formularz;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_listpacjent;
        private System.Windows.Forms.Button button_zapis;
        private System.Windows.Forms.Button button_lista;
    }
}