namespace WindowsFormsApp1
{
    partial class failed_transactions_list
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
            this.button2 = new System.Windows.Forms.Button();
            this.label_queue_identifier = new System.Windows.Forms.Label();
            this.BT_solve = new System.Windows.Forms.Button();
            this.BT_View = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.button2);
            this.main_panel.Controls.Add(this.label_queue_identifier);
            this.main_panel.Controls.Add(this.BT_solve);
            this.main_panel.Controls.Add(this.BT_View);
            this.main_panel.Location = new System.Drawing.Point(12, 97);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(863, 44);
            this.main_panel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(14, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label_queue_identifier
            // 
            this.label_queue_identifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_queue_identifier.AutoSize = true;
            this.label_queue_identifier.Font = new System.Drawing.Font("Hind Siliguri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_queue_identifier.Location = new System.Drawing.Point(60, 10);
            this.label_queue_identifier.Name = "label_queue_identifier";
            this.label_queue_identifier.Size = new System.Drawing.Size(137, 22);
            this.label_queue_identifier.TabIndex = 8;
            this.label_queue_identifier.Text = "queue_reference_here";
            // 
            // BT_solve
            // 
            this.BT_solve.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_solve.BackColor = System.Drawing.Color.Transparent;
            this.BT_solve.FlatAppearance.BorderSize = 0;
            this.BT_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_solve.ForeColor = System.Drawing.Color.Black;
            this.BT_solve.Location = new System.Drawing.Point(756, 11);
            this.BT_solve.Name = "BT_solve";
            this.BT_solve.Size = new System.Drawing.Size(92, 23);
            this.BT_solve.TabIndex = 7;
            this.BT_solve.Text = "MARK AS SOLVE";
            this.BT_solve.UseVisualStyleBackColor = false;
            // 
            // BT_View
            // 
            this.BT_View.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_View.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_View.FlatAppearance.BorderSize = 0;
            this.BT_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_View.ForeColor = System.Drawing.Color.White;
            this.BT_View.Location = new System.Drawing.Point(687, 11);
            this.BT_View.Name = "BT_View";
            this.BT_View.Size = new System.Drawing.Size(62, 23);
            this.BT_View.TabIndex = 6;
            this.BT_View.Text = "VIEW";
            this.BT_View.UseVisualStyleBackColor = false;
            // 
            // failed_transactions_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.main_panel);
            this.Name = "failed_transactions_list";
            this.Text = "failed_transactions_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_solve;
        private System.Windows.Forms.Button BT_View;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel main_panel;
        public System.Windows.Forms.Label label_queue_identifier;
    }
}