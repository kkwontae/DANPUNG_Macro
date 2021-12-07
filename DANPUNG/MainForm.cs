using System;
using System.Windows.Forms;
using System.Diagnostics;
using WindowsInput;
using System.IO;
using System.Deployment;
using System.Deployment.Application;

namespace DANPUNG
{
    public partial class MainForm : Form
    {

        static int idLoop = 0;
        public MainForm()
        {
            InitializeComponent();

            if (Program.IsAdministrator() == true)
            {
                this.Text += " (Administrator)";
            }

            txtDebug.Visible = false;
            #region STYLE
            barMenu.Renderer = new ToolStripProfessionalRenderer(new style());

            #endregion
            startFlag = 0;
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F3);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F4);
        }

        #region HOTKEY
        protected override void WndProc(ref Message message)
        {
            switch (message.Msg)
            {
                case hotkey.WM_HOTKEY:
                    Keys key = (Keys)(((int)message.LParam >> 16) & 0xFFFF);
                    hotkey.KeyModifiers modifier = (hotkey.KeyModifiers)((int)message.LParam & 0xFFFF);

                    if ((hotkey.KeyModifiers.None | hotkey.KeyModifiers.None) == modifier && Keys.F3 == key)
                    {
                        if (startFlag == 0)
                            startList(int.Parse(txtRepeat.Text));
                    }
                    else if ((hotkey.KeyModifiers.None | hotkey.KeyModifiers.None) == modifier && Keys.F4 == key)
                    {
                        if (startFlag == 1)
                            stopList();
                    }
                    break;
            }
            base.WndProc(ref message);
        }
        #endregion

        #region FUNCTION
        private void listContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCode.ClearSelected();
            listCode.BeginUpdate();
            for (int i = 0; i < listContent.SelectedItems.Count; i++)
                listCode.SetSelected(listContent.SelectedIndices[i], true);
            listCode.EndUpdate();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (listCode.Visible)
                listCode.Visible = false;
            else
                listCode.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (listContent.SelectedItems.Count != 0)
            {
                listCode.Items.RemoveAt(listCode.SelectedIndex);
                listContent.Items.RemoveAt(listContent.SelectedIndex);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            listContent.SelectedIndexChanged -= listContent_SelectedIndexChanged;

            int lowestIndexNotSelected = listContent.Items.Count - 1;
            for (int i = listContent.Items.Count - 1; i >= 0; i--)
                if (!listContent.SelectedIndices.Contains(i))
                    lowestIndexNotSelected = i;

            listContent.BeginUpdate();
            listCode.BeginUpdate();
            int numberOfSelectedItems = listContent.SelectedItems.Count;
            for (int i = 0; i < numberOfSelectedItems; i++)
            {
                if (listContent.SelectedIndices[i] > lowestIndexNotSelected)
                {
                    int indexToInsertIn = listContent.SelectedIndices[i] - 1;
                    listContent.Items.Insert(indexToInsertIn, listContent.SelectedItems[i]);
                    listContent.Items.RemoveAt(indexToInsertIn + 2);
                    listContent.SelectedIndex = indexToInsertIn;

                    listCode.Items.Insert(indexToInsertIn, listCode.SelectedItems[i]);
                    listCode.Items.RemoveAt(indexToInsertIn + 2);
                    listCode.SelectedIndex = indexToInsertIn;
                }
            }
            listContent.EndUpdate();
            listCode.EndUpdate();

            listContent.SelectedIndexChanged += listContent_SelectedIndexChanged;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            listContent.SelectedIndexChanged -= listContent_SelectedIndexChanged;

            int highestIndexNonSelected = 0;
            for (int i = 0; i < listContent.Items.Count; i++)
                if (!listContent.SelectedIndices.Contains(i))
                    highestIndexNonSelected = i;

            listContent.BeginUpdate();
            listCode.BeginUpdate();
            int numberOfSelectedItems = listContent.SelectedItems.Count;
            for (int i = numberOfSelectedItems - 1; i >= 0; i--)
            {
                if (listContent.SelectedIndices[i] < highestIndexNonSelected)
                {
                    int indexToInsertIn = listContent.SelectedIndices[i] + 2;
                    listContent.Items.Insert(indexToInsertIn, listContent.SelectedItems[i]);
                    listContent.Items.RemoveAt(indexToInsertIn - 2);
                    listContent.SelectedIndex = indexToInsertIn - 1;

                    listCode.Items.Insert(indexToInsertIn, listCode.SelectedItems[i]);
                    listCode.Items.RemoveAt(indexToInsertIn - 2);
                    listCode.SelectedIndex = indexToInsertIn - 1;
                }
            }
            listContent.EndUpdate();
            listCode.EndUpdate();

            listContent.SelectedIndexChanged += listContent_SelectedIndexChanged;
        }

        private void btnKeyboardEvent_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4);
            addKeyEvent aKE = new addKeyEvent();
            if (aKE.ShowDialog(this) == DialogResult.OK)
            {
                listContent.Items.Add(aKE.getItem());
                listCode.Items.Add(aKE.getCode());

                aKE.Close();
                aKE.Dispose();
            }
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F3);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F4);
        }

        private void btnAddMouseEvent_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4);
            addMouseEvent aME = new addMouseEvent();
            if (aME.ShowDialog(this) == DialogResult.OK)
            {
                listContent.Items.Add(aME.getItem());
                listCode.Items.Add(aME.getCode());

                aME.Close();
                aME.Dispose();
            }
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F3);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F4);
        }

        private void btnAddStringCopy_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4);
            addStringCopy aSC = new addStringCopy();
            if (aSC.ShowDialog(this) == DialogResult.OK)
            {
                listContent.Items.Add(aSC.getItem());
                listCode.Items.Add(aSC.getCode());

                aSC.Close();
                aSC.Dispose();
            }
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F3);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F4);
        }

        private void btnAddPixelSearch_Click(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4);
            addPixelSearch aPS = new addPixelSearch();
            if (aPS.ShowDialog(this) == DialogResult.OK)
            {
                listContent.Items.Add(aPS.getItem());
                listContent.Items.Add("--]");
                listContent.Items.Add("[--ELSE");
                listContent.Items.Add("--]");
                listCode.Items.Add(aPS.getCode());
                listCode.Items.Add("]");
                listCode.Items.Add("{");
                listCode.Items.Add("}");

                aPS.Close();
                aPS.Dispose();
            }
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F3);
            hotkey.RegisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4, hotkey.KeyModifiers.None | hotkey.KeyModifiers.None, Keys.F4);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startList(int.Parse(txtRepeat.Text));
        }

        private void btnAddDelay_Click(object sender, EventArgs e)
        {
            int delay1 = int.Parse(txtDelay1.Text);
            int delay2 = 0;
            int rDelay = 0;

            if (txtDelay2.Text != "")
            {
                if ((delay2 = int.Parse(txtDelay2.Text)) < delay1)
                {
                    MessageBox.Show("First Delay(" + delay1 + ") should be larger than Secondary Delay(" + delay2 + ")", "Error");
                    return;
                }
                rDelay = 1;
                listContent.Items.Add("Delay(" + delay1 + "~" + delay2 + ")");
            }
            else
                listContent.Items.Add("Delay(" + delay1 + ")");

            listCode.Items.Add("d" + delay1 + "f" + delay2 + "r" + rDelay);
        }

        private void cbInfinite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInfinite.Checked)
            {
                txtRepeat.ReadOnly = true;
                txtRepeat.Text = "-1";
            }
            else
            {
                txtRepeat.ReadOnly = false;
                txtRepeat.Text = "1";
            }
        }

        private void exitApp(object sender, EventArgs e)
        {
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f3);
            hotkey.UnregisterHotKey(this.Handle, hotkey.HOTKEY_ID_f4);
            Close();
            Dispose();
        }
        #endregion

        #region STRIPMENU
        static bool isfile = false;
        static string savesfolder = Path.Combine(Directory.GetCurrentDirectory() + @"\saves");
        static string openedFileName;
        static FileStream file;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogOpen.FileName = "";
            dialogOpen.InitialDirectory = Directory.GetCurrentDirectory();


            if (dialogOpen.ShowDialog(this) == DialogResult.OK)
            {
                openedFileName = dialogOpen.FileName;
                listContent.Items.Clear();
                listCode.Items.Clear();
                int section = 0;
                int num = 0;
                file = File.OpenRead(openedFileName);
                string[] line = File.ReadAllLines(openedFileName);
                while (num < line.Length)
                {
                    if (line[num] == "＄") // '＄' means a Section Seperator
                        section++;
                    else
                    {
                        if (section == 1)
                            listContent.Items.Add(line[num]);
                        else if (section == 2)
                            listCode.Items.Add(line[num]);
                    }
                    num++;
                }
                isfile = true;
                this.Text = "DANPUNG (" + Path.GetFileName(file.Name) + ")";
                dialogOpen.Dispose();
                file.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listContent.Items.Count == 0)
                MessageBox.Show("There is no data to save!", "Error!");

            if (!isfile)
            {
                dialogSave.FileName = "";
                if(Directory.Exists(savesfolder))
                    dialogSave.InitialDirectory = savesfolder;
                else
                    dialogSave.InitialDirectory = Directory.GetCurrentDirectory();

                if (listContent.Items.Count != 0 && dialogSave.ShowDialog(this) == DialogResult.OK)
                {
                    file = File.Create(dialogSave.FileName);
                    StreamWriter SaveFile = new StreamWriter(file);

                    SaveFile.WriteLine("＄"); // '＄' means a Section Seperator
                    foreach (var content in listContent.Items)
                        SaveFile.WriteLine(content);

                    SaveFile.WriteLine("＄");
                    foreach (var code in listCode.Items)
                        SaveFile.WriteLine(code);

                    SaveFile.Close();
                    file.Close();
                    dialogSave.Dispose();
                }
            }
            else
            {
                if (File.Exists(openedFileName))
                    File.Delete(openedFileName);
                file = File.Create(openedFileName);
                StreamWriter SaveFile = new StreamWriter(file);
                SaveFile.WriteLine("＄");
                foreach (var content in listContent.Items)
                    SaveFile.WriteLine(content);

                SaveFile.WriteLine("＄");
                foreach (var code in listCode.Items)
                    SaveFile.WriteLine(code);

                SaveFile.Close();
                file.Close();
            }
            if (dialogSave.FileName != "")
            {
                openedFileName = dialogSave.FileName;
                isfile = true;

                this.Text = "DANPUNG (" + Path.GetFileName(file.Name) + ")";
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listContent.Items.Count == 0)
                MessageBox.Show("There is no data to save!", "Error!");

            dialogSave.FileName = Path.GetFileName(openedFileName);
            dialogSave.InitialDirectory = Directory.GetCurrentDirectory();

            if (listContent.Items.Count != 0 && dialogSave.ShowDialog(this) == DialogResult.OK)
            {
                if (Directory.Exists(savesfolder))
                    dialogSave.InitialDirectory = savesfolder;
                else
                    dialogSave.InitialDirectory = Directory.GetCurrentDirectory();

                file = File.Create(dialogSave.FileName);
                StreamWriter SaveFile = new StreamWriter(file);

                SaveFile.WriteLine("＄"); // '＄' means a Section Seperator
                foreach (var content in listContent.Items)
                    SaveFile.WriteLine(content);

                SaveFile.WriteLine("＄");
                foreach (var code in listCode.Items)
                    SaveFile.WriteLine(code);

                SaveFile.Close();
                file.Close();
                dialogSave.Dispose();
            }
            if (dialogSave.FileName != "")
            {
                isfile = true;
                this.Text = "DANPUNG (" + Path.GetFileName(file.Name) + ")";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the changes?", "Warning!", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
                listCode.Items.Clear();
                listContent.Items.Clear();
            }

            else if (result == DialogResult.No)
            {
                listCode.Items.Clear();
                listContent.Items.Clear();
                txtDelay1.Text = "1000";
                txtRepeat.Text = "1";
                txtRepeat.ReadOnly = false;
                cbInfinite.Checked = false;
                this.Text = "DANPUNG";
                isfile = false;
                openedFileName = "";
            }
            else if (result == DialogResult.Cancel)
                return;
        }
        #endregion

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Back))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                e.Handled = true;
            else
                txtDebug.Visible = true;
        }

        private void btnAddLoop_Click(object sender, EventArgs e)
        {
            if(txtLoop.Text != "")
            {
                Loop.Text = idLoop++.ToString();

                listContent.Items.Add(":Loop" + Loop.Text + "," + txtLoop.Text + "times");
                listContent.Items.Add(":EndLoop" + Loop.Text);

                listCode.Items.Add("<i" + Loop.Text + "t" + txtLoop.Text);
                listCode.Items.Add(">i" + Loop.Text + "t" + txtLoop.Text);

            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                Version myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                Version latestVersion = ApplicationDeployment.CurrentDeployment.UpdatedVersion;
                MessageBox.Show("Current Version: v" + myVersion + "\n Latest Version : v" + latestVersion);
            }
        }

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("The application has been upgraded, and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            return;
                        }
                    }
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }
    }
}