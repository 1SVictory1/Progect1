
namespace Progect
{
    partial class Form2
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
            this.uch = new System.Windows.Forms.RadioButton();
            this.druz = new System.Windows.Forms.RadioButton();
            this.vivod = new System.Windows.Forms.Button();
            this.dalee = new System.Windows.Forms.Button();
            this.pole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uch
            // 
            this.uch.AutoSize = true;
            this.uch.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uch.Location = new System.Drawing.Point(547, 140);
            this.uch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uch.Name = "uch";
            this.uch.Size = new System.Drawing.Size(411, 58);
            this.uch.TabIndex = 5;
            this.uch.TabStop = true;
            this.uch.Text = "Список участников";
            this.uch.UseVisualStyleBackColor = true;
            this.uch.CheckedChanged += new System.EventHandler(this.uch_CheckedChanged);
            // 
            // druz
            // 
            this.druz.AutoSize = true;
            this.druz.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.druz.Location = new System.Drawing.Point(636, 19);
            this.druz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.druz.Name = "druz";
            this.druz.Size = new System.Drawing.Size(329, 58);
            this.druz.TabIndex = 4;
            this.druz.TabStop = true;
            this.druz.Text = "Список друзей";
            this.druz.UseVisualStyleBackColor = true;
            this.druz.CheckedChanged += new System.EventHandler(this.druz_CheckedChanged);
            // 
            // vivod
            // 
            this.vivod.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivod.Location = new System.Drawing.Point(570, 266);
            this.vivod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(441, 60);
            this.vivod.TabIndex = 6;
            this.vivod.Text = "вывод";
            this.vivod.UseVisualStyleBackColor = true;
            this.vivod.Click += new System.EventHandler(this.vivod_Click);
            // 
            // dalee
            // 
            this.dalee.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dalee.Location = new System.Drawing.Point(855, 503);
            this.dalee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dalee.Name = "dalee";
            this.dalee.Size = new System.Drawing.Size(168, 60);
            this.dalee.TabIndex = 8;
            this.dalee.Text = "далее";
            this.dalee.UseVisualStyleBackColor = true;
            this.dalee.Click += new System.EventHandler(this.dalee_Click);
            // 
            // pole
            // 
            this.pole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pole.Location = new System.Drawing.Point(28, 83);
            this.pole.Multiline = true;
            this.pole.Name = "pole";
            this.pole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pole.Size = new System.Drawing.Size(364, 480);
            this.pole.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Всего человек:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Друзья пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(612, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID пользователя:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(803, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 28);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBoxes_TestChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(612, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID сообщества:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(803, 217);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 28);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBoxes_TestChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 599);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.dalee);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.uch);
            this.Controls.Add(this.druz);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API VK";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TextChanged += new System.EventHandler(this.TextBoxes_TestChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton uch;
        private System.Windows.Forms.RadioButton druz;
        private System.Windows.Forms.Button vivod;
        private System.Windows.Forms.Button dalee;
        private System.Windows.Forms.TextBox pole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}