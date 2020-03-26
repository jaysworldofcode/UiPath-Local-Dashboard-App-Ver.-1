namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BT_Login = new System.Windows.Forms.Button();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BT_Login);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Controls.Add(this.TF_Username);
            this.panel1.Location = new System.Drawing.Point(620, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 808);
            this.panel1.TabIndex = 0;
            // 
            // BT_Login
            // 
            this.BT_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Login.BackColor = System.Drawing.SystemColors.Highlight;
            this.BT_Login.FlatAppearance.BorderSize = 0;
            this.BT_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Login.Location = new System.Drawing.Point(82, 402);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(438, 49);
            this.BT_Login.TabIndex = 2;
            this.BT_Login.Text = "LOGIN";
            this.BT_Login.UseVisualStyleBackColor = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "PASSWORD";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(82, 354);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(438, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // TF_Username
            // 
            this.TF_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_Username.Depth = 0;
            this.TF_Username.Hint = "USERNAME";
            this.TF_Username.Location = new System.Drawing.Point(82, 304);
            this.TF_Username.MaxLength = 32767;
            this.TF_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_Username.Name = "TF_Username";
            this.TF_Username.PasswordChar = '\0';
            this.TF_Username.SelectedText = "";
            this.TF_Username.SelectionLength = 0;
            this.TF_Username.SelectionStart = 0;
            this.TF_Username.Size = new System.Drawing.Size(438, 23);
            this.TF_Username.TabIndex = 0;
            this.TF_Username.TabStop = false;
            this.TF_Username.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 804);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TF_Username;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.Button BT_Login;
    }
}

