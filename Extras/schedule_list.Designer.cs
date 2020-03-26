namespace WindowsFormsApp1.Extras
{
    partial class schedule_list
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
            this.label_schedule_name = new System.Windows.Forms.Label();
            this.BT_edit = new System.Windows.Forms.Button();
            this.label_schedule = new System.Windows.Forms.Label();
            this.BT_delete = new System.Windows.Forms.Button();
            this.BT_status = new System.Windows.Forms.Button();
            this.label_process_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_bottom_border = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel_bottom_border);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.label_schedule_name);
            this.main_panel.Controls.Add(this.BT_edit);
            this.main_panel.Controls.Add(this.label_schedule);
            this.main_panel.Controls.Add(this.BT_delete);
            this.main_panel.Controls.Add(this.BT_status);
            this.main_panel.Controls.Add(this.label_process_name);
            this.main_panel.ForeColor = System.Drawing.Color.White;
            this.main_panel.Location = new System.Drawing.Point(2, 3);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(846, 83);
            this.main_panel.TabIndex = 2;
            // 
            // label_schedule_name
            // 
            this.label_schedule_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_schedule_name.AutoSize = true;
            this.label_schedule_name.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_schedule_name.ForeColor = System.Drawing.Color.Black;
            this.label_schedule_name.Location = new System.Drawing.Point(43, 16);
            this.label_schedule_name.Name = "label_schedule_name";
            this.label_schedule_name.Size = new System.Drawing.Size(114, 26);
            this.label_schedule_name.TabIndex = 6;
            this.label_schedule_name.Text = "process_name";
            // 
            // BT_edit
            // 
            this.BT_edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_edit.FlatAppearance.BorderSize = 0;
            this.BT_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_edit.ForeColor = System.Drawing.Color.Black;
            this.BT_edit.Location = new System.Drawing.Point(789, 21);
            this.BT_edit.Name = "BT_edit";
            this.BT_edit.Size = new System.Drawing.Size(40, 40);
            this.BT_edit.TabIndex = 5;
            this.BT_edit.Text = "Edit";
            this.BT_edit.UseVisualStyleBackColor = true;
            // 
            // label_schedule
            // 
            this.label_schedule.AutoSize = true;
            this.label_schedule.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_schedule.ForeColor = System.Drawing.Color.Black;
            this.label_schedule.Location = new System.Drawing.Point(349, 36);
            this.label_schedule.Name = "label_schedule";
            this.label_schedule.Size = new System.Drawing.Size(76, 18);
            this.label_schedule.TabIndex = 4;
            this.label_schedule.Text = "schedule_here";
            // 
            // BT_delete
            // 
            this.BT_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_delete.FlatAppearance.BorderSize = 0;
            this.BT_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_delete.ForeColor = System.Drawing.Color.Black;
            this.BT_delete.Location = new System.Drawing.Point(738, 21);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(40, 40);
            this.BT_delete.TabIndex = 2;
            this.BT_delete.Text = "Delete";
            this.BT_delete.UseVisualStyleBackColor = true;
            // 
            // BT_status
            // 
            this.BT_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_status.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_status.FlatAppearance.BorderSize = 0;
            this.BT_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_status.ForeColor = System.Drawing.Color.Black;
            this.BT_status.Location = new System.Drawing.Point(685, 21);
            this.BT_status.Name = "BT_status";
            this.BT_status.Size = new System.Drawing.Size(40, 40);
            this.BT_status.TabIndex = 1;
            this.BT_status.Text = "Dis/En";
            this.BT_status.UseVisualStyleBackColor = true;
            // 
            // label_process_name
            // 
            this.label_process_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_process_name.AutoSize = true;
            this.label_process_name.Font = new System.Drawing.Font("Hind Siliguri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_process_name.ForeColor = System.Drawing.Color.Black;
            this.label_process_name.Location = new System.Drawing.Point(44, 42);
            this.label_process_name.Name = "label_process_name";
            this.label_process_name.Size = new System.Drawing.Size(88, 22);
            this.label_process_name.TabIndex = 0;
            this.label_process_name.Text = "process_name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel_bottom_border
            // 
            this.panel_bottom_border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom_border.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bottom_border.Location = new System.Drawing.Point(0, 82);
            this.panel_bottom_border.Name = "panel_bottom_border";
            this.panel_bottom_border.Size = new System.Drawing.Size(846, 1);
            this.panel_bottom_border.TabIndex = 19;
            this.panel_bottom_border.Visible = false;
            // 
            // schedule_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 621);
            this.Controls.Add(this.main_panel);
            this.Name = "schedule_list";
            this.Text = "schedule_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label_process_name;
        public System.Windows.Forms.Button BT_status;
        public System.Windows.Forms.Button BT_delete;
        public System.Windows.Forms.Button BT_edit;
        private System.Windows.Forms.Label label_schedule;
        private System.Windows.Forms.Label label_schedule_name;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel_bottom_border;
    }
}