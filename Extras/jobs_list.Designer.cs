namespace WindowsFormsApp1.Extras
{
    partial class jobs_list
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
            this.panel_bottom_border = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_info = new System.Windows.Forms.Button();
            this.BT_view = new System.Windows.Forms.Button();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.label_robot = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel_bottom_border);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.BT_info);
            this.main_panel.Controls.Add(this.BT_view);
            this.main_panel.Controls.Add(this.pb_status);
            this.main_panel.Controls.Add(this.label_robot);
            this.main_panel.ForeColor = System.Drawing.Color.White;
            this.main_panel.Location = new System.Drawing.Point(0, 1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(846, 64);
            this.main_panel.TabIndex = 1;
            // 
            // panel_bottom_border
            // 
            this.panel_bottom_border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom_border.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bottom_border.Location = new System.Drawing.Point(3, 63);
            this.panel_bottom_border.Name = "panel_bottom_border";
            this.panel_bottom_border.Size = new System.Drawing.Size(846, 1);
            this.panel_bottom_border.TabIndex = 11;
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
            this.panel2.TabIndex = 10;
            // 
            // BT_info
            // 
            this.BT_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_info.FlatAppearance.BorderSize = 0;
            this.BT_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_info.Location = new System.Drawing.Point(708, 12);
            this.BT_info.Name = "BT_info";
            this.BT_info.Size = new System.Drawing.Size(40, 40);
            this.BT_info.TabIndex = 7;
            this.BT_info.UseVisualStyleBackColor = true;
            // 
            // BT_view
            // 
            this.BT_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_view.FlatAppearance.BorderSize = 0;
            this.BT_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_view.Location = new System.Drawing.Point(772, 12);
            this.BT_view.Name = "BT_view";
            this.BT_view.Size = new System.Drawing.Size(40, 40);
            this.BT_view.TabIndex = 6;
            this.BT_view.UseVisualStyleBackColor = true;
            // 
            // pb_status
            // 
            this.pb_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_status.Location = new System.Drawing.Point(41, 25);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(30, 30);
            this.pb_status.TabIndex = 5;
            this.pb_status.TabStop = false;
            // 
            // label_robot
            // 
            this.label_robot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_robot.AutoSize = true;
            this.label_robot.Font = new System.Drawing.Font("Hind Siliguri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_robot.ForeColor = System.Drawing.Color.Black;
            this.label_robot.Location = new System.Drawing.Point(104, 19);
            this.label_robot.Name = "label_robot";
            this.label_robot.Size = new System.Drawing.Size(96, 26);
            this.label_robot.TabIndex = 2;
            this.label_robot.Text = "robot_name";
            // 
            // jobs_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.main_panel);
            this.Name = "jobs_list";
            this.Text = "jobs_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel main_panel;
        public System.Windows.Forms.Label label_robot;
        private System.Windows.Forms.PictureBox pb_status;
        public System.Windows.Forms.Button BT_view;
        public System.Windows.Forms.Button BT_info;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel_bottom_border;
    }
}