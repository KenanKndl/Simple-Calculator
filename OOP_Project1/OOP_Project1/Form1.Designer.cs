namespace OOP_Project1
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
            FirstNumber = new Label();
            SecondNumber = new Label();
            Result = new Label();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // FirstNumber
            // 
            FirstNumber.BackColor = Color.FromArgb(68, 71, 90);
            FirstNumber.FlatStyle = FlatStyle.Flat;
            FirstNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            FirstNumber.ForeColor = Color.FromArgb(248, 248, 242);
            FirstNumber.Location = new Point(50, 100);
            FirstNumber.Name = "FirstNumber";
            FirstNumber.Size = new Size(154, 32);
            FirstNumber.TabIndex = 0;
            FirstNumber.Text = "First Number";
            // 
            // SecondNumber
            // 
            SecondNumber.BackColor = Color.FromArgb(68, 71, 90);
            SecondNumber.FlatStyle = FlatStyle.Flat;
            SecondNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            SecondNumber.ForeColor = Color.FromArgb(248, 248, 242);
            SecondNumber.Location = new Point(50, 145);
            SecondNumber.Name = "SecondNumber";
            SecondNumber.Size = new Size(154, 32);
            SecondNumber.TabIndex = 1;
            SecondNumber.Text = "Second Number";
            // 
            // Result
            // 
            Result.BackColor = Color.FromArgb(68, 71, 90);
            Result.FlatStyle = FlatStyle.Flat;
            Result.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            Result.ForeColor = Color.FromArgb(248, 248, 242);
            Result.Location = new Point(50, 190);
            Result.Name = "Result";
            Result.Size = new Size(154, 32);
            Result.TabIndex = 2;
            Result.Text = "Result";
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.BackColor = Color.FromArgb(98, 114, 164);
            txtFirstNumber.BorderStyle = BorderStyle.None;
            txtFirstNumber.Cursor = Cursors.IBeam;
            txtFirstNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtFirstNumber.ForeColor = Color.FromArgb(248, 248, 242);
            txtFirstNumber.Location = new Point(238, 105);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(125, 25);
            txtFirstNumber.TabIndex = 3;
            txtFirstNumber.KeyPress += txtFirstNumber_KeyPress;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.BackColor = Color.FromArgb(98, 114, 164);
            txtSecondNumber.BorderStyle = BorderStyle.None;
            txtSecondNumber.Cursor = Cursors.IBeam;
            txtSecondNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtSecondNumber.ForeColor = Color.FromArgb(248, 248, 242);
            txtSecondNumber.Location = new Point(238, 150);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(125, 25);
            txtSecondNumber.TabIndex = 4;
            txtSecondNumber.KeyPress += txtSecondNumber_KeyPress;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(98, 114, 164);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            txtResult.ForeColor = Color.FromArgb(248, 248, 242);
            txtResult.Location = new Point(238, 195);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(125, 25);
            txtResult.TabIndex = 5;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(98, 114, 164);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.FromArgb(80, 250, 123);
            btnAdd.Location = new Point(50, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 45);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += btnAdd_MouseEnter;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(98, 114, 164);
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSubtract.ForeColor = Color.FromArgb(80, 250, 123);
            btnSubtract.Location = new Point(120, 257);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(45, 45);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            btnSubtract.MouseEnter += btnSubtract_MouseEnter;
            btnSubtract.MouseLeave += btnSubtract_MouseLeave;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(98, 114, 164);
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMultiply.ForeColor = Color.FromArgb(80, 250, 123);
            btnMultiply.Location = new Point(190, 257);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 45);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            btnMultiply.MouseEnter += btnMultiply_MouseEnter;
            btnMultiply.MouseLeave += btnMultiply_MouseLeave;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(98, 114, 164);
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDivide.ForeColor = Color.FromArgb(80, 250, 123);
            btnDivide.Location = new Point(261, 257);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 45);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            btnDivide.MouseEnter += btnDivide_MouseEnter;
            btnDivide.MouseLeave += btnDivide_MouseLeave;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(98, 114, 164);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReset.ForeColor = Color.FromArgb(80, 250, 123);
            btnReset.Location = new Point(120, 322);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(115, 43);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            btnReset.MouseEnter += btnReset_MouseEnter;
            btnReset.MouseLeave += btnReset_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(Result);
            Controls.Add(SecondNumber);
            Controls.Add(FirstNumber);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNumber;
        private Label SecondNumber;
        private Label Result;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private TextBox txtResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnReset;
    }
}
