namespace WindowsFormsApp1.Extras
{
    partial class logs_list
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
            this.label_timestamp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_view = new System.Windows.Forms.Button();
            this.label_description = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.label_timestamp);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.BT_view);
            this.main_panel.Controls.Add(this.label_description);
            this.main_panel.Controls.Add(this.label_type);
            this.main_panel.Location = new System.Drawing.Point(1, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(846, 44);
            this.main_panel.TabIndex = 0;
            // 
            // label_timestamp
            // 
            this.label_timestamp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_timestamp.AutoSize = true;
            this.label_timestamp.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timestamp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_timestamp.Location = new System.Drawing.Point(601, 12);
            this.label_timestamp.Name = "label_timestamp";
            this.label_timestamp.Size = new System.Drawing.Size(91, 18);
            this.label_timestamp.TabIndex = 12;
            this.label_timestamp.Text = "{10/10/10 10:00PM}";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 1);
            this.panel2.TabIndex = 11;
            // 
            // BT_view
            // 
            this.BT_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_view.FlatAppearance.BorderSize = 0;
            this.BT_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_view.Font = new System.Drawing.Font("Hind Siliguri", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_view.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BT_view.Location = new System.Drawing.Point(765, 9);
            this.BT_view.Name = "BT_view";
            this.BT_view.Size = new System.Drawing.Size(68, 24);
            this.BT_view.TabIndex = 2;
            this.BT_view.Text = "VIEW";
            this.BT_view.UseVisualStyleBackColor = true;
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(11, 12);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(418, 18);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adip" +
    "isci velit...";
            // 
            // label_type
            // 
            this.label_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_type.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(719, 10);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(38, 22);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "INFO";
            // 
            // logs_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.main_panel);
            this.Name = "logs_list";
            this.Text = "logs_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button BT_view;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_timestamp;
    }
}