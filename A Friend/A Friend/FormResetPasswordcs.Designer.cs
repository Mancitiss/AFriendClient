namespace A_Friend
{
    partial class FormResetPasswordcs
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
            this.textBoxPassword = new A_Friend.CustomControls.CustomTextBox();
            this.TextBoxEnterCode = new A_Friend.CustomControls.CustomTextBox();
            this.buttonResetPassword = new A_Friend.CustomControls.CustomButton();
            this.labelTittle = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.textBoxPassword.BorderRadius = 20;
            this.textBoxPassword.BorderSize = 2;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(42, 188);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 38);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // TextBoxEnterCode
            // 
            this.TextBoxEnterCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxEnterCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TextBoxEnterCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TextBoxEnterCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.TextBoxEnterCode.BorderRadius = 20;
            this.TextBoxEnterCode.BorderSize = 2;
            this.TextBoxEnterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEnterCode.Location = new System.Drawing.Point(42, 105);
            this.TextBoxEnterCode.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEnterCode.Multiline = false;
            this.TextBoxEnterCode.Name = "TextBoxEnterCode";
            this.TextBoxEnterCode.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.TextBoxEnterCode.PasswordChar = true;
            this.TextBoxEnterCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxEnterCode.PlaceholderText = "Enter Code";
            this.TextBoxEnterCode.Size = new System.Drawing.Size(250, 38);
            this.TextBoxEnterCode.TabIndex = 5;
            this.TextBoxEnterCode.Texts = "";
            this.TextBoxEnterCode.UnderlinedStyle = false;
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(228)))), ((int)(((byte)(185)))));
            this.buttonResetPassword.BorderColor = System.Drawing.Color.Lime;
            this.buttonResetPassword.BorderRadius = 20;
            this.buttonResetPassword.BorderSize = 1;
            this.buttonResetPassword.FlatAppearance.BorderSize = 0;
            this.buttonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPassword.ForeColor = System.Drawing.Color.DimGray;
            this.buttonResetPassword.Location = new System.Drawing.Point(42, 354);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(250, 40);
            this.buttonResetPassword.TabIndex = 6;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = false;
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.labelTittle.Location = new System.Drawing.Point(61, 32);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(213, 31);
            this.labelTittle.TabIndex = 7;
            this.labelTittle.Text = "Reset Password";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DimGray;
            this.button.Location = new System.Drawing.Point(263, 194);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(29, 29);
            this.button.TabIndex = 8;
            this.button.UseVisualStyleBackColor = false;
            // 
            // FormResetPasswordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.TextBoxEnterCode);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormResetPasswordcs";
            this.Text = "FormResetPasswordcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomTextBox textBoxPassword;
        private CustomControls.CustomTextBox TextBoxEnterCode;
        private CustomControls.CustomButton buttonResetPassword;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button button;
    }
}