namespace WindowsFormsApp1
{
    partial class Edit_Queue
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
            this.Label_QueueName = new System.Windows.Forms.Label();
            this.queue_list = new System.Windows.Forms.Panel();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TF_retry = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RB_no = new MaterialSkin.Controls.MaterialRadioButton();
            this.RB_yes = new MaterialSkin.Controls.MaterialRadioButton();
            this.TF_description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_queue_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.queue_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.Label_QueueName);
            this.MainPanel.Controls.Add(this.queue_list);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 2;
            // 
            // Label_QueueName
            // 
            this.Label_QueueName.AutoSize = true;
            this.Label_QueueName.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Bold);
            this.Label_QueueName.Location = new System.Drawing.Point(106, 16);
            this.Label_QueueName.Name = "Label_QueueName";
            this.Label_QueueName.Size = new System.Drawing.Size(162, 26);
            this.Label_QueueName.TabIndex = 3;
            this.Label_QueueName.Text = "> queue_name_here";
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.BT_Cancel);
            this.queue_list.Controls.Add(this.BT_update);
            this.queue_list.Controls.Add(this.label3);
            this.queue_list.Controls.Add(this.label7);
            this.queue_list.Controls.Add(this.label6);
            this.queue_list.Controls.Add(this.label5);
            this.queue_list.Controls.Add(this.TF_retry);
            this.queue_list.Controls.Add(this.RB_no);
            this.queue_list.Controls.Add(this.RB_yes);
            this.queue_list.Controls.Add(this.TF_description);
            this.queue_list.Controls.Add(this.TF_queue_name);
            this.queue_list.Location = new System.Drawing.Point(20, 52);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(846, 642);
            this.queue_list.TabIndex = 2;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BT_Cancel.FlatAppearance.BorderSize = 0;
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BT_Cancel.Location = new System.Drawing.Point(153, 487);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 28);
            this.BT_Cancel.TabIndex = 23;
            this.BT_Cancel.Text = "CANCEL";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            // 
            // BT_update
            // 
            this.BT_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_update.FlatAppearance.BorderSize = 0;
            this.BT_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_update.ForeColor = System.Drawing.Color.White;
            this.BT_update.Location = new System.Drawing.Point(240, 487);
            this.BT_update.Name = "BT_update";
            this.BT_update.Size = new System.Drawing.Size(75, 28);
            this.BT_update.TabIndex = 22;
            this.BT_update.Text = "UPDATE";
            this.BT_update.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(155, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Max Retry";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(157, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unique Reference";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(157, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(157, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // TF_retry
            // 
            this.TF_retry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TF_retry.Depth = 0;
            this.TF_retry.Enabled = false;
            this.TF_retry.Hint = "";
            this.TF_retry.Location = new System.Drawing.Point(158, 396);
            this.TF_retry.MaxLength = 32767;
            this.TF_retry.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_retry.Name = "TF_retry";
            this.TF_retry.PasswordChar = '\0';
            this.TF_retry.SelectedText = "";
            this.TF_retry.SelectionLength = 0;
            this.TF_retry.SelectionStart = 0;
            this.TF_retry.Size = new System.Drawing.Size(50, 23);
            this.TF_retry.TabIndex = 8;
            this.TF_retry.TabStop = false;
            this.TF_retry.UseSystemPasswordChar = false;
            // 
            // RB_no
            // 
            this.RB_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_no.AutoSize = true;
            this.RB_no.Depth = 0;
            this.RB_no.Enabled = false;
            this.RB_no.Font = new System.Drawing.Font("Roboto", 10F);
            this.RB_no.Location = new System.Drawing.Point(220, 310);
            this.RB_no.Margin = new System.Windows.Forms.Padding(0);
            this.RB_no.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_no.Name = "RB_no";
            this.RB_no.Ripple = true;
            this.RB_no.Size = new System.Drawing.Size(47, 30);
            this.RB_no.TabIndex = 4;
            this.RB_no.TabStop = true;
            this.RB_no.Text = "No";
            this.RB_no.UseVisualStyleBackColor = true;
            // 
            // RB_yes
            // 
            this.RB_yes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_yes.AutoSize = true;
            this.RB_yes.Depth = 0;
            this.RB_yes.Enabled = false;
            this.RB_yes.Font = new System.Drawing.Font("Roboto", 10F);
            this.RB_yes.Location = new System.Drawing.Point(154, 310);
            this.RB_yes.Margin = new System.Windows.Forms.Padding(0);
            this.RB_yes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RB_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.RB_yes.Name = "RB_yes";
            this.RB_yes.Ripple = true;
            this.RB_yes.Size = new System.Drawing.Size(52, 30);
            this.RB_yes.TabIndex = 3;
            this.RB_yes.TabStop = true;
            this.RB_yes.Text = "Yes";
            this.RB_yes.UseVisualStyleBackColor = true;
            // 
            // TF_description
            // 
            this.TF_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_description.Depth = 0;
            this.TF_description.Hint = "";
            this.TF_description.Location = new System.Drawing.Point(156, 239);
            this.TF_description.MaxLength = 32767;
            this.TF_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_description.Name = "TF_description";
            this.TF_description.PasswordChar = '\0';
            this.TF_description.SelectedText = "";
            this.TF_description.SelectionLength = 0;
            this.TF_description.SelectionStart = 0;
            this.TF_description.Size = new System.Drawing.Size(505, 23);
            this.TF_description.TabIndex = 1;
            this.TF_description.TabStop = false;
            this.TF_description.UseSystemPasswordChar = false;
            // 
            // TF_queue_name
            // 
            this.TF_queue_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_queue_name.Depth = 0;
            this.TF_queue_name.Enabled = false;
            this.TF_queue_name.Hint = "";
            this.TF_queue_name.Location = new System.Drawing.Point(156, 165);
            this.TF_queue_name.MaxLength = 32767;
            this.TF_queue_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_queue_name.Name = "TF_queue_name";
            this.TF_queue_name.PasswordChar = '\0';
            this.TF_queue_name.SelectedText = "";
            this.TF_queue_name.SelectionLength = 0;
            this.TF_queue_name.SelectionStart = 0;
            this.TF_queue_name.Size = new System.Drawing.Size(505, 23);
            this.TF_queue_name.TabIndex = 0;
            this.TF_queue_name.TabStop = false;
            this.TF_queue_name.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUEUES";
            // 
            // Edit_Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Edit_Queue";
            this.Text = "Edit_Queue";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.queue_list.ResumeLayout(false);
            this.queue_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Label_QueueName;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRadioButton RB_no;
        private MaterialSkin.Controls.MaterialRadioButton RB_yes;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_queue_name;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_description;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_retry;
        public System.Windows.Forms.Button BT_update;
        public System.Windows.Forms.Button BT_Cancel;
    }
}