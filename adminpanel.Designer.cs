namespace WindowsFormsApp2
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.button_pa_login = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.text_admin_username = new System.Windows.Forms.TextBox();
            this.text_admin_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_pa_login
            // 
            this.button_pa_login.Location = new System.Drawing.Point(306, 187);
            this.button_pa_login.Name = "button_pa_login";
            this.button_pa_login.Size = new System.Drawing.Size(167, 40);
            this.button_pa_login.TabIndex = 0;
            this.button_pa_login.Text = "Login to Admin Panel";
            this.button_pa_login.UseVisualStyleBackColor = true;
            this.button_pa_login.Click += new System.EventHandler(this.button_pa_login_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(306, 253);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(167, 37);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back to User Mode";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // text_admin_username
            // 
            this.text_admin_username.Location = new System.Drawing.Point(264, 82);
            this.text_admin_username.Name = "text_admin_username";
            this.text_admin_username.Size = new System.Drawing.Size(259, 20);
            this.text_admin_username.TabIndex = 2;
            // 
            // text_admin_password
            // 
            this.text_admin_password.Location = new System.Drawing.Point(264, 134);
            this.text_admin_password.Name = "text_admin_password";
            this.text_admin_password.Size = new System.Drawing.Size(259, 20);
            this.text_admin_password.TabIndex = 3;
            this.text_admin_password.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.Location = new System.Drawing.Point(90, 80);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(146, 20);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Admin Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(90, 132);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(141, 20);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Admin Password";
            // 
            // adminpanel
            // 
            this.AcceptButton = this.button_pa_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.text_admin_password);
            this.Controls.Add(this.text_admin_username);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_pa_login);
            this.Name = "adminpanel";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_pa_login;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox text_admin_username;
        private System.Windows.Forms.TextBox text_admin_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
    }
}