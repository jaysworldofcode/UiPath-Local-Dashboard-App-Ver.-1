namespace WindowsFormsApp1
{
    partial class queues_list
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
            this.BT_settings = new System.Windows.Forms.Button();
            this.label_queue_name = new System.Windows.Forms.Label();
            this.label_in_progress = new System.Windows.Forms.Label();
            this.label_successful = new System.Windows.Forms.Label();
            this.label_fail = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_bottom_border = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_settings
            // 
            this.BT_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_settings.FlatAppearance.BorderSize = 0;
            this.BT_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_settings.Location = new System.Drawing.Point(774, 10);
            this.BT_settings.Name = "BT_settings";
            this.BT_settings.Size = new System.Drawing.Size(40, 40);
            this.BT_settings.TabIndex = 2;
            this.BT_settings.UseVisualStyleBackColor = true;
            // 
            // label_queue_name
            // 
            this.label_queue_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_queue_name.AutoSize = true;
            this.label_queue_name.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queue_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_queue_name.Location = new System.Drawing.Point(22, 9);
            this.label_queue_name.Name = "label_queue_name";
            this.label_queue_name.Size = new System.Drawing.Size(107, 26);
            this.label_queue_name.TabIndex = 12;
            this.label_queue_name.Text = "queue_name";
            // 
            // label_in_progress
            // 
            this.label_in_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_in_progress.AutoSize = true;
            this.label_in_progress.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_in_progress.ForeColor = System.Drawing.Color.Blue;
            this.label_in_progress.Location = new System.Drawing.Point(331, 23);
            this.label_in_progress.Name = "label_in_progress";
            this.label_in_progress.Size = new System.Drawing.Size(73, 22);
            this.label_in_progress.TabIndex = 13;
            this.label_in_progress.Text = "NEW(total)";
            // 
            // label_successful
            // 
            this.label_successful.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_successful.AutoSize = true;
            this.label_successful.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_successful.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_successful.Location = new System.Drawing.Point(430, 23);
            this.label_successful.Name = "label_successful";
            this.label_successful.Size = new System.Drawing.Size(119, 22);
            this.label_successful.TabIndex = 14;
            this.label_successful.Text = "SUCCESSFUL(total)";
            // 
            // label_fail
            // 
            this.label_fail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_fail.AutoSize = true;
            this.label_fail.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fail.ForeColor = System.Drawing.Color.Red;
            this.label_fail.Location = new System.Drawing.Point(580, 23);
            this.label_fail.Name = "label_fail";
            this.label_fail.Size = new System.Drawing.Size(70, 22);
            this.label_fail.TabIndex = 15;
            this.label_fail.Text = "FAIL(total)";
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_description.Location = new System.Drawing.Point(26, 35);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(121, 18);
            this.label_description.TabIndex = 16;
            this.label_description.Text = "queue_description_here";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel_bottom_border);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.label_description);
            this.main_panel.Controls.Add(this.label_fail);
            this.main_panel.Controls.Add(this.label_successful);
            this.main_panel.Controls.Add(this.label_in_progress);
            this.main_panel.Controls.Add(this.label_queue_name);
            this.main_panel.Controls.Add(this.BT_settings);
            this.main_panel.Location = new System.Drawing.Point(-3, -1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(833, 62);
            this.main_panel.TabIndex = 0;
            // 
            // panel_bottom_border
            // 
            this.panel_bottom_border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom_border.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bottom_border.Location = new System.Drawing.Point(3, 60);
            this.panel_bottom_border.Name = "panel_bottom_border";
            this.panel_bottom_border.Size = new System.Drawing.Size(846, 1);
            this.panel_bottom_border.TabIndex = 18;
            this.panel_bottom_border.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 1);
            this.panel2.TabIndex = 17;
            // 
            // queues_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 61);
            this.Controls.Add(this.main_panel);
            this.Name = "queues_list";
            this.Text = "queues_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BT_settings;
        public System.Windows.Forms.Label label_queue_name;
        private System.Windows.Forms.Label label_in_progress;
        private System.Windows.Forms.Label label_successful;
        private System.Windows.Forms.Label label_fail;
        public System.Windows.Forms.Label label_description;
        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel_bottom_border;
    }
}