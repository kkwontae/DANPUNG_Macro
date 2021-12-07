namespace DANPUNG
{
    partial class addStringCopy
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
            this.txtCopyString = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtStringItem = new System.Windows.Forms.TextBox();
            this.txtStringCode = new System.Windows.Forms.TextBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCopyString
            // 
            this.txtCopyString.Location = new System.Drawing.Point(12, 12);
            this.txtCopyString.Multiline = true;
            this.txtCopyString.Name = "txtCopyString";
            this.txtCopyString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCopyString.Size = new System.Drawing.Size(260, 88);
            this.txtCopyString.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(116, 108);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtStringItem
            // 
            this.txtStringItem.Location = new System.Drawing.Point(136, 110);
            this.txtStringItem.Name = "txtStringItem";
            this.txtStringItem.Size = new System.Drawing.Size(55, 21);
            this.txtStringItem.TabIndex = 4;
            this.txtStringItem.Visible = false;
            // 
            // txtStringCode
            // 
            this.txtStringCode.Location = new System.Drawing.Point(197, 110);
            this.txtStringCode.Name = "txtStringCode";
            this.txtStringCode.Size = new System.Drawing.Size(55, 21);
            this.txtStringCode.TabIndex = 5;
            this.txtStringCode.Visible = false;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(44, 110);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(37, 21);
            this.txtDelay.TabIndex = 6;
            this.txtDelay.Text = "0";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(87, 119);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(23, 12);
            this.ms.TabIndex = 7;
            this.ms.Text = "ms";
            // 
            // addStringCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtStringCode);
            this.Controls.Add(this.txtStringItem);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCopyString);
            this.Name = "addStringCopy";
            this.Text = "addStringCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopyString;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.TextBox txtStringItem;
        public System.Windows.Forms.TextBox txtStringCode;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label ms;
    }
}