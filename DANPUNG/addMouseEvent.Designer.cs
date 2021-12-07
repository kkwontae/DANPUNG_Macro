namespace DANPUNG
{
    partial class addMouseEvent
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
            this.Options = new System.Windows.Forms.GroupBox();
            this.valAction = new System.Windows.Forms.NumericUpDown();
            this.valButton = new System.Windows.Forms.NumericUpDown();
            this.ms = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btnMouseDown = new System.Windows.Forms.RadioButton();
            this.btnMouseUp = new System.Windows.Forms.RadioButton();
            this.btnDoubleClick = new System.Windows.Forms.RadioButton();
            this.btnClick = new System.Windows.Forms.RadioButton();
            this.Button = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.CursorPos = new System.Windows.Forms.GroupBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.txtPosY2 = new System.Windows.Forms.TextBox();
            this.txtPosX2 = new System.Windows.Forms.TextBox();
            this.PosY2 = new System.Windows.Forms.Label();
            this.PosX2 = new System.Windows.Forms.Label();
            this.Tip1 = new System.Windows.Forms.Label();
            this.txtPosY1 = new System.Windows.Forms.TextBox();
            this.txtPosX1 = new System.Windows.Forms.TextBox();
            this.PosY1 = new System.Windows.Forms.Label();
            this.PosX1 = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.valClickDelay = new System.Windows.Forms.NumericUpDown();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.valRandom = new System.Windows.Forms.NumericUpDown();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valButton)).BeginInit();
            this.CursorPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valClickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 304);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 20);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.valAction);
            this.Options.Controls.Add(this.valButton);
            this.Options.Controls.Add(this.ms);
            this.Options.Controls.Add(this.txtDelay);
            this.Options.Controls.Add(this.btnMouseDown);
            this.Options.Controls.Add(this.btnMouseUp);
            this.Options.Controls.Add(this.btnDoubleClick);
            this.Options.Controls.Add(this.btnClick);
            this.Options.Controls.Add(this.Button);
            this.Options.Controls.Add(this.btnButton);
            this.Options.Location = new System.Drawing.Point(13, 146);
            this.Options.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Options.Size = new System.Drawing.Size(226, 152);
            this.Options.TabIndex = 7;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // valAction
            // 
            this.valAction.Location = new System.Drawing.Point(179, 122);
            this.valAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valAction.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.valAction.Name = "valAction";
            this.valAction.Size = new System.Drawing.Size(28, 21);
            this.valAction.TabIndex = 13;
            this.valAction.Visible = false;
            // 
            // valButton
            // 
            this.valButton.Location = new System.Drawing.Point(146, 122);
            this.valButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valButton.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.valButton.Name = "valButton";
            this.valButton.Size = new System.Drawing.Size(28, 21);
            this.valButton.TabIndex = 12;
            this.valButton.Visible = false;
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(198, 83);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(23, 12);
            this.ms.TabIndex = 10;
            this.ms.Text = "ms";
            // 
            // txtDelay
            // 
            this.txtDelay.BackColor = System.Drawing.Color.LightGray;
            this.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelay.Enabled = false;
            this.txtDelay.Location = new System.Drawing.Point(162, 82);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDelay.Multiline = true;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.ReadOnly = true;
            this.txtDelay.Size = new System.Drawing.Size(34, 16);
            this.txtDelay.TabIndex = 6;
            this.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // btnMouseDown
            // 
            this.btnMouseDown.AutoSize = true;
            this.btnMouseDown.Location = new System.Drawing.Point(16, 102);
            this.btnMouseDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMouseDown.Name = "btnMouseDown";
            this.btnMouseDown.Size = new System.Drawing.Size(94, 16);
            this.btnMouseDown.TabIndex = 9;
            this.btnMouseDown.TabStop = true;
            this.btnMouseDown.Text = "MouseDown";
            this.btnMouseDown.UseVisualStyleBackColor = true;
            // 
            // btnMouseUp
            // 
            this.btnMouseUp.AutoSize = true;
            this.btnMouseUp.Location = new System.Drawing.Point(16, 122);
            this.btnMouseUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMouseUp.Name = "btnMouseUp";
            this.btnMouseUp.Size = new System.Drawing.Size(77, 16);
            this.btnMouseUp.TabIndex = 8;
            this.btnMouseUp.TabStop = true;
            this.btnMouseUp.Text = "MouseUp";
            this.btnMouseUp.UseVisualStyleBackColor = true;
            // 
            // btnDoubleClick
            // 
            this.btnDoubleClick.AutoSize = true;
            this.btnDoubleClick.Location = new System.Drawing.Point(16, 82);
            this.btnDoubleClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoubleClick.Name = "btnDoubleClick";
            this.btnDoubleClick.Size = new System.Drawing.Size(90, 16);
            this.btnDoubleClick.TabIndex = 7;
            this.btnDoubleClick.TabStop = true;
            this.btnDoubleClick.Text = "DoubleClick";
            this.btnDoubleClick.UseVisualStyleBackColor = true;
            // 
            // btnClick
            // 
            this.btnClick.AutoSize = true;
            this.btnClick.Location = new System.Drawing.Point(16, 62);
            this.btnClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(51, 16);
            this.btnClick.TabIndex = 6;
            this.btnClick.TabStop = true;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.Location = new System.Drawing.Point(23, 30);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(40, 12);
            this.Button.TabIndex = 5;
            this.Button.Text = "Button";
            // 
            // btnButton
            // 
            this.btnButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnButton.FormattingEnabled = true;
            this.btnButton.Items.AddRange(new object[] {
            "None",
            "L-Button",
            "R-Button",
            "Wheel"});
            this.btnButton.Location = new System.Drawing.Point(102, 27);
            this.btnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(106, 20);
            this.btnButton.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(104, 304);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(66, 20);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // CursorPos
            // 
            this.CursorPos.Controls.Add(this.cbRandom);
            this.CursorPos.Controls.Add(this.txtPosY2);
            this.CursorPos.Controls.Add(this.txtPosX2);
            this.CursorPos.Controls.Add(this.PosY2);
            this.CursorPos.Controls.Add(this.PosX2);
            this.CursorPos.Controls.Add(this.Tip1);
            this.CursorPos.Controls.Add(this.txtPosY1);
            this.CursorPos.Controls.Add(this.txtPosX1);
            this.CursorPos.Controls.Add(this.PosY1);
            this.CursorPos.Controls.Add(this.PosX1);
            this.CursorPos.Location = new System.Drawing.Point(10, 9);
            this.CursorPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CursorPos.Name = "CursorPos";
            this.CursorPos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CursorPos.Size = new System.Drawing.Size(226, 133);
            this.CursorPos.TabIndex = 6;
            this.CursorPos.TabStop = false;
            this.CursorPos.Text = "Cursor Pos";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(11, 55);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(71, 16);
            this.cbRandom.TabIndex = 18;
            this.cbRandom.Text = "Random";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // txtPosY2
            // 
            this.txtPosY2.Location = new System.Drawing.Point(167, 75);
            this.txtPosY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosY2.Name = "txtPosY2";
            this.txtPosY2.Size = new System.Drawing.Size(44, 21);
            this.txtPosY2.TabIndex = 8;
            // 
            // txtPosX2
            // 
            this.txtPosX2.Location = new System.Drawing.Point(52, 75);
            this.txtPosX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosX2.Name = "txtPosX2";
            this.txtPosX2.Size = new System.Drawing.Size(44, 21);
            this.txtPosX2.TabIndex = 7;
            // 
            // PosY2
            // 
            this.PosY2.AutoSize = true;
            this.PosY2.Location = new System.Drawing.Point(125, 78);
            this.PosY2.Name = "PosY2";
            this.PosY2.Size = new System.Drawing.Size(41, 12);
            this.PosY2.TabIndex = 6;
            this.PosY2.Text = "PosY2";
            // 
            // PosX2
            // 
            this.PosX2.AutoSize = true;
            this.PosX2.Location = new System.Drawing.Point(9, 78);
            this.PosX2.Name = "PosX2";
            this.PosX2.Size = new System.Drawing.Size(41, 12);
            this.PosX2.TabIndex = 5;
            this.PosX2.Text = "PosX2";
            // 
            // Tip1
            // 
            this.Tip1.AutoSize = true;
            this.Tip1.Location = new System.Drawing.Point(9, 105);
            this.Tip1.Name = "Tip1";
            this.Tip1.Size = new System.Drawing.Size(202, 12);
            this.Tip1.TabIndex = 4;
            this.Tip1.Text = "Press F1, F2 to get current position";
            // 
            // txtPosY1
            // 
            this.txtPosY1.Location = new System.Drawing.Point(167, 26);
            this.txtPosY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosY1.Name = "txtPosY1";
            this.txtPosY1.Size = new System.Drawing.Size(44, 21);
            this.txtPosY1.TabIndex = 3;
            this.txtPosY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // txtPosX1
            // 
            this.txtPosX1.Location = new System.Drawing.Point(52, 26);
            this.txtPosX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosX1.Name = "txtPosX1";
            this.txtPosX1.Size = new System.Drawing.Size(44, 21);
            this.txtPosX1.TabIndex = 2;
            this.txtPosX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // PosY1
            // 
            this.PosY1.AutoSize = true;
            this.PosY1.Location = new System.Drawing.Point(125, 29);
            this.PosY1.Name = "PosY1";
            this.PosY1.Size = new System.Drawing.Size(41, 12);
            this.PosY1.TabIndex = 1;
            this.PosY1.Text = "PosY1";
            // 
            // PosX1
            // 
            this.PosX1.AutoSize = true;
            this.PosX1.Location = new System.Drawing.Point(9, 29);
            this.PosX1.Name = "PosX1";
            this.PosX1.Size = new System.Drawing.Size(41, 12);
            this.PosX1.TabIndex = 0;
            this.PosX1.Text = "PosX1";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(21, 302);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(36, 21);
            this.txtEvent.TabIndex = 10;
            this.txtEvent.Visible = false;
            // 
            // valClickDelay
            // 
            this.valClickDelay.Location = new System.Drawing.Point(159, 293);
            this.valClickDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valClickDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valClickDelay.Name = "valClickDelay";
            this.valClickDelay.Size = new System.Drawing.Size(28, 21);
            this.valClickDelay.TabIndex = 16;
            this.valClickDelay.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(62, 302);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(36, 21);
            this.txtCode.TabIndex = 17;
            this.txtCode.Visible = false;
            // 
            // valRandom
            // 
            this.valRandom.Location = new System.Drawing.Point(192, 293);
            this.valRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valRandom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valRandom.Name = "valRandom";
            this.valRandom.Size = new System.Drawing.Size(28, 21);
            this.valRandom.TabIndex = 18;
            this.valRandom.Visible = false;
            // 
            // addMouseEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(247, 335);
            this.Controls.Add(this.valRandom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.valClickDelay);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.CursorPos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addMouseEvent";
            this.Text = "Add Mouse Event";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valButton)).EndInit();
            this.CursorPos.ResumeLayout(false);
            this.CursorPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valClickDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox Options;
        public System.Windows.Forms.NumericUpDown valAction;
        public System.Windows.Forms.NumericUpDown valButton;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.RadioButton btnMouseDown;
        private System.Windows.Forms.RadioButton btnMouseUp;
        private System.Windows.Forms.RadioButton btnDoubleClick;
        private System.Windows.Forms.RadioButton btnClick;
        private System.Windows.Forms.Label Button;
        private System.Windows.Forms.ComboBox btnButton;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox CursorPos;
        private System.Windows.Forms.Label Tip1;
        public System.Windows.Forms.TextBox txtPosY1;
        private System.Windows.Forms.TextBox txtPosX1;
        private System.Windows.Forms.Label PosY1;
        private System.Windows.Forms.Label PosX1;
        public System.Windows.Forms.TextBox txtEvent;
        public System.Windows.Forms.NumericUpDown valClickDelay;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.TextBox txtPosY2;
        private System.Windows.Forms.TextBox txtPosX2;
        private System.Windows.Forms.Label PosY2;
        private System.Windows.Forms.Label PosX2;
        private System.Windows.Forms.CheckBox cbRandom;
        public System.Windows.Forms.NumericUpDown valRandom;
    }
}