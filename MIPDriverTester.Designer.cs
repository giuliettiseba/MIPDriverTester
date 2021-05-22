namespace MIPDriverTester
{
    partial class MIPDriverTester
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.port_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MACAddress_TextBox = new System.Windows.Forms.TextBox();
            this.outout_TextBox = new System.Windows.Forms.TextBox();
            this.sendMetadataTest_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.activeSessions_TextBox = new System.Windows.Forms.TextBox();
            this.IsConnected_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.started_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(21, 134);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(104, 134);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // userName_TextBox
            // 
            this.userName_TextBox.Location = new System.Drawing.Point(79, 38);
            this.userName_TextBox.Name = "userName_TextBox";
            this.userName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.userName_TextBox.TabIndex = 3;
            this.userName_TextBox.Text = "root";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(79, 61);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.password_TextBox.TabIndex = 3;
            this.password_TextBox.Text = "pass";
            // 
            // port_TextBox
            // 
            this.port_TextBox.Location = new System.Drawing.Point(79, 84);
            this.port_TextBox.Name = "port_TextBox";
            this.port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.port_TextBox.TabIndex = 3;
            this.port_TextBox.Text = "52123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MAC";
            // 
            // MACAddress_TextBox
            // 
            this.MACAddress_TextBox.Location = new System.Drawing.Point(79, 108);
            this.MACAddress_TextBox.Name = "MACAddress_TextBox";
            this.MACAddress_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MACAddress_TextBox.TabIndex = 3;
            this.MACAddress_TextBox.Text = "001122334455";
            // 
            // outout_TextBox
            // 
            this.outout_TextBox.Location = new System.Drawing.Point(216, 38);
            this.outout_TextBox.Multiline = true;
            this.outout_TextBox.Name = "outout_TextBox";
            this.outout_TextBox.Size = new System.Drawing.Size(407, 219);
            this.outout_TextBox.TabIndex = 4;
            // 
            // sendMetadataTest_button
            // 
            this.sendMetadataTest_button.Location = new System.Drawing.Point(216, 263);
            this.sendMetadataTest_button.Name = "sendMetadataTest_button";
            this.sendMetadataTest_button.Size = new System.Drawing.Size(407, 23);
            this.sendMetadataTest_button.TabIndex = 5;
            this.sendMetadataTest_button.Text = "Send Metadata Test";
            this.sendMetadataTest_button.UseVisualStyleBackColor = true;
            this.sendMetadataTest_button.Click += new System.EventHandler(this.sendMetadataTest_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ActiveSessions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "IsConnected";
            // 
            // activeSessions_TextBox
            // 
            this.activeSessions_TextBox.Location = new System.Drawing.Point(104, 196);
            this.activeSessions_TextBox.Name = "activeSessions_TextBox";
            this.activeSessions_TextBox.Size = new System.Drawing.Size(100, 20);
            this.activeSessions_TextBox.TabIndex = 7;
            // 
            // IsConnected_TextBox
            // 
            this.IsConnected_TextBox.Location = new System.Drawing.Point(104, 222);
            this.IsConnected_TextBox.Name = "IsConnected_TextBox";
            this.IsConnected_TextBox.Size = new System.Drawing.Size(100, 20);
            this.IsConnected_TextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Started";
            // 
            // started_TextBox
            // 
            this.started_TextBox.Location = new System.Drawing.Point(104, 169);
            this.started_TextBox.Name = "started_TextBox";
            this.started_TextBox.Size = new System.Drawing.Size(100, 20);
            this.started_TextBox.TabIndex = 7;
            // 
            // MIPDriverTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 297);
            this.Controls.Add(this.IsConnected_TextBox);
            this.Controls.Add(this.started_TextBox);
            this.Controls.Add(this.activeSessions_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendMetadataTest_button);
            this.Controls.Add(this.outout_TextBox);
            this.Controls.Add(this.MACAddress_TextBox);
            this.Controls.Add(this.port_TextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "MIPDriverTester";
            this.Text = "MIPDriverTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox port_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MACAddress_TextBox;
        private System.Windows.Forms.TextBox outout_TextBox;
        private System.Windows.Forms.Button sendMetadataTest_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox activeSessions_TextBox;
        private System.Windows.Forms.TextBox IsConnected_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox started_TextBox;
    }
}

