namespace MatrixCalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMatrix
            // 
            this.btnNewMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMatrix.Location = new System.Drawing.Point(13, 13);
            this.btnNewMatrix.Name = "btnNewMatrix";
            this.btnNewMatrix.Size = new System.Drawing.Size(106, 28);
            this.btnNewMatrix.TabIndex = 0;
            this.btnNewMatrix.Text = "New Matrix";
            this.btnNewMatrix.UseVisualStyleBackColor = true;
            this.btnNewMatrix.Click += new System.EventHandler(this.btnNewMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewMatrix);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Matrix Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewMatrix;
    }
}

