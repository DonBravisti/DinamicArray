namespace CalcExpession
{
    partial class FormMain
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
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.textBoxBackExpression = new System.Windows.Forms.TextBox();
            this.buttonExpression = new System.Windows.Forms.Button();
            this.buttonCalcExpression = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpression.Location = new System.Drawing.Point(348, 87);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(379, 31);
            this.textBoxExpression.TabIndex = 0;
            this.textBoxExpression.Text = "(2*3-(7+1)/(4-5))*(4+2*3)";
            this.textBoxExpression.TextChanged += new System.EventHandler(this.textBoxExpression_TextChanged);
            // 
            // textBoxBackExpression
            // 
            this.textBoxBackExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBackExpression.Location = new System.Drawing.Point(348, 227);
            this.textBoxBackExpression.Name = "textBoxBackExpression";
            this.textBoxBackExpression.Size = new System.Drawing.Size(379, 31);
            this.textBoxBackExpression.TabIndex = 1;
            this.textBoxBackExpression.Text = "23*71+45-/-423*+*";
            // 
            // buttonExpression
            // 
            this.buttonExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExpression.Location = new System.Drawing.Point(348, 161);
            this.buttonExpression.Name = "buttonExpression";
            this.buttonExpression.Size = new System.Drawing.Size(379, 41);
            this.buttonExpression.TabIndex = 2;
            this.buttonExpression.Text = "получить польскую запись";
            this.buttonExpression.UseVisualStyleBackColor = true;
            this.buttonExpression.Click += new System.EventHandler(this.buttonExpression_Click);
            // 
            // buttonCalcExpression
            // 
            this.buttonCalcExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcExpression.Location = new System.Drawing.Point(348, 294);
            this.buttonCalcExpression.Name = "buttonCalcExpression";
            this.buttonCalcExpression.Size = new System.Drawing.Size(379, 35);
            this.buttonCalcExpression.TabIndex = 3;
            this.buttonCalcExpression.Text = "Вычислить по обратной записи";
            this.buttonCalcExpression.UseVisualStyleBackColor = true;
            this.buttonCalcExpression.Click += new System.EventHandler(this.buttonCalcExpression_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите выражение: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Польская запись: ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(343, 374);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(24, 25);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalcExpression);
            this.Controls.Add(this.buttonExpression);
            this.Controls.Add(this.textBoxBackExpression);
            this.Controls.Add(this.textBoxExpression);
            this.Name = "FormMain";
            this.Text = "Вычисление выражений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.TextBox textBoxBackExpression;
        private System.Windows.Forms.Button buttonExpression;
        private System.Windows.Forms.Button buttonCalcExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
    }
}

