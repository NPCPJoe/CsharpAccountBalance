namespace Account_balance
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
            this.RBDeposit = new System.Windows.Forms.RadioButton();
            this.RBCheck = new System.Windows.Forms.RadioButton();
            this.RBServicecharge = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBTransactionamount = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSummary = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TBNewaccountbalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RBDeposit
            // 
            this.RBDeposit.AutoSize = true;
            this.RBDeposit.Location = new System.Drawing.Point(22, 19);
            this.RBDeposit.Name = "RBDeposit";
            this.RBDeposit.Size = new System.Drawing.Size(77, 21);
            this.RBDeposit.TabIndex = 0;
            this.RBDeposit.TabStop = true;
            this.RBDeposit.Text = "Deposit";
            this.RBDeposit.UseVisualStyleBackColor = true;
            // 
            // RBCheck
            // 
            this.RBCheck.AutoSize = true;
            this.RBCheck.Location = new System.Drawing.Point(22, 46);
            this.RBCheck.Name = "RBCheck";
            this.RBCheck.Size = new System.Drawing.Size(68, 21);
            this.RBCheck.TabIndex = 1;
            this.RBCheck.TabStop = true;
            this.RBCheck.Text = "Check";
            this.RBCheck.UseVisualStyleBackColor = true;
            // 
            // RBServicecharge
            // 
            this.RBServicecharge.AutoSize = true;
            this.RBServicecharge.Location = new System.Drawing.Point(22, 73);
            this.RBServicecharge.Name = "RBServicecharge";
            this.RBServicecharge.Size = new System.Drawing.Size(126, 21);
            this.RBServicecharge.TabIndex = 2;
            this.RBServicecharge.TabStop = true;
            this.RBServicecharge.Text = "Service Charge";
            this.RBServicecharge.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Account Balance";
            // 
            // TBTransactionamount
            // 
            this.TBTransactionamount.Location = new System.Drawing.Point(403, 27);
            this.TBTransactionamount.Name = "TBTransactionamount";
            this.TBTransactionamount.Size = new System.Drawing.Size(143, 22);
            this.TBTransactionamount.TabIndex = 5;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(168, 161);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 48);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(306, 161);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(120, 48);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSummary
            // 
            this.BtnSummary.Location = new System.Drawing.Point(446, 161);
            this.BtnSummary.Name = "BtnSummary";
            this.BtnSummary.Size = new System.Drawing.Size(120, 48);
            this.BtnSummary.TabIndex = 8;
            this.BtnSummary.Text = "Summary";
            this.BtnSummary.UseVisualStyleBackColor = true;
            this.BtnSummary.Click += new System.EventHandler(this.BtnSummary_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(33, 161);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(120, 48);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TBNewaccountbalance
            // 
            this.TBNewaccountbalance.Enabled = false;
            this.TBNewaccountbalance.Location = new System.Drawing.Point(403, 73);
            this.TBNewaccountbalance.Name = "TBNewaccountbalance";
            this.TBNewaccountbalance.Size = new System.Drawing.Size(143, 22);
            this.TBNewaccountbalance.TabIndex = 10;
            this.TBNewaccountbalance.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 221);
            this.Controls.Add(this.TBNewaccountbalance);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnSummary);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TBTransactionamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBServicecharge);
            this.Controls.Add(this.RBCheck);
            this.Controls.Add(this.RBDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBDeposit;
        private System.Windows.Forms.RadioButton RBCheck;
        private System.Windows.Forms.RadioButton RBServicecharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBTransactionamount;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSummary;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TBNewaccountbalance;
    }
}

