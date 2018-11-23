namespace CombAlg_lab1
{
    partial class MainForm
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
            this.lblInputNum = new System.Windows.Forms.Label();
            this.tbInputNum = new System.Windows.Forms.TextBox();
            this.lblNeedNum = new System.Windows.Forms.Label();
            this.tbNeedNum = new System.Windows.Forms.TextBox();
            this.btnSearchSol = new System.Windows.Forms.Button();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputNum
            // 
            this.lblInputNum.AutoSize = true;
            this.lblInputNum.Location = new System.Drawing.Point(12, 28);
            this.lblInputNum.Name = "lblInputNum";
            this.lblInputNum.Size = new System.Drawing.Size(106, 17);
            this.lblInputNum.TabIndex = 0;
            this.lblInputNum.Text = "Введите числа";
            // 
            // tbInputNum
            // 
            this.tbInputNum.Location = new System.Drawing.Point(12, 48);
            this.tbInputNum.Name = "tbInputNum";
            this.tbInputNum.Size = new System.Drawing.Size(298, 22);
            this.tbInputNum.TabIndex = 1;
            // 
            // lblNeedNum
            // 
            this.lblNeedNum.AutoSize = true;
            this.lblNeedNum.Location = new System.Drawing.Point(9, 94);
            this.lblNeedNum.Name = "lblNeedNum";
            this.lblNeedNum.Size = new System.Drawing.Size(108, 17);
            this.lblNeedNum.TabIndex = 2;
            this.lblNeedNum.Text = "Искомое число";
            // 
            // tbNeedNum
            // 
            this.tbNeedNum.Location = new System.Drawing.Point(12, 114);
            this.tbNeedNum.Name = "tbNeedNum";
            this.tbNeedNum.Size = new System.Drawing.Size(100, 22);
            this.tbNeedNum.TabIndex = 3;
            // 
            // btnSearchSol
            // 
            this.btnSearchSol.Location = new System.Drawing.Point(179, 105);
            this.btnSearchSol.Name = "btnSearchSol";
            this.btnSearchSol.Size = new System.Drawing.Size(131, 31);
            this.btnSearchSol.TabIndex = 4;
            this.btnSearchSol.Text = "Искать решение";
            this.btnSearchSol.UseVisualStyleBackColor = true;
            // 
            // tbSolution
            // 
            this.tbSolution.Location = new System.Drawing.Point(12, 187);
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(298, 22);
            this.tbSolution.TabIndex = 5;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(9, 167);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(68, 17);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "Решение";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(113, 249);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(91, 31);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Очистить";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.tbSolution);
            this.Controls.Add(this.btnSearchSol);
            this.Controls.Add(this.tbNeedNum);
            this.Controls.Add(this.lblNeedNum);
            this.Controls.Add(this.tbInputNum);
            this.Controls.Add(this.lblInputNum);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputNum;
        private System.Windows.Forms.TextBox tbInputNum;
        private System.Windows.Forms.Label lblNeedNum;
        private System.Windows.Forms.TextBox tbNeedNum;
        private System.Windows.Forms.Button btnSearchSol;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnClean;
    }
}

