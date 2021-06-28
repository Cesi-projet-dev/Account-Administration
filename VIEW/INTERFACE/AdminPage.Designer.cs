
namespace Ces_it.VIEW.INTERFACE
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.Reduce_PictureBox = new System.Windows.Forms.PictureBox();
            this.Refresh_PictureBox = new System.Windows.Forms.PictureBox();
            this.Closed_PictureBox = new System.Windows.Forms.PictureBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Title2_label = new System.Windows.Forms.Label();
            this.User_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Reduce_PictureBox
            // 
            this.Reduce_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reduce_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Reduce_PictureBox.Image")));
            this.Reduce_PictureBox.Location = new System.Drawing.Point(871, 12);
            this.Reduce_PictureBox.Name = "Reduce_PictureBox";
            this.Reduce_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Reduce_PictureBox.TabIndex = 5;
            this.Reduce_PictureBox.TabStop = false;
            this.Reduce_PictureBox.Click += new System.EventHandler(this.Reduce_PictureBox_Click);
            // 
            // Refresh_PictureBox
            // 
            this.Refresh_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_PictureBox.Image")));
            this.Refresh_PictureBox.Location = new System.Drawing.Point(905, 12);
            this.Refresh_PictureBox.Name = "Refresh_PictureBox";
            this.Refresh_PictureBox.Size = new System.Drawing.Size(28, 26);
            this.Refresh_PictureBox.TabIndex = 4;
            this.Refresh_PictureBox.TabStop = false;
            this.Refresh_PictureBox.Click += new System.EventHandler(this.Refresh_PictureBox_Click);
            // 
            // Closed_PictureBox
            // 
            this.Closed_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Closed_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Closed_PictureBox.Image")));
            this.Closed_PictureBox.Location = new System.Drawing.Point(939, 12);
            this.Closed_PictureBox.Name = "Closed_PictureBox";
            this.Closed_PictureBox.Size = new System.Drawing.Size(25, 24);
            this.Closed_PictureBox.TabIndex = 3;
            this.Closed_PictureBox.TabStop = false;
            this.Closed_PictureBox.Click += new System.EventHandler(this.Closed_PictureBox_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title_label.Location = new System.Drawing.Point(420, 13);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(114, 25);
            this.Title_label.TabIndex = 6;
            this.Title_label.Text = "CES\'EAT";
            // 
            // Title2_label
            // 
            this.Title2_label.AutoSize = true;
            this.Title2_label.BackColor = System.Drawing.Color.Transparent;
            this.Title2_label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title2_label.Location = new System.Drawing.Point(295, 50);
            this.Title2_label.Name = "Title2_label";
            this.Title2_label.Size = new System.Drawing.Size(372, 20);
            this.Title2_label.TabIndex = 7;
            this.Title2_label.Text = "Page d\'administration et de gestion des comptes";
            // 
            // User_DataGridView
            // 
            this.User_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.User_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.User_DataGridView.Location = new System.Drawing.Point(79, 114);
            this.User_DataGridView.Name = "User_DataGridView";
            this.User_DataGridView.ReadOnly = true;
            this.User_DataGridView.RowHeadersVisible = false;
            this.User_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.User_DataGridView.RowTemplate.Height = 25;
            this.User_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.User_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_DataGridView.Size = new System.Drawing.Size(802, 379);
            this.User_DataGridView.TabIndex = 8;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 567);
            this.Controls.Add(this.User_DataGridView);
            this.Controls.Add(this.Title2_label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Reduce_PictureBox);
            this.Controls.Add(this.Refresh_PictureBox);
            this.Controls.Add(this.Closed_PictureBox);
            this.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Reduce_PictureBox;
        private System.Windows.Forms.PictureBox Refresh_PictureBox;
        private System.Windows.Forms.PictureBox Closed_PictureBox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Title2_label;
        private System.Windows.Forms.DataGridView User_DataGridView;
    }
}