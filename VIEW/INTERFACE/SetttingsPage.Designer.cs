
namespace Ces_it.VIEW.INTERFACE
{
    partial class SetttingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetttingsPage));
            this.Title_label = new System.Windows.Forms.Label();
            this.Title2_label = new System.Windows.Forms.Label();
            this.Reduce_PictureBox = new System.Windows.Forms.PictureBox();
            this.Refresh_PictureBox = new System.Windows.Forms.PictureBox();
            this.Closed_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_label.Location = new System.Drawing.Point(320, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(114, 25);
            this.Title_label.TabIndex = 4;
            this.Title_label.Text = "CES\'EAT";
            // 
            // Title2_label
            // 
            this.Title2_label.AutoSize = true;
            this.Title2_label.BackColor = System.Drawing.Color.Transparent;
            this.Title2_label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title2_label.Location = new System.Drawing.Point(233, 34);
            this.Title2_label.Name = "Title2_label";
            this.Title2_label.Size = new System.Drawing.Size(291, 20);
            this.Title2_label.TabIndex = 8;
            this.Title2_label.Text = "Paramètres et configuration logicielle";
            // 
            // Reduce_PictureBox
            // 
            this.Reduce_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reduce_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Reduce_PictureBox.Image")));
            this.Reduce_PictureBox.Location = new System.Drawing.Point(695, 9);
            this.Reduce_PictureBox.Name = "Reduce_PictureBox";
            this.Reduce_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Reduce_PictureBox.TabIndex = 11;
            this.Reduce_PictureBox.TabStop = false;
            this.Reduce_PictureBox.Click += new System.EventHandler(this.Reduce_PictureBox_Click);
            // 
            // Refresh_PictureBox
            // 
            this.Refresh_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_PictureBox.Image")));
            this.Refresh_PictureBox.Location = new System.Drawing.Point(729, 9);
            this.Refresh_PictureBox.Name = "Refresh_PictureBox";
            this.Refresh_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Refresh_PictureBox.TabIndex = 10;
            this.Refresh_PictureBox.TabStop = false;
            this.Refresh_PictureBox.Click += new System.EventHandler(this.Refresh_PictureBox_Click);
            // 
            // Closed_PictureBox
            // 
            this.Closed_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Closed_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Closed_PictureBox.Image")));
            this.Closed_PictureBox.Location = new System.Drawing.Point(763, 9);
            this.Closed_PictureBox.Name = "Closed_PictureBox";
            this.Closed_PictureBox.Size = new System.Drawing.Size(25, 24);
            this.Closed_PictureBox.TabIndex = 9;
            this.Closed_PictureBox.TabStop = false;
            this.Closed_PictureBox.Click += new System.EventHandler(this.Closed_PictureBox_Click);
            // 
            // SetttingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reduce_PictureBox);
            this.Controls.Add(this.Refresh_PictureBox);
            this.Controls.Add(this.Closed_PictureBox);
            this.Controls.Add(this.Title2_label);
            this.Controls.Add(this.Title_label);
            this.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetttingsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetttingsPage";
            this.Load += new System.EventHandler(this.SetttingsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Title2_label;
        private System.Windows.Forms.PictureBox Reduce_PictureBox;
        private System.Windows.Forms.PictureBox Refresh_PictureBox;
        private System.Windows.Forms.PictureBox Closed_PictureBox;
    }
}