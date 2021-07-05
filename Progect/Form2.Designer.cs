
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
            this.pole = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uch
            // 
            this.uch.AutoSize = true;
            this.uch.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uch.Location = new System.Drawing.Point(398, 75);
            this.uch.Name = "uch";
            this.uch.Size = new System.Drawing.Size(331, 47);
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
            this.druz.Location = new System.Drawing.Point(398, 22);
            this.druz.Name = "druz";
            this.druz.Size = new System.Drawing.Size(266, 47);
            this.druz.TabIndex = 4;
            this.druz.TabStop = true;
            this.druz.Text = "Список друзей";
            this.druz.UseVisualStyleBackColor = true;
            this.druz.CheckedChanged += new System.EventHandler(this.druz_CheckedChanged);
            // 
            // vivod
            // 
            this.vivod.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivod.Location = new System.Drawing.Point(398, 142);
            this.vivod.Name = "vivod";
            this.vivod.Size = new System.Drawing.Size(331, 49);
            this.vivod.TabIndex = 6;
            this.vivod.Text = "вывод";
            this.vivod.UseVisualStyleBackColor = true;
            this.vivod.Click += new System.EventHandler(this.vivod_Click);
            // 
            // pole
            // 
            this.pole.FormattingEnabled = true;
            this.pole.Location = new System.Drawing.Point(29, 12);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(312, 446);
            this.pole.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 487);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.uch);
            this.Controls.Add(this.druz);
            this.Name = "Form2";
            this.Text = "API VK";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton uch;
        private System.Windows.Forms.RadioButton druz;
        private System.Windows.Forms.Button vivod;
        private System.Windows.Forms.ListBox pole;
    }
}