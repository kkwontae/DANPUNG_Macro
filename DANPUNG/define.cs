using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using WindowsInput;
using System.Diagnostics;

namespace DANPUNG
{
    public partial class MainForm
    {
        static int sizeOfList;
        static int startFlag;
        static int priority;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        public const int MOUSEEVENTF_MOVE = 0x0001;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        public const int MOUSEEVENTF_WHEEL = 0x0800;
        public const int MOUSEEVENTF_XDOWN = 0x0080;
        public const int MOUSEEVENTF_XUP = 0x0100;

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(int wCode, int wMapType);

        [DllImport("imm32.dll")]
        private static extern IntPtr ImmGetDefaultIMEWnd(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr IParam);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void onlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
        }

        double ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        double ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public int CalcPosX(double absx)
        {
            return (int)(absx / ScreenWidth * 65535.0);
        }
        public int CalcPosY(double absy)
        {
            return (int)(absy / ScreenHeight * 65535.0);
        }
        private void Mouse(int X, int Y, int P, int Q, int B, int A, int D, int R)
        {
            uint absMove = MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE;

            if (R == 1)
            {
                Random r = new Random();
                X = r.Next(X, P);
                Y = r.Next(Y, Q);
            }

            switch (B) // Null(Error), None, LButton, RButton, Wheel
            {
                case 0: // Null
                    MessageBox.Show("Error!");
                    break;
                case 1: // None
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, CalcPosX(X), CalcPosY(Y), 0, 0);
                    break;
                case 2: // LButton
                    switch (A) // Null(Error), Click, DoubleClick, MouseDown, MouseUp
                    {
                        case 0: // Null
                            MessageBox.Show("Error!");
                            break;
                        case 1: // Click
                            mouse_event(absMove | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, CalcPosX(X), CalcPosY(Y), 0, 0);

                            break;
                        case 2: // DoubleClick
                            mouse_event(absMove | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            Delay(D);
                            mouse_event(absMove | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 3: // MouseDown
                            mouse_event(absMove | MOUSEEVENTF_LEFTDOWN, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 4: // MouseUp
                            mouse_event(absMove | MOUSEEVENTF_LEFTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                    }
                    break;
                case 3: // RButton
                    switch (A)
                    {
                        case 0: // Null
                            MessageBox.Show("Error!");
                            break;
                        case 1: // Click
                            mouse_event(absMove | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 2: // DoubleClick
                            mouse_event(absMove | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            Delay(D);
                            mouse_event(absMove | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 3: // MouseDown
                            mouse_event(absMove | MOUSEEVENTF_RIGHTDOWN, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 4: // MouseUp
                            mouse_event(absMove | MOUSEEVENTF_RIGHTUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                    }
                    break;
                case 4: // Wheel
                    switch (A)
                    {
                        case 0: // Null
                            MessageBox.Show("Error!");
                            break;
                        case 1: // Click
                            mouse_event(absMove | MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 2: // DoubleClick
                            mouse_event(absMove | MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            Delay(D);
                            mouse_event(absMove | MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 3: // MouseDown
                            mouse_event(absMove | MOUSEEVENTF_MIDDLEDOWN, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                        case 4: // MouseUp
                            mouse_event(absMove | MOUSEEVENTF_MIDDLEUP, CalcPosX(X), CalcPosY(Y), 0, 0);
                            break;
                    }
                    break;
            }
        }
        
        const int PauseBetweenStrokes = 1;
        const int KEY_DOWN_EVENT = 0x0001; //Key down flag
        const int KEY_UP_EVENT = 0x0002; //Key up flag

        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;

        #region KEYTEST
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, VirtualKeyCode vk, string lParam);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, uint wMsg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, uint lParam);

        public static void sendKey(IntPtr hwnd, VirtualKeyCode keyCode, bool extended)
        {
            uint scanCode = MapVirtualKey((uint)keyCode, 0);
            uint lParam;

            //KEY DOWN
            lParam = (0x00000001 | (scanCode << 16));
            if (extended)
            {
                lParam |= 0x01000000;
            }
            PostMessage(hwnd, WM_KEYDOWN, (IntPtr)keyCode, lParam);

            //KEY UP
            lParam |= 0xC0000000;  // set previous key and transition states (bits 30 and 31)
            PostMessage(hwnd, WM_KEYUP, (IntPtr)keyCode, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        #endregion
        private VirtualKeyCode[] modifedKeys(int c, int m, int s, int w)
        {
            List<VirtualKeyCode> VKList = new List<VirtualKeyCode>();

            if (c == 1)
                VKList.Add(VirtualKeyCode.CONTROL);
            if (m == 1)
                VKList.Add(VirtualKeyCode.MENU);
            if (s == 1)
                VKList.Add(VirtualKeyCode.SHIFT);
            if (w == 1)
                VKList.Add(VirtualKeyCode.LWIN);

            VirtualKeyCode[] VKmod = VKList.ToArray();

            return VKmod;
        }

        private static Bitmap CaptureScreenRegion(Rectangle rect)
        {
            Bitmap BMP = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);
            Graphics GFX = Graphics.FromImage(BMP);
            GFX.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);

            return BMP;
        }

        private int[] PixelSearchRange(int X, int Y, int P, int Q, int R, int C)
        {
            int Height = Q - Y + 1;
            int Width = P - X + 1;
            int[] result = new int[3] { -1, 0, 0 }; // result[0] == -1 -> false ,  result[1] ,result[2] = x , y
            if (Width < 1 || Height < 1)
                return result;

            Bitmap scr = CaptureScreenRegion(new Rectangle(X, Y, Width, Height));
            if (P - X > scr.Width || Q - Y > scr.Height)
                return result;

            BitmapData scrdata = scr.LockBits(new Rectangle(0, 0, scr.Width, scr.Height), ImageLockMode.ReadWrite, scr.PixelFormat);
            IntPtr scan0 = scrdata.Scan0;

            int stride = scrdata.Stride;
            int size = Math.Abs(stride) * scr.Height;

            Color c = Color.FromArgb(C);
            byte[] comData = { c.B, c.G, c.R };   // rgbValue에 BGR 순으로 저장되기때문에 이 순서대로 저장.

            int count = 0;
            unsafe
            {
                byte* p = (byte*)(void*)scan0;

                int nOffset = stride - scr.Width * 3;
                int nWidth = scr.Width * 3;

                for (int y = 0; y < scr.Height; y++)
                {
                    for (int x = 0; x < nWidth; x++)
                    {
                        if (p[0] == comData[0] && p[1] == comData[1] && p[2] == comData[2])
                        {
                            count++;
                            result[0] = 1;
                            result[1] = X + x;
                            result[2] = Y + y;
                            //MessageBox.Show("(" + (X + x) + "," + (Y + y) + ")\n" + count + "Found!, " + result[1] + "," + result[2]);
                            return result;
                        }
                        p++;
                    }
                    p = p + nOffset;
                }
                //MessageBox.Show(count.ToString());
                return result;
            }
        }

        private void TypingEnglish(string str, int delay)
        {
            string NumSpecialChar = ")!@#$%^&*(";
            string SpecialChar = "`-=\\[];',./";
            string ShiftSpecialChar = "~_+|{}:\"<>?";
            byte[] SpecialCharCode = { 0xC0, 0xBD, 0xBB, 0xDC, 0xDB, 0xDD, 0xBA, 0xDE, 0xBC, 0xBE, 0xBF };

            int Length = str.Length;

            for (int i = 0; i < Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    keybd_event((byte)(str[i] - 'a' + 'A'), 0, 0, 0);
                    keybd_event((byte)(str[i] - 'a' + 'A'), 0, 0x0002, 0);
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0, 0);
                    keybd_event((byte)str[i], 0, 0, 0);
                    keybd_event((byte)str[i], 0, 0x0002, 0);
                    keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0x0002, 0);
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    keybd_event((byte)str[i], 0, 0, 0);
                    keybd_event((byte)str[i], 0, 0x0002, 0);
                }
                else if (str[i] == ' ')
                {
                    keybd_event((byte)str[i], 0, 0, 0);
                    keybd_event((byte)str[i], 0, 0x0002, 0);
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (str[i] == NumSpecialChar[j])
                        {
                            keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0, 0);
                            keybd_event((byte)('0' + j), 0, 0, 0);
                            keybd_event((byte)('0' + j), 0, 0x0002, 0);
                            keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0x0002, 0);
                            break;
                        }
                        if (j == 9)
                        {
                            for (int k = 0; k < 11; k++)
                            {
                                if (str[i] == SpecialChar[k])
                                {
                                    keybd_event(SpecialCharCode[k], 0, 0, 0);
                                    keybd_event(SpecialCharCode[k], 0, 0x0002, 0);
                                    break;
                                }
                                else if (str[i] == ShiftSpecialChar[k])
                                {
                                    keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0, 0);
                                    keybd_event(SpecialCharCode[k], 0, 0, 0);
                                    keybd_event(SpecialCharCode[k], 0, 0x0002, 0);
                                    keybd_event((byte)VirtualKeyCode.SHIFT, 0, 0x0002, 0);
                                    break;
                                }
                            }
                        }
                    }
                }
                Delay(delay);
            }
        }

        private void TypingString(string str, int delay)
        {
            string Buf;
            char[] cBuf = new char[10];
            int Length = str.Length;

            for (int i = 0; i < Length; i++)
            {
                if (str[i] >= 0xAC00 && str[i] <= 0xD7A3)
                {
                    Buf = string.Copy(addStringCopy.EngHanConverter.Kor2Eng(str[i].ToString()));
                    TypingEnglish(Buf, delay);
                }
                else
                {
                    Buf = str[i].ToString();

                    InputSimulator.SimulateKeyPress(VirtualKeyCode.HANGUL);
                    TypingEnglish(Buf, delay);
                    InputSimulator.SimulateKeyPress(VirtualKeyCode.HANGUL);
                }
            }
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MOUSEINPUT
    {
        int dx;
        int dy;
        uint mouseData;
        uint dwFlags;
        uint time;
        IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KEYBDINPUT
    {
        public ushort wVk;
        public ushort wScan;
        public uint dwFlags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HARDWAREINPUT
    {
        uint uMsg;
        ushort wParamL;
        ushort wParamH;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct INPUT
    {
        [FieldOffset(0)]
        public int type;
        [FieldOffset(4)] //*
        public MOUSEINPUT mi;
        [FieldOffset(4)] //*
        public KEYBDINPUT ki;
        [FieldOffset(4)] //*
        public HARDWAREINPUT hi;
    }
}
