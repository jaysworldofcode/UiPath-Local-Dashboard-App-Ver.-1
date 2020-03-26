namespace WindowsFormsApp1
{
    partial class New_Schedule
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
            this.label7 = new System.Windows.Forms.Label();
            this.CB_robot_list = new System.Windows.Forms.ComboBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_add_schedule = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TF_minute = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TF_hour = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_saturday = new System.Windows.Forms.CheckBox();
            this.CB_friday = new System.Windows.Forms.CheckBox();
            this.CB_thursday = new System.Windows.Forms.CheckBox();
            this.CB_wednesday = new System.Windows.Forms.CheckBox();
            this.CB_tuesday = new System.Windows.Forms.CheckBox();
            this.CB_monday = new System.Windows.Forms.CheckBox();
            this.CB_sunday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TF_schedule_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MainPanel.SuspendLayout();
            this.queue_list.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MainPanel.TabIndex = 3;
            // 
            // queue_list
            // 
            this.queue_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queue_list.BackColor = System.Drawing.Color.White;
            this.queue_list.Controls.Add(this.label7);
            this.queue_list.Controls.Add(this.CB_robot_list);
            this.queue_list.Controls.Add(this.BT_Cancel);
            this.queue_list.Controls.Add(this.BT_add_schedule);
            this.queue_list.Controls.Add(this.label6);
            this.queue_list.Controls.Add(this.label3);
            this.queue_list.Controls.Add(this.TF_minute);
            this.queue_list.Controls.Add(this.TF_hour);
            this.queue_list.Controls.Add(this.label2);
            this.queue_list.Controls.Add(this.panel1);
            this.queue_list.Controls.Add(this.label5);
            this.queue_list.Controls.Add(this.TF_schedule_name);
            this.queue_list.Location = new System.Drawing.Point(0, 59);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(891, 657);
            this.queue_list.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(155, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Robot name";
            // 
            // CB_robot_list
            // 
            this.CB_robot_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_robot_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_robot_list.Font = new System.Drawing.Font("Hind Siliguri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_robot_list.FormattingEnabled = true;
            this.CB_robot_list.Location = new System.Drawing.Point(154, 180);
            this.CB_robot_list.Name = "CB_robot_list";
            this.CB_robot_list.Size = new System.Drawing.Size(550, 30);
            this.CB_robot_list.TabIndex = 26;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BT_Cancel.FlatAppearance.BorderSize = 0;
            this.BT_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancel.ForeColor = System.Drawing.Color.Black;
            this.BT_Cancel.Location = new System.Drawing.Point(160, 541);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 28);
            this.BT_Cancel.TabIndex = 25;
            this.BT_Cancel.Text = "CANCEL";
            this.BT_Cancel.UseVisualStyleBackColor = false;
            // 
            // BT_add_schedule
            // 
            this.BT_add_schedule.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_add_schedule.FlatAppearance.BorderSize = 0;
            this.BT_add_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_add_schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_add_schedule.ForeColor = System.Drawing.Color.White;
            this.BT_add_schedule.Location = new System.Drawing.Point(247, 541);
            this.BT_add_schedule.Name = "BT_add_schedule";
            this.BT_add_schedule.Size = new System.Drawing.Size(75, 28);
            this.BT_add_schedule.TabIndex = 24;
            this.BT_add_schedule.Text = "ADD";
            this.BT_add_schedule.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(283, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(180, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hour";
            // 
            // TF_minute
            // 
            this.TF_minute.Depth = 0;
            this.TF_minute.Hint = "";
            this.TF_minute.Location = new System.Drawing.Point(263, 425);
            this.TF_minute.MaxLength = 32767;
            this.TF_minute.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_minute.Name = "TF_minute";
            this.TF_minute.PasswordChar = '\0';
            this.TF_minute.SelectedText = "";
            this.TF_minute.SelectionLength = 0;
            this.TF_minute.SelectionStart = 0;
            this.TF_minute.Size = new System.Drawing.Size(84, 23);
            this.TF_minute.TabIndex = 18;
            this.TF_minute.TabStop = false;
            this.TF_minute.UseSystemPasswordChar = false;
            // 
            // TF_hour
            // 
            this.TF_hour.Depth = 0;
            this.TF_hour.Hint = "";
            this.TF_hour.Location = new System.Drawing.Point(154, 425);
            this.TF_hour.MaxLength = 32767;
            this.TF_hour.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_hour.Name = "TF_hour";
            this.TF_hour.PasswordChar = '\0';
            this.TF_hour.SelectedText = "";
            this.TF_hour.SelectionLength = 0;
            this.TF_hour.SelectionStart = 0;
            this.TF_hour.Size = new System.Drawing.Size(84, 23);
            this.TF_hour.TabIndex = 17;
            this.TF_hour.TabStop = false;
            this.TF_hour.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(155, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Day";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CB_saturday);
            this.panel1.Controls.Add(this.CB_friday);
            this.panel1.Controls.Add(this.CB_thursday);
            this.panel1.Controls.Add(this.CB_wednesday);
            this.panel1.Controls.Add(this.CB_tuesday);
            this.panel1.Controls.Add(this.CB_monday);
            this.panel1.Controls.Add(this.CB_sunday);
            this.panel1.Location = new System.Drawing.Point(154, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 139);
            this.panel1.TabIndex = 15;
            // 
            // CB_saturday
            // 
            this.CB_saturday.AutoSize = true;
            this.CB_saturday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_saturday.Location = new System.Drawing.Point(125, 68);
            this.CB_saturday.Name = "CB_saturday";
            this.CB_saturday.Size = new System.Drawing.Size(67, 22);
            this.CB_saturday.TabIndex = 6;
            this.CB_saturday.Text = "Saturday";
            this.CB_saturday.UseVisualStyleBackColor = true;
            // 
            // CB_friday
            // 
            this.CB_friday.AutoSize = true;
            this.CB_friday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_friday.Location = new System.Drawing.Point(125, 43);
            this.CB_friday.Name = "CB_friday";
            this.CB_friday.Size = new System.Drawing.Size(53, 22);
            this.CB_friday.TabIndex = 5;
            this.CB_friday.Text = "Friday";
            this.CB_friday.UseVisualStyleBackColor = true;
            // 
            // CB_thursday
            // 
            this.CB_thursday.AutoSize = true;
            this.CB_thursday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_thursday.Location = new System.Drawing.Point(125, 18);
            this.CB_thursday.Name = "CB_thursday";
            this.CB_thursday.Size = new System.Drawing.Size(67, 22);
            this.CB_thursday.TabIndex = 4;
            this.CB_thursday.Text = "Thursday";
            this.CB_thursday.UseVisualStyleBackColor = true;
            // 
            // CB_wednesday
            // 
            this.CB_wednesday.AutoSize = true;
            this.CB_wednesday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_wednesday.Location = new System.Drawing.Point(19, 93);
            this.CB_wednesday.Name = "CB_wednesday";
            this.CB_wednesday.Size = new System.Drawing.Size(81, 22);
            this.CB_wednesday.TabIndex = 3;
            this.CB_wednesday.Text = "Wednesday";
            this.CB_wednesday.UseVisualStyleBackColor = true;
            // 
            // CB_tuesday
            // 
            this.CB_tuesday.AutoSize = true;
            this.CB_tuesday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_tuesday.Location = new System.Drawing.Point(19, 68);
            this.CB_tuesday.Name = "CB_tuesday";
            this.CB_tuesday.Size = new System.Drawing.Size(64, 22);
            this.CB_tuesday.TabIndex = 2;
            this.CB_tuesday.Text = "Tuesday";
            this.CB_tuesday.UseVisualStyleBackColor = true;
            // 
            // CB_monday
            // 
            this.CB_monday.AutoSize = true;
            this.CB_monday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_monday.Location = new System.Drawing.Point(19, 43);
            this.CB_monday.Name = "CB_monday";
            this.CB_monday.Size = new System.Drawing.Size(64, 22);
            this.CB_monday.TabIndex = 1;
            this.CB_monday.Text = "Monday";
            this.CB_monday.UseVisualStyleBackColor = true;
            // 
            // CB_sunday
            // 
            this.CB_sunday.AutoSize = true;
            this.CB_sunday.Font = new System.Drawing.Font("Hind Siliguri Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sunday.Location = new System.Drawing.Point(19, 18);
            this.CB_sunday.Name = "CB_sunday";
            this.CB_sunday.Size = new System.Drawing.Size(61, 22);
            this.CB_sunday.TabIndex = 0;
            this.CB_sunday.Text = "Sunday";
            this.CB_sunday.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(155, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Schedule name";
            // 
            // TF_schedule_name
            // 
            this.TF_schedule_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TF_schedule_name.Depth = 0;
            this.TF_schedule_name.Hint = "";
            this.TF_schedule_name.Location = new System.Drawing.Point(154, 95);
            this.TF_schedule_name.MaxLength = 32767;
            this.TF_schedule_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.TF_schedule_name.Name = "TF_schedule_name";
            this.TF_schedule_name.PasswordChar = '\0';
            this.TF_schedule_name.SelectedText = "";
            this.TF_schedule_name.SelectionLength = 0;
            this.TF_schedule_name.SelectionStart = 0;
            this.TF_schedule_name.Size = new System.Drawing.Size(550, 23);
            this.TF_schedule_name.TabIndex = 13;
            this.TF_schedule_name.TabStop = false;
            this.TF_schedule_name.UseSystemPasswordChar = false;
            // 
            // New_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.MainPanel);
            this.Name = "New_Schedule";
            this.Text = "New_Schedule";
            this.MainPanel.ResumeLayout(false);
            this.queue_list.ResumeLayout(false);
            this.queue_list.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel queue_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox CB_sunday;
        public System.Windows.Forms.CheckBox CB_wednesday;
        public System.Windows.Forms.CheckBox CB_tuesday;
        public System.Windows.Forms.CheckBox CB_monday;
        public System.Windows.Forms.CheckBox CB_saturday;
        public System.Windows.Forms.CheckBox CB_friday;
        public System.Windows.Forms.CheckBox CB_thursday;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_schedule_name;
        public System.Windows.Forms.ComboBox CB_robot_list;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_hour;
        public MaterialSkin.Controls.MaterialSingleLineTextField TF_minute;
        public System.Windows.Forms.Button BT_add_schedule;
    }
}