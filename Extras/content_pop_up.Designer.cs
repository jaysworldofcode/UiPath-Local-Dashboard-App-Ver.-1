namespace WindowsFormsApp1.Extras
{
    partial class content_pop_up
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
            this.content = new System.Windows.Forms.RichTextBox();
            this.BT_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Font = new System.Drawing.Font("Hind Siliguri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(15, 13);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(503, 210);
            this.content.TabIndex = 0;
            this.content.Text = "";
            // 
            // BT_back
            // 
            this.BT_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_back.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F);
            this.BT_back.Location = new System.Drawing.Point(397, 238);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(128, 30);
            this.BT_back.TabIndex = 3;
            this.BT_back.Text = ">>BACK";
            this.BT_back.UseVisualStyleBackColor = true;
            // 
            // content_pop_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 280);
            this.Controls.Add(this.BT_back);
            this.Controls.Add(this.content);
            this.Name = "content_pop_up";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "content_pop_up";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox content;
        public System.Windows.Forms.Button BT_back;
    }
}