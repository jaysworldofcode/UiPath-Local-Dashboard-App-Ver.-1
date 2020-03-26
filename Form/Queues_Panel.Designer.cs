namespace WindowsFormsApp1
{
    partial class Queues_Panel
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
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_add_queue = new System.Windows.Forms.Button();
            this.BT_add_robot = new System.Windows.Forms.Button();
            this.queue_list = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
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
            this.MainPanel.Controls.Add(this.BT_add_queue);
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.materialFlatButton4);
            this.MainPanel.Controls.Add(this.materialFlatButton3);
            this.MainPanel.Controls.Add(this.materialFlatButton2);
            this.MainPanel.Controls.Add(this.materialFlatButton1);
            this.MainPanel.Controls.Add(this.comboBox5);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 0;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(839, 669);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButton4.TabIndex = 14;
            this.materialFlatButton4.Text = ">|";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(713, 669);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(31, 36);
            this.materialFlatButton3.TabIndex = 13;
            this.materialFlatButton3.Text = "|<";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(799, 669);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(28, 36);
            this.materialFlatButton2.TabIndex = 12;
            this.materialFlatButton2.Text = ">";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(754, 669);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(28, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "<";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "10",
            "25",
            "50"});
            this.comboBox5.Location = new System.Drawing.Point(604, 678);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(72, 21);
            this.comboBox5.TabIndex = 10;
            this.comboBox5.Text = "Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUEUES";
            // 
            // BT_add_queue
            // 
            this.BT_add_queue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_add_queue.BackColor = System.Drawing.Color.Transparent;
            this.BT_add_queue.FlatAppearance.BorderSize = 0;
            this.BT_add_queue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_queue.ForeColor = System.Drawing.Color.Transparent;
            this.BT_add_queue.Location = new System.Drawing.Point(759, 504);
            this.BT_add_queue.Name = "BT_add_queue";
            this.BT_add_queue.Size = new System.Drawing.Size(80, 80);
            this.BT_add_queue.TabIndex = 1;
            this.BT_add_queue.Text = "+";
            this.BT_add_queue.UseVisualStyleBackColor = false;
            // 
            // BT_add_robot
            // 
            this.BT_add_robot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_add_robot.BackColor = System.Drawing.Color.Transparent;
            this.BT_add_robot.FlatAppearance.BorderSize = 0;
            this.BT_add_robot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_robot.ForeColor = System.Drawing.Color.Transparent;
            this.BT_add_robot.Location = new System.Drawing.Point(776, 427);
            this.BT_add_robot.Name = "BT_add_robot";
            this.BT_add_robot.Size = new System.Drawing.Size(80, 80);
            this.BT_add_robot.TabIndex = 0;
            this.BT_add_robot.Text = "+";
            this.BT_add_robot.UseVisualStyleBackColor = false;
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
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListPanel.Controls.Add(this.queue_list);
            this.ListPanel.Controls.Add(this.BT_add_robot);
            this.ListPanel.Location = new System.Drawing.Point(0, 96);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(891, 543);
            this.ListPanel.TabIndex = 30;
            // 
            // Queues_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Queues_Panel";
            this.Text = "Queues_Panel";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel MainPanel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox comboBox5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.Button BT_add_queue;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Button BT_add_robot;
    }
}