namespace TCP_User_PLAYGROUND
{
    partial class AddChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputTargteIP = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAddChat = new System.Windows.Forms.Button();
            this.inputUsername.SuspendLayout();
            this.inputTargteIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Chat";
            // 
            // inputUsername
            // 
            this.inputUsername.Controls.Add(this.textBox1);
            this.inputUsername.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(19, 71);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(301, 67);
            this.inputUsername.TabIndex = 1;
            this.inputUsername.TabStop = false;
            this.inputUsername.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.textBox1.Location = new System.Drawing.Point(7, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 30);
            this.textBox1.TabIndex = 0;
            // 
            // inputTargteIP
            // 
            this.inputTargteIP.Controls.Add(this.textBox2);
            this.inputTargteIP.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTargteIP.Location = new System.Drawing.Point(19, 144);
            this.inputTargteIP.Name = "inputTargteIP";
            this.inputTargteIP.Size = new System.Drawing.Size(301, 67);
            this.inputTargteIP.TabIndex = 2;
            this.inputTargteIP.TabStop = false;
            this.inputTargteIP.Text = "Target IP-Address";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.textBox2.Location = new System.Drawing.Point(7, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 30);
            this.textBox2.TabIndex = 0;
            // 
            // buttonAddChat
            // 
            this.buttonAddChat.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddChat.Location = new System.Drawing.Point(19, 236);
            this.buttonAddChat.Name = "buttonAddChat";
            this.buttonAddChat.Size = new System.Drawing.Size(301, 55);
            this.buttonAddChat.TabIndex = 3;
            this.buttonAddChat.Text = "@";
            this.buttonAddChat.UseVisualStyleBackColor = true;
            // 
            // AddChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.buttonAddChat);
            this.Controls.Add(this.inputTargteIP);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label1);
            this.Name = "AddChat";
            this.Text = "AddChat";
            this.inputUsername.ResumeLayout(false);
            this.inputUsername.PerformLayout();
            this.inputTargteIP.ResumeLayout(false);
            this.inputTargteIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox inputUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox inputTargteIP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAddChat;
    }
}