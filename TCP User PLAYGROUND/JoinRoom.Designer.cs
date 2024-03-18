namespace TCP_User_PLAYGROUND
{
    partial class JoinRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputServerIP = new System.Windows.Forms.TextBox();
            this.buttonJoint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Join Chatroom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputServerIP);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target IP-Adress";
            // 
            // inputServerIP
            // 
            this.inputServerIP.Location = new System.Drawing.Point(6, 32);
            this.inputServerIP.Name = "inputServerIP";
            this.inputServerIP.Size = new System.Drawing.Size(295, 29);
            this.inputServerIP.TabIndex = 0;
            // 
            // buttonJoint
            // 
            this.buttonJoint.BackgroundImage = global::TCP_User_PLAYGROUND.Properties.Resources.broccoli;
            this.buttonJoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJoint.Location = new System.Drawing.Point(13, 146);
            this.buttonJoint.Name = "buttonJoint";
            this.buttonJoint.Size = new System.Drawing.Size(307, 145);
            this.buttonJoint.TabIndex = 2;
            this.buttonJoint.UseVisualStyleBackColor = true;
            // 
            // JoinRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.buttonJoint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "JoinRoom";
            this.Text = "JoinRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputServerIP;
        private System.Windows.Forms.Button buttonJoint;
    }
}