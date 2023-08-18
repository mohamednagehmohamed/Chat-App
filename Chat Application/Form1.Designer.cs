namespace Chat_Application
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtremoteip = new System.Windows.Forms.TextBox();
            this.txtremoteport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalport = new System.Windows.Forms.TextBox();
            this.txtlocalip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.messages = new System.Windows.Forms.ListBox();
            this.txtmessages = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtremoteport);
            this.groupBox3.Controls.Add(this.txtremoteip);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(322, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Friend";
            // 
            // txtremoteip
            // 
            this.txtremoteip.Location = new System.Drawing.Point(83, 25);
            this.txtremoteip.Multiline = true;
            this.txtremoteip.Name = "txtremoteip";
            this.txtremoteip.Size = new System.Drawing.Size(186, 30);
            this.txtremoteip.TabIndex = 0;
            // 
            // txtremoteport
            // 
            this.txtremoteport.Location = new System.Drawing.Point(83, 81);
            this.txtremoteport.Multiline = true;
            this.txtremoteport.Name = "txtremoteport";
            this.txtremoteport.Size = new System.Drawing.Size(186, 30);
            this.txtremoteport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtlocalport);
            this.groupBox4.Controls.Add(this.txtlocalip);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 132);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP";
            // 
            // txtlocalport
            // 
            this.txtlocalport.Location = new System.Drawing.Point(83, 81);
            this.txtlocalport.Multiline = true;
            this.txtlocalport.Name = "txtlocalport";
            this.txtlocalport.Size = new System.Drawing.Size(186, 30);
            this.txtlocalport.TabIndex = 1;
            // 
            // txtlocalip
            // 
            this.txtlocalip.Location = new System.Drawing.Point(83, 25);
            this.txtlocalip.Multiline = true;
            this.txtlocalip.Name = "txtlocalip";
            this.txtlocalip.Size = new System.Drawing.Size(186, 30);
            this.txtlocalip.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(625, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // messages
            // 
            this.messages.FormattingEnabled = true;
            this.messages.Location = new System.Drawing.Point(12, 177);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(607, 186);
            this.messages.TabIndex = 3;
            // 
            // txtmessages
            // 
            this.txtmessages.Location = new System.Drawing.Point(12, 403);
            this.txtmessages.Multiline = true;
            this.txtmessages.Name = "txtmessages";
            this.txtmessages.Size = new System.Drawing.Size(607, 30);
            this.txtmessages.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(625, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(737, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtmessages);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtremoteport;
        private System.Windows.Forms.TextBox txtremoteip;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalport;
        private System.Windows.Forms.TextBox txtlocalip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.TextBox txtmessages;
        private System.Windows.Forms.Button button3;
    }
}

