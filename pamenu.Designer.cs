namespace WindowsFormsApp2
{
    partial class pamenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pamenu));
            this.label1 = new System.Windows.Forms.Label();
            this.button_users = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(316, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Admina";
            // 
            // button_users
            // 
            this.button_users.Location = new System.Drawing.Point(133, 103);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(184, 58);
            this.button_users.TabIndex = 1;
            this.button_users.Text = "Użytkownicy";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(477, 103);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(170, 58);
            this.button_menu.TabIndex = 2;
            this.button_menu.Text = "Menu USERA";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // pamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.label1);
            this.Name = "pamenu";
            this.Text = "pamenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_menu;
    }
}