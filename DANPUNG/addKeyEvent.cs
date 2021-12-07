using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WindowsInput;
using System.Runtime.InteropServices;

namespace DANPUNG
{
    public partial class addKeyEvent : Form
    {
        public addKeyEvent()
        {
            InitializeComponent();
            txtDown.Enabled = false;

            this.StartPosition = FormStartPosition.CenterParent;

            ArrayList keybdEvent = new ArrayList();

            keybdEvent.Add(new keybdEvent("None", "0"));
            keybdEvent.Add(new keybdEvent("ESC", ((int)VirtualKeyCode.ESCAPE).ToString()));
            keybdEvent.Add(new keybdEvent("TAB", ((int)VirtualKeyCode.TAB).ToString()));
            keybdEvent.Add(new keybdEvent("CAPSLOCK", ((int)VirtualKeyCode.CAPITAL).ToString()));
            keybdEvent.Add(new keybdEvent("L-SHIFT", ((int)VirtualKeyCode.LSHIFT).ToString()));
            keybdEvent.Add(new keybdEvent("R-SHIFT", ((int)VirtualKeyCode.RSHIFT).ToString()));
            keybdEvent.Add(new keybdEvent("L-ALT", ((int)VirtualKeyCode.LMENU).ToString()));
            keybdEvent.Add(new keybdEvent("R-ALT", ((int)VirtualKeyCode.RMENU).ToString()));
            keybdEvent.Add(new keybdEvent("L-WIN", ((int)VirtualKeyCode.LWIN).ToString()));
            keybdEvent.Add(new keybdEvent("R-WIN", ((int)VirtualKeyCode.RWIN).ToString()));
            keybdEvent.Add(new keybdEvent("BACKSPACE", ((int)VirtualKeyCode.BACK).ToString()));
            keybdEvent.Add(new keybdEvent("ENTER", ((int)VirtualKeyCode.RETURN).ToString()));
            keybdEvent.Add(new keybdEvent("SPACEBAR", ((int)VirtualKeyCode.SPACE).ToString()));
            keybdEvent.Add(new keybdEvent("PRINTSCRN", ((int)VirtualKeyCode.PRINT).ToString()));
            keybdEvent.Add(new keybdEvent("SCROLLLOCK", ((int)VirtualKeyCode.SCROLL).ToString()));
            keybdEvent.Add(new keybdEvent("PAUSE", ((int)VirtualKeyCode.PAUSE).ToString()));
            keybdEvent.Add(new keybdEvent("INSERT", ((int)VirtualKeyCode.INSERT).ToString()));
            keybdEvent.Add(new keybdEvent("DELETE", ((int)VirtualKeyCode.DELETE).ToString()));
            keybdEvent.Add(new keybdEvent("HOME", ((int)VirtualKeyCode.HOME).ToString()));
            keybdEvent.Add(new keybdEvent("END", ((int)VirtualKeyCode.END).ToString()));
            keybdEvent.Add(new keybdEvent("PAGEUP", ((int)VirtualKeyCode.PRIOR).ToString()));
            keybdEvent.Add(new keybdEvent("PAGEDOWN", ((int)VirtualKeyCode.NEXT).ToString()));
            keybdEvent.Add(new keybdEvent("UP-ARROW", ((int)VirtualKeyCode.UP).ToString()));
            keybdEvent.Add(new keybdEvent("DOWN-ARROW", ((int)VirtualKeyCode.DOWN).ToString()));
            keybdEvent.Add(new keybdEvent("LEFT-ARROW", ((int)VirtualKeyCode.LEFT).ToString()));
            keybdEvent.Add(new keybdEvent("RIGHT-ARROW", ((int)VirtualKeyCode.RIGHT).ToString()));
            keybdEvent.Add(new keybdEvent("HANGUL", ((int)VirtualKeyCode.HANGUL).ToString()));
            keybdEvent.Add(new keybdEvent("F1", ((int)VirtualKeyCode.F1).ToString()));
            keybdEvent.Add(new keybdEvent("F2", ((int)VirtualKeyCode.F2).ToString()));
            keybdEvent.Add(new keybdEvent("F3", ((int)VirtualKeyCode.F3).ToString()));
            keybdEvent.Add(new keybdEvent("F4", ((int)VirtualKeyCode.F4).ToString()));
            keybdEvent.Add(new keybdEvent("F5", ((int)VirtualKeyCode.F5).ToString()));
            keybdEvent.Add(new keybdEvent("F6", ((int)VirtualKeyCode.F6).ToString()));
            keybdEvent.Add(new keybdEvent("F7", ((int)VirtualKeyCode.F7).ToString()));
            keybdEvent.Add(new keybdEvent("F8", ((int)VirtualKeyCode.F8).ToString()));
            keybdEvent.Add(new keybdEvent("F9", ((int)VirtualKeyCode.F9).ToString()));
            keybdEvent.Add(new keybdEvent("F10", ((int)VirtualKeyCode.F10).ToString()));
            keybdEvent.Add(new keybdEvent("F11", ((int)VirtualKeyCode.F11).ToString()));
            keybdEvent.Add(new keybdEvent("F12", ((int)VirtualKeyCode.F12).ToString()));
            keybdEvent.Add(new keybdEvent("NUM0", ((int)VirtualKeyCode.NUMPAD0).ToString()));
            keybdEvent.Add(new keybdEvent("NUM1", ((int)VirtualKeyCode.NUMPAD1).ToString()));
            keybdEvent.Add(new keybdEvent("NUM2", ((int)VirtualKeyCode.NUMPAD2).ToString()));
            keybdEvent.Add(new keybdEvent("NUM3", ((int)VirtualKeyCode.NUMPAD3).ToString()));
            keybdEvent.Add(new keybdEvent("NUM4", ((int)VirtualKeyCode.NUMPAD4).ToString()));
            keybdEvent.Add(new keybdEvent("NUM5", ((int)VirtualKeyCode.NUMPAD5).ToString()));
            keybdEvent.Add(new keybdEvent("NUM6", ((int)VirtualKeyCode.NUMPAD6).ToString()));
            keybdEvent.Add(new keybdEvent("NUM7", ((int)VirtualKeyCode.NUMPAD7).ToString()));
            keybdEvent.Add(new keybdEvent("NUM8", ((int)VirtualKeyCode.NUMPAD8).ToString()));
            keybdEvent.Add(new keybdEvent("NUM9", ((int)VirtualKeyCode.NUMPAD9).ToString()));
            keybdEvent.Add(new keybdEvent("[", ((int)VirtualKeyCode.OEM_4).ToString()));
            keybdEvent.Add(new keybdEvent("]", ((int)VirtualKeyCode.OEM_6).ToString()));
            keybdEvent.Add(new keybdEvent("\\", ((int)VirtualKeyCode.OEM_5).ToString()));
            keybdEvent.Add(new keybdEvent(";", ((int)VirtualKeyCode.OEM_1).ToString()));
            keybdEvent.Add(new keybdEvent("'", ((int)VirtualKeyCode.OEM_7).ToString()));
            keybdEvent.Add(new keybdEvent(".", ((int)VirtualKeyCode.OEM_PERIOD).ToString()));
            keybdEvent.Add(new keybdEvent(",", ((int)VirtualKeyCode.OEM_COMMA).ToString()));
            keybdEvent.Add(new keybdEvent("/", ((int)VirtualKeyCode.OEM_2).ToString()));
            keybdEvent.Add(new keybdEvent("`", ((int)VirtualKeyCode.OEM_3).ToString()));
            keybdEvent.Add(new keybdEvent("1", ((int)VirtualKeyCode.VK_1).ToString()));
            keybdEvent.Add(new keybdEvent("2", ((int)VirtualKeyCode.VK_2).ToString()));
            keybdEvent.Add(new keybdEvent("3", ((int)VirtualKeyCode.VK_3).ToString()));
            keybdEvent.Add(new keybdEvent("4", ((int)VirtualKeyCode.VK_4).ToString()));
            keybdEvent.Add(new keybdEvent("5", ((int)VirtualKeyCode.VK_5).ToString()));
            keybdEvent.Add(new keybdEvent("6", ((int)VirtualKeyCode.VK_6).ToString()));
            keybdEvent.Add(new keybdEvent("7", ((int)VirtualKeyCode.VK_7).ToString()));
            keybdEvent.Add(new keybdEvent("8", ((int)VirtualKeyCode.VK_8).ToString()));
            keybdEvent.Add(new keybdEvent("9", ((int)VirtualKeyCode.VK_9).ToString()));
            keybdEvent.Add(new keybdEvent("0", ((int)VirtualKeyCode.VK_0).ToString()));
            keybdEvent.Add(new keybdEvent("-", ((int)VirtualKeyCode.SUBTRACT).ToString()));
            keybdEvent.Add(new keybdEvent("=", ((int)VirtualKeyCode.OEM_PLUS).ToString()));
            keybdEvent.Add(new keybdEvent("A", ((int)VirtualKeyCode.VK_A).ToString()));
            keybdEvent.Add(new keybdEvent("B", ((int)VirtualKeyCode.VK_B).ToString()));
            keybdEvent.Add(new keybdEvent("C", ((int)VirtualKeyCode.VK_C).ToString()));
            keybdEvent.Add(new keybdEvent("D", ((int)VirtualKeyCode.VK_D).ToString()));
            keybdEvent.Add(new keybdEvent("E", ((int)VirtualKeyCode.VK_E).ToString()));
            keybdEvent.Add(new keybdEvent("F", ((int)VirtualKeyCode.VK_F).ToString()));
            keybdEvent.Add(new keybdEvent("G", ((int)VirtualKeyCode.VK_G).ToString()));
            keybdEvent.Add(new keybdEvent("H", ((int)VirtualKeyCode.VK_H).ToString()));
            keybdEvent.Add(new keybdEvent("I", ((int)VirtualKeyCode.VK_I).ToString()));
            keybdEvent.Add(new keybdEvent("J", ((int)VirtualKeyCode.VK_J).ToString()));
            keybdEvent.Add(new keybdEvent("K", ((int)VirtualKeyCode.VK_K).ToString()));
            keybdEvent.Add(new keybdEvent("L", ((int)VirtualKeyCode.VK_L).ToString()));
            keybdEvent.Add(new keybdEvent("M", ((int)VirtualKeyCode.VK_M).ToString()));
            keybdEvent.Add(new keybdEvent("N", ((int)VirtualKeyCode.VK_N).ToString()));
            keybdEvent.Add(new keybdEvent("O", ((int)VirtualKeyCode.VK_O).ToString()));
            keybdEvent.Add(new keybdEvent("P", ((int)VirtualKeyCode.VK_P).ToString()));
            keybdEvent.Add(new keybdEvent("Q", ((int)VirtualKeyCode.VK_Q).ToString()));
            keybdEvent.Add(new keybdEvent("R", ((int)VirtualKeyCode.VK_R).ToString()));
            keybdEvent.Add(new keybdEvent("S", ((int)VirtualKeyCode.VK_S).ToString()));
            keybdEvent.Add(new keybdEvent("T", ((int)VirtualKeyCode.VK_T).ToString()));
            keybdEvent.Add(new keybdEvent("U", ((int)VirtualKeyCode.VK_U).ToString()));
            keybdEvent.Add(new keybdEvent("V", ((int)VirtualKeyCode.VK_V).ToString()));
            keybdEvent.Add(new keybdEvent("W", ((int)VirtualKeyCode.VK_W).ToString()));
            keybdEvent.Add(new keybdEvent("X", ((int)VirtualKeyCode.VK_X).ToString()));
            keybdEvent.Add(new keybdEvent("Y", ((int)VirtualKeyCode.VK_Y).ToString()));
            keybdEvent.Add(new keybdEvent("Z", ((int)VirtualKeyCode.VK_Z).ToString()));

            listKey.DataSource = keybdEvent;
            
            listKey.DisplayMember = "LongName";
            listKey.ValueMember = "ShortName";
        }        
                
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtDown.Text == "")
                txtDown.Text = "0";
            txtCode.Text = "k" + listKey.SelectedValue.ToString();
            modifedKeys();
            txtCode.Text += "d" + txtDown.Text;
            txtEvent.Text += ((keybdEvent)listKey.SelectedItem).LongName + "'";
        }

        public string getItem()
        {
            return txtEvent.Text;
        }
        public string getCode()
        {
            return txtCode.Text;
        }

        private void txtEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEvent.Text = ((int)e.KeyChar).ToString();
        }

        private void modifedKeys()
        {
            if (cbCtrl.Checked)
            {
                txtCode.Text += "c1";
                txtEvent.Text += "Press 'Ctrl";
            }
            else
                txtCode.Text += "c0";

            if (cbAlt.Checked)
            {
                txtCode.Text += "m1";
                if (txtEvent.Text == "")
                    txtEvent.Text += "Press 'Alt";
                else
                    txtEvent.Text += "+Alt";
            }
                
            else
                txtCode.Text += "m0";

            if (cbShift.Checked)
            {
                txtCode.Text += "s1";
                if (txtEvent.Text == "")
                    txtEvent.Text += "Press 'Shift";
                else
                    txtEvent.Text += "+Shift";
            }
            else
                txtCode.Text += "s0";

            if (cbWin.Checked)
            {
                txtCode.Text += "w1";
                if (txtEvent.Text == "")
                    txtEvent.Text += "Press 'Win";
                else
                    txtEvent.Text += "+Win";
            }
            else
                txtCode.Text += "w0";

            if (txtEvent.Text == "")
                txtEvent.Text = "Press '";
            else
                txtEvent.Text += "+";
        }

        private void cbKeyDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeyDown.Checked)
                txtDown.Enabled = true;
            else
                txtDown.Enabled = false;
        }

        private void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
        }
    }

    public class keybdEvent
    {
        private string myShortName;
        private string myLongName;

        public keybdEvent(string strLongName, string strShortName)
        {
            this.myShortName = strShortName;
            this.myLongName = strLongName;
        }

        public string ShortName { get { return myShortName; } }
        public string LongName { get { return myLongName; } }
    }
}
