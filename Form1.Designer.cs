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
            this.button1 = new System.Windows.Forms.Button();
            this.save_me = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Is Shannon Cool?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_me
            // 
            this.save_me.Location = new System.Drawing.Point(664, 12);
            this.save_me.Name = "save_me";
            this.save_me.Size = new System.Drawing.Size(124, 56);
            this.save_me.TabIndex = 4;
            this.save_me.Text = "Save me!";
            this.save_me.UseVisualStyleBackColor = true;
            this.save_me.Click += new System.EventHandler(this.save_me_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save it!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save_me);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_me;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

