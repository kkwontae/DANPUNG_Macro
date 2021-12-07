using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace DANPUNG
{
    public partial class addMouseEvent : Form
    {
        enum MouseButton
        {
            Error = 0,
            None = 1,
            LButton = 2,
            RButton = 3,
            Wheel = 4
        }
        enum MouseAction
        {
            Error = 0,
            Click = 1,
            DoubleClick = 2,
            MouseDown = 3,
            MouseUp = 4,
        }

        MouseButton mBtn;
        MouseAction mAct;

        public addMouseEvent()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            btnButton.SelectedIndex = 1;
            btnClick.Checked = true;
            cbRandom.Checked = false;
            txtPosX2.Enabled = false;
            txtPosY2.Enabled = false;
            valAction.Value = 1;

            txtPosX1.MaxLength = 4;
            txtPosY1.MaxLength = 4;
            txtDelay.MaxLength = 4;


            btnClick.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            btnDoubleClick.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            btnMouseDown.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            btnMouseUp.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f1, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F1);
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
                    break;
            }
            base.WndProc(ref message);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            txtDelay.ReadOnly = true;
            txtDelay.Text = "";
            txtDelay.BackColor = Color.LightGray;
            txtDelay.Enabled = false;

            if (btnClick.Checked)
                valAction.Value = 1;
            else if (btnDoubleClick.Checked)
            {
                valAction.Value = 2;
                txtDelay.ReadOnly = false;
                txtDelay.BackColor = Color.White;
                txtDelay.Enabled = true;
            }
            else if (btnMouseDown.Checked)
                valAction.Value = 3;
            else if (btnMouseUp.Checked)
                valAction.Value = 4;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtPosX1.Text == "" || txtPosY1.Text == "")
            {
                MessageBox.Show("Invalid PosX/Y!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (cbRandom.Checked && (txtPosX2.Text == "" || txtPosY2.Text == ""))
            {
                MessageBox.Show("Invalid X2/Y2!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (btnButton.Text=="")
            {
                MessageBox.Show("Invalid Button!", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (btnDoubleClick.Checked && (txtDelay.Text == "" || int.Parse(txtDelay.Text) < 0 || int.Parse(txtDelay.Text) > 1000))
            {
                MessageBox.Show("Invalid Delay!\nDelay must be 0 ms ~ 1000 ms", "Error!");
                this.DialogResult = DialogResult.None;
                return;
            }
            if(!cbRandom.Checked)
            {
                txtPosX2.Text = "0";
                txtPosY2.Text = "0";
            }
            valButton.Value = btnButton.SelectedIndex + 1;
            if (txtDelay.Text != "")
                valClickDelay.Value = decimal.Parse(txtDelay.Text);

            mBtn = (MouseButton)(Convert.ToInt32(valButton.Value));
            mAct = (MouseAction)(Convert.ToInt32(valAction.Value));

            if (!cbRandom.Checked)
                txtEvent.Text = mBtn + "," + mAct + " (" + txtPosX1.Text + "," + txtPosY1.Text + ") ";
            else
                txtEvent.Text = mBtn + "," + mAct + " (" + txtPosX1.Text + "," + txtPosY1.Text + ")~(" + txtPosX2.Text + "," + txtPosY2.Text +") ";

            txtCode.Text = "x" + txtPosX1.Text + "y" + txtPosY1.Text + "p" + txtPosX2.Text + "q" + txtPosY2.Text + "b" + valButton.Value + "a" + valAction.Value + "d" + valClickDelay.Value + "r" + valRandom.Value;

            if (mAct == MouseAction.DoubleClick)
                txtEvent.Text += (txtDelay.Text + "ms");

            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f1);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f1);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2);
            Close();
            Dispose();
        }


        private void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
        }


        public string getItem()
        {
            return txtEvent.Text;
        }
        public string getCode()
        {
            return txtCode.Text;
        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRandom.Checked)
            {
                txtPosX2.Enabled = true;
                txtPosY2.Enabled = true;
                valRandom.Value = 1;
                hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F2);
            }
            else
            {
                txtPosX2.Enabled = false;
                txtPosY2.Enabled = false;
                valRandom.Value = 0;
                hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f2);
            }
            
        }
        ///////////////////////////////////
    }
}
