namespace WindowsFormsApp1
{
    partial class package_list
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
            this.label_package_name = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_publish_date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_publish_date);
            this.panel1.Controls.Add(this.label_description);
            this.panel1.Controls.Add(this.label_package_name);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 70);
            this.panel1.TabIndex = 0;
            // 
            // label_package_name
            // 
            this.label_package_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_package_name.AutoSize = true;
            this.label_package_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_package_name.Location = new System.Drawing.Point(15, 26);
            this.label_package_name.Name = "label_package_name";
            this.label_package_name.Size = new System.Drawing.Size(154, 16);
            this.label_package_name.TabIndex = 0;
            this.label_package_name.Text = "package_name_here";
            // 
            // label_description
            // 
            this.label_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(288, 26);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(85, 13);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "description_here";
            // 
            // label_publish_date
            // 
            this.label_publish_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_publish_date.AutoSize = true;
            this.label_publish_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_publish_date.Location = new System.Drawing.Point(609, 26);
            this.label_publish_date.Name = "label_publish_date";
            this.label_publish_date.Size = new System.Drawing.Size(67, 13);
            this.label_publish_date.TabIndex = 2;
            this.label_publish_date.Text = "publish_date";
            // 
            // package_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 677);
            this.Controls.Add(this.panel1);
            this.Name = "package_list";
            this.Text = "package_list";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_package_name;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_publish_date;
    }
}