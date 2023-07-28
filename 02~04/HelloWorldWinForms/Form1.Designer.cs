namespace HelloWorldWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            sum1 = new TextBox();
            sum2 = new TextBox();
            sumNums = new Button();
            sumResult = new TextBox();
            operator1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 62);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Click Here!";
            label1.Click += label1_Click;
            // 
            // sum1
            // 
            sum1.Location = new Point(67, 134);
            sum1.Name = "sum1";
            sum1.Size = new Size(150, 31);
            sum1.TabIndex = 1;
            // 
            // sum2
            // 
            sum2.Location = new Point(277, 134);
            sum2.Name = "sum2";
            sum2.Size = new Size(150, 31);
            sum2.TabIndex = 2;
            // 
            // sumNums
            // 
            sumNums.Location = new Point(451, 131);
            sumNums.Name = "sumNums";
            sumNums.Size = new Size(65, 34);
            sumNums.TabIndex = 3;
            sumNums.Text = "=";
            sumNums.UseVisualStyleBackColor = true;
            sumNums.Click += sumNums_Click;
            // 
            // sumResult
            // 
            sumResult.Location = new Point(538, 134);
            sumResult.Name = "sumResult";
            sumResult.Size = new Size(150, 31);
            sumResult.TabIndex = 4;
            // 
            // operator1
            // 
            operator1.FormattingEnabled = true;
            operator1.Location = new Point(223, 134);
            operator1.Name = "operator1";
            operator1.Size = new Size(48, 33);
            operator1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(operator1);
            Controls.Add(sumResult);
            Controls.Add(sumNums);
            Controls.Add(sum2);
            Controls.Add(sum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sum1;
        private TextBox sum2;
        private Button sumNums;
        private TextBox sumResult;
        private ComboBox operator1;
    }
}