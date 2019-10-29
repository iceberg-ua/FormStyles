namespace FormStyles
{
    partial class MainForm
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
            this._windowStyleGB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _windowStyleGB
            // 
            this._windowStyleGB.Location = new System.Drawing.Point(12, 12);
            this._windowStyleGB.Name = "_windowStyleGB";
            this._windowStyleGB.Size = new System.Drawing.Size(101, 20);
            this._windowStyleGB.TabIndex = 0;
            this._windowStyleGB.TabStop = false;
            this._windowStyleGB.Text = "WindowStyle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._windowStyleGB);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _windowStyleGB;
        private System.Windows.Forms.Button button1;
    }
}

