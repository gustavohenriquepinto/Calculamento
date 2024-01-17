namespace CalculatorApp
{
    partial class formEntrar
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
            labelUsuario = new Label();
            labelSenha = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonEntrar = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelUsuario.Location = new Point(77, 9);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(69, 21);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelSenha.Location = new Point(77, 85);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(57, 21);
            labelSenha.TabIndex = 1;
            labelSenha.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(22, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 29);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox2.Location = new Point(22, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 29);
            textBox2.TabIndex = 3;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEntrar.Location = new Point(258, 28);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(101, 45);
            buttonEntrar.TabIndex = 4;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonSair
            // 
            buttonSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.Location = new Point(258, 104);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(101, 45);
            buttonSair.TabIndex = 6;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // formEntrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 208);
            ControlBox = false;
            Controls.Add(buttonSair);
            Controls.Add(buttonEntrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Name = "formEntrar";
            ShowIcon = false;
            Text = "Entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelSenha;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonEntrar;
        private Button buttonSair;
    }
}