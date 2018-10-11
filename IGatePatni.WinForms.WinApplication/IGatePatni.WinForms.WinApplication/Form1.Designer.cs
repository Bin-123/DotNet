namespace IGatePatni.WinForms.WinApplication
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnwelcome = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(62, 103);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnwelcome
            // 
            this.btnwelcome.Location = new System.Drawing.Point(180, 103);
            this.btnwelcome.Name = "btnwelcome";
            this.btnwelcome.Size = new System.Drawing.Size(75, 23);
            this.btnwelcome.TabIndex = 1;
            this.btnwelcome.Text = "Welcome";
            this.btnwelcome.UseVisualStyleBackColor = true;
            this.btnwelcome.Click += new System.EventHandler(this.btnwelcome_Click);
            this.btnwelcome.MouseEnter += new System.EventHandler(this.btnwelcome_MouseEnter);
            this.btnwelcome.MouseLeave += new System.EventHandler(this.btnwelcome_MouseLeave);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(74, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(63, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Enter Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(180, 45);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(51, 20);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.MouseHover += new System.EventHandler(this.txtname_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 185);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnwelcome);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Welcome Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnwelcome;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
    }
}

