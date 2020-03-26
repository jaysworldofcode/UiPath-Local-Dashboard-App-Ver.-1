namespace WindowsFormsApp1
{
    partial class assets_list_ui
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.BT_View = new System.Windows.Forms.Button();
            this.label_asset_value = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.image_type = new System.Windows.Forms.PictureBox();
            this.label_asset_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_type)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.BT_View);
            this.main_panel.Controls.Add(this.label_asset_value);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.label_asset_name);
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(409, 77);
            this.main_panel.TabIndex = 0;
            // 
            // BT_View
            // 
            this.BT_View.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_View.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_View.FlatAppearance.BorderSize = 0;
            this.BT_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_View.ForeColor = System.Drawing.Color.White;
            this.BT_View.Location = new System.Drawing.Point(326, 28);
            this.BT_View.Name = "BT_View";
            this.BT_View.Size = new System.Drawing.Size(62, 23);
            this.BT_View.TabIndex = 5;
            this.BT_View.Text = "VIEW";
            this.BT_View.UseVisualStyleBackColor = false;
            // 
            // label_asset_value
            // 
            this.label_asset_value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_asset_value.AutoSize = true;
            this.label_asset_value.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asset_value.Location = new System.Drawing.Point(64, 39);
            this.label_asset_value.MaximumSize = new System.Drawing.Size(250, 0);
            this.label_asset_value.Name = "label_asset_value";
            this.label_asset_value.Size = new System.Drawing.Size(59, 18);
            this.label_asset_value.TabIndex = 4;
            this.label_asset_value.Text = "value_here";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.image_type);
            this.panel2.Location = new System.Drawing.Point(-190, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 117);
            this.panel2.TabIndex = 3;
            // 
            // image_type
            // 
            this.image_type.Location = new System.Drawing.Point(203, 40);
            this.image_type.Name = "image_type";
            this.image_type.Size = new System.Drawing.Size(30, 25);
            this.image_type.TabIndex = 1;
            this.image_type.TabStop = false;
            // 
            // label_asset_name
            // 
            this.label_asset_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_asset_name.AutoSize = true;
            this.label_asset_name.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asset_name.Location = new System.Drawing.Point(61, 17);
            this.label_asset_name.Name = "label_asset_name";
            this.label_asset_name.Size = new System.Drawing.Size(98, 26);
            this.label_asset_name.TabIndex = 2;
            this.label_asset_name.Text = "asset_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // assets_list_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 332);
            this.Controls.Add(this.main_panel);
            this.Name = "assets_list_ui";
            this.Text = "assets_list_ui";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_asset_name;
        private System.Windows.Forms.Label label_asset_value;
        private System.Windows.Forms.Button BT_View;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox image_type;
    }
}