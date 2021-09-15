namespace Jedi_Name_Generator
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
            this.txtfrstnm = new System.Windows.Forms.TextBox();
            this.txtlstnm = new System.Windows.Forms.TextBox();
            this.txtmthrmdnnm = new System.Windows.Forms.TextBox();
            this.txtplcbrn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsbmt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfdbk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfrstnm
            // 
            this.txtfrstnm.Location = new System.Drawing.Point(32, 202);
            this.txtfrstnm.Name = "txtfrstnm";
            this.txtfrstnm.Size = new System.Drawing.Size(335, 38);
            this.txtfrstnm.TabIndex = 0;
            // 
            // txtlstnm
            // 
            this.txtlstnm.Location = new System.Drawing.Point(469, 202);
            this.txtlstnm.Name = "txtlstnm";
            this.txtlstnm.Size = new System.Drawing.Size(335, 38);
            this.txtlstnm.TabIndex = 1;
            // 
            // txtmthrmdnnm
            // 
            this.txtmthrmdnnm.Location = new System.Drawing.Point(32, 360);
            this.txtmthrmdnnm.Name = "txtmthrmdnnm";
            this.txtmthrmdnnm.Size = new System.Drawing.Size(335, 38);
            this.txtmthrmdnnm.TabIndex = 2;
            // 
            // txtplcbrn
            // 
            this.txtplcbrn.Location = new System.Drawing.Point(469, 360);
            this.txtplcbrn.Name = "txtplcbrn";
            this.txtplcbrn.Size = new System.Drawing.Size(335, 38);
            this.txtplcbrn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mother\'s Maiden Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Born City/Town you were?";
            // 
            // btnsbmt
            // 
            this.btnsbmt.Location = new System.Drawing.Point(317, 451);
            this.btnsbmt.Name = "btnsbmt";
            this.btnsbmt.Size = new System.Drawing.Size(198, 72);
            this.btnsbmt.TabIndex = 8;
            this.btnsbmt.Text = "Submit";
            this.btnsbmt.UseVisualStyleBackColor = true;
            this.btnsbmt.Click += new System.EventHandler(this.btnsbmt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(1, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(754, 83);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jedi Name Generator";
            // 
            // lblfdbk
            // 
            this.lblfdbk.AutoSize = true;
            this.lblfdbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfdbk.Location = new System.Drawing.Point(284, 567);
            this.lblfdbk.Name = "lblfdbk";
            this.lblfdbk.Size = new System.Drawing.Size(0, 39);
            this.lblfdbk.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(824, 724);
            this.Controls.Add(this.lblfdbk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsbmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplcbrn);
            this.Controls.Add(this.txtmthrmdnnm);
            this.Controls.Add(this.txtlstnm);
            this.Controls.Add(this.txtfrstnm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfrstnm;
        private System.Windows.Forms.TextBox txtlstnm;
        private System.Windows.Forms.TextBox txtmthrmdnnm;
        private System.Windows.Forms.TextBox txtplcbrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsbmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblfdbk;
    }
}

