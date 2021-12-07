namespace DANPUNG
{
    partial class addPixelSearch
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
            this.components = new System.ComponentModel.Container();
            this.CursorPos = new System.Windows.Forms.GroupBox();
            this.cbRange = new System.Windows.Forms.CheckBox();
            this.txtPosY2 = new System.Windows.Forms.TextBox();
            this.txtPosX2 = new System.Windows.Forms.TextBox();
            this.PosY2 = new System.Windows.Forms.Label();
            this.PosX2 = new System.Windows.Forms.Label();
            this.Tip1 = new System.Windows.Forms.Label();
            this.txtPosY1 = new System.Windows.Forms.TextBox();
            this.txtPosX1 = new System.Windows.Forms.TextBox();
            this.PosY1 = new System.Windows.Forms.Label();
            this.PosX1 = new System.Windows.Forms.Label();
            this.valRange = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.screenColorPicker = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.colorEditorManager = new Cyotek.Windows.Forms.ColorEditorManager();
            this.eyedropper = new System.Windows.Forms.ToolTip(this.components);
            this.CursorPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valRange)).BeginInit();
            this.SuspendLayout();
            // 
            // CursorPos
            // 
            this.CursorPos.Controls.Add(this.cbRange);
            this.CursorPos.Controls.Add(this.txtPosY2);
            this.CursorPos.Controls.Add(this.txtPosX2);
            this.CursorPos.Controls.Add(this.PosY2);
            this.CursorPos.Controls.Add(this.PosX2);
            this.CursorPos.Controls.Add(this.Tip1);
            this.CursorPos.Controls.Add(this.txtPosY1);
            this.CursorPos.Controls.Add(this.txtPosX1);
            this.CursorPos.Controls.Add(this.PosY1);
            this.CursorPos.Controls.Add(this.PosX1);
            this.CursorPos.Location = new System.Drawing.Point(12, 11);
            this.CursorPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CursorPos.Name = "CursorPos";
            this.CursorPos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CursorPos.Size = new System.Drawing.Size(226, 133);
            this.CursorPos.TabIndex = 7;
            this.CursorPos.TabStop = false;
            this.CursorPos.Text = "Cursor Pos";
            // 
            // cbRange
            // 
            this.cbRange.AutoSize = true;
            this.cbRange.Location = new System.Drawing.Point(11, 55);
            this.cbRange.Name = "cbRange";
            this.cbRange.Size = new System.Drawing.Size(60, 16);
            this.cbRange.TabIndex = 18;
            this.cbRange.Text = "Range";
            this.cbRange.UseVisualStyleBackColor = true;
            this.cbRange.CheckedChanged += new System.EventHandler(this.cbRange_CheckedChanged);
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
            // 
            // txtPosX1
            // 
            this.txtPosX1.Location = new System.Drawing.Point(52, 26);
            this.txtPosX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPosX1.Name = "txtPosX1";
            this.txtPosX1.Size = new System.Drawing.Size(44, 21);
            this.txtPosX1.TabIndex = 2;
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
            // valRange
            // 
            this.valRange.Location = new System.Drawing.Point(197, 268);
            this.valRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.valRange.Name = "valRange";
            this.valRange.Size = new System.Drawing.Size(28, 21);
            this.valRange.TabIndex = 19;
            this.valRange.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(169, 295);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 20);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(98, 295);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(66, 20);
            this.btnApply.TabIndex = 20;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.Transparent;
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Location = new System.Drawing.Point(164, 150);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(71, 38);
            this.previewPanel.TabIndex = 22;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(164, 191);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(38, 12);
            this.info.TabIndex = 0;
            this.info.Text = "label1";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(175, 214);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(50, 21);
            this.txtEvent.TabIndex = 23;
            this.txtEvent.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(175, 239);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(50, 21);
            this.txtCode.TabIndex = 24;
            this.txtCode.Visible = false;
            // 
            // screenColorPicker
            // 
            this.screenColorPicker.Color = System.Drawing.Color.Empty;
            this.screenColorPicker.Image = global::DANPUNG.Properties.Resources.eyedropper;
            this.screenColorPicker.Location = new System.Drawing.Point(12, 150);
            this.screenColorPicker.Name = "screenColorPicker";
            this.screenColorPicker.Size = new System.Drawing.Size(139, 139);
            this.eyedropper.SetToolTip(this.screenColorPicker, "Click and drag to select screen color");
            this.screenColorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screenColorPicker_MouseDown);
            this.screenColorPicker.MouseLeave += new System.EventHandler(this.screenColorPicker_MouseLeave);
            this.screenColorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.screenColorPicker_MouseMove);
            // 
            // colorEditorManager
            // 
            this.colorEditorManager.ScreenColorPicker = this.screenColorPicker;
            this.colorEditorManager.ColorChanged += new System.EventHandler(this.colorEditorManager_ColorChanged);
            // 
            // addPixelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(247, 326);
            this.Controls.Add(this.screenColorPicker);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.info);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.valRange);
            this.Controls.Add(this.CursorPos);
            this.Name = "addPixelSearch";
            this.Text = "Add Pixel Search";
            this.CursorPos.ResumeLayout(false);
            this.CursorPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CursorPos;
        private System.Windows.Forms.CheckBox cbRange;
        public System.Windows.Forms.TextBox txtPosY2;
        private System.Windows.Forms.TextBox txtPosX2;
        private System.Windows.Forms.Label PosY2;
        private System.Windows.Forms.Label PosX2;
        private System.Windows.Forms.Label Tip1;
        public System.Windows.Forms.TextBox txtPosY1;
        private System.Windows.Forms.TextBox txtPosX1;
        private System.Windows.Forms.Label PosY1;
        private System.Windows.Forms.Label PosX1;
        public System.Windows.Forms.NumericUpDown valRange;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.TextBox txtEvent;
        public System.Windows.Forms.TextBox txtCode;
        private Cyotek.Windows.Forms.ScreenColorPicker screenColorPicker;
        private Cyotek.Windows.Forms.ColorEditorManager colorEditorManager;
        private System.Windows.Forms.ToolTip eyedropper;
    }
}