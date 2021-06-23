
namespace Ces_it.VIEW.HOME
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.Closed_PictureBox = new System.Windows.Forms.PictureBox();
            this.Refresh_PictureBox = new System.Windows.Forms.PictureBox();
            this.Reduce_PictureBox = new System.Windows.Forms.PictureBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.HidePw_CheckBox = new System.Windows.Forms.CheckBox();
            this.Connection_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Closed_PictureBox
            // 
            this.Closed_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Closed_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Closed_PictureBox.Image")));
            this.Closed_PictureBox.Location = new System.Drawing.Point(502, 12);
            this.Closed_PictureBox.Name = "Closed_PictureBox";
            this.Closed_PictureBox.Size = new System.Drawing.Size(25, 24);
            this.Closed_PictureBox.TabIndex = 0;
            this.Closed_PictureBox.TabStop = false;
            this.Closed_PictureBox.Click += new System.EventHandler(this.Closed_PictureBox_Click);
            // 
            // Refresh_PictureBox
            // 
            this.Refresh_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_PictureBox.Image")));
            this.Refresh_PictureBox.Location = new System.Drawing.Point(468, 12);
            this.Refresh_PictureBox.Name = "Refresh_PictureBox";
            this.Refresh_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Refresh_PictureBox.TabIndex = 1;
            this.Refresh_PictureBox.TabStop = false;
            this.Refresh_PictureBox.Click += new System.EventHandler(this.Refresh_PictureBox_Click);
            // 
            // Reduce_PictureBox
            // 
            this.Reduce_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reduce_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Reduce_PictureBox.Image")));
            this.Reduce_PictureBox.Location = new System.Drawing.Point(434, 12);
            this.Reduce_PictureBox.Name = "Reduce_PictureBox";
            this.Reduce_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Reduce_PictureBox.TabIndex = 2;
            this.Reduce_PictureBox.TabStop = false;
            this.Reduce_PictureBox.Click += new System.EventHandler(this.Reduce_PictureBox_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_label.Location = new System.Drawing.Point(214, 45);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(114, 25);
            this.Title_label.TabIndex = 3;
            this.Title_label.Text = "CES\'EAT";
            // 
            // User_TextBox
            // 
            this.User_TextBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_TextBox.Location = new System.Drawing.Point(111, 138);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.Size = new System.Drawing.Size(277, 26);
            this.User_TextBox.TabIndex = 4;
            this.User_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_TextBox.Location = new System.Drawing.Point(111, 253);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(277, 26);
            this.Password_TextBox.TabIndex = 5;
            this.Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Name_Label.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(111, 101);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(83, 16);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Identifiant : ";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password_Label.Location = new System.Drawing.Point(111, 218);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(102, 16);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Mot de passe : ";
            // 
            // HidePw_CheckBox
            // 
            this.HidePw_CheckBox.AutoSize = true;
            this.HidePw_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.HidePw_CheckBox.Location = new System.Drawing.Point(395, 259);
            this.HidePw_CheckBox.Name = "HidePw_CheckBox";
            this.HidePw_CheckBox.Size = new System.Drawing.Size(15, 14);
            this.HidePw_CheckBox.TabIndex = 8;
            this.HidePw_CheckBox.UseVisualStyleBackColor = false;
            this.HidePw_CheckBox.CheckedChanged += new System.EventHandler(this.HidePw_CheckBox_CheckedChanged);
            // 
            // Connection_Button
            // 
            this.Connection_Button.BackColor = System.Drawing.Color.Transparent;
            this.Connection_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connection_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connection_Button.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Connection_Button.Location = new System.Drawing.Point(214, 320);
            this.Connection_Button.Name = "Connection_Button";
            this.Connection_Button.Size = new System.Drawing.Size(106, 25);
            this.Connection_Button.TabIndex = 9;
            this.Connection_Button.Text = "CONNEXION";
            this.Connection_Button.UseVisualStyleBackColor = false;
            this.Connection_Button.Click += new System.EventHandler(this.Connection_Button_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 393);
            this.Controls.Add(this.Connection_Button);
            this.Controls.Add(this.HidePw_CheckBox);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.User_TextBox);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Reduce_PictureBox);
            this.Controls.Add(this.Refresh_PictureBox);
            this.Controls.Add(this.Closed_PictureBox);
            this.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Closed_PictureBox;
        private System.Windows.Forms.PictureBox Refresh_PictureBox;
        private System.Windows.Forms.PictureBox Reduce_PictureBox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.TextBox User_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.CheckBox HidePw_CheckBox;
        private System.Windows.Forms.Button Connection_Button;
    }
}