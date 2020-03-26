namespace WindowsFormsApp1.Controller
{
    partial class queue_items
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
            this.label_queue_name = new System.Windows.Forms.Label();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.queue_list = new System.Windows.Forms.Panel();
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
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.label_queue_name);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 2;
            // 
            // label_queue_name
            // 
            this.label_queue_name.AutoSize = true;
            this.label_queue_name.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold);
            this.label_queue_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_queue_name.Location = new System.Drawing.Point(22, 17);
            this.label_queue_name.Name = "label_queue_name";
            this.label_queue_name.Size = new System.Drawing.Size(230, 39);
            this.label_queue_name.TabIndex = 19;
            this.label_queue_name.Text = "QUEUE NAME HERE";
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.Controls.Add(this.queue_list);
            this.ListPanel.Location = new System.Drawing.Point(0, 96);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(891, 543);
            this.ListPanel.TabIndex = 32;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.Transparent;
            this.queue_list.Location = new System.Drawing.Point(0, 0);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(891, 103);
            this.queue_list.TabIndex = 0;
            // 
            // queue_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "queue_items";
            this.Text = "queues_list";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label_queue_name;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel queue_list;
    }
}