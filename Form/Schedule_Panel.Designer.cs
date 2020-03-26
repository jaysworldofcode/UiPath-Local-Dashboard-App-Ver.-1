namespace WindowsFormsApp1
{
    partial class Schedule_Panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.panel_schedule_list = new System.Windows.Forms.Panel();
            this.BT_add_schedule = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.ListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.BT_add_schedule);
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCHEDULE";
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.Controls.Add(this.panel_schedule_list);
            this.ListPanel.Location = new System.Drawing.Point(0, 96);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(891, 543);
            this.ListPanel.TabIndex = 31;
            // 
            // panel_schedule_list
            // 
            this.panel_schedule_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_schedule_list.BackColor = System.Drawing.Color.Transparent;
            this.panel_schedule_list.Location = new System.Drawing.Point(0, 0);
            this.panel_schedule_list.Name = "panel_schedule_list";
            this.panel_schedule_list.Size = new System.Drawing.Size(891, 103);
            this.panel_schedule_list.TabIndex = 0;
            // 
            // BT_add_schedule
            // 
            this.BT_add_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_add_schedule.BackColor = System.Drawing.Color.Transparent;
            this.BT_add_schedule.FlatAppearance.BorderSize = 0;
            this.BT_add_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_schedule.ForeColor = System.Drawing.Color.Transparent;
            this.BT_add_schedule.Location = new System.Drawing.Point(751, 581);
            this.BT_add_schedule.Name = "BT_add_schedule";
            this.BT_add_schedule.Size = new System.Drawing.Size(80, 80);
            this.BT_add_schedule.TabIndex = 37;
            this.BT_add_schedule.Text = "+";
            this.BT_add_schedule.UseVisualStyleBackColor = false;
            // 
            // Schedule_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Schedule_Panel";
            this.Text = "Schedule_Panel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel panel_schedule_list;
        private System.Windows.Forms.Button BT_add_schedule;
    }
}