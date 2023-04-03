namespace Simple_Calculator
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
            lblResult = new Label();
            lblOp2 = new Label();
            lblAdd = new Label();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            resultTextBox = new TextBox();
            operand2 = new TextBox();
            operand1 = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(308, 128);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";
            lblResult.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblOp2
            // 
            lblOp2.AutoSize = true;
            lblOp2.Location = new Point(308, 79);
            lblOp2.Name = "lblOp2";
            lblOp2.Size = new Size(62, 15);
            lblOp2.TabIndex = 1;
            lblOp2.Text = "Operand 2";
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Location = new Point(308, 49);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(62, 15);
            lblAdd.TabIndex = 2;
            lblAdd.Text = "Operand 1";
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(502, 185);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(421, 185);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(326, 185);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(226, 185);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Enabled = false;
            resultTextBox.Location = new Point(391, 125);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(100, 23);
            resultTextBox.TabIndex = 7;
            // 
            // operand2
            // 
            operand2.Location = new Point(391, 79);
            operand2.Name = "operand2";
            operand2.Size = new Size(100, 23);
            operand2.TabIndex = 8;
            operand2.TextChanged += operand2_TextChanged;
            operand2.KeyPress += operand2_KeyPress;
            // 
            // operand1
            // 
            operand1.Location = new Point(391, 41);
            operand1.Name = "operand1";
            operand1.Size = new Size(100, 23);
            operand1.TabIndex = 9;
            operand1.TextChanged += operand1_TextChanged;
            operand1.KeyPress += operand1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(operand1);
            Controls.Add(operand2);
            Controls.Add(resultTextBox);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(lblAdd);
            Controls.Add(lblOp2);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label lblOp2;
        private Label lblAdd;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnSubtract;
        private Button btnAdd;
        private TextBox resultTextBox;
        private TextBox operand2;
        private TextBox operand1;
    }
}