using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DANPUNG
{
    class hotkey : Form
    {
        public const int WM_HOTKEY = 0x0312;

        protected override void WndProc(ref Message message) { }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public const int HOTKEY_ID_f1 = 31197; //Any number to use to identify the hotkey instance
        public const int HOTKEY_ID_f2 = 31198;
        public const int HOTKEY_ID_f3 = 31199;
        public const int HOTKEY_ID_f4 = 31200;
        public const int HOTKEY_ID_f5 = 31201;
        public const int HOTKEY_ID_f6 = 31202;
        public const int HOTKEY_ID_f7 = 31203;
        public const int HOTKEY_ID_f8 = 31204;
        public const int HOTKEY_ID_f9 = 31205;
        public const int HOTKEY_ID_f10 = 31206;
        public const int HOTKEY_ID_f11 = 31207;
        public const int HOTKEY_ID_f12 = 31208;

        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }
    }
}
