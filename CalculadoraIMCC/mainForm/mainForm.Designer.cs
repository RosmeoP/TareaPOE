namespace mainForm
{
    partial class mainForm
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
            groupBox1 = new GroupBox();
            btnCalcular = new Button();
            resultLabel = new Label();
            tallTextBox = new TextBox();
            weightTextBox = new TextBox();
            tallLabel = new Label();
            weightLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculadora IMCC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(resultLabel);
            groupBox1.Controls.Add(tallTextBox);
            groupBox1.Controls.Add(weightTextBox);
            groupBox1.Controls.Add(tallLabel);
            groupBox1.Controls.Add(weightLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(86, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculadora";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(259, 233);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calculate";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(263, 226);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 5;
            // 
            // tallTextBox
            // 
            tallTextBox.Location = new Point(365, 166);
            tallTextBox.Name = "tallTextBox";
            tallTextBox.Size = new Size(125, 27);
            tallTextBox.TabIndex = 4;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(54, 166);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(125, 27);
            weightTextBox.TabIndex = 3;
            // 
            // tallLabel
            // 
            tallLabel.AutoSize = true;
            tallLabel.Location = new Point(365, 111);
            tallLabel.Name = "tallLabel";
            tallLabel.Size = new Size(118, 20);
            tallLabel.TabIndex = 2;
            tallLabel.Text = "How tall are you";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(54, 111);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(158, 20);
            weightLabel.TabIndex = 1;
            weightLabel.Text = "Type your weight in kg";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "mainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label weightLabel;
        private Label tallLabel;
        private TextBox weightTextBox;
        private TextBox tallTextBox;
        private Label resultLabel;
        private Button btnCalcular;
    }
}
