namespace DANPUNG
{
    partial class addKeyEvent
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listKey = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbWin = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.cbCtrl = new System.Windows.Forms.CheckBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cbKeyDown = new System.Windows.Forms.CheckBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(158, 147);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 20);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(87, 147);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(66, 20);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key";
            // 
            // listKey
            // 
            this.listKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listKey.FormattingEnabled = true;
            this.listKey.Location = new System.Drawing.Point(63, 20);
            this.listKey.Name = "listKey";
            this.listKey.Size = new System.Drawing.Size(119, 20);
            this.listKey.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbWin);
            this.groupBox2.Controls.Add(this.cbShift);
            this.groupBox2.Controls.Add(this.cbAlt);
            this.groupBox2.Controls.Add(this.cbCtrl);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 71);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifier Key";
            // 
            // cbWin
            // 
            this.cbWin.AutoSize = true;
            this.cbWin.Location = new System.Drawing.Point(63, 42);
            this.cbWin.Name = "cbWin";
            this.cbWin.Size = new System.Drawing.Size(44, 16);
            this.cbWin.TabIndex = 22;
            this.cbWin.Text = "Win";
            this.cbWin.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Location = new System.Drawing.Point(63, 20);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(48, 16);
            this.cbShift.TabIndex = 21;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Location = new System.Drawing.Point(6, 42);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(38, 16);
            this.cbAlt.TabIndex = 20;
            this.cbAlt.Text = "Alt";
            this.cbAlt.UseVisualStyleBackColor = true;
            // 
            // cbCtrl
            // 
            this.cbCtrl.AutoSize = true;
            this.cbCtrl.Location = new System.Drawing.Point(6, 20);
            this.cbCtrl.Name = "cbCtrl";
            this.cbCtrl.Size = new System.Drawing.Size(43, 16);
            this.cbCtrl.TabIndex = 19;
            this.cbCtrl.Text = "Ctrl";
            this.cbCtrl.UseVisualStyleBackColor = true;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(18, 146);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(38, 21);
            this.txtEvent.TabIndex = 17;
            this.txtEvent.Visible = false;
            this.txtEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvent_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(62, 146);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(38, 21);
            this.txtCode.TabIndex = 0;
            this.txtCode.Visible = false;
            // 
            // cbKeyDown
            // 
            this.cbKeyDown.AutoSize = true;
            this.cbKeyDown.Location = new System.Drawing.Point(146, 89);
            this.cbKeyDown.Name = "cbKeyDown";
            this.cbKeyDown.Size = new System.Drawing.Size(78, 16);
            this.cbKeyDown.TabIndex = 23;
            this.cbKeyDown.Text = "KeyDown";
            this.cbKeyDown.UseVisualStyleBackColor = true;
            this.cbKeyDown.CheckedChanged += new System.EventHandler(this.cbKeyDown_CheckedChanged);
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(146, 111);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(47, 21);
            this.txtDown.TabIndex = 24;
            this.txtDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "ms";
            // 
            // addKeyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(231, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.cbKeyDown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtEvent);
            this.Name = "addKeyEvent";
            this.Text = "Add KeyBoard Event";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.ComboBox listKey;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.CheckBox cbCtrl;
        private System.Windows.Forms.CheckBox cbAlt;
        private System.Windows.Forms.CheckBox cbWin;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.CheckBox cbKeyDown;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDown;
    }
}