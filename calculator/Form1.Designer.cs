namespace calculator
{
    partial class Calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnDiv = new Button();
            btnAdd = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnCA = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            Textbox = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn1.Location = new Point(12, 271);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 69);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn2.Location = new Point(94, 271);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 69);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn3.Location = new Point(176, 271);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 69);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn4.Location = new Point(12, 196);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 69);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn5.Location = new Point(94, 196);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 69);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn6.Location = new Point(176, 196);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 69);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn7.Location = new Point(12, 121);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 69);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn8.Location = new Point(94, 121);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 69);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn9.Location = new Point(176, 121);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 69);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn0.Location = new Point(12, 346);
            btn0.Name = "btn0";
            btn0.Size = new Size(148, 62);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDot.Location = new Point(176, 346);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(66, 62);
            btnDot.TabIndex = 10;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += button_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDiv.Location = new Point(260, 346);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(65, 60);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += operation_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(260, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 60);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += operation_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSub.Location = new Point(260, 196);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(65, 60);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += operation_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMult.Location = new Point(260, 271);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(65, 60);
            btnMult.TabIndex = 11;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += operation_Click;
            // 
            // btnCA
            // 
            btnCA.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCA.Location = new Point(331, 121);
            btnCA.Name = "btnCA";
            btnCA.Size = new Size(65, 60);
            btnCA.TabIndex = 16;
            btnCA.Text = "CE";
            btnCA.UseVisualStyleBackColor = true;
            btnCA.Click += btnCA_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnClear.Location = new Point(331, 196);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(65, 60);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEqual.Location = new Point(331, 271);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(65, 135);
            btnEqual.TabIndex = 17;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += equal_Click;
            // 
            // Textbox
            // 
            Textbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Textbox.Location = new Point(12, 44);
            Textbox.Multiline = true;
            Textbox.Name = "Textbox";
            Textbox.ReadOnly = true;
            Textbox.Size = new Size(384, 52);
            Textbox.TabIndex = 18;
            Textbox.Text = "0";
            Textbox.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 422);
            Controls.Add(Textbox);
            Controls.Add(btnEqual);
            Controls.Add(btnCA);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
        private Button btnDiv;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMult;
        private Button btnCA;
        private Button btnClear;
        private Button btnEqual;
        private TextBox Textbox;
    }
}
