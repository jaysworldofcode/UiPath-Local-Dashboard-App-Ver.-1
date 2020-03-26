namespace WindowsFormsApp1
{
    partial class splashscreen
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
            this.status = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.status);
            this.main_panel.Location = new System.Drawing.Point(1, -1);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(450, 250);
            this.main_panel.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Hind Siliguri", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(375, 219);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(45, 18);
            this.status.TabIndex = 0;
            this.status.Text = "Loading";
            // 
            // splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 249);
            this.Controls.Add(this.main_panel);
            this.Name = "splashscreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashscreen";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label status;
    }
}