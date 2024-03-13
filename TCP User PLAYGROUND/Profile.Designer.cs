namespace TCP_User_PLAYGROUND
{
    partial class Profile
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
            this.labelProfile = new System.Windows.Forms.Label();
            this.groupBoxUsername = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConfirmProfile = new System.Windows.Forms.Button();
            this.groupBoxUsername.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(13, 13);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(70, 24);
            this.labelProfile.TabIndex = 0;
            this.labelProfile.Text = "Profile";
            // 
            // groupBoxUsername
            // 
            this.groupBoxUsername.Controls.Add(this.textBoxUsername);
            this.groupBoxUsername.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsername.Location = new System.Drawing.Point(13, 52);
            this.groupBoxUsername.Name = "groupBoxUsername";
            this.groupBoxUsername.Size = new System.Drawing.Size(311, 66);
            this.groupBoxUsername.TabIndex = 1;
            this.groupBoxUsername.TabStop = false;
            this.groupBoxUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(6, 28);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(299, 32);
            this.textBoxUsername.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(6, 28);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(299, 32);
            this.textBoxIP.TabIndex = 0;
            // 
            // buttonConfirmProfile
            // 
            this.buttonConfirmProfile.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmProfile.Location = new System.Drawing.Point(13, 237);
            this.buttonConfirmProfile.Name = "buttonConfirmProfile";
            this.buttonConfirmProfile.Size = new System.Drawing.Size(311, 54);
            this.buttonConfirmProfile.TabIndex = 3;
            this.buttonConfirmProfile.Text = "Confirm";
            this.buttonConfirmProfile.UseVisualStyleBackColor = true;
            this.buttonConfirmProfile.Click += new System.EventHandler(this.buttonConfirmProfile_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 306);
            this.Controls.Add(this.buttonConfirmProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUsername);
            this.Controls.Add(this.labelProfile);
            this.Name = "Profile";
            this.Text = "Profile";
            this.groupBoxUsername.ResumeLayout(false);
            this.groupBoxUsername.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.GroupBox groupBoxUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConfirmProfile;
    }
}