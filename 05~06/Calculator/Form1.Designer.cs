namespace Calculator
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
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            divide = new Button();
            multiple = new Button();
            substract = new Button();
            add = new Button();
            clear = new Button();
            delete = new Button();
            equal = new Button();
            num0 = new Button();
            numScreen = new Label();
            dot = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Location = new Point(40, 142);
            num1.Margin = new Padding(4);
            num1.Name = "num1";
            num1.Size = new Size(92, 79);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Location = new Point(156, 142);
            num2.Margin = new Padding(4);
            num2.Name = "num2";
            num2.Size = new Size(92, 79);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num3
            // 
            num3.Location = new Point(271, 142);
            num3.Margin = new Padding(4);
            num3.Name = "num3";
            num3.Size = new Size(92, 79);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num6
            // 
            num6.Location = new Point(271, 241);
            num6.Margin = new Padding(4);
            num6.Name = "num6";
            num6.Size = new Size(92, 79);
            num6.TabIndex = 5;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(156, 241);
            num5.Margin = new Padding(4);
            num5.Name = "num5";
            num5.Size = new Size(92, 79);
            num5.TabIndex = 4;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(40, 241);
            num4.Margin = new Padding(4);
            num4.Name = "num4";
            num4.Size = new Size(92, 79);
            num4.TabIndex = 3;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num9
            // 
            num9.Location = new Point(271, 339);
            num9.Margin = new Padding(4);
            num9.Name = "num9";
            num9.Size = new Size(92, 79);
            num9.TabIndex = 8;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Location = new Point(156, 339);
            num8.Margin = new Padding(4);
            num8.Name = "num8";
            num8.Size = new Size(92, 79);
            num8.TabIndex = 7;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Location = new Point(40, 339);
            num7.Margin = new Padding(4);
            num7.Name = "num7";
            num7.Size = new Size(92, 79);
            num7.TabIndex = 6;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // divide
            // 
            divide.Location = new Point(503, 339);
            divide.Margin = new Padding(4);
            divide.Name = "divide";
            divide.Size = new Size(92, 79);
            divide.TabIndex = 14;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multiple
            // 
            multiple.Location = new Point(388, 339);
            multiple.Margin = new Padding(4);
            multiple.Name = "multiple";
            multiple.Size = new Size(92, 79);
            multiple.TabIndex = 13;
            multiple.Text = "×";
            multiple.UseVisualStyleBackColor = true;
            multiple.Click += multiple_Click;
            // 
            // substract
            // 
            substract.Location = new Point(503, 241);
            substract.Margin = new Padding(4);
            substract.Name = "substract";
            substract.Size = new Size(92, 79);
            substract.TabIndex = 12;
            substract.Text = "-";
            substract.UseVisualStyleBackColor = true;
            substract.Click += substract_Click;
            // 
            // add
            // 
            add.Location = new Point(388, 241);
            add.Margin = new Padding(4);
            add.Name = "add";
            add.Size = new Size(92, 79);
            add.TabIndex = 11;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // clear
            // 
            clear.Location = new Point(503, 142);
            clear.Margin = new Padding(4);
            clear.Name = "clear";
            clear.Size = new Size(92, 79);
            clear.TabIndex = 10;
            clear.Text = "AC";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // delete
            // 
            delete.Location = new Point(388, 142);
            delete.Margin = new Padding(4);
            delete.Name = "delete";
            delete.Size = new Size(92, 79);
            delete.TabIndex = 9;
            delete.Text = "DEL";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // equal
            // 
            equal.Location = new Point(503, 438);
            equal.Margin = new Padding(4);
            equal.Name = "equal";
            equal.Size = new Size(92, 79);
            equal.TabIndex = 19;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // num0
            // 
            num0.Location = new Point(156, 438);
            num0.Margin = new Padding(4);
            num0.Name = "num0";
            num0.Size = new Size(92, 79);
            num0.TabIndex = 16;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // numScreen
            // 
            numScreen.BackColor = SystemColors.ControlLight;
            numScreen.BorderStyle = BorderStyle.Fixed3D;
            numScreen.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numScreen.Location = new Point(40, 42);
            numScreen.Margin = new Padding(4, 0, 4, 0);
            numScreen.Name = "numScreen";
            numScreen.Size = new Size(555, 79);
            numScreen.TabIndex = 20;
            numScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dot
            // 
            dot.Location = new Point(271, 438);
            dot.Margin = new Padding(4);
            dot.Name = "dot";
            dot.Size = new Size(92, 79);
            dot.TabIndex = 21;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 574);
            Controls.Add(dot);
            Controls.Add(numScreen);
            Controls.Add(equal);
            Controls.Add(num0);
            Controls.Add(divide);
            Controls.Add(multiple);
            Controls.Add(substract);
            Controls.Add(add);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button num1;
        private Button num2;
        private Button num3;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button divide;
        private Button multiple;
        private Button substract;
        private Button add;
        private Button clear;
        private Button delete;
        private Button equal;
        private Button num0;
        private Label numScreen;
        private Button dot;
    }
}