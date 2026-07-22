namespace HelloWorldWinApp
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkExclamation = new System.Windows.Forms.CheckBox();
            this.btnGreet = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblSource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(25, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(824, 182);
            this.lblDescription.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 252);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter your name:";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(41, 344);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 25);
            this.lblGreeting.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 252);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 4;
            // 
            // chkExclamation
            // 
            this.chkExclamation.AutoSize = true;
            this.chkExclamation.Location = new System.Drawing.Point(46, 293);
            this.chkExclamation.Name = "chkExclamation";
            this.chkExclamation.Size = new System.Drawing.Size(171, 20);
            this.chkExclamation.TabIndex = 5;
            this.chkExclamation.Text = "Add extra enthusiasm (!)";
            this.chkExclamation.UseVisualStyleBackColor = true;
            // 
            // btnGreet
            // 
            this.btnGreet.Location = new System.Drawing.Point(351, 246);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(96, 29);
            this.btnGreet.TabIndex = 6;
            this.btnGreet.Text = "Say Hello";
            this.btnGreet.UseVisualStyleBackColor = true;
            this.btnGreet.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(103, 400);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Atul-Arc";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(44, 400);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(53, 16);
            this.lblSource.TabIndex = 8;
            this.lblSource.Text = "Source:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 438);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.chkExclamation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkExclamation;
        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblSource;
    }
}

