using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANPUNG
{
    public partial class addPixelSearch : Form
    {
        public addPixelSearch()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            info.Text = "A: R:\nG: B:\n#";

            txtPosX2.Enabled = false;
            txtPosY2.Enabled = false;
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f1, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F1);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f9, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F9);
        }

        private void cbRange_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRange.Checked)
            {
                txtPosX2.Enabled = true;
                txtPosY2.Enabled = true;
                valRange.Value = 1;
                hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F2);
            }
            else
            {
                txtPosX2.Enabled = false;
                txtPosY2.Enabled = false;
                valRange.Value = 0;
                hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2);
            }
        }

        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case hotkey.WM_HOTKEY:
                    Keys key = (Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    hotkey.KeyModifiers modifier = (hotkey.KeyModifiers)((int)message.LParam & 0xFFFF);

                    if ((hotkey.KeyModifiers.None | hotkey.KeyModifiers.None) == modifier && Keys.F1 == key)
                    {
                        txtPosX1.Text = Cursor.Position.X.ToString();
                        txtPosY1.Text = Cursor.Position.Y.ToString();
                    }
                    else if ((hotkey.KeyModifiers.None | hotkey.KeyModifiers.None) == modifier && Keys.F2 == key)
                    {
                        txtPosX2.Text = Cursor.Position.X.ToString();
                        txtPosY2.Text = Cursor.Position.Y.ToString();
                    }
                    else if ((hotkey.KeyModifiers.None | hotkey.KeyModifiers.None) == modifier && Keys.F9 == key)
                    { }
                    break;
            }
            base.WndProc(ref message);
        }

        private Color ScreenColor(int x, int y)
        {
            Size sz = new Size(1, 1);
            Bitmap bmp = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(x, y, 0, 0, sz);
            return bmp.GetPixel(0, 0);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtPosX1.Text == "" || txtPosY1.Text == "")
            {
                MessageBox.Show("Invalid PosX/Y!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (cbRange.Checked && (txtPosX2.Text == "" || txtPosY2.Text == ""))
            {
                MessageBox.Show("Invalid X2/Y2!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (previewPanel.BackColor == Color.Transparent)
            {
                MessageBox.Show(previewPanel.BackColor + " is unavailable!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (!cbRange.Checked)
            {
                txtPosX2.Text = "0";
                txtPosY2.Text = "0";
                txtEvent.Text = "[--IF #" + previewPanel.BackColor.Name.ToUpper() + " in (" + txtPosX1.Text + "," + txtPosY1.Text + ")";
            }
            else
            {
                txtEvent.Text = "[--IF #" + previewPanel.BackColor.Name.ToUpper() + " in (" + txtPosX1.Text + "," + txtPosY1.Text + ")~(" + txtPosX2.Text + "," + txtPosY2.Text + ")";
            }
            txtCode.Text = "[x" + txtPosX1.Text + "y" + txtPosY1.Text + "p" + txtPosX2.Text + "q" + txtPosY2.Text + "r" + valRange.Value + "#" + previewPanel.BackColor.ToArgb();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f1);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2);
            Close();
            Dispose();
        }

        private void colorEditorManager_ColorChanged(object sender, EventArgs e)
        {
            previewPanel.BackColor = colorEditorManager.Color;
            info.Text = "A:" + previewPanel.BackColor.A + " R:" + previewPanel.BackColor.R + "\nG:" + previewPanel.BackColor.G + " B:" + previewPanel.BackColor.B + "\n#" + previewPanel.BackColor.Name.ToUpper()+"\nRGB:"+previewPanel.BackColor.ToArgb();
        }
        

        public string getItem()
        {
            return txtEvent.Text;
        }
        public string getCode()
        {
            return txtCode.Text;
        }

        private void screenColorPicker_MouseLeave(object sender, EventArgs e)
        {
            if (MouseButtons != MouseButtons.Left)
            {
                return;
            }
        }

        private void screenColorPicker_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void screenColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPosX1.Text = MousePosition.X.ToString();
                txtPosY1.Text = MousePosition.Y.ToString();
            }
        }
    }
}
