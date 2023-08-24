namespace A_Friend
{
    partial class FormForgotPassword
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
            this.labelTittle = new System.Windows.Forms.Label();
            this.textBoxUserName = new A_Friend.CustomControls.CustomTextBox();
            this.TextBoxEmail = new A_Friend.CustomControls.CustomTextBox();
            this.buttonSendCode = new A_Friend.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.labelTittle.Location = new System.Drawing.Point(57, 24);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(220, 31);
            this.labelTittle.TabIndex = 1;
            this.labelTittle.Text = "Forgot Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.textBoxUserName.BorderRadius = 20;
            this.textBoxUserName.BorderSize = 2;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(42, 116);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Multiline = false;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.textBoxUserName.PasswordChar = false;
            this.textBoxUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUserName.PlaceholderText = "User name";
            this.textBoxUserName.Size = new System.Drawing.Size(250, 38);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.Texts = "";
            this.textBoxUserName.UnderlinedStyle = false;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(75)))), ((int)(((byte)(133)))));
            this.TextBoxEmail.BorderRadius = 20;
            this.TextBoxEmail.BorderSize = 2;
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(42, 194);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Multiline = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.TextBoxEmail.PasswordChar = false;
            this.TextBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxEmail.PlaceholderText = "Email";
            this.TextBoxEmail.Size = new System.Drawing.Size(250, 38);
            this.TextBoxEmail.TabIndex = 6;
            this.TextBoxEmail.Texts = "";
            this.TextBoxEmail.UnderlinedStyle = false;
            // 
            // buttonSendCode
            // 
            this.buttonSendCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(228)))), ((int)(((byte)(185)))));
            this.buttonSendCode.BorderColor = System.Drawing.Color.Lime;
            this.buttonSendCode.BorderRadius = 20;
            this.buttonSendCode.BorderSize = 1;
            this.buttonSendCode.FlatAppearance.BorderSize = 0;
            this.buttonSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendCode.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSendCode.Location = new System.Drawing.Point(42, 321);
            this.buttonSendCode.Name = "buttonSendCode";
            this.buttonSendCode.Size = new System.Drawing.Size(250, 40);
            this.buttonSendCode.TabIndex = 5;
            this.buttonSendCode.Text = "SEND CODE";
            this.buttonSendCode.UseVisualStyleBackColor = false;
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.buttonSendCode);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelTittle);
            this.Name = "FormForgotPassword";
            this.Text = "FormForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittle;
        private CustomControls.CustomTextBox textBoxUserName;
        private CustomControls.CustomTextBox TextBoxEmail;
        private CustomControls.CustomButton buttonSendCode;
    }
}