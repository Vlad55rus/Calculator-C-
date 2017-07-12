namespace CalculatorVladDanil
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.textBoxEntering1 = new System.Windows.Forms.TextBox();
            this.textBoxEntering2 = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.Module = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Arccosinus = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Button();
            this.Arcsinus = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(10, 98);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(58, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(74, 98);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(58, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(138, 98);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(66, 23);
            this.buttonMulti.TabIndex = 2;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(210, 98);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 23);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Clicking);
            // 
            // textBoxEntering1
            // 
            this.textBoxEntering1.Location = new System.Drawing.Point(21, 41);
            this.textBoxEntering1.Name = "textBoxEntering1";
            this.textBoxEntering1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering1.TabIndex = 4;
            // 
            // textBoxEntering2
            // 
            this.textBoxEntering2.Location = new System.Drawing.Point(154, 41);
            this.textBoxEntering2.Name = "textBoxEntering2";
            this.textBoxEntering2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering2.TabIndex = 5;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(121, 98);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 13);
            this.labelOut.TabIndex = 6;
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(13, 128);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(75, 23);
            this.Module.TabIndex = 7;
            this.Module.Text = "Mod";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(94, 128);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(75, 23);
            this.Cosinus.TabIndex = 8;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(13, 157);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 9;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Arccosinus
            // 
            this.Arccosinus.Location = new System.Drawing.Point(94, 157);
            this.Arccosinus.Name = "Arccosinus";
            this.Arccosinus.Size = new System.Drawing.Size(75, 23);
            this.Arccosinus.TabIndex = 10;
            this.Arccosinus.Text = "Arccos";
            this.Arccosinus.UseVisualStyleBackColor = true;
            this.Arccosinus.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(13, 186);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(75, 23);
            this.Binary.TabIndex = 11;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(94, 186);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 23);
            this.Square.TabIndex = 12;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(13, 215);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(75, 23);
            this.Factorial.TabIndex = 13;
            this.Factorial.Text = "Factorial";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(94, 215);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(75, 23);
            this.Ten.TabIndex = 14;
            this.Ten.Text = "10^x";
            this.Ten.UseVisualStyleBackColor = true;
            this.Ten.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Arcsinus
            // 
            this.Arcsinus.Location = new System.Drawing.Point(175, 157);
            this.Arcsinus.Name = "Arcsinus";
            this.Arcsinus.Size = new System.Drawing.Size(75, 23);
            this.Arcsinus.TabIndex = 15;
            this.Arcsinus.Text = "Arcsin";
            this.Arcsinus.UseVisualStyleBackColor = true;
            this.Arcsinus.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(175, 128);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(75, 23);
            this.Sinus.TabIndex = 16;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.ClickingOneButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Arcsinus);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Arccosinus);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.textBoxEntering2);
            this.Controls.Add(this.textBoxEntering1);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.TextBox textBoxEntering1;
        private System.Windows.Forms.TextBox textBoxEntering2;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Arccosinus;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Ten;
        private System.Windows.Forms.Button Arcsinus;
        private System.Windows.Forms.Button Sinus;
    }
}

