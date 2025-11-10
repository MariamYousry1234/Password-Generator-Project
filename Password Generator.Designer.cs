
namespace Password_Generator_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSymbols = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password Length:";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(255, 87);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(228, 26);
            this.txtLength.TabIndex = 1;
            this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkSymbols);
            this.groupBox1.Controls.Add(this.chkNumbers);
            this.groupBox1.Controls.Add(this.chkLowerCase);
            this.groupBox1.Controls.Add(this.chkUpperCase);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(217, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters Used";
            // 
            // chkSymbols
            // 
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.ForeColor = System.Drawing.Color.Lime;
            this.chkSymbols.Location = new System.Drawing.Point(170, 108);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(116, 30);
            this.chkSymbols.TabIndex = 3;
            this.chkSymbols.Tag = "0";
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.ForeColor = System.Drawing.Color.Lime;
            this.chkNumbers.Location = new System.Drawing.Point(6, 108);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(124, 30);
            this.chkNumbers.TabIndex = 2;
            this.chkNumbers.Tag = "0";
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.ForeColor = System.Drawing.Color.Lime;
            this.chkLowerCase.Location = new System.Drawing.Point(164, 61);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(141, 30);
            this.chkLowerCase.TabIndex = 1;
            this.chkLowerCase.Tag = "0";
            this.chkLowerCase.Text = "Lowercase";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.ForeColor = System.Drawing.Color.Lime;
            this.chkUpperCase.Location = new System.Drawing.Point(6, 61);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(139, 30);
            this.chkUpperCase.TabIndex = 0;
            this.chkUpperCase.Tag = "0";
            this.chkUpperCase.Text = "Uppercase";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.Location = new System.Drawing.Point(269, 371);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(204, 37);
            this.btnGeneratePassword.TabIndex = 3;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(121, 450);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(550, 55);
            this.txtPassword.TabIndex = 4;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.BackColor = System.Drawing.Color.Red;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.Location = new System.Drawing.Point(520, 462);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(151, 31);
            this.btnCopyPassword.TabIndex = 5;
            this.btnCopyPassword.Text = "Copy Password";
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Password_Generator_Project.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 540);
            this.Controls.Add(this.btnCopyPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSymbols;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

