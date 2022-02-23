namespace SCREENSHOT_TAKER
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
            this.capture_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // capture_BTN
            // 
            this.capture_BTN.Location = new System.Drawing.Point(182, 114);
            this.capture_BTN.Name = "capture_BTN";
            this.capture_BTN.Size = new System.Drawing.Size(75, 23);
            this.capture_BTN.TabIndex = 0;
            this.capture_BTN.Text = "Capture";
            this.capture_BTN.UseVisualStyleBackColor = true;
            this.capture_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 258);
            this.Controls.Add(this.capture_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button capture_BTN;
    }
}

