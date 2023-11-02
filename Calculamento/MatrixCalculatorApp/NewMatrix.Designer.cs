namespace MatrixCalculatorApp
{
    partial class NewMatrix
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
            this.labelMatrixName = new System.Windows.Forms.Label();
            this.textBoxMatrixName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMatrixName
            // 
            this.labelMatrixName.AutoSize = true;
            this.labelMatrixName.Location = new System.Drawing.Point(26, 24);
            this.labelMatrixName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelMatrixName.Name = "labelMatrixName";
            this.labelMatrixName.Size = new System.Drawing.Size(133, 24);
            this.labelMatrixName.TabIndex = 0;
            this.labelMatrixName.Text = "Matrix Name:";
            // 
            // textBoxMatrixName
            // 
            this.textBoxMatrixName.Location = new System.Drawing.Point(169, 19);
            this.textBoxMatrixName.Name = "textBoxMatrixName";
            this.textBoxMatrixName.Size = new System.Drawing.Size(248, 29);
            this.textBoxMatrixName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lines:";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(26, 92);
            this.labelColumns.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(98, 24);
            this.labelColumns.TabIndex = 3;
            this.labelColumns.Text = "Columns:";
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(169, 89);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(105, 29);
            this.textBoxColumns.TabIndex = 4;
            this.textBoxColumns.Text = "1";
            // 
            // textBoxLines
            // 
            this.textBoxLines.Location = new System.Drawing.Point(169, 54);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.Size = new System.Drawing.Size(105, 29);
            this.textBoxLines.TabIndex = 5;
            this.textBoxLines.Text = "1";
            // 
            // NewMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.textBoxLines);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMatrixName);
            this.Controls.Add(this.labelMatrixName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "NewMatrix";
            this.Text = "NewMatrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMatrixName;
        private System.Windows.Forms.TextBox textBoxMatrixName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.TextBox textBoxLines;
    }
}