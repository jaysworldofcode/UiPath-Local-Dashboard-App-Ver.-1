namespace WindowsFormsApp1
{
    partial class New_Robot_Panel
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
            this.BT_Browse = new System.Windows.Forms.Button();
            this.TF_package_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_add_robot = new System.Windows.Forms.Button();
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
            this.MainPanel.TabIndex = 2;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.BT_Browse);
            this.queue_list.Controls.Add(this.TF_package_path);
            this.queue_list.Controls.Add(this.BT_Cancel);
            this.queue_list.Controls.Add(this.BT_add_robot);
            this.queue_list.Location = new System.Drawing.Point(0, 52);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(891, 642);
            this.queue_list.TabIndex = 2;
            // 
            // BT_Browse
            // 
            this.BT_Browse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Browse.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_Browse.FlatAppearance.BorderSize = 0;
            this.BT_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.BT_Browse.ForeColor = System.Drawing.Color.Transparent;
            this.BT_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Browse.Location = new System.Drawing.Point(609, 269);
            this.BT_Browse.Name = "BT_Browse";
            this.BT_Browse.Size = new System.Drawing.Size(116, 32);
            this.BT_Browse.TabIndex = 25;
            this.BT_Browse.Text = "BROWSE";
            this.BT_Browse.UseVisualStyleBackColor = false;
            // 
            // TF_package_path
            // 
            this.TF_package_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_package_path.Depth = 0;
            this.TF_package_path.Hint = "Path";
            this.TF_package_path.Location = new System.Drawing.Point(146, 271);
            this.TF_package_path.MaxLength = 32767;
            this.TF_package_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_package_path.Name = "TF_package_path";
            this.TF_package_path.PasswordChar = '\0';
            this.TF_package_path.SelectedText = "";
            this.TF_package_path.SelectionLength = 0;
            this.TF_package_path.SelectionStart = 0;
            this.TF_package_path.Size = new System.Drawing.Size(445, 23);
            this.TF_package_path.TabIndex = 24;
            this.TF_package_path.TabStop = false;
            this.TF_package_path.UseSystemPasswordChar = false;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BT_Cancel.FlatAppearance.BorderSize = 0;
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BT_Cancel.Location = new System.Drawing.Point(171, 360);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 28);
            this.BT_Cancel.TabIndex = 23;
            this.BT_Cancel.Text = "CANCEL";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            // 
            // BT_add_robot
            // 
            this.BT_add_robot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BT_add_robot.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_add_robot.FlatAppearance.BorderSize = 0;
            this.BT_add_robot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_add_robot.ForeColor = System.Drawing.Color.White;
            this.BT_add_robot.Location = new System.Drawing.Point(258, 360);
            this.BT_add_robot.Name = "BT_add_robot";
            this.BT_add_robot.Size = new System.Drawing.Size(75, 28);
            this.BT_add_robot.TabIndex = 22;
            this.BT_add_robot.Text = "ADD";
            this.BT_add_robot.UseVisualStyleBackColor = false;
            // 
            // New_Robot_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "New_Robot_Panel";
            this.Text = "New_Robot_Panel";
            this.MainPanel.ResumeLayout(false);
            this.queue_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Button BT_Browse;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_add_robot;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_package_path;
    }
}