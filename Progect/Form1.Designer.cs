
namespace Progect
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pol = new System.Windows.Forms.RadioButton();
            this.grupp = new System.Windows.Forms.RadioButton();
            this.sogl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(49, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pol
            // 
            this.pol.AutoSize = true;
            this.pol.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pol.Location = new System.Drawing.Point(49, 42);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(255, 47);
            this.pol.TabIndex = 2;
            this.pol.TabStop = true;
            this.pol.Text = "Пользователь";
            this.pol.UseVisualStyleBackColor = true;
            // 
            // grupp
            // 
            this.grupp.AutoSize = true;
            this.grupp.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grupp.Location = new System.Drawing.Point(49, 135);
            this.grupp.Name = "grupp";
            this.grupp.Size = new System.Drawing.Size(141, 47);
            this.grupp.TabIndex = 3;
            this.grupp.TabStop = true;
            this.grupp.Text = "Группа";
            this.grupp.UseVisualStyleBackColor = true;
            this.grupp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sogl
            // 
            this.sogl.AutoSize = true;
            this.sogl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sogl.Location = new System.Drawing.Point(49, 292);
            this.sogl.Name = "sogl";
            this.sogl.Size = new System.Drawing.Size(463, 22);
            this.sogl.TabIndex = 4;
            this.sogl.Text = "Я подтверждаю согласие на обработку персональных данных";
            this.sogl.UseVisualStyleBackColor = true;
            this.sogl.CheckedChanged += new System.EventHandler(this.sogl_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.sogl);
            this.Controls.Add(this.grupp);
            this.Controls.Add(this.pol);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "API VK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton pol;
        private System.Windows.Forms.RadioButton grupp;
        private System.Windows.Forms.CheckBox sogl;
    }
}

