namespace PresentationTimekeeper.Forms
{
    partial class TimeSignForm
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
            this.timeTextType = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeTextType
            // 
            this.timeTextType.AutoSize = true;
            this.timeTextType.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeTextType.ForeColor = System.Drawing.Color.White;
            this.timeTextType.Location = new System.Drawing.Point(21, 21);
            this.timeTextType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeTextType.Name = "timeTextType";
            this.timeTextType.Size = new System.Drawing.Size(400, 122);
            this.timeTextType.TabIndex = 0;
            this.timeTextType.Text = "残り時間";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Meiryo UI", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(209, 278);
            this.timeText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(1156, 272);
            this.timeText.TabIndex = 1;
            this.timeText.Text = "00:00:00";
            this.timeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1574, 829);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.timeTextType);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "TimeSignForm";
            this.Text = "TimeSignForm";
            this.Load += new System.EventHandler(this.TimeSignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeTextType;
        private System.Windows.Forms.Label timeText;
    }
}