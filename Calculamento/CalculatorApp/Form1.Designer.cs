namespace CalculatorApp
{
    partial class formInicio
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
            buttonMatrix = new Button();
            buttonFibonacci = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonMatrix
            // 
            buttonMatrix.Location = new Point(23, 24);
            buttonMatrix.Margin = new Padding(5, 6, 5, 6);
            buttonMatrix.Name = "buttonMatrix";
            buttonMatrix.Size = new Size(226, 61);
            buttonMatrix.TabIndex = 0;
            buttonMatrix.Text = "Matrizes";
            buttonMatrix.UseVisualStyleBackColor = true;
            // 
            // buttonFibonacci
            // 
            buttonFibonacci.Location = new Point(23, 97);
            buttonFibonacci.Margin = new Padding(5, 6, 5, 6);
            buttonFibonacci.Name = "buttonFibonacci";
            buttonFibonacci.Size = new Size(226, 61);
            buttonFibonacci.TabIndex = 1;
            buttonFibonacci.Text = "Fibonacci";
            buttonFibonacci.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(23, 170);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(226, 61);
            button2.TabIndex = 2;
            button2.Text = "Bhaskara";
            button2.UseVisualStyleBackColor = true;
            // 
            // formInicio
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 531);
            Controls.Add(button2);
            Controls.Add(buttonFibonacci);
            Controls.Add(buttonMatrix);
            Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "formInicio";
            ShowIcon = false;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMatrix;
        private Button buttonFibonacci;
        private Button button2;
    }
}