using System;
using System.Threading;
using WindowsInput;
using System.Windows.Forms;

namespace DANPUNG
{
    partial class MainForm
    {
        static int[] count = { 1, };
        static int[] sizeLoop = { 1, };

        private void startList(int repeatEnd)
        {
            startFlag = 1;
            priority = 0;
            sizeOfList = listContent.Items.Count;

            for (int repeat = 0; repeat != repeatEnd; repeat++)
            {
                for (int i = 0; i < sizeOfList; i++)
                {
                    label1.Text = i.ToString();
                    listCode.SelectedIndex = i;
                    string codeItem = listCode.SelectedItem.ToString();

                    if (codeItem.IndexOf("d") == 0)
                    {
                        char[] delimiterChars = { 'd', 'f', 'r' };
                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        int dDelay = int.Parse(codeItemPiece[1]);
                        int fDelay = int.Parse(codeItemPiece[2]);
                        int randomDelay = int.Parse(codeItemPiece[3]);

                        if (randomDelay == 1)
                        {
                            Random r = new Random();
                            Delay(r.Next(dDelay, fDelay));
                        }
                        else
                            Delay(dDelay);
                    }

                    else if (codeItem.IndexOf("x") == 0)
                    {
                        char[] delimiterChars = { 'x', 'y', 'p', 'q', 'b', 'a', 'd', 'r' };

                        string[] codeItemPiece = codeItem.Split(delimiterChars); // [1]PosX [2]PosY [3]Button [4]Action [5]Delay

                        int mPosX1 = int.Parse(codeItemPiece[1]);
                        int mPosY1 = int.Parse(codeItemPiece[2]);
                        int mPosX2 = int.Parse(codeItemPiece[3]);
                        int mPosY2 = int.Parse(codeItemPiece[4]);
                        int mButton = int.Parse(codeItemPiece[5]);
                        int mAction = int.Parse(codeItemPiece[6]);
                        int mDelay = int.Parse(codeItemPiece[7]);
                        int mRandom = int.Parse(codeItemPiece[8]);

                        Mouse(mPosX1, mPosY1, mPosX2, mPosY2, mButton, mAction, mDelay, mRandom);
                    }
                    else if (codeItem.IndexOf("k") == 0)
                    {
                        char[] delimiterChars = { 'k', 'c', 'm', 's', 'w', 'd', 'h' };

                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        VirtualKeyCode kVK = (VirtualKeyCode)int.Parse(codeItemPiece[1]); // [1]VirtualKey [2]Control [3]Alt [4]
                        int kControl = int.Parse(codeItemPiece[2]);
                        int kAlt = int.Parse(codeItemPiece[3]);
                        int kShift = int.Parse(codeItemPiece[4]);
                        int kWindow = int.Parse(codeItemPiece[5]);
                        int kKeyDown = int.Parse(codeItemPiece[6]);
                        if (txtDebug.Text == "")
                        {
                            if (kControl + kAlt + kShift + kWindow == 0)
                            {
                                if (kKeyDown <= 0)
                                    InputSimulator.SimulateKeyPress(kVK);
                                else
                                {
                                    InputSimulator.SimulateKeyDown(kVK);
                                    Thread.Sleep(kKeyDown);
                                    InputSimulator.SimulateKeyUp(kVK);
                                }
                            }
                            else
                                InputSimulator.SimulateModifiedKeyStroke(modifedKeys(kControl, kAlt, kShift, kWindow), kVK);
                        }
                        else
                        {
                            IntPtr hWnd = FindWindow(txtDebug.Text, null);

                            if (kKeyDown <= 0)
                                sendKey(hWnd, kVK, false);
                            else
                            {
                                InputSimulator.SimulateKeyDown(kVK);
                                Thread.Sleep(kKeyDown);
                                InputSimulator.SimulateKeyUp(kVK);
                            }
                        }

                    }
                    else if (codeItem.IndexOf("！") == 0)
                    {
                        char[] delimiterChars = { '！', '？' };

                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        string line = codeItemPiece[1];
                        int sDelay = int.Parse(codeItemPiece[2]);

                        TypingString(line, sDelay);
                    }
                    else if (codeItem.IndexOf("[") == 0)
                    {
                        char[] delimiterChars = { '[', 'x', 'y', 'p', 'q', 'r', '#' };

                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        var open = codeItemPiece[1];
                        int pPosX1 = int.Parse(codeItemPiece[2]);
                        int pPosY1 = int.Parse(codeItemPiece[3]);
                        int pPosX2 = int.Parse(codeItemPiece[4]);
                        int pPosY2 = int.Parse(codeItemPiece[5]);
                        int pRange = int.Parse(codeItemPiece[6]);
                        int pColor = int.Parse(codeItemPiece[7]);

                        int pWidth = pPosX2 - pPosX1 + 1;
                        int pHeight = pPosY2 - pPosY1 + 1;

                        int[] result = new int[3];

                        result = PixelSearchRange(pPosX1, pPosY1, pPosX2, pPosY2, pRange, pColor);

                        if (result[0] > 0)
                            priority++;
                        else if (result[0] < 0)
                            while (listCode.Items[i].ToString() != "]")
                                i++;
                    }
                    else if (codeItem.IndexOf("]") == 0)
                    {
                        priority--;
                        while (listCode.Items[i].ToString() != "}")
                            i++;
                    }

                    else if (codeItem.IndexOf("{") == 0)
                        priority++;
                    else if (codeItem.IndexOf("}") == 0)
                        priority--;
                    else if (codeItem.IndexOf("<") == 0)
                    {
                        char[] delimiterChars = { '<', 'i', 't' };
                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        idLoop = int.Parse(codeItemPiece[2]);
                    }

                    else if (codeItem.IndexOf(">") == 0)
                    {
                        char[] delimiterChars = { '>', 'i', 't' };
                        string[] codeItemPiece = codeItem.Split(delimiterChars);

                        idLoop = int.Parse(codeItemPiece[2]);
                        sizeLoop[idLoop] = int.Parse(codeItemPiece[3]);

                        if (count[idLoop] < sizeLoop[idLoop])
                        {
                            MessageBox.Show(count[idLoop].ToString() + "<" + sizeLoop[idLoop]);
                            count[idLoop]++;
                            MessageBox.Show((listCode.Items[i].ToString().IndexOf("<i" + idLoop) != 0).ToString());
                            while (listCode.Items[i].ToString().IndexOf("<i" + idLoop) != 0)
                                i--;
                        }
                        else
                            count[idLoop] = 1;
                        
                    }
                    else if (codeItem.IndexOf("=") == 0)
                    {
                        //MessageBox.Show("Stopped");
                        break;
                    }
                    listCode.ClearSelected();
                }
                Delay(1);
                if (startFlag == 0)
                    break;
            }
            startFlag = 0;
            listCode.Items.Remove("====================");
        }

        private void stopList()
        {
            listCode.Items.Insert(listCode.SelectedIndex + 1, "====================");
            startFlag = 0;
        }
    }
}
