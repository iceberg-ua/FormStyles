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
            this.button2 = new System.Windows.Forms.Button();
            this._windowStyleExGB = new System.Windows.Forms.GroupBox();
            this._classStyleGB = new System.Windows.Forms.GroupBox();
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
            this.button1.Location = new System.Drawing.Point(3, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // _windowStyleExGB
            // 
            this._windowStyleExGB.Location = new System.Drawing.Point(172, 12);
            this._windowStyleExGB.Name = "_windowStyleExGB";
            this._windowStyleExGB.Size = new System.Drawing.Size(124, 22);
            this._windowStyleExGB.TabIndex = 3;
            this._windowStyleExGB.TabStop = false;
            this._windowStyleExGB.Text = "WindowExStyle";
            // 
            // _classStyleGB
            // 
            this._classStyleGB.Location = new System.Drawing.Point(388, 12);
            this._classStyleGB.Name = "_classStyleGB";
            this._classStyleGB.Size = new System.Drawing.Size(124, 22);
            this._classStyleGB.TabIndex = 4;
            this._classStyleGB.TabStop = false;
            this._classStyleGB.Text = "WindowClassStyle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(405, 304);
            this.Controls.Add(this._classStyleGB);
            this.Controls.Add(this._windowStyleExGB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._windowStyleGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "FormStyling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _windowStyleGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox _windowStyleExGB;
        private System.Windows.Forms.GroupBox _classStyleGB;
    }
}

