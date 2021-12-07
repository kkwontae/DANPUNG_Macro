namespace DANPUNG
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listContent = new System.Windows.Forms.ListBox();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnKeyboardEvent = new System.Windows.Forms.Button();
            this.btnAddMouseEvent = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listCode = new System.Windows.Forms.ListBox();
            this.txtDelay1 = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.Label();
            this.btnAddStringCopy = new System.Windows.Forms.Button();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.Repeat = new System.Windows.Forms.GroupBox();
            this.cbInfinite = new System.Windows.Forms.CheckBox();
            this.times2 = new System.Windows.Forms.Label();
            this.barMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogSave = new System.Windows.Forms.SaveFileDialog();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.txtDelay2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPixelSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerKeyDown = new System.Windows.Forms.Timer(this.components);
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnAddLoop = new System.Windows.Forms.Button();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.times1 = new System.Windows.Forms.Label();
            this.Loop = new System.Windows.Forms.Label();
            this.Repeat.SuspendLayout();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listContent
            // 
            this.listContent.FormattingEnabled = true;
            this.listContent.ItemHeight = 12;
            this.listContent.Location = new System.Drawing.Point(12, 29);
            this.listContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listContent.Name = "listContent";
            this.listContent.ScrollAlwaysVisible = true;
            this.listContent.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listContent.Size = new System.Drawing.Size(259, 184);
            this.listContent.TabIndex = 2;
            this.listContent.SelectedIndexChanged += new System.EventHandler(this.listContent_SelectedIndexChanged);
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Location = new System.Drawing.Point(277, 195);
            this.btnAddDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(118, 20);
            this.btnAddDelay.TabIndex = 18;
            this.btnAddDelay.Text = "Add Delay";
            this.btnAddDelay.UseVisualStyleBackColor = true;
            this.btnAddDelay.Click += new System.EventHandler(this.btnAddDelay_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(277, 291);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 20);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnKeyboardEvent
            // 
            this.btnKeyboardEvent.Location = new System.Drawing.Point(277, 98);
            this.btnKeyboardEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeyboardEvent.Name = "btnKeyboardEvent";
            this.btnKeyboardEvent.Size = new System.Drawing.Size(118, 20);
            this.btnKeyboardEvent.TabIndex = 16;
            this.btnKeyboardEvent.Text = "Add Keyboard";
            this.btnKeyboardEvent.UseVisualStyleBackColor = true;
            this.btnKeyboardEvent.Click += new System.EventHandler(this.btnKeyboardEvent_Click);
            // 
            // btnAddMouseEvent
            // 
            this.btnAddMouseEvent.Location = new System.Drawing.Point(277, 122);
            this.btnAddMouseEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMouseEvent.Name = "btnAddMouseEvent";
            this.btnAddMouseEvent.Size = new System.Drawing.Size(118, 20);
            this.btnAddMouseEvent.TabIndex = 15;
            this.btnAddMouseEvent.Text = "Add Mouse";
            this.btnAddMouseEvent.UseVisualStyleBackColor = true;
            this.btnAddMouseEvent.Click += new System.EventHandler(this.btnAddMouseEvent_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(339, 75);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 20);
            this.btnDown.TabIndex = 14;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(277, 75);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 20);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(277, 315);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 20);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitApp);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 51);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 20);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 20);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Test";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnDebug_Click);
            this.btnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAdd_KeyPress);
            // 
            // listCode
            // 
            this.listCode.FormattingEnabled = true;
            this.listCode.ItemHeight = 12;
            this.listCode.Location = new System.Drawing.Point(12, 217);
            this.listCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listCode.Name = "listCode";
            this.listCode.ScrollAlwaysVisible = true;
            this.listCode.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCode.Size = new System.Drawing.Size(259, 184);
            this.listCode.TabIndex = 19;
            this.listCode.Visible = false;
            // 
            // txtDelay1
            // 
            this.txtDelay1.Location = new System.Drawing.Point(280, 217);
            this.txtDelay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(35, 21);
            this.txtDelay1.TabIndex = 21;
            this.txtDelay1.Text = "1000";
            this.txtDelay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDelay1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(368, 222);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(23, 12);
            this.ms.TabIndex = 22;
            this.ms.Text = "ms";
            // 
            // btnAddStringCopy
            // 
            this.btnAddStringCopy.Location = new System.Drawing.Point(277, 147);
            this.btnAddStringCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStringCopy.Name = "btnAddStringCopy";
            this.btnAddStringCopy.Size = new System.Drawing.Size(118, 20);
            this.btnAddStringCopy.TabIndex = 23;
            this.btnAddStringCopy.Text = "Add StringCopy";
            this.btnAddStringCopy.UseVisualStyleBackColor = true;
            this.btnAddStringCopy.Click += new System.EventHandler(this.btnAddStringCopy_Click);
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(9, 42);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(54, 21);
            this.txtRepeat.TabIndex = 24;
            this.txtRepeat.Text = "1";
            this.txtRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // Repeat
            // 
            this.Repeat.Controls.Add(this.cbInfinite);
            this.Repeat.Controls.Add(this.txtRepeat);
            this.Repeat.Controls.Add(this.times2);
            this.Repeat.Location = new System.Drawing.Point(280, 358);
            this.Repeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Repeat.Name = "Repeat";
            this.Repeat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Repeat.Size = new System.Drawing.Size(113, 70);
            this.Repeat.TabIndex = 26;
            this.Repeat.TabStop = false;
            this.Repeat.Text = "Repeat";
            // 
            // cbInfinite
            // 
            this.cbInfinite.AutoSize = true;
            this.cbInfinite.Location = new System.Drawing.Point(9, 23);
            this.cbInfinite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInfinite.Name = "cbInfinite";
            this.cbInfinite.Size = new System.Drawing.Size(60, 16);
            this.cbInfinite.TabIndex = 27;
            this.cbInfinite.Text = "Infinite";
            this.cbInfinite.UseVisualStyleBackColor = true;
            this.cbInfinite.CheckedChanged += new System.EventHandler(this.cbInfinite_CheckedChanged);
            // 
            // times2
            // 
            this.times2.AutoSize = true;
            this.times2.Location = new System.Drawing.Point(67, 47);
            this.times2.Name = "times2";
            this.times2.Size = new System.Drawing.Size(36, 12);
            this.times2.TabIndex = 25;
            this.times2.Text = "times";
            // 
            // barMenu
            // 
            this.barMenu.AutoSize = false;
            this.barMenu.BackColor = System.Drawing.Color.Transparent;
            this.barMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.barMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.barMenu.Size = new System.Drawing.Size(403, 24);
            this.barMenu.Stretch = false;
            this.barMenu.TabIndex = 27;
            this.barMenu.Text = "barMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitApp);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dialogSave
            // 
            this.dialogSave.DefaultExt = "dp";
            this.dialogSave.FileName = " ";
            this.dialogSave.Filter = "DANPUNG|*.dp";
            // 
            // dialogOpen
            // 
            this.dialogOpen.DefaultExt = "dp";
            this.dialogOpen.FileName = " ";
            this.dialogOpen.Filter = "DANPUNG|*.dp";
            this.dialogOpen.Title = "Open Saved File";
            // 
            // txtDelay2
            // 
            this.txtDelay2.Location = new System.Drawing.Point(330, 217);
            this.txtDelay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDelay2.Name = "txtDelay2";
            this.txtDelay2.Size = new System.Drawing.Size(35, 21);
            this.txtDelay2.TabIndex = 28;
            this.txtDelay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "~";
            // 
            // btnAddPixelSearch
            // 
            this.btnAddPixelSearch.Location = new System.Drawing.Point(277, 171);
            this.btnAddPixelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPixelSearch.Name = "btnAddPixelSearch";
            this.btnAddPixelSearch.Size = new System.Drawing.Size(118, 20);
            this.btnAddPixelSearch.TabIndex = 31;
            this.btnAddPixelSearch.Text = "Add PixelSearch";
            this.btnAddPixelSearch.UseVisualStyleBackColor = true;
            this.btnAddPixelSearch.Click += new System.EventHandler(this.btnAddPixelSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(151, 6);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(118, 21);
            this.txtDebug.TabIndex = 32;
            // 
            // btnAddLoop
            // 
            this.btnAddLoop.Location = new System.Drawing.Point(277, 242);
            this.btnAddLoop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLoop.Name = "btnAddLoop";
            this.btnAddLoop.Size = new System.Drawing.Size(118, 20);
            this.btnAddLoop.TabIndex = 33;
            this.btnAddLoop.Text = "Add Loop";
            this.btnAddLoop.UseVisualStyleBackColor = true;
            this.btnAddLoop.Click += new System.EventHandler(this.btnAddLoop_Click);
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(277, 266);
            this.txtLoop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(66, 21);
            this.txtLoop.TabIndex = 28;
            this.txtLoop.Text = "1";
            this.txtLoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // times1
            // 
            this.times1.AutoSize = true;
            this.times1.Location = new System.Drawing.Point(347, 271);
            this.times1.Name = "times1";
            this.times1.Size = new System.Drawing.Size(36, 12);
            this.times1.TabIndex = 29;
            this.times1.Text = "times";
            // 
            // Loop
            // 
            this.Loop.AutoSize = true;
            this.Loop.Location = new System.Drawing.Point(278, 9);
            this.Loop.Name = "Loop";
            this.Loop.Size = new System.Drawing.Size(11, 12);
            this.Loop.TabIndex = 34;
            this.Loop.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 439);
            this.Controls.Add(this.Loop);
            this.Controls.Add(this.txtLoop);
            this.Controls.Add(this.times1);
            this.Controls.Add(this.btnAddLoop);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPixelSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDelay2);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.btnAddStringCopy);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.txtDelay1);
            this.Controls.Add(this.listCode);
            this.Controls.Add(this.btnAddDelay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnKeyboardEvent);
            this.Controls.Add(this.btnAddMouseEvent);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listContent);
            this.Controls.Add(this.barMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barMenu;
            this.Name = "MainForm";
            this.Text = "DANPUNG";
            this.Repeat.ResumeLayout(false);
            this.Repeat.PerformLayout();
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listContent;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnKeyboardEvent;
        private System.Windows.Forms.Button btnAddMouseEvent;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox listCode;
        private System.Windows.Forms.TextBox txtDelay1;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Button btnAddStringCopy;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.GroupBox Repeat;
        private System.Windows.Forms.CheckBox cbInfinite;
        private System.Windows.Forms.Label times2;
        private System.Windows.Forms.MenuStrip barMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialogSave;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDelay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPixelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerKeyDown;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Button btnAddLoop;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label times1;
        private System.Windows.Forms.Label Loop;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

