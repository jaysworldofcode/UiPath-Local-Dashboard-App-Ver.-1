namespace WindowsFormsApp1
{
    partial class New_Assets_Panel
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
            this.queue_list = new System.Windows.Forms.Panel();
            this.CB_type = new System.Windows.Forms.ComboBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.Label_asset_password = new System.Windows.Forms.Label();
            this.TF_asset_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BT_Add = new System.Windows.Forms.Button();
            this.Label_asset_text = new System.Windows.Forms.Label();
            this.TF_asset_text = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.TF_asset_description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.TF_asset_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MainPanel.SuspendLayout();
            this.queue_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.queue_list);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 2;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.CB_type);
            this.queue_list.Controls.Add(this.BT_Cancel);
            this.queue_list.Controls.Add(this.Label_asset_password);
            this.queue_list.Controls.Add(this.TF_asset_password);
            this.queue_list.Controls.Add(this.BT_Add);
            this.queue_list.Controls.Add(this.Label_asset_text);
            this.queue_list.Controls.Add(this.TF_asset_text);
            this.queue_list.Controls.Add(this.label3);
            this.queue_list.Controls.Add(this.TF_asset_description);
            this.queue_list.Controls.Add(this.label2);
            this.queue_list.Controls.Add(this.TF_asset_name);
            this.queue_list.Location = new System.Drawing.Point(3, 73);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(888, 621);
            this.queue_list.TabIndex = 2;
            // 
            // CB_type
            // 
            this.CB_type.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_type.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CB_type.FormattingEnabled = true;
            this.CB_type.Items.AddRange(new object[] {
            "Text",
            "Credential"});
            this.CB_type.Location = new System.Drawing.Point(609, 160);
            this.CB_type.Name = "CB_type";
            this.CB_type.Size = new System.Drawing.Size(108, 21);
            this.CB_type.TabIndex = 22;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BT_Cancel.FlatAppearance.BorderSize = 0;
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BT_Cancel.Location = new System.Drawing.Point(174, 391);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 28);
            this.BT_Cancel.TabIndex = 21;
            this.BT_Cancel.Text = "CANCEL";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            // 
            // Label_asset_password
            // 
            this.Label_asset_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_asset_password.AutoSize = true;
            this.Label_asset_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label_asset_password.Location = new System.Drawing.Point(425, 301);
            this.Label_asset_password.Name = "Label_asset_password";
            this.Label_asset_password.Size = new System.Drawing.Size(81, 13);
            this.Label_asset_password.TabIndex = 19;
            this.Label_asset_password.Text = "Asset password";
            this.Label_asset_password.Visible = false;
            // 
            // TF_asset_password
            // 
            this.TF_asset_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TF_asset_password.Depth = 0;
            this.TF_asset_password.Hint = "";
            this.TF_asset_password.Location = new System.Drawing.Point(428, 329);
            this.TF_asset_password.MaxLength = 32767;
            this.TF_asset_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_password.Name = "TF_asset_password";
            this.TF_asset_password.PasswordChar = '\0';
            this.TF_asset_password.SelectedText = "";
            this.TF_asset_password.SelectionLength = 0;
            this.TF_asset_password.SelectionStart = 0;
            this.TF_asset_password.Size = new System.Drawing.Size(247, 23);
            this.TF_asset_password.TabIndex = 18;
            this.TF_asset_password.TabStop = false;
            this.TF_asset_password.UseSystemPasswordChar = true;
            this.TF_asset_password.Visible = false;
            // 
            // BT_Add
            // 
            this.BT_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_Add.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_Add.FlatAppearance.BorderSize = 0;
            this.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.ForeColor = System.Drawing.Color.White;
            this.BT_Add.Location = new System.Drawing.Point(261, 391);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(75, 28);
            this.BT_Add.TabIndex = 17;
            this.BT_Add.Text = "CREATE";
            this.BT_Add.UseVisualStyleBackColor = false;
            // 
            // Label_asset_text
            // 
            this.Label_asset_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_asset_text.AutoSize = true;
            this.Label_asset_text.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label_asset_text.Location = new System.Drawing.Point(177, 301);
            this.Label_asset_text.Name = "Label_asset_text";
            this.Label_asset_text.Size = new System.Drawing.Size(53, 13);
            this.Label_asset_text.TabIndex = 15;
            this.Label_asset_text.Text = "Asset text";
            // 
            // TF_asset_text
            // 
            this.TF_asset_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TF_asset_text.Depth = 0;
            this.TF_asset_text.Hint = "";
            this.TF_asset_text.Location = new System.Drawing.Point(174, 329);
            this.TF_asset_text.MaxLength = 32767;
            this.TF_asset_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_text.Name = "TF_asset_text";
            this.TF_asset_text.PasswordChar = '\0';
            this.TF_asset_text.SelectedText = "";
            this.TF_asset_text.SelectionLength = 0;
            this.TF_asset_text.SelectionStart = 0;
            this.TF_asset_text.Size = new System.Drawing.Size(238, 23);
            this.TF_asset_text.TabIndex = 14;
            this.TF_asset_text.TabStop = false;
            this.TF_asset_text.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(177, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Asset description";
            // 
            // TF_asset_description
            // 
            this.TF_asset_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_description.Depth = 0;
            this.TF_asset_description.Hint = "";
            this.TF_asset_description.Location = new System.Drawing.Point(174, 245);
            this.TF_asset_description.MaxLength = 32767;
            this.TF_asset_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_description.Name = "TF_asset_description";
            this.TF_asset_description.PasswordChar = '\0';
            this.TF_asset_description.SelectedText = "";
            this.TF_asset_description.SelectionLength = 0;
            this.TF_asset_description.SelectionStart = 0;
            this.TF_asset_description.Size = new System.Drawing.Size(543, 23);
            this.TF_asset_description.TabIndex = 12;
            this.TF_asset_description.TabStop = false;
            this.TF_asset_description.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(177, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asset name";
            // 
            // TF_asset_name
            // 
            this.TF_asset_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_asset_name.Depth = 0;
            this.TF_asset_name.Hint = "";
            this.TF_asset_name.Location = new System.Drawing.Point(174, 159);
            this.TF_asset_name.MaxLength = 32767;
            this.TF_asset_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_asset_name.Name = "TF_asset_name";
            this.TF_asset_name.PasswordChar = '\0';
            this.TF_asset_name.SelectedText = "";
            this.TF_asset_name.SelectionLength = 0;
            this.TF_asset_name.SelectionStart = 0;
            this.TF_asset_name.Size = new System.Drawing.Size(415, 23);
            this.TF_asset_name.TabIndex = 10;
            this.TF_asset_name.TabStop = false;
            this.TF_asset_name.UseSystemPasswordChar = false;
            // 
            // New_Assets_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "New_Assets_Panel";
            this.Text = "New_Assets_Panel";
            this.MainPanel.ResumeLayout(false);
            this.queue_list.ResumeLayout(false);
            this.queue_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Cancel;
        public System.Windows.Forms.Label Label_asset_password;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_password;
        public System.Windows.Forms.Label Label_asset_text;
        public System.Windows.Forms.ComboBox CB_type;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_name;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_text;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_asset_description;
    }
}