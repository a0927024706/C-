namespace Example_5
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multipliedButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.divivedButton = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.eqation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(32, 39);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(302, 33);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(186, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(109, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(186, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(109, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(186, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(263, 97);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 47);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(263, 150);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(71, 47);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // multipliedButton
            // 
            this.multipliedButton.Location = new System.Drawing.Point(263, 203);
            this.multipliedButton.Name = "multipliedButton";
            this.multipliedButton.Size = new System.Drawing.Size(71, 47);
            this.multipliedButton.TabIndex = 12;
            this.multipliedButton.Text = "x";
            this.multipliedButton.UseVisualStyleBackColor = true;
            this.multipliedButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(32, 256);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(71, 47);
            this.dotButton.TabIndex = 13;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click_1);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(109, 256);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 47);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(186, 256);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(71, 47);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // divivedButton
            // 
            this.divivedButton.Location = new System.Drawing.Point(263, 256);
            this.divivedButton.Name = "divivedButton";
            this.divivedButton.Size = new System.Drawing.Size(71, 47);
            this.divivedButton.TabIndex = 16;
            this.divivedButton.Text = "/";
            this.divivedButton.UseVisualStyleBackColor = true;
            this.divivedButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(109, 309);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(148, 41);
            this.CE.TabIndex = 17;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click_1);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.equation.Location = new System.Drawing.Point(42, 47);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 16);
            this.equation.TabIndex = 18;
            // 
            // eqation
            // 
            this.eqation.AutoSize = true;
            this.eqation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.eqation.Location = new System.Drawing.Point(42, 47);
            this.eqation.Name = "eqation";
            this.eqation.Size = new System.Drawing.Size(43, 16);
            this.eqation.TabIndex = 19;
            this.eqation.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 366);
            this.Controls.Add(this.eqation);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.divivedButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.multipliedButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multipliedButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button divivedButton;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Label eqation;
    }
}

