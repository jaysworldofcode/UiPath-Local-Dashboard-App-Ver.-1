namespace WindowsFormsApp1.Extras
{
    partial class pop_up_medium
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_no = new System.Windows.Forms.Button();
            this.BT_yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BT_no);
            this.panel1.Controls.Add(this.BT_yes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 282);
            this.panel1.TabIndex = 0;
            // 
            // BT_no
            // 
            this.BT_no.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_no.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F);
            this.BT_no.Location = new System.Drawing.Point(271, 201);
            this.BT_no.Name = "BT_no";
            this.BT_no.Size = new System.Drawing.Size(195, 46);
            this.BT_no.TabIndex = 2;
            this.BT_no.Text = "NO";
            this.BT_no.UseVisualStyleBackColor = true;
            // 
            // BT_yes
            // 
            this.BT_yes.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_yes.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_yes.ForeColor = System.Drawing.Color.White;
            this.BT_yes.Location = new System.Drawing.Point(50, 201);
            this.BT_yes.Name = "BT_yes";
            this.BT_yes.Size = new System.Drawing.Size(195, 46);
            this.BT_yes.TabIndex = 1;
            this.BT_yes.Text = "YES";
            this.BT_yes.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure?";
            // 
            // pop_up_medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 282);
            this.Controls.Add(this.panel1);
            this.Name = "pop_up_medium";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "pop_up_medium";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BT_no;
        public System.Windows.Forms.Button BT_yes;
    }
}