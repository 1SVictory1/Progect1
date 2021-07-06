
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
            this.SuspendLayout();
            // 
            // uch
            // 
            this.uch.AutoSize = true;
            this.uch.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uch.Location = new System.Drawing.Point(597, 115);
            this.uch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uch.Name = "uch";
            this.uch.Size = new System.Drawing.Size(495, 69);
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
            this.druz.Location = new System.Drawing.Point(597, 34);
            this.druz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.druz.Name = "druz";
            this.druz.Size = new System.Drawing.Size(398, 69);
            this.druz.TabIndex = 4;
            this.druz.TabStop = true;
            this.druz.Text = "Список друзей";
            this.druz.UseVisualStyleBackColor = true;
            this.druz.CheckedChanged += new System.EventHandler(this.druz_CheckedChanged);
            // 
            // vivod
            // 
            this.vivod.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivod.Location = new System.Drawing.Point(597, 219);
            this.vivod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(496, 75);
            this.vivod.TabIndex = 6;
            this.vivod.Text = "вывод";
            this.vivod.UseVisualStyleBackColor = true;
            this.vivod.Click += new System.EventHandler(this.vivod_Click);
            // 
            // dalee
            // 
            this.dalee.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dalee.Location = new System.Drawing.Point(962, 629);
            this.dalee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dalee.Name = "dalee";
            this.dalee.Size = new System.Drawing.Size(189, 75);
            this.dalee.TabIndex = 8;
            this.dalee.Text = "далее";
            this.dalee.UseVisualStyleBackColor = true;
            this.dalee.Click += new System.EventHandler(this.dalee_Click);
            // 
            // pole
            // 
            this.pole.Location = new System.Drawing.Point(32, 34);
            this.pole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pole.Multiline = true;
            this.pole.Name = "pole";
            this.pole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pole.Size = new System.Drawing.Size(409, 669);
            this.pole.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.dalee);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.uch);
            this.Controls.Add(this.druz);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "API VK";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton uch;
        private System.Windows.Forms.RadioButton druz;
        private System.Windows.Forms.Button vivod;
        private System.Windows.Forms.Button dalee;
        private System.Windows.Forms.TextBox pole;
    }
}