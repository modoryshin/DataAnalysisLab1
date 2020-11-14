namespace DataAnalysisLab1
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 12);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(776, 181);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbOutput.Location = new System.Drawing.Point(12, 257);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(776, 181);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(329, 213);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(133, 24);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Преобразовать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Name = "Form1";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnConvert;
    }
}

