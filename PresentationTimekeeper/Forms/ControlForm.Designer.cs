namespace PresentationTimekeeper.Forms
{
    partial class ControlForm
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.signPanel = new System.Windows.Forms.Panel();
            this.timeText = new System.Windows.Forms.Label();
            this.timeTextType = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.overtimeBehaviorLabel = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.settingButton = new System.Windows.Forms.Button();
            this.signPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(382, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(265, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(124, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "時間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "設定時間";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hourLabel.Location = new System.Drawing.Point(52, 45);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(72, 50);
            this.hourLabel.TabIndex = 11;
            this.hourLabel.Text = "00";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minuteLabel.Location = new System.Drawing.Point(193, 45);
            this.minuteLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(72, 50);
            this.minuteLabel.TabIndex = 12;
            this.minuteLabel.Text = "01";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Meiryo UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secondLabel.Location = new System.Drawing.Point(310, 45);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(72, 50);
            this.secondLabel.TabIndex = 13;
            this.secondLabel.Text = "00";
            // 
            // signPanel
            // 
            this.signPanel.BackColor = System.Drawing.Color.Black;
            this.signPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signPanel.Controls.Add(this.timeText);
            this.signPanel.Controls.Add(this.timeTextType);
            this.signPanel.Location = new System.Drawing.Point(611, 82);
            this.signPanel.Margin = new System.Windows.Forms.Padding(5);
            this.signPanel.Name = "signPanel";
            this.signPanel.Size = new System.Drawing.Size(668, 405);
            this.signPanel.TabIndex = 14;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.BackColor = System.Drawing.Color.Transparent;
            this.timeText.Font = new System.Drawing.Font("Meiryo UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(45, 130);
            this.timeText.Margin = new System.Windows.Forms.Padding(0);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(576, 143);
            this.timeText.TabIndex = 1;
            this.timeText.Text = "00:00:00";
            // 
            // timeTextType
            // 
            this.timeTextType.AutoSize = true;
            this.timeTextType.BackColor = System.Drawing.Color.Transparent;
            this.timeTextType.Font = new System.Drawing.Font("Meiryo UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeTextType.ForeColor = System.Drawing.Color.White;
            this.timeTextType.Location = new System.Drawing.Point(28, 32);
            this.timeTextType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeTextType.Name = "timeTextType";
            this.timeTextType.Size = new System.Drawing.Size(180, 55);
            this.timeTextType.TabIndex = 0;
            this.timeTextType.Text = "残り時間";
            // 
            // startStopButton
            // 
            this.startStopButton.Font = new System.Drawing.Font("Meiryo UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startStopButton.Location = new System.Drawing.Point(611, 498);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(5);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(452, 107);
            this.startStopButton.TabIndex = 15;
            this.startStopButton.Text = "スタート";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetButton.Location = new System.Drawing.Point(1072, 498);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(208, 107);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "設定時間経過後の挙動";
            // 
            // overtimeBehaviorLabel
            // 
            this.overtimeBehaviorLabel.AutoSize = true;
            this.overtimeBehaviorLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.overtimeBehaviorLabel.Location = new System.Drawing.Point(54, 141);
            this.overtimeBehaviorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.overtimeBehaviorLabel.Name = "overtimeBehaviorLabel";
            this.overtimeBehaviorLabel.Size = new System.Drawing.Size(82, 41);
            this.overtimeBehaviorLabel.TabIndex = 18;
            this.overtimeBehaviorLabel.Text = "停止";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // settingButton
            // 
            this.settingButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingButton.Location = new System.Drawing.Point(1103, 14);
            this.settingButton.Margin = new System.Windows.Forms.Padding(5);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(177, 53);
            this.settingButton.TabIndex = 19;
            this.settingButton.Text = "設定変更";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.overtimeBehaviorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.signPanel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Text = "PresentationTimeKeeper";
            this.signPanel.ResumeLayout(false);
            this.signPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Panel signPanel;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label timeTextType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label overtimeBehaviorLabel;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button settingButton;
    }
}