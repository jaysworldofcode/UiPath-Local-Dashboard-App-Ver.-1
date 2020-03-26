namespace WindowsFormsApp1
{
    partial class Assets_Panel
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_delete = new System.Windows.Forms.Button();
            this.BT_AddAssets = new System.Windows.Forms.Button();
            this.Label_asset_password = new System.Windows.Forms.Label();
            this.TF_asset_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BT_update = new System.Windows.Forms.Button();
            this.Label_asset_text = new System.Windows.Forms.Label();
            this.TF_asset_text = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.TF_asset_description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.TF_asset_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.queue_list = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.list_panel = new System.Windows.Forms.Panel();
            this.BT_add_robot = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.queue_list.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.queue_list);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BT_delete);
            this.panel1.Controls.Add(this.BT_AddAssets);
            this.panel1.Controls.Add(this.Label_asset_password);
            this.panel1.Controls.Add(this.TF_asset_password);
            this.panel1.Controls.Add(this.BT_update);
            this.panel1.Controls.Add(this.Label_asset_text);
            this.panel1.Controls.Add(this.TF_asset_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TF_asset_description);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TF_asset_name);
            this.panel1.Location = new System.Drawing.Point(410, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 715);
            this.panel1.TabIndex = 15;
            // 
            // BT_delete
            // 
            this.BT_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_delete.BackColor = System.Drawing.Color.White;
            this.BT_delete.FlatAppearance.BorderSize = 0;
            this.BT_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_delete.ForeColor = System.Drawing.Color.Black;
            this.BT_delete.Location = new System.Drawing.Point(185, 509);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(75, 28);
            this.BT_delete.TabIndex = 10;
            this.BT_delete.Text = "DELETE";
            this.BT_delete.UseVisualStyleBackColor = false;
            // 
            // BT_AddAssets
            // 
            this.BT_AddAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_AddAssets.BackColor = System.Drawing.Color.Transparent;
            this.BT_AddAssets.FlatAppearance.BorderSize = 0;
            this.BT_AddAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddAssets.Location = new System.Drawing.Point(350, 584);
            this.BT_AddAssets.Name = "BT_AddAssets";
            this.BT_AddAssets.Size = new System.Drawing.Size(80, 80);
            this.BT_AddAssets.TabIndex = 4;
            this.BT_AddAssets.UseVisualStyleBackColor = false;
            // 
            // Label_asset_password
            // 
            this.Label_asset_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_asset_password.AutoSize = true;
            this.Label_asset_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label_asset_password.Location = new System.Drawing.Point(78, 416);
            this.Label_asset_password.Name = "Label_asset_password";
            this.Label_asset_password.Size = new System.Drawing.Size(81, 13);
            this.Label_asset_password.TabIndex = 9;
            this.Label_asset_password.Text = "Asset password";
            // 
            // TF_asset_password
            // 
            this.TF_asset_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_password.Depth = 0;
            this.TF_asset_password.Hint = "";
            this.TF_asset_password.Location = new System.Drawing.Point(80, 446);
            this.TF_asset_password.MaxLength = 32767;
            this.TF_asset_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_password.Name = "TF_asset_password";
            this.TF_asset_password.PasswordChar = '\0';
            this.TF_asset_password.SelectedText = "";
            this.TF_asset_password.SelectionLength = 0;
            this.TF_asset_password.SelectionStart = 0;
            this.TF_asset_password.Size = new System.Drawing.Size(332, 23);
            this.TF_asset_password.TabIndex = 8;
            this.TF_asset_password.TabStop = false;
            this.TF_asset_password.UseSystemPasswordChar = true;
            // 
            // BT_update
            // 
            this.BT_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_update.FlatAppearance.BorderSize = 0;
            this.BT_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_update.ForeColor = System.Drawing.Color.White;
            this.BT_update.Location = new System.Drawing.Point(92, 509);
            this.BT_update.Name = "BT_update";
            this.BT_update.Size = new System.Drawing.Size(75, 28);
            this.BT_update.TabIndex = 7;
            this.BT_update.Text = "UPDATE";
            this.BT_update.UseVisualStyleBackColor = false;
            // 
            // Label_asset_text
            // 
            this.Label_asset_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_asset_text.AutoSize = true;
            this.Label_asset_text.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label_asset_text.Location = new System.Drawing.Point(78, 339);
            this.Label_asset_text.Name = "Label_asset_text";
            this.Label_asset_text.Size = new System.Drawing.Size(53, 13);
            this.Label_asset_text.TabIndex = 5;
            this.Label_asset_text.Text = "Asset text";
            // 
            // TF_asset_text
            // 
            this.TF_asset_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_text.Depth = 0;
            this.TF_asset_text.Hint = "";
            this.TF_asset_text.Location = new System.Drawing.Point(80, 366);
            this.TF_asset_text.MaxLength = 32767;
            this.TF_asset_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_text.Name = "TF_asset_text";
            this.TF_asset_text.PasswordChar = '\0';
            this.TF_asset_text.SelectedText = "";
            this.TF_asset_text.SelectionLength = 0;
            this.TF_asset_text.SelectionStart = 0;
            this.TF_asset_text.Size = new System.Drawing.Size(332, 23);
            this.TF_asset_text.TabIndex = 4;
            this.TF_asset_text.TabStop = false;
            this.TF_asset_text.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(77, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asset description";
            // 
            // TF_asset_description
            // 
            this.TF_asset_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_description.Depth = 0;
            this.TF_asset_description.Hint = "";
            this.TF_asset_description.Location = new System.Drawing.Point(80, 285);
            this.TF_asset_description.MaxLength = 32767;
            this.TF_asset_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_description.Name = "TF_asset_description";
            this.TF_asset_description.PasswordChar = '\0';
            this.TF_asset_description.SelectedText = "";
            this.TF_asset_description.SelectionLength = 0;
            this.TF_asset_description.SelectionStart = 0;
            this.TF_asset_description.Size = new System.Drawing.Size(332, 23);
            this.TF_asset_description.TabIndex = 2;
            this.TF_asset_description.TabStop = false;
            this.TF_asset_description.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(78, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset name";
            // 
            // TF_asset_name
            // 
            this.TF_asset_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_name.Depth = 0;
            this.TF_asset_name.Hint = "";
            this.TF_asset_name.Location = new System.Drawing.Point(80, 206);
            this.TF_asset_name.MaxLength = 32767;
            this.TF_asset_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_name.Name = "TF_asset_name";
            this.TF_asset_name.PasswordChar = '\0';
            this.TF_asset_name.SelectedText = "";
            this.TF_asset_name.SelectionLength = 0;
            this.TF_asset_name.SelectionStart = 0;
            this.TF_asset_name.Size = new System.Drawing.Size(332, 23);
            this.TF_asset_name.TabIndex = 0;
            this.TF_asset_name.TabStop = false;
            this.TF_asset_name.UseSystemPasswordChar = false;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.ListPanel);
            this.queue_list.Controls.Add(this.label1);
            this.queue_list.Location = new System.Drawing.Point(0, 0);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(409, 716);
            this.queue_list.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "ASSETS";
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListPanel.Controls.Add(this.list_panel);
            this.ListPanel.Controls.Add(this.BT_add_robot);
            this.ListPanel.Location = new System.Drawing.Point(2, 101);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(407, 543);
            this.ListPanel.TabIndex = 31;
            // 
            // list_panel
            // 
            this.list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_panel.BackColor = System.Drawing.Color.Transparent;
            this.list_panel.Location = new System.Drawing.Point(0, 0);
            this.list_panel.Name = "list_panel";
            this.list_panel.Size = new System.Drawing.Size(407, 103);
            this.list_panel.TabIndex = 0;
            // 
            // BT_add_robot
            // 
            this.BT_add_robot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_add_robot.BackColor = System.Drawing.Color.Transparent;
            this.BT_add_robot.FlatAppearance.BorderSize = 0;
            this.BT_add_robot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_robot.ForeColor = System.Drawing.Color.Transparent;
            this.BT_add_robot.Location = new System.Drawing.Point(292, 427);
            this.BT_add_robot.Name = "BT_add_robot";
            this.BT_add_robot.Size = new System.Drawing.Size(80, 80);
            this.BT_add_robot.TabIndex = 0;
            this.BT_add_robot.Text = "+";
            this.BT_add_robot.UseVisualStyleBackColor = false;
            // 
            // Assets_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Assets_Panel";
            this.Text = "Assets_Panel";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.queue_list.ResumeLayout(false);
            this.queue_list.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_AddAssets;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_description;
        private System.Windows.Forms.Label Label_asset_text;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_text;
        private System.Windows.Forms.Label Label_asset_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_password;
        private System.Windows.Forms.Button BT_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_update;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.Button BT_add_robot;
    }
}