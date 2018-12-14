namespace SimpleMD5Cracker
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
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrack = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(110, 12);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(435, 32);
            this.txtMD5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MD5 Hash";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(172, 50);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(373, 32);
            this.txtPasswd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cracked Password";
            // 
            // btnCrack
            // 
            this.btnCrack.AutoSize = true;
            this.btnCrack.Location = new System.Drawing.Point(460, 88);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(85, 33);
            this.btnCrack.TabIndex = 4;
            this.btnCrack.Text = "Crack!";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Location = new System.Drawing.Point(7, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(196, 33);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse for wordlists";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(557, 128);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMD5);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleMD5Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.Button btnBrowse;
    }
}

