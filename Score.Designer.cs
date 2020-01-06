namespace DontScrewAround
{
    partial class Score
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wyniki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(598, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOP1: brak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(596, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOP2: brak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(596, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOP3: brak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(596, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOP4: brak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(598, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOP5: brak";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(601, 868);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::DontScrewAround.Properties.Resources.layout_rozgrywki;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1278, 982);
            this.Name = "Score";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}