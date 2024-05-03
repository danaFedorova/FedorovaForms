namespace FedorovaForms
{
    partial class RegisterForm
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
            ErrorLabel = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            RepPasswordLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            RepPasswordTextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(49, 41);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(398, 32);
            ErrorLabel.TabIndex = 0;
            ErrorLabel.Text = "Введите регистрационные данные";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(50, 88);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(66, 32);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Имя:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(49, 137);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(101, 32);
            PasswordLabel.TabIndex = 0;
            PasswordLabel.Text = "Пароль:";
            // 
            // RepPasswordLabel
            // 
            RepPasswordLabel.AutoSize = true;
            RepPasswordLabel.Location = new Point(49, 197);
            RepPasswordLabel.Name = "RepPasswordLabel";
            RepPasswordLabel.Size = new Size(187, 32);
            RepPasswordLabel.TabIndex = 0;
            RepPasswordLabel.Text = "Повтор пароля:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(454, 79);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(200, 39);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(442, 159);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(200, 39);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.TextChanged += textBox1_TextChanged;
            // 
            // RepPasswordTextBox
            // 
            RepPasswordTextBox.Location = new Point(442, 215);
            RepPasswordTextBox.Name = "RepPasswordTextBox";
            RepPasswordTextBox.Size = new Size(200, 39);
            RepPasswordTextBox.TabIndex = 1;
            RepPasswordTextBox.TextChanged += textBox1_TextChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(256, 323);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(235, 67);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += button1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterButton);
            Controls.Add(RepPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(RepPasswordLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(ErrorLabel);
            Name = "RegisterForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ErrorLabel;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label RepPasswordLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox RepPasswordTextBox;
        private Button RegisterButton;
    }
}
