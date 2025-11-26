namespace RadioButtonsinActionPrjt
{
    partial class frmRadioStar
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
            btnReset = new Button();
            btnExit = new Button();
            lblLeftNumber = new Label();
            txtLeftInput = new TextBox();
            lblRightNumber = new Label();
            txtRightInput = new TextBox();
            groupBox1 = new GroupBox();
            rdoAdd = new RadioButton();
            rdoSubtract = new RadioButton();
            rdoMultiply = new RadioButton();
            rdoDivide = new RadioButton();
            rdoModulus = new RadioButton();
            chkVerbose = new CheckBox();
            btnCalculate = new Button();
            lblMessage = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(146, 523);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 1;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 523);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblLeftNumber
            // 
            lblLeftNumber.AutoSize = true;
            lblLeftNumber.Location = new Point(102, 36);
            lblLeftNumber.Name = "lblLeftNumber";
            lblLeftNumber.Size = new Size(111, 25);
            lblLeftNumber.TabIndex = 3;
            lblLeftNumber.Text = "Left Number";
            // 
            // txtLeftInput
            // 
            txtLeftInput.Location = new Point(76, 77);
            txtLeftInput.Name = "txtLeftInput";
            txtLeftInput.Size = new Size(150, 31);
            txtLeftInput.TabIndex = 4;
            txtLeftInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRightNumber
            // 
            lblRightNumber.AutoSize = true;
            lblRightNumber.Location = new Point(397, 36);
            lblRightNumber.Name = "lblRightNumber";
            lblRightNumber.Size = new Size(124, 25);
            lblRightNumber.TabIndex = 5;
            lblRightNumber.Text = "Right Number";
            // 
            // txtRightInput
            // 
            txtRightInput.Location = new Point(382, 77);
            txtRightInput.Name = "txtRightInput";
            txtRightInput.Size = new Size(150, 31);
            txtRightInput.TabIndex = 6;
            txtRightInput.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoModulus);
            groupBox1.Controls.Add(rdoDivide);
            groupBox1.Controls.Add(rdoMultiply);
            groupBox1.Controls.Add(rdoSubtract);
            groupBox1.Controls.Add(rdoAdd);
            groupBox1.Location = new Point(102, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 107);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Math Operations Available";
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Location = new Point(23, 30);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(71, 29);
            rdoAdd.TabIndex = 0;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add";
            rdoAdd.TextAlign = ContentAlignment.MiddleCenter;
            rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            rdoSubtract.AutoSize = true;
            rdoSubtract.Location = new Point(149, 30);
            rdoSubtract.Name = "rdoSubtract";
            rdoSubtract.Size = new Size(103, 29);
            rdoSubtract.TabIndex = 1;
            rdoSubtract.TabStop = true;
            rdoSubtract.Text = "Subtract";
            rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            rdoMultiply.AutoSize = true;
            rdoMultiply.Location = new Point(295, 30);
            rdoMultiply.Name = "rdoMultiply";
            rdoMultiply.Size = new Size(101, 29);
            rdoMultiply.TabIndex = 2;
            rdoMultiply.TabStop = true;
            rdoMultiply.Text = "Multiply";
            rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            rdoDivide.AutoSize = true;
            rdoDivide.Location = new Point(69, 65);
            rdoDivide.Name = "rdoDivide";
            rdoDivide.Size = new Size(87, 29);
            rdoDivide.TabIndex = 3;
            rdoDivide.TabStop = true;
            rdoDivide.Text = "Divide";
            rdoDivide.UseVisualStyleBackColor = true;
            // 
            // rdoModulus
            // 
            rdoModulus.AutoSize = true;
            rdoModulus.Location = new Point(206, 65);
            rdoModulus.Name = "rdoModulus";
            rdoModulus.Size = new Size(123, 29);
            rdoModulus.TabIndex = 4;
            rdoModulus.TabStop = true;
            rdoModulus.Text = "Percentage";
            rdoModulus.UseVisualStyleBackColor = true;
            // 
            // chkVerbose
            // 
            chkVerbose.AutoSize = true;
            chkVerbose.Location = new Point(147, 244);
            chkVerbose.Name = "chkVerbose";
            chkVerbose.Size = new Size(321, 29);
            chkVerbose.TabIndex = 8;
            chkVerbose.Text = "Check this to show the full equation";
            chkVerbose.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(242, 279);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.RightToLeft = RightToLeft.No;
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.BackColor = Color.LightGoldenrodYellow;
            lblMessage.BorderStyle = BorderStyle.FixedSingle;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(102, 344);
            lblMessage.Name = "lblMessage";
            lblMessage.Padding = new Padding(8);
            lblMessage.Size = new Size(419, 154);
            lblMessage.TabIndex = 10;
            // 
            // frmRadioStar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(628, 578);
            Controls.Add(lblMessage);
            Controls.Add(btnCalculate);
            Controls.Add(chkVerbose);
            Controls.Add(groupBox1);
            Controls.Add(txtRightInput);
            Controls.Add(lblRightNumber);
            Controls.Add(txtLeftInput);
            Controls.Add(lblLeftNumber);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Name = "frmRadioStar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radio Buttons in Action!";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReset;
        private Button btnExit;
        private Label lblLeftNumber;
        private TextBox txtLeftInput;
        private Label lblRightNumber;
        private TextBox txtRightInput;
        private GroupBox groupBox1;
        private RadioButton rdoModulus;
        private RadioButton rdoDivide;
        private RadioButton rdoMultiply;
        private RadioButton rdoSubtract;
        private RadioButton rdoAdd;
        private CheckBox chkVerbose;
        private Button btnCalculate;
        private Label lblMessage;
    }
}
