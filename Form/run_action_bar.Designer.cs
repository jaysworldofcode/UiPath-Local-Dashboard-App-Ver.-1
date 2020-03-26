namespace WindowsFormsApp1
{
    partial class run_action_bar
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
            this.BT_restart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_stop = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.BT_restart);
            this.main_panel.Controls.Add(this.button2);
            this.main_panel.Controls.Add(this.BT_stop);
            this.main_panel.Location = new System.Drawing.Point(-1, -1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(392, 61);
            this.main_panel.TabIndex = 0;
            // 
            // BT_restart
            // 
            this.BT_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_restart.Location = new System.Drawing.Point(264, 13);
            this.BT_restart.Name = "BT_restart";
            this.BT_restart.Size = new System.Drawing.Size(115, 33);
            this.BT_restart.TabIndex = 3;
            this.BT_restart.Text = "RESTART";
            this.BT_restart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(139, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "PAUSE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BT_stop
            // 
            this.BT_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_stop.Location = new System.Drawing.Point(13, 13);
            this.BT_stop.Name = "BT_stop";
            this.BT_stop.Size = new System.Drawing.Size(115, 33);
            this.BT_stop.TabIndex = 0;
            this.BT_stop.Text = "STOP";
            this.BT_stop.UseVisualStyleBackColor = true;
            // 
            // run_action_bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 58);
            this.Controls.Add(this.main_panel);
            this.Name = "run_action_bar";
            this.Opacity = 0.6D;
            this.Text = "run_action_bar";
            this.TopMost = true;
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_stop;
        private System.Windows.Forms.Button BT_restart;
        public System.Windows.Forms.Panel main_panel;
    }
}