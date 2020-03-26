namespace WindowsFormsApp1
{
    partial class Dashboard_Panel
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
            this.queue_filter_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gauge_status_queue_meter = new LiveCharts.WinForms.SolidGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queue_list = new System.Windows.Forms.ComboBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.queue_filter_type);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.gauge_status_queue_meter);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.queue_list);
            this.MainPanel.Controls.Add(this.pieChart1);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 4;
            // 
            // queue_filter_type
            // 
            this.queue_filter_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_filter_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queue_filter_type.Font = new System.Drawing.Font("Hind Siliguri", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue_filter_type.FormattingEnabled = true;
            this.queue_filter_type.Items.AddRange(new object[] {
            "New",
            "Successful",
            "Fail",
            "Abandon"});
            this.queue_filter_type.Location = new System.Drawing.Point(759, 387);
            this.queue_filter_type.Name = "queue_filter_type";
            this.queue_filter_type.Size = new System.Drawing.Size(111, 26);
            this.queue_filter_type.TabIndex = 7;
            this.queue_filter_type.Text = "VIEW BY";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hind Siliguri Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(628, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "FAIL STATUS";
            // 
            // gauge_status_queue_meter
            // 
            this.gauge_status_queue_meter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gauge_status_queue_meter.Location = new System.Drawing.Point(526, 92);
            this.gauge_status_queue_meter.Name = "gauge_status_queue_meter";
            this.gauge_status_queue_meter.Size = new System.Drawing.Size(294, 178);
            this.gauge_status_queue_meter.TabIndex = 5;
            this.gauge_status_queue_meter.Text = "solidGauge1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.list_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 286);
            this.panel1.TabIndex = 4;
            // 
            // list_panel
            // 
            this.list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_panel.BackColor = System.Drawing.Color.Transparent;
            this.list_panel.Location = new System.Drawing.Point(1, 45);
            this.list_panel.Name = "list_panel";
            this.list_panel.Size = new System.Drawing.Size(848, 241);
            this.list_panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Hind Siliguri", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 44);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "FAILED TRANSACTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hind Siliguri Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "QUEUE STATUS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHOOSE A QUEUE";
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.FormattingEnabled = true;
            this.queue_list.Location = new System.Drawing.Point(759, 12);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(121, 21);
            this.queue_list.TabIndex = 1;
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(22, 71);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(401, 262);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // Dashboard_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Dashboard_Panel";
            this.Text = "Dashboard_Panel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox queue_list;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.Label label4;
        private LiveCharts.WinForms.SolidGauge gauge_status_queue_meter;
        private System.Windows.Forms.ComboBox queue_filter_type;
    }
}