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
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).BeginInit();
            this.overtimeBehaviorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "設定時間";
            // 
            // hourUpDown
            // 
            this.hourUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hourUpDown.Location = new System.Drawing.Point(16, 34);
            this.hourUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(73, 27);
            this.hourUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(95, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "時間";
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minuteUpDown.Location = new System.Drawing.Point(138, 34);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(73, 27);
            this.minuteUpDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(217, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "分";
            // 
            // secondUpDown
            // 
            this.secondUpDown.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.secondUpDown.Location = new System.Drawing.Point(247, 34);
            this.secondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondUpDown.Name = "secondUpDown";
            this.secondUpDown.Size = new System.Drawing.Size(73, 27);
            this.secondUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(326, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "秒";
            // 
            // overtimeBehaviorGroup
            // 
            this.overtimeBehaviorGroup.Controls.Add(this.countupRadio);
            this.overtimeBehaviorGroup.Controls.Add(this.stopRadio);
            this.overtimeBehaviorGroup.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.overtimeBehaviorGroup.Location = new System.Drawing.Point(16, 77);
            this.overtimeBehaviorGroup.Name = "overtimeBehaviorGroup";
            this.overtimeBehaviorGroup.Size = new System.Drawing.Size(244, 61);
            this.overtimeBehaviorGroup.TabIndex = 8;
            this.overtimeBehaviorGroup.TabStop = false;
            this.overtimeBehaviorGroup.Text = "設定時間経過後の挙動";
            // 
            // countupRadio
            // 
            this.countupRadio.AutoSize = true;
            this.countupRadio.Location = new System.Drawing.Point(100, 25);
            this.countupRadio.Name = "countupRadio";
            this.countupRadio.Size = new System.Drawing.Size(120, 23);
            this.countupRadio.TabIndex = 1;
            this.countupRadio.Text = "超過時間表示";
            this.countupRadio.UseVisualStyleBackColor = true;
            // 
            // stopRadio
            // 
            this.stopRadio.AutoSize = true;
            this.stopRadio.Checked = true;
            this.stopRadio.Location = new System.Drawing.Point(15, 25);
            this.stopRadio.Name = "stopRadio";
            this.stopRadio.Size = new System.Drawing.Size(60, 23);
            this.stopRadio.TabIndex = 0;
            this.stopRadio.TabStop = true;
            this.stopRadio.Text = "停止";
            this.stopRadio.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.submitButton.Location = new System.Drawing.Point(598, 13);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(87, 46);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "決定";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancelButton.Location = new System.Drawing.Point(702, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 46);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ParameterSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "ParameterSettingForm";
            this.Text = "設定 | PresentationTimekeeper";
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).EndInit();
            this.overtimeBehaviorGroup.ResumeLayout(false);
            this.overtimeBehaviorGroup.PerformLayout();
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
    }
}

