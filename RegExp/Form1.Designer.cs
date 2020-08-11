namespace RegExp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrslt = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btncheckNumber = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(118, 312);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(308, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(196, 357);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(98, 29);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(118, 58);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(308, 20);
            this.txtPattern.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pattern";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // lblrslt
            // 
            this.lblrslt.AutoSize = true;
            this.lblrslt.BackColor = System.Drawing.Color.White;
            this.lblrslt.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrslt.ForeColor = System.Drawing.Color.Green;
            this.lblrslt.Location = new System.Drawing.Point(218, 271);
            this.lblrslt.Name = "lblrslt";
            this.lblrslt.Size = new System.Drawing.Size(0, 23);
            this.lblrslt.TabIndex = 5;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(118, 139);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(183, 20);
            this.txtnumber.TabIndex = 6;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(118, 198);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(183, 20);
            this.txtmail.TabIndex = 7;
            // 
            // btncheckNumber
            // 
            this.btncheckNumber.Location = new System.Drawing.Point(308, 139);
            this.btncheckNumber.Name = "btncheckNumber";
            this.btncheckNumber.Size = new System.Drawing.Size(118, 23);
            this.btncheckNumber.TabIndex = 8;
            this.btncheckNumber.Text = "Check number";
            this.btncheckNumber.UseVisualStyleBackColor = true;
            this.btncheckNumber.Click += new System.EventHandler(this.btncheckNumber_Click);
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(308, 195);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(118, 23);
            this.btnMail.TabIndex = 9;
            this.btnMail.Text = "Check Email";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblNumber.Location = new System.Drawing.Point(451, 141);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 19);
            this.lblNumber.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.Blue;
            this.lblMail.Location = new System.Drawing.Point(451, 201);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(0, 19);
            this.lblMail.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 413);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btncheckNumber);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.lblrslt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrslt;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btncheckNumber;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMail;
    }
}

