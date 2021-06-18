namespace InvestmentTracker
{
    partial class UserInterface
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
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(13, 28);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(81, 17);
            this.uxUsernameLabel.TabIndex = 0;
            this.uxUsernameLabel.Text = "Username: ";
            // 
            // uxUsername
            // 
            this.uxUsername.Location = new System.Drawing.Point(101, 28);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(304, 22);
            this.uxUsername.TabIndex = 1;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(101, 65);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(304, 22);
            this.uxPassword.TabIndex = 2;
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(13, 68);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.uxPasswordLabel.TabIndex = 3;
            this.uxPasswordLabel.Text = "Password:";
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(164, 102);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(93, 23);
            this.uxSubmit.TabIndex = 4;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 137);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxUsernameLabel);
            this.Name = "UserInterface";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.Button uxSubmit;
    }
}