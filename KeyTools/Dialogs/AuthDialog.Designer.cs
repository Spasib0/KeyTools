namespace KeyTools.Dialogs
{
    partial class AuthDialog
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(12, 9);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(170, 23);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(12, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(170, 23);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(12, 35);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(170, 23);
            this.loginField.TabIndex = 2;
            this.loginField.TextChanged += new System.EventHandler(this.OnLoginChanged);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(12, 87);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(170, 23);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextChanged += new System.EventHandler(this.OnPasswordChanged);
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(40, 141);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(107, 23);
            this.authButton.TabIndex = 4;
            this.authButton.Text = "Authorize";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.OnAuthClick);
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Location = new System.Drawing.Point(40, 116);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(107, 19);
            this.saveCheckBox.TabIndex = 5;
            this.saveCheckBox.Text = " Remember me";
            this.saveCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthDialog
            // 
            this.AcceptButton = this.authButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 176);
            this.Controls.Add(this.saveCheckBox);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"{0}\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.CheckBox saveCheckBox;
    }
}