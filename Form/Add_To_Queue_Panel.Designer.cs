namespace WindowsFormsApp1
{
    partial class Add_To_Queue_Panel
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
            this.queue_list = new System.Windows.Forms.Panel();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_new = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TF_description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_queue_panel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MainPanel.SuspendLayout();
            this.queue_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.queue_list);
            this.MainPanel.Location = new System.Drawing.Point(1, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(891, 716);
            this.MainPanel.TabIndex = 1;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.BT_Cancel);
            this.queue_list.Controls.Add(this.BT_new);
            this.queue_list.Controls.Add(this.label6);
            this.queue_list.Controls.Add(this.label5);
            this.queue_list.Controls.Add(this.TF_description);
            this.queue_list.Controls.Add(this.TF_queue_panel);
            this.queue_list.Location = new System.Drawing.Point(0, 52);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(891, 642);
            this.queue_list.TabIndex = 2;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BT_Cancel.FlatAppearance.BorderSize = 0;
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BT_Cancel.Location = new System.Drawing.Point(631, 388);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 28);
            this.BT_Cancel.TabIndex = 23;
            this.BT_Cancel.Text = "CANCEL";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            // 
            // BT_new
            // 
            this.BT_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_new.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_new.FlatAppearance.BorderSize = 0;
            this.BT_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_new.ForeColor = System.Drawing.Color.White;
            this.BT_new.Location = new System.Drawing.Point(532, 388);
            this.BT_new.Name = "BT_new";
            this.BT_new.Size = new System.Drawing.Size(75, 28);
            this.BT_new.TabIndex = 22;
            this.BT_new.Text = "CREATE";
            this.BT_new.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(157, 289);
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
            this.label5.Location = new System.Drawing.Point(157, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // TF_description
            // 
            this.TF_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_description.Depth = 0;
            this.TF_description.Hint = "";
            this.TF_description.Location = new System.Drawing.Point(156, 321);
            this.TF_description.MaxLength = 32767;
            this.TF_description.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_description.Name = "TF_description";
            this.TF_description.PasswordChar = '\0';
            this.TF_description.SelectedText = "";
            this.TF_description.SelectionLength = 0;
            this.TF_description.SelectionStart = 0;
            this.TF_description.Size = new System.Drawing.Size(550, 23);
            this.TF_description.TabIndex = 1;
            this.TF_description.TabStop = false;
            this.TF_description.UseSystemPasswordChar = false;
            // 
            // TF_queue_panel
            // 
            this.TF_queue_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_queue_panel.Depth = 0;
            this.TF_queue_panel.Hint = "";
            this.TF_queue_panel.Location = new System.Drawing.Point(156, 247);
            this.TF_queue_panel.MaxLength = 32767;
            this.TF_queue_panel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_queue_panel.Name = "TF_queue_panel";
            this.TF_queue_panel.PasswordChar = '\0';
            this.TF_queue_panel.SelectedText = "";
            this.TF_queue_panel.SelectionLength = 0;
            this.TF_queue_panel.SelectionStart = 0;
            this.TF_queue_panel.Size = new System.Drawing.Size(550, 23);
            this.TF_queue_panel.TabIndex = 0;
            this.TF_queue_panel.TabStop = false;
            this.TF_queue_panel.UseSystemPasswordChar = false;
            // 
            // Add_To_Queue_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "Add_To_Queue_Panel";
            this.Text = "Add_To_Queue_Panel";
            this.MainPanel.ResumeLayout(false);
            this.queue_list.ResumeLayout(false);
            this.queue_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_queue_panel;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_description;
    }
}