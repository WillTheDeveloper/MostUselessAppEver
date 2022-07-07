namespace JustAnotherApplication
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
            this.press_01 = new System.Windows.Forms.Button();
            this.text_01 = new System.Windows.Forms.Label();
            this.press_02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // press_01
            // 
            this.press_01.Location = new System.Drawing.Point(683, 394);
            this.press_01.Name = "press_01";
            this.press_01.Size = new System.Drawing.Size(105, 44);
            this.press_01.TabIndex = 0;
            this.press_01.Text = "Press me!";
            this.press_01.UseVisualStyleBackColor = true;
            this.press_01.Click += new System.EventHandler(this.press_01_Click);
            // 
            // text_01
            // 
            this.text_01.AutoSize = true;
            this.text_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_01.Location = new System.Drawing.Point(293, 193);
            this.text_01.Name = "text_01";
            this.text_01.Size = new System.Drawing.Size(162, 46);
            this.text_01.TabIndex = 1;
            this.text_01.Text = "HELLO!";
            this.text_01.Click += new System.EventHandler(this.text_01_Click);
            // 
            // press_02
            // 
            this.press_02.Location = new System.Drawing.Point(12, 12);
            this.press_02.Name = "press_02";
            this.press_02.Size = new System.Drawing.Size(105, 44);
            this.press_02.TabIndex = 2;
            this.press_02.Text = "Press me!";
            this.press_02.UseVisualStyleBackColor = true;
            this.press_02.Click += new System.EventHandler(this.press_02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.press_02);
            this.Controls.Add(this.text_01);
            this.Controls.Add(this.press_01);
            this.Name = "Form1";
            this.Text = "Bonk Bonk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button press_01;
        private System.Windows.Forms.Label text_01;
        private System.Windows.Forms.Button press_02;
    }
}

