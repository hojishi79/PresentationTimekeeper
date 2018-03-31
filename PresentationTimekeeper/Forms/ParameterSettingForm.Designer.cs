namespace PresentationTimekeeper.Forms
{
    partial class ParameterSettingForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.secondUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.overtimeBehaviorGroup = new System.Windows.Forms.GroupBox();
            this.countupRadio = new System.Windows.Forms.RadioButton();
            this.stopRadio = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textColorButton = new System.Windows.Forms.Button();
            this.backGroundColorButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.omitHourCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBellButton = new System.Windows.Forms.Button();
            this.addColorChangeButton = new System.Windows.Forms.Button();
            this.colorChengeListPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bellChbList = new System.Windows.Forms.CheckedListBox();
            this.delBellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).BeginInit();
            this.overtimeBehaviorGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "設定時間";
            // 
            // hourUpDown
            // 
            this.hourUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hourUpDown.Location = new System.Drawing.Point(26, 54);
            this.hourUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.hourUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(119, 38);
            this.hourUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(154, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "時間";
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minuteUpDown.Location = new System.Drawing.Point(224, 54);
            this.minuteUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(119, 38);
            this.minuteUpDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(353, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "分";
            // 
            // secondUpDown
            // 
            this.secondUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secondUpDown.Location = new System.Drawing.Point(401, 54);
            this.secondUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.secondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondUpDown.Name = "secondUpDown";
            this.secondUpDown.Size = new System.Drawing.Size(119, 38);
            this.secondUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(530, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "秒";
            // 
            // overtimeBehaviorGroup
            // 
            this.overtimeBehaviorGroup.Controls.Add(this.countupRadio);
            this.overtimeBehaviorGroup.Controls.Add(this.stopRadio);
            this.overtimeBehaviorGroup.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.overtimeBehaviorGroup.Location = new System.Drawing.Point(26, 123);
            this.overtimeBehaviorGroup.Margin = new System.Windows.Forms.Padding(5);
            this.overtimeBehaviorGroup.Name = "overtimeBehaviorGroup";
            this.overtimeBehaviorGroup.Padding = new System.Windows.Forms.Padding(5);
            this.overtimeBehaviorGroup.Size = new System.Drawing.Size(396, 98);
            this.overtimeBehaviorGroup.TabIndex = 8;
            this.overtimeBehaviorGroup.TabStop = false;
            this.overtimeBehaviorGroup.Text = "設定時間経過後の挙動";
            // 
            // countupRadio
            // 
            this.countupRadio.AutoSize = true;
            this.countupRadio.Location = new System.Drawing.Point(162, 40);
            this.countupRadio.Margin = new System.Windows.Forms.Padding(5);
            this.countupRadio.Name = "countupRadio";
            this.countupRadio.Size = new System.Drawing.Size(188, 34);
            this.countupRadio.TabIndex = 1;
            this.countupRadio.Text = "超過時間表示";
            this.countupRadio.UseVisualStyleBackColor = true;
            // 
            // stopRadio
            // 
            this.stopRadio.AutoSize = true;
            this.stopRadio.Checked = true;
            this.stopRadio.Location = new System.Drawing.Point(24, 40);
            this.stopRadio.Margin = new System.Windows.Forms.Padding(5);
            this.stopRadio.Name = "stopRadio";
            this.stopRadio.Size = new System.Drawing.Size(92, 34);
            this.stopRadio.TabIndex = 0;
            this.stopRadio.TabStop = true;
            this.stopRadio.Text = "停止";
            this.stopRadio.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.submitButton.Location = new System.Drawing.Point(969, 34);
            this.submitButton.Margin = new System.Windows.Forms.Padding(5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(141, 74);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "決定";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelButton.Location = new System.Drawing.Point(1138, 34);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 74);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "文字色";
            // 
            // textColorButton
            // 
            this.textColorButton.BackColor = System.Drawing.Color.White;
            this.textColorButton.Location = new System.Drawing.Point(110, 44);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(76, 34);
            this.textColorButton.TabIndex = 12;
            this.textColorButton.UseVisualStyleBackColor = false;
            this.textColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // backGroundColorButton
            // 
            this.backGroundColorButton.BackColor = System.Drawing.Color.Black;
            this.backGroundColorButton.Location = new System.Drawing.Point(299, 43);
            this.backGroundColorButton.Name = "backGroundColorButton";
            this.backGroundColorButton.Size = new System.Drawing.Size(76, 34);
            this.backGroundColorButton.TabIndex = 14;
            this.backGroundColorButton.UseVisualStyleBackColor = false;
            this.backGroundColorButton.Click += new System.EventHandler(this.BackGroundColorButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "背景色";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.omitHourCheckBox);
            this.groupBox1.Controls.Add(this.backGroundColorButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textColorButton);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(442, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時間表示部";
            // 
            // omitHourCheckBox
            // 
            this.omitHourCheckBox.AutoSize = true;
            this.omitHourCheckBox.Location = new System.Drawing.Point(412, 43);
            this.omitHourCheckBox.Name = "omitHourCheckBox";
            this.omitHourCheckBox.Size = new System.Drawing.Size(408, 34);
            this.omitHourCheckBox.TabIndex = 15;
            this.omitHourCheckBox.Text = "\"時間\" 部分がゼロのときは表示しない";
            this.omitHourCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(21, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "ベル鳴動";
            // 
            // addBellButton
            // 
            this.addBellButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addBellButton.Location = new System.Drawing.Point(401, 238);
            this.addBellButton.Name = "addBellButton";
            this.addBellButton.Size = new System.Drawing.Size(107, 61);
            this.addBellButton.TabIndex = 18;
            this.addBellButton.Text = "追加";
            this.addBellButton.UseVisualStyleBackColor = true;
            this.addBellButton.Click += new System.EventHandler(this.AddBellButton_Click);
            // 
            // addColorChangeButton
            // 
            this.addColorChangeButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addColorChangeButton.Location = new System.Drawing.Point(1171, 238);
            this.addColorChangeButton.Name = "addColorChangeButton";
            this.addColorChangeButton.Size = new System.Drawing.Size(107, 61);
            this.addColorChangeButton.TabIndex = 21;
            this.addColorChangeButton.Text = "追加";
            this.addColorChangeButton.UseVisualStyleBackColor = true;
            // 
            // colorChengeListPanel
            // 
            this.colorChengeListPanel.AutoScroll = true;
            this.colorChengeListPanel.Location = new System.Drawing.Point(677, 313);
            this.colorChengeListPanel.Name = "colorChengeListPanel";
            this.colorChengeListPanel.Size = new System.Drawing.Size(601, 395);
            this.colorChengeListPanel.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(672, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "文字色／背景色変更";
            // 
            // bellChbList
            // 
            this.bellChbList.CheckOnClick = true;
            this.bellChbList.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bellChbList.FormattingEnabled = true;
            this.bellChbList.Location = new System.Drawing.Point(26, 313);
            this.bellChbList.Name = "bellChbList";
            this.bellChbList.Size = new System.Drawing.Size(602, 400);
            this.bellChbList.TabIndex = 22;
            // 
            // delBellButton
            // 
            this.delBellButton.Enabled = false;
            this.delBellButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delBellButton.Location = new System.Drawing.Point(521, 238);
            this.delBellButton.Name = "delBellButton";
            this.delBellButton.Size = new System.Drawing.Size(107, 61);
            this.delBellButton.TabIndex = 23;
            this.delBellButton.Text = "削除";
            this.delBellButton.UseVisualStyleBackColor = true;
            this.delBellButton.Click += new System.EventHandler(this.DelBellButton_Click);
            // 
            // ParameterSettingForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1310, 734);
            this.Controls.Add(this.delBellButton);
            this.Controls.Add(this.bellChbList);
            this.Controls.Add(this.addColorChangeButton);
            this.Controls.Add(this.colorChengeListPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addBellButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.overtimeBehaviorGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minuteUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParameterSettingForm";
            this.Text = "設定 | PresentationTimekeeper";
            this.Load += new System.EventHandler(this.ParameterSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).EndInit();
            this.overtimeBehaviorGroup.ResumeLayout(false);
            this.overtimeBehaviorGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown secondUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox overtimeBehaviorGroup;
        private System.Windows.Forms.RadioButton countupRadio;
        private System.Windows.Forms.RadioButton stopRadio;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button backGroundColorButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox omitHourCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBellButton;
        private System.Windows.Forms.Button addColorChangeButton;
        private System.Windows.Forms.Panel colorChengeListPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox bellChbList;
        private System.Windows.Forms.Button delBellButton;
    }
}

