namespace PCShutdownTimer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.minuteComboBox = new System.Windows.Forms.ComboBox();
            this.colonLabel = new System.Windows.Forms.Label();
            this.alarmCheckBox = new System.Windows.Forms.CheckBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Agency FB", 35.25F);
            this.timeLabel.Location = new System.Drawing.Point(12, 21);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(364, 87);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourComboBox
            // 
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Location = new System.Drawing.Point(104, 118);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(49, 20);
            this.hourComboBox.TabIndex = 2;
            this.hourComboBox.SelectionChangeCommitted += new System.EventHandler(this.hourComboBox_SelectionChangeCommitted);
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Location = new System.Drawing.Point(190, 118);
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(53, 20);
            this.minuteComboBox.TabIndex = 3;
            this.minuteComboBox.SelectionChangeCommitted += new System.EventHandler(this.minuteComboBox_SelectionChangeCommitted);
            // 
            // colonLabel
            // 
            this.colonLabel.Font = new System.Drawing.Font("Marlett", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabel.Location = new System.Drawing.Point(159, 115);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(25, 23);
            this.colonLabel.TabIndex = 4;
            this.colonLabel.Text = ":";
            this.colonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmCheckBox
            // 
            this.alarmCheckBox.AutoSize = true;
            this.alarmCheckBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.alarmCheckBox.Location = new System.Drawing.Point(71, 121);
            this.alarmCheckBox.Name = "alarmCheckBox";
            this.alarmCheckBox.Size = new System.Drawing.Size(15, 14);
            this.alarmCheckBox.TabIndex = 5;
            this.alarmCheckBox.UseVisualStyleBackColor = false;
            this.alarmCheckBox.Click += new System.EventHandler(this.alarmCheckBox_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Location = new System.Drawing.Point(12, 121);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(50, 17);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "Таймер";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 149);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.alarmCheckBox);
            this.Controls.Add(this.colonLabel);
            this.Controls.Add(this.minuteComboBox);
            this.Controls.Add(this.hourComboBox);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Таймер выключения компьютера";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.ComboBox minuteComboBox;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.CheckBox alarmCheckBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

