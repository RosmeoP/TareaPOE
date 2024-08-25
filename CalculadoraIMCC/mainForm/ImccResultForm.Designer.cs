namespace mainForm
{
    partial class ImccResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            closeFormButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // closeFormButton
            // 
            closeFormButton.Location = new Point(318, 223);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(94, 29);
            closeFormButton.TabIndex = 1;
            closeFormButton.Text = "Close Form ";
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += closeFormButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(324, 62);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 2;
            // 
            // ImccResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(closeFormButton);
            Name = "ImccResultForm";
            Text = "ImccResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button closeFormButton;
        private Label resultLabel;
    }
}