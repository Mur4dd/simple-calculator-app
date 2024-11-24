namespace Day_2
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
            numbers = new GroupBox();
            number2MaskedBox = new MaskedTextBox();
            number1MaskedBox = new MaskedTextBox();
            proscessButton = new Button();
            operators = new GroupBox();
            operatorComboBox = new ComboBox();
            resultListBox = new ListBox();
            numbers.SuspendLayout();
            operators.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // numbers
            // 
            numbers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numbers.Controls.Add(number2MaskedBox);
            numbers.Controls.Add(number1MaskedBox);
            numbers.ForeColor = Color.White;
            numbers.Location = new Point(12, 75);
            numbers.Name = "numbers";
            numbers.Size = new Size(460, 86);
            numbers.TabIndex = 1;
            numbers.TabStop = false;
            numbers.Text = "Numbers";
            // 
            // number2MaskedBox
            // 
            number2MaskedBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            number2MaskedBox.Location = new Point(6, 52);
            number2MaskedBox.Mask = "00000000";
            number2MaskedBox.Name = "number2MaskedBox";
            number2MaskedBox.Size = new Size(448, 23);
            number2MaskedBox.TabIndex = 1;
            number2MaskedBox.ValidatingType = typeof(int);
            // 
            // number1MaskedBox
            // 
            number1MaskedBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            number1MaskedBox.Location = new Point(6, 23);
            number1MaskedBox.Mask = "00000000";
            number1MaskedBox.Name = "number1MaskedBox";
            number1MaskedBox.Size = new Size(448, 23);
            number1MaskedBox.TabIndex = 0;
            number1MaskedBox.ValidatingType = typeof(int);
            // 
            // proscessButton
            // 
            proscessButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            proscessButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proscessButton.ForeColor = Color.DarkBlue;
            proscessButton.Location = new Point(18, 265);
            proscessButton.Name = "proscessButton";
            proscessButton.Size = new Size(448, 33);
            proscessButton.TabIndex = 2;
            proscessButton.Text = "Process";
            proscessButton.UseVisualStyleBackColor = true;
            proscessButton.Click += proscessButton_Click;
            // 
            // operators
            // 
            operators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            operators.Controls.Add(operatorComboBox);
            operators.ForeColor = Color.White;
            operators.Location = new Point(12, 178);
            operators.Name = "operators";
            operators.Size = new Size(460, 59);
            operators.TabIndex = 3;
            operators.TabStop = false;
            operators.Text = "Operators";
            // 
            // operatorComboBox
            // 
            operatorComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            operatorComboBox.FormattingEnabled = true;
            operatorComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operatorComboBox.Location = new Point(6, 22);
            operatorComboBox.Name = "operatorComboBox";
            operatorComboBox.Size = new Size(448, 23);
            operatorComboBox.TabIndex = 0;
            // 
            // resultListBox
            // 
            resultListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new Point(18, 334);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(448, 109);
            resultListBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(484, 461);
            Controls.Add(resultListBox);
            Controls.Add(operators);
            Controls.Add(proscessButton);
            Controls.Add(numbers);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            numbers.ResumeLayout(false);
            numbers.PerformLayout();
            operators.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox numbers;
        private MaskedTextBox number2MaskedBox;
        private MaskedTextBox number1MaskedBox;
        private Button proscessButton;
        private GroupBox operators;
        private ComboBox operatorComboBox;
        private ListBox resultListBox;
    }
}
