
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.Reduce_PictureBox = new System.Windows.Forms.PictureBox();
            this.Refresh_PictureBox = new System.Windows.Forms.PictureBox();
            this.Closed_PictureBox = new System.Windows.Forms.PictureBox();
            this.Title_label = new System.Windows.Forms.Label();
            this.Title2_label = new System.Windows.Forms.Label();
            this.User_DataGridView = new System.Windows.Forms.DataGridView();
            this.Admin_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Role_ContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminRoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommercialRoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestaurateurRoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LivreurRoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientRoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_ContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeInterface_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reduce_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closed_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGridView)).BeginInit();
            this.Admin_ContextMenuStrip.SuspendLayout();
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
            this.User_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.User_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_DataGridView.ContextMenuStrip = this.Admin_ContextMenuStrip;
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
            this.User_DataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_DataGridView_CellContentDoubleClick);
            // 
            // Admin_ContextMenuStrip
            // 
            this.Admin_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Role_ContextMenuItem,
            this.Delete_ContextMenuItem});
            this.Admin_ContextMenuStrip.Name = "Admin_ContextMenuStrip";
            this.Admin_ContextMenuStrip.Size = new System.Drawing.Size(130, 48);
            // 
            // Role_ContextMenuItem
            // 
            this.Role_ContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminRoleMenuItem,
            this.CommercialRoleMenuItem,
            this.RestaurateurRoleMenuItem,
            this.LivreurRoleMenuItem,
            this.ClientRoleMenuItem});
            this.Role_ContextMenuItem.Name = "Role_ContextMenuItem";
            this.Role_ContextMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Role_ContextMenuItem.Text = "Rôle";
            this.Role_ContextMenuItem.Click += new System.EventHandler(this.Role_ContextMenuItem_Click);
            // 
            // AdminRoleMenuItem
            // 
            this.AdminRoleMenuItem.Name = "AdminRoleMenuItem";
            this.AdminRoleMenuItem.Size = new System.Drawing.Size(140, 22);
            this.AdminRoleMenuItem.Text = "Admin";
            // 
            // CommercialRoleMenuItem
            // 
            this.CommercialRoleMenuItem.Name = "CommercialRoleMenuItem";
            this.CommercialRoleMenuItem.Size = new System.Drawing.Size(140, 22);
            this.CommercialRoleMenuItem.Text = "Commercial";
            // 
            // RestaurateurRoleMenuItem
            // 
            this.RestaurateurRoleMenuItem.Name = "RestaurateurRoleMenuItem";
            this.RestaurateurRoleMenuItem.Size = new System.Drawing.Size(140, 22);
            this.RestaurateurRoleMenuItem.Text = "Restaurateur";
            // 
            // LivreurRoleMenuItem
            // 
            this.LivreurRoleMenuItem.Name = "LivreurRoleMenuItem";
            this.LivreurRoleMenuItem.Size = new System.Drawing.Size(140, 22);
            this.LivreurRoleMenuItem.Text = "Livreur";
            // 
            // ClientRoleMenuItem
            // 
            this.ClientRoleMenuItem.Name = "ClientRoleMenuItem";
            this.ClientRoleMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ClientRoleMenuItem.Text = "Client";
            // 
            // Delete_ContextMenuItem
            // 
            this.Delete_ContextMenuItem.Name = "Delete_ContextMenuItem";
            this.Delete_ContextMenuItem.Size = new System.Drawing.Size(129, 22);
            this.Delete_ContextMenuItem.Text = "Supprimer";
            this.Delete_ContextMenuItem.Click += new System.EventHandler(this.Delete_ContextMenuItem_Click);
            // 
            // TypeInterface_Label
            // 
            this.TypeInterface_Label.AutoSize = true;
            this.TypeInterface_Label.BackColor = System.Drawing.Color.Transparent;
            this.TypeInterface_Label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeInterface_Label.Location = new System.Drawing.Point(12, 9);
            this.TypeInterface_Label.Name = "TypeInterface_Label";
            this.TypeInterface_Label.Size = new System.Drawing.Size(79, 20);
            this.TypeInterface_Label.TabIndex = 9;
            this.TypeInterface_Label.Text = "Interface ";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 567);
            this.Controls.Add(this.TypeInterface_Label);
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
            this.Admin_ContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip Admin_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Role_ContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Del;
        private System.Windows.Forms.Label TypeInterface_Label;
        private System.Windows.Forms.ToolStripMenuItem Delete_ContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminRoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CommercialRoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestaurateurRoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LivreurRoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientRoleMenuItem;
    }
}