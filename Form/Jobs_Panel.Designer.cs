
namespace WindowsFormsApp1
{
    partial class Jobs_Panel
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
            this.jobs_list = new System.Windows.Forms.Panel();
            this.BT_run_job = new System.Windows.Forms.Button();
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
            this.MainPanel.Controls.Add(this.BT_run_job);
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "JOBS";
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListPanel.Controls.Add(this.jobs_list);
            this.ListPanel.Location = new System.Drawing.Point(0, 104);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(891, 543);
            this.ListPanel.TabIndex = 31;
            // 
            // jobs_list
            // 
            this.jobs_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobs_list.BackColor = System.Drawing.Color.Transparent;
            this.jobs_list.Location = new System.Drawing.Point(0, 0);
            this.jobs_list.Name = "jobs_list";
            this.jobs_list.Size = new System.Drawing.Size(891, 103);
            this.jobs_list.TabIndex = 0;
            // 
            // BT_run_job
            // 
            this.BT_run_job.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_run_job.BackColor = System.Drawing.Color.Transparent;
            this.BT_run_job.FlatAppearance.BorderSize = 0;
            this.BT_run_job.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_run_job.Location = new System.Drawing.Point(766, 521);
            this.BT_run_job.Name = "BT_run_job";
            this.BT_run_job.Size = new System.Drawing.Size(80, 80);
            this.BT_run_job.TabIndex = 32;
            this.BT_run_job.UseVisualStyleBackColor = false;
            // 
            // Jobs_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Jobs_Panel";
            this.Text = "Jobs_Panel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel jobs_list;
        private System.Windows.Forms.Button BT_run_job;
    }
}