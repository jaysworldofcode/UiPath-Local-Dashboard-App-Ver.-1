namespace WindowsFormsApp1.Controller
{
    partial class robots_list
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
            this.BT_settings = new System.Windows.Forms.Button();
            this.label_published_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_robot = new System.Windows.Forms.Label();
            this.BT_run = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.panel_bottom_border);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.BT_settings);
            this.main_panel.Controls.Add(this.label_published_date);
            this.main_panel.Controls.Add(this.label_description);
            this.main_panel.Controls.Add(this.label_robot);
            this.main_panel.Controls.Add(this.BT_run);
            this.main_panel.ForeColor = System.Drawing.Color.White;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(846, 80);
            this.main_panel.TabIndex = 0;
            // 
            // panel_bottom_border
            // 
            this.panel_bottom_border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom_border.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_bottom_border.Location = new System.Drawing.Point(3, 79);
            this.panel_bottom_border.Name = "panel_bottom_border";
            this.panel_bottom_border.Size = new System.Drawing.Size(846, 1);
            this.panel_bottom_border.TabIndex = 10;
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
            this.panel2.TabIndex = 9;
            // 
            // BT_settings
            // 
            this.BT_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_settings.FlatAppearance.BorderSize = 0;
            this.BT_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_settings.Location = new System.Drawing.Point(793, 20);
            this.BT_settings.Name = "BT_settings";
            this.BT_settings.Size = new System.Drawing.Size(40, 40);
            this.BT_settings.TabIndex = 4;
            this.BT_settings.UseVisualStyleBackColor = true;
            // 
            // label_published_date
            // 
            this.label_published_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_published_date.AutoSize = true;
            this.label_published_date.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_published_date.ForeColor = System.Drawing.Color.Black;
            this.label_published_date.Location = new System.Drawing.Point(578, 35);
            this.label_published_date.Name = "label_published_date";
            this.label_published_date.Size = new System.Drawing.Size(110, 18);
            this.label_published_date.TabIndex = 3;
            this.label_published_date.Text = "robot_published_date";
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.Color.Black;
            this.label_description.Location = new System.Drawing.Point(353, 35);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(71, 18);
            this.label_description.TabIndex = 2;
            this.label_description.Text = "robot_version";
            // 
            // label_robot
            // 
            this.label_robot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_robot.AutoSize = true;
            this.label_robot.Font = new System.Drawing.Font("Hind Siliguri Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_robot.ForeColor = System.Drawing.Color.Black;
            this.label_robot.Location = new System.Drawing.Point(17, 30);
            this.label_robot.Name = "label_robot";
            this.label_robot.Size = new System.Drawing.Size(107, 26);
            this.label_robot.TabIndex = 1;
            this.label_robot.Text = "robot_name";
            // 
            // BT_run
            // 
            this.BT_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_run.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_run.FlatAppearance.BorderSize = 0;
            this.BT_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_run.ForeColor = System.Drawing.Color.Black;
            this.BT_run.Location = new System.Drawing.Point(733, 20);
            this.BT_run.Name = "BT_run";
            this.BT_run.Size = new System.Drawing.Size(40, 40);
            this.BT_run.TabIndex = 0;
            this.BT_run.Text = "Run";
            this.BT_run.UseVisualStyleBackColor = true;
            // 
            // robots_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.main_panel);
            this.Name = "robots_list";
            this.Text = "robots_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel main_panel;
        public System.Windows.Forms.Label label_robot;
        public System.Windows.Forms.Button BT_settings;
        private System.Windows.Forms.Label label_published_date;
        private System.Windows.Forms.Label label_description;
        public System.Windows.Forms.Button BT_run;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel_bottom_border;
    }
}