using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ReplayEditor
{
    public enum Mods
    {
        None = 0,
        NoFail = 1,
        Easy = 2,
        Hidden = 8,
        HardRock = 16,
        SuddenDeath = 32,
        DoubleTime = 64,
        Relax = 128,
        HalfTime = 256,
        Nightcore = 512,
        Flashlight = 1024,
        Auto = 2048,
        SpunOut = 4096,
        Autopilot = 8192,
        Perfect = 16384,
    }

    public partial class MainForm : Form
    {
        public static string FileArg = "";
        public static UTF8Encoding Encoding = new UTF8Encoding();

        private byte gameModeSelected = 0;
        private byte perfectSelected = 1;
        private int modsSelected = 0;
        private string currentFile = "";
        private byte[] restOfData;

        public MainForm()
        {
            InitializeComponent();

            this.dateTime.Format = DateTimePickerFormat.Custom;
            this.dateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.UpdateCycle(true);
            if (MainForm.FileArg != "")
            {
                this.Open(MainForm.FileArg);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                this.Save();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                this.LoadFile();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                this.Open();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FromBytes(byte[] bytes)
        {
            int pos = 5;
            this.UpdateGameMode(bytes[0]);
            this.txtOsuVersion.Value = BitConverter.ToInt32(bytes, 1);
            this.txtBeatmapHash.Text = this.stringFromBytes(bytes, ref pos);
            this.txtPlayerName.Text = this.stringFromBytes(bytes, ref pos);
            this.txtReplayHash.Text = this.stringFromBytes(bytes, ref pos);
            this.txtCount300.Value = BitConverter.ToUInt16(bytes, pos);
            this.txtCount100.Value = BitConverter.ToUInt16(bytes, pos += 2);
            this.txtCount50.Value = BitConverter.ToUInt16(bytes, pos += 2);
            this.txtCountGeki.Value = BitConverter.ToUInt16(bytes, pos += 2);
            this.txtCountKatsu.Value = BitConverter.ToUInt16(bytes, pos += 2);
            this.txtCountMiss.Value = BitConverter.ToUInt16(bytes, pos += 2);
            this.txtScore.Value = BitConverter.ToInt32(bytes, pos += 2);
            this.txtMaxCombo.Value = BitConverter.ToUInt16(bytes, pos += 4);
            this.UpdatePerfect(bytes[pos += 2]);
            this.UpdateMods(BitConverter.ToInt32(bytes, pos += 1));
            pos += 4;
            this.txtGraph.Text = this.stringFromBytes(bytes, ref pos);
            this.dateTime.Value = TimeZoneInfo.ConvertTimeFromUtc(DateTime.FromBinary(BitConverter.ToInt64(bytes, pos)), TimeZoneInfo.Local);
            pos += 8;
            this.restOfData = new byte[bytes.Length - pos];
            Array.Copy(bytes, pos, this.restOfData, 0, restOfData.Length);
        }

        private byte[] ToBytes()
        {
            List<byte> list = new List<byte>();

            list.Add(this.gameModeSelected);
            list.AddRange(this.txtOsuVersion.ToByteArray());
            list.AddRange(this.txtBeatmapHash.ToByteArray());
            list.AddRange(this.txtPlayerName.ToByteArray());
            list.AddRange(this.txtReplayHash.ToByteArray());
            list.AddRange(this.txtCount300.ToByteArray());
            list.AddRange(this.txtCount100.ToByteArray());
            list.AddRange(this.txtCount50.ToByteArray());
            list.AddRange(this.txtCountGeki.ToByteArray());
            list.AddRange(this.txtCountKatsu.ToByteArray());
            list.AddRange(this.txtCountMiss.ToByteArray());
            list.AddRange(this.txtScore.ToByteArray());
            list.AddRange(this.txtMaxCombo.ToByteArray());
            list.Add(this.perfectSelected);
            list.AddRange(BitConverter.GetBytes(this.modsSelected));
            list.AddRange(this.txtGraph.ToByteArray());
            DateTime storedValue = TimeZoneInfo.ConvertTimeToUtc(this.dateTime.Value);
            list.AddRange(BitConverter.GetBytes(storedValue.Ticks));
            list.AddRange(this.restOfData);
            return list.ToArray();
        }

        private string stringFromBytes(byte[] bytes, ref int pos)
        {
            if (bytes[pos++] != 0x0b)
            {
                throw new Exception("Incorrect file format. Must be a .osr osu replay file.");
            }
            int len = MainForm.DecodeULEB(bytes, ref pos);
            string eax = MainForm.Encoding.GetString(bytes, ++pos, len);
            pos += len;
            return eax;
        }

        public static List<byte> EncodeULEB(int num)
        {
            List<byte> list = new List<byte>();
            do
            {
                byte value = (byte)(num & 0x7f);
                num >>= 7;
                if (num != 0)
                {
                    value |= 0x80;
                }
                list.Add(value);
            }
            while(num != 0);
            return list;
        }

        public static int DecodeULEB(byte[] bytes, ref int pos)
        {
            int eax = 0;
            int shift = 0;
            while (true)
            {
                eax |= ((bytes[pos] & 0x7f) << shift);
                if ((bytes[pos] >> 7) == 0)
                {
                    break;
                }
                shift += 7;
                pos++;
            }
            return eax;
        }

        private void Save()
        {
            if (this.currentFile == "")
            {
                this.ErrorMessage("No file open.");
                return;
            }
            this.Focus();
            try
            {
                File.WriteAllBytes(this.currentFile, this.ToBytes());
            }
            catch (Exception e)
            {
                this.ErrorMessage(e.Message);
            }
        }

        private void Open(string file)
        {
            this.currentFile = file;
            this.LoadFile();
        }

        private void Open()
        {
            if (this.openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                this.Open(this.openFileDialog.FileName);
            }
        }

        private void LoadFile()
        {
            if (this.currentFile == "")
            {
                this.ErrorMessage("No file open.");
                return;
            }
            try
            {
                this.FromBytes(File.ReadAllBytes(this.currentFile));
            }
            catch (Exception e)
            {
                this.ErrorMessage(e.Message);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.Open(files[0]);
        }

        private void ErrorMessage(string msg)
        {
            MessageBox.Show(msg, "Error");
        }

        private void modeStandard_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateGameMode();
        }

        private void modeTaiko_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateGameMode();
        }

        private void modeCatchTheBeat_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateGameMode();
        }

        private void modeMania_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateGameMode();
        }

        private void UpdateGameMode()
        {
            if (modeStandard.Checked)
            {
                this.gameModeSelected = 0;
            }
            else if (modeTaiko.Checked)
            {
                this.gameModeSelected = 1;
            }
            else if (modeCatchTheBeat.Checked)
            {
                this.gameModeSelected = 2;
            }
            else if (modeMania.Checked)
            {
                this.gameModeSelected = 3;
            }
            else
            {
                this.gameModeSelected = 0;
            }
        }

        private void UpdateGameMode(byte value)
        {
            this.gameModeSelected = value;
            if (value == 0)
            {
                modeStandard.Checked = true;
            }
            else if (value == 1)
            {
                modeTaiko.Checked = true;
            }
            else if (value == 2)
            {
                modeCatchTheBeat.Checked = true;
            }
            else if (value == 3)
            {
                modeMania.Checked = true;
            }
        }

        private void perfectYes_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdatePerfect();
        }

        private void perfectNo_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdatePerfect();
        }

        private void UpdatePerfect()
        {
            if (perfectNo.Checked)
            {
                this.perfectSelected = 0;
            }
            else if (perfectYes.Checked)
            {
                this.perfectSelected = 1;
            }
            else
            {
                this.perfectSelected = 0;

            }
        }

        private void UpdatePerfect(byte value)
        {
            this.perfectSelected = value;
            if (value == 0)
            {
                perfectNo.Checked = true;
            }
            else if (value == 1)
            {
                perfectYes.Checked = true;
            }
        }

        private void modNofail_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modEasy_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modHidden_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modHardRock_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modSuddenDeath_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modRelax_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modHalfTime_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modNightcore_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modDoubleTime_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modFlashlight_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modSpunOut_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modAutopilot_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void modPerfect_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateMods();
        }

        private void UpdateMods()
        {
            this.modsSelected = 0;
            if (modNofail.Checked)
            {
                this.modsSelected += (int)Mods.NoFail;
            }
            if (modEasy.Checked)
            {
                this.modsSelected += (int)Mods.Easy;
            }
            if (modHidden.Checked)
            {
                this.modsSelected += (int)Mods.Hidden;
            }
            if (modHardRock.Checked)
            {
                this.modsSelected += (int)Mods.HardRock;
            }
            if (modSuddenDeath.Checked)
            {
                this.modsSelected += (int)Mods.SuddenDeath;
            }
            if (modDoubleTime.Checked)
            {
                this.modsSelected += (int)Mods.DoubleTime;
            }
            if (modRelax.Checked)
            {
                this.modsSelected += (int)Mods.Relax;
            }
            if (modHalfTime.Checked)
            {
                this.modsSelected += (int)Mods.HalfTime;
            }
            if (modNightcore.Checked)
            {
                this.modsSelected += (int)Mods.Nightcore;
            }
            if (modFlashlight.Checked)
            {
                this.modsSelected += (int)Mods.Flashlight;
            }
            if (modAuto.Checked)
            {
                this.modsSelected += (int)Mods.Auto;
            }
            if (modSpunOut.Checked)
            {
                this.modsSelected += (int)Mods.SpunOut;
            }
            if (modAutopilot.Checked)
            {
                this.modsSelected += (int)Mods.Autopilot;
            }
            if (modPerfect.Checked)
            {
                this.modsSelected += (int)Mods.Perfect;
            }
        }

        private void UpdateMods(int value)
        {
            this.modsSelected = value;
            modNofail.Checked = (value & (int)Mods.NoFail) != 0;
            modEasy.Checked = (value & (int)Mods.Easy) != 0;
            modHidden.Checked = (value & (int)Mods.Hidden) != 0;
            modHardRock.Checked = (value & (int)Mods.HardRock) != 0;
            modSuddenDeath.Checked = (value & (int)Mods.SuddenDeath) != 0;
            modDoubleTime.Checked = (value & (int)Mods.DoubleTime) != 0;
            modRelax.Checked = (value & (int)Mods.Relax) != 0;
            modHalfTime.Checked = (value & (int)Mods.HalfTime) != 0;
            modNightcore.Checked = (value & (int)Mods.Nightcore) != 0;
            modFlashlight.Checked = (value & (int)Mods.Flashlight) != 0;
            modAuto.Checked = (value & (int)Mods.Auto) != 0;
            modSpunOut.Checked = (value & (int)Mods.SpunOut) != 0;
            modAutopilot.Checked = (value & (int)Mods.Autopilot) != 0;
            modPerfect.Checked = (value & (int)Mods.Perfect) != 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadFile();
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/thebetioplane/OsuReplayEditor");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdateCycle(false);
        }

        private void UpdateCycle(bool silent)
        {
            if (Updater.CheckForUpdate())
            {
                DialogResult response = MessageBox.Show("An update has been found. Would you like to apply it?", "Update Found", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (response == DialogResult.Yes)
                {
                    string file = "__ReplayEditor.exe.tmp";
                    if (Updater.DownloadUpdate(file))
                    {
                        File.WriteAllLines("updater.bat", new string[] { "@echo off", "echo Waiting for process to close", "timeout /t 3", "echo Updating...", "del \"ReplayEditor.exe\"", "ren \"" + file + "\" \"ReplayEditor.exe\"", "start ReplayEditor.exe", "(goto) 2>nul & del \"%~f0\"" });
                        Process.Start("updater.bat");
                        Application.Exit();
                    }
                    else
                    {
                        this.ErrorMessage("Could not download update.");
                    }
                }
            }
            else if (! silent)
            {
                MessageBox.Show("No update found.", "Check for Update");
            }
        }
    }
}
