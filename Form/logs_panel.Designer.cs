namespace WindowsFormsApp1.Extras
{
    partial class logs_panel
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
            this.label_process_name = new System.Windows.Forms.Label();
            this.BT_back = new System.Windows.Forms.Button();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.logs_list = new System.Windows.Forms.Panel();
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
            this.MainPanel.Controls.Add(this.label_process_name);
            this.MainPanel.Controls.Add(this.BT_back);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 4;
            // 
            // label_process_name
            // 
            this.label_process_name.AutoSize = true;
            this.label_process_name.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold);
            this.label_process_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_process_name.Location = new System.Drawing.Point(22, 17);
            this.label_process_name.Name = "label_process_name";
            this.label_process_name.Size = new System.Drawing.Size(190, 39);
            this.label_process_name.TabIndex = 27;
            this.label_process_name.Text = "PROCESS NAME";
            // 
            // BT_back
            // 
            this.BT_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_back.FlatAppearance.BorderSize = 0;
            this.BT_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_back.ForeColor = System.Drawing.Color.White;
            this.BT_back.Location = new System.Drawing.Point(728, 665);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(134, 28);
            this.BT_back.TabIndex = 25;
            this.BT_back.Text = "BACK";
            this.BT_back.UseVisualStyleBackColor = false;
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListPanel.Controls.Add(this.logs_list);
            this.ListPanel.Location = new System.Drawing.Point(0, 96);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(891, 543);
            this.ListPanel.TabIndex = 28;
            // 
            // logs_list
            // 
            this.logs_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logs_list.BackColor = System.Drawing.Color.Transparent;
            this.logs_list.Location = new System.Drawing.Point(0, 0);
            this.logs_list.Name = "logs_list";
            this.logs_list.Size = new System.Drawing.Size(891, 103);
            this.logs_list.TabIndex = 0;
            // 
            // logs_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "logs_panel";
            this.Text = "logs_panel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Button BT_back;
        public System.Windows.Forms.Label label_process_name;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel logs_list;
    }
}