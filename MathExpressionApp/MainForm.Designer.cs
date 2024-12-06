namespace MathExpressionApp
{
    partial class MainForm
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
            XLabel = new Label();
            ZLabel = new Label();
            ALabel = new Label();
            BLabel = new Label();
            ResultLabel = new Label();
            XTextBox = new TextBox();
            ZTextBox = new TextBox();
            ATextBox = new TextBox();
            BTextBox = new TextBox();
            CalculateButton = new Button();
            DescriptionLabel = new Label();
            CalculationDetailLabel = new Label();
            SuspendLayout();
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(12, 123);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(62, 15);
            XLabel.TabIndex = 0;
            XLabel.Text = "Введите x:";
            // 
            // ZLabel
            // 
            ZLabel.AutoSize = true;
            ZLabel.Location = new Point(12, 167);
            ZLabel.Name = "ZLabel";
            ZLabel.Size = new Size(61, 15);
            ZLabel.TabIndex = 1;
            ZLabel.Text = "Введите z:";
            // 
            // ALabel
            // 
            ALabel.AutoSize = true;
            ALabel.Location = new Point(15, 211);
            ALabel.Name = "ALabel";
            ALabel.Size = new Size(62, 15);
            ALabel.TabIndex = 2;
            ALabel.Text = "Введите a:";
            // 
            // BLabel
            // 
            BLabel.AutoSize = true;
            BLabel.Location = new Point(15, 255);
            BLabel.Name = "BLabel";
            BLabel.Size = new Size(63, 15);
            BLabel.TabIndex = 3;
            BLabel.Text = "Введите b:";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(15, 418);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(63, 15);
            ResultLabel.TabIndex = 4;
            ResultLabel.Text = "Результат:";
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(12, 141);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(367, 23);
            XTextBox.TabIndex = 5;
            // 
            // ZTextBox
            // 
            ZTextBox.Location = new Point(12, 185);
            ZTextBox.Name = "ZTextBox";
            ZTextBox.Size = new Size(367, 23);
            ZTextBox.TabIndex = 6;
            // 
            // ATextBox
            // 
            ATextBox.Location = new Point(13, 229);
            ATextBox.Name = "ATextBox";
            ATextBox.Size = new Size(366, 23);
            ATextBox.TabIndex = 7;
            // 
            // BTextBox
            // 
            BTextBox.Location = new Point(13, 273);
            BTextBox.Name = "BTextBox";
            BTextBox.Size = new Size(366, 23);
            BTextBox.TabIndex = 8;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(148, 302);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(111, 23);
            CalculateButton.TabIndex = 9;
            CalculateButton.Text = "Вычислить";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(13, 9);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(61, 15);
            DescriptionLabel.TabIndex = 10;
            DescriptionLabel.Text = "Формула:";
            // 
            // CalculationDetailLabel
            // 
            CalculationDetailLabel.AutoSize = true;
            CalculationDetailLabel.Location = new Point(15, 338);
            CalculationDetailLabel.Name = "CalculationDetailLabel";
            CalculationDetailLabel.Size = new Size(0, 15);
            CalculationDetailLabel.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 442);
            Controls.Add(CalculationDetailLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(CalculateButton);
            Controls.Add(BTextBox);
            Controls.Add(ATextBox);
            Controls.Add(ZTextBox);
            Controls.Add(XTextBox);
            Controls.Add(ResultLabel);
            Controls.Add(BLabel);
            Controls.Add(ALabel);
            Controls.Add(ZLabel);
            Controls.Add(XLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label XLabel;
        private Label ZLabel;
        private Label ALabel;
        private Label BLabel;
        private Label ResultLabel;
        private TextBox XTextBox;
        private TextBox ZTextBox;
        private TextBox ATextBox;
        private TextBox BTextBox;
        private Button CalculateButton;
        private Label DescriptionLabel;
        private Label CalculationDetailLabel;
    }
}
