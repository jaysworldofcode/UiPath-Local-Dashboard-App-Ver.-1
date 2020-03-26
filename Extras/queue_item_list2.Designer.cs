using System.Windows.Forms;

namespace WindowsFormsApp1.Extras
{
    partial class queue_item_list2 : Form
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
            this.label_reference = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_type = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.Label();
            this.Created = new System.Windows.Forms.Label();
            this.Started = new System.Windows.Forms.Label();
            this.Ended = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BackColor = System.Drawing.Color.White;
            this.main_panel.Controls.Add(this.Ended);
            this.main_panel.Controls.Add(this.Started);
            this.main_panel.Controls.Add(this.Created);
            this.main_panel.Controls.Add(this.Priority);
            this.main_panel.Controls.Add(this.label_reference);
            this.main_panel.Controls.Add(this.panel2);
            this.main_panel.Controls.Add(this.label_type);
            this.main_panel.Location = new System.Drawing.Point(160, 250);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1128, 54);
            this.main_panel.TabIndex = 1;
            // 
            // label_reference
            // 
            this.label_reference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_reference.AutoSize = true;
            this.label_reference.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reference.Location = new System.Drawing.Point(179, 18);
            this.label_reference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reference.Name = "label_reference";
            this.label_reference.Size = new System.Drawing.Size(68, 23);
            this.label_reference.TabIndex = 13;
            this.label_reference.Text = "Reference";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 1);
            this.panel2.TabIndex = 11;
            // 
            // label_type
            // 
            this.label_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_type.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(23, 15);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(49, 28);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "INFO";
            // 
            // Priority
            // 
            this.Priority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Priority.AutoSize = true;
            this.Priority.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priority.Location = new System.Drawing.Point(420, 17);
            this.Priority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(52, 23);
            this.Priority.TabIndex = 14;
            this.Priority.Text = "Priority";
            // 
            // Created
            // 
            this.Created.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Created.AutoSize = true;
            this.Created.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Created.Location = new System.Drawing.Point(604, 17);
            this.Created.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(56, 23);
            this.Created.TabIndex = 15;
            this.Created.Text = "Created";
            // 
            // Started
            // 
            this.Started.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Started.AutoSize = true;
            this.Started.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Started.Location = new System.Drawing.Point(782, 18);
            this.Started.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Started.Name = "Started";
            this.Started.Size = new System.Drawing.Size(53, 23);
            this.Started.TabIndex = 16;
            this.Started.Text = "Started";
            // 
            // Ended
            // 
            this.Ended.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ended.AutoSize = true;
            this.Ended.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ended.Location = new System.Drawing.Point(958, 20);
            this.Ended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ended.Name = "Ended";
            this.Ended.Size = new System.Drawing.Size(47, 23);
            this.Ended.TabIndex = 17;
            this.Ended.Text = "Ended";
            // 
            // queue_item_list2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 554);
            this.Controls.Add(this.main_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "queue_item_list2";
            this.Text = "queue_items_list";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label_reference;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_type;
        private Label Created;
        private Label Priority;
        private Label Ended;
        private Label Started;
    }
}