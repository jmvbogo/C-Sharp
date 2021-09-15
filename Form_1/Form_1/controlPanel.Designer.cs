namespace Form_1
{
    partial class ControlPanel
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.panelContact = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsrName = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblUsrFdbck = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelContact.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(136, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Contcts";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.Location = new System.Drawing.Point(29, 32);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(101, 23);
            this.btnEdt.TabIndex = 2;
            this.btnEdt.Text = "Edit Contact";
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(136, 32);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(101, 23);
            this.btnDlt.TabIndex = 3;
            this.btnDlt.Text = "Delete Contact";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.btnEdt);
            this.panelContact.Controls.Add(this.btnAdd);
            this.panelContact.Controls.Add(this.btnSearch);
            this.panelContact.Controls.Add(this.btnDlt);
            this.panelContact.Location = new System.Drawing.Point(12, 109);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(268, 63);
            this.panelContact.TabIndex = 4;
            this.panelContact.Visible = false;
            // 
            // panelLog
            // 
            this.panelLog.Controls.Add(this.txtPassword);
            this.panelLog.Controls.Add(this.txtUsrName);
            this.panelLog.Controls.Add(this.lblPassword);
            this.panelLog.Controls.Add(this.lblUsrName);
            this.panelLog.Controls.Add(this.btnLogIn);
            this.panelLog.Location = new System.Drawing.Point(12, 12);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(268, 79);
            this.panelLog.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPassword.Location = new System.Drawing.Point(138, 28);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsrName
            // 
            this.txtUsrName.Location = new System.Drawing.Point(31, 27);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(100, 20);
            this.txtUsrName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(137, 12);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsrName
            // 
            this.lblUsrName.AutoSize = true;
            this.lblUsrName.Location = new System.Drawing.Point(28, 11);
            this.lblUsrName.Name = "lblUsrName";
            this.lblUsrName.Size = new System.Drawing.Size(55, 13);
            this.lblUsrName.TabIndex = 2;
            this.lblUsrName.Text = "Username";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(80, 53);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(101, 23);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblUsrFdbck
            // 
            this.lblUsrFdbck.AutoSize = true;
            this.lblUsrFdbck.Location = new System.Drawing.Point(13, 203);
            this.lblUsrFdbck.Name = "lblUsrFdbck";
            this.lblUsrFdbck.Size = new System.Drawing.Size(0, 13);
            this.lblUsrFdbck.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(92, 38);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 23);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 325);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUsrFdbck);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelContact);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.panelContact.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsrName;
        private System.Windows.Forms.Label lblUsrFdbck;
        private System.Windows.Forms.Button btnLogOut;
    }
}