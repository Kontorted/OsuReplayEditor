namespace ReplayEditor
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.modeStandard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modeMania = new System.Windows.Forms.RadioButton();
            this.modeCatchTheBeat = new System.Windows.Forms.RadioButton();
            this.modeTaiko = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.perfectNo = new System.Windows.Forms.RadioButton();
            this.perfectYes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.modNofail = new System.Windows.Forms.CheckBox();
            this.modEasy = new System.Windows.Forms.CheckBox();
            this.modHidden = new System.Windows.Forms.CheckBox();
            this.modHardRock = new System.Windows.Forms.CheckBox();
            this.modSuddenDeath = new System.Windows.Forms.CheckBox();
            this.modAuto = new System.Windows.Forms.CheckBox();
            this.modRelax = new System.Windows.Forms.CheckBox();
            this.modHalfTime = new System.Windows.Forms.CheckBox();
            this.modNightcore = new System.Windows.Forms.CheckBox();
            this.modDoubleTime = new System.Windows.Forms.CheckBox();
            this.modPerfect = new System.Windows.Forms.CheckBox();
            this.modAutopilot = new System.Windows.Forms.CheckBox();
            this.modSpunOut = new System.Windows.Forms.CheckBox();
            this.modFlashlight = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtGraph = new ReplayEditor.StringTextBox();
            this.txtMaxCombo = new ReplayEditor.ShortTextBox();
            this.txtScore = new ReplayEditor.IntTextBox();
            this.txtCountMiss = new ReplayEditor.ShortTextBox();
            this.txtCountKatsu = new ReplayEditor.ShortTextBox();
            this.txtCountGeki = new ReplayEditor.ShortTextBox();
            this.txtCount50 = new ReplayEditor.ShortTextBox();
            this.txtCount100 = new ReplayEditor.ShortTextBox();
            this.txtCount300 = new ReplayEditor.ShortTextBox();
            this.txtPlayerName = new ReplayEditor.StringTextBox();
            this.txtReplayHash = new ReplayEditor.StringTextBox();
            this.txtBeatmapHash = new ReplayEditor.StringTextBox();
            this.txtOsuVersion = new ReplayEditor.IntTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Mode";
            // 
            // modeStandard
            // 
            this.modeStandard.AutoSize = true;
            this.modeStandard.Checked = true;
            this.modeStandard.Location = new System.Drawing.Point(3, 3);
            this.modeStandard.Name = "modeStandard";
            this.modeStandard.Size = new System.Drawing.Size(68, 17);
            this.modeStandard.TabIndex = 1;
            this.modeStandard.TabStop = true;
            this.modeStandard.Text = "Standard";
            this.modeStandard.UseVisualStyleBackColor = true;
            this.modeStandard.CheckedChanged += new System.EventHandler(this.modeStandard_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modeMania);
            this.panel1.Controls.Add(this.modeCatchTheBeat);
            this.panel1.Controls.Add(this.modeTaiko);
            this.panel1.Controls.Add(this.modeStandard);
            this.panel1.Location = new System.Drawing.Point(108, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 23);
            this.panel1.TabIndex = 2;
            // 
            // modeMania
            // 
            this.modeMania.AutoSize = true;
            this.modeMania.Location = new System.Drawing.Point(237, 3);
            this.modeMania.Name = "modeMania";
            this.modeMania.Size = new System.Drawing.Size(54, 17);
            this.modeMania.TabIndex = 4;
            this.modeMania.Text = "Mania";
            this.modeMania.UseVisualStyleBackColor = true;
            this.modeMania.CheckedChanged += new System.EventHandler(this.modeMania_CheckedChanged);
            // 
            // modeCatchTheBeat
            // 
            this.modeCatchTheBeat.AutoSize = true;
            this.modeCatchTheBeat.Location = new System.Drawing.Point(135, 3);
            this.modeCatchTheBeat.Name = "modeCatchTheBeat";
            this.modeCatchTheBeat.Size = new System.Drawing.Size(96, 17);
            this.modeCatchTheBeat.TabIndex = 3;
            this.modeCatchTheBeat.Text = "Catch the Beat";
            this.modeCatchTheBeat.UseVisualStyleBackColor = true;
            this.modeCatchTheBeat.CheckedChanged += new System.EventHandler(this.modeCatchTheBeat_CheckedChanged);
            // 
            // modeTaiko
            // 
            this.modeTaiko.AutoSize = true;
            this.modeTaiko.Location = new System.Drawing.Point(77, 3);
            this.modeTaiko.Name = "modeTaiko";
            this.modeTaiko.Size = new System.Drawing.Size(52, 17);
            this.modeTaiko.TabIndex = 2;
            this.modeTaiko.Text = "Taiko";
            this.modeTaiko.UseVisualStyleBackColor = true;
            this.modeTaiko.CheckedChanged += new System.EventHandler(this.modeTaiko_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osu Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Beatmap Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Replay Hash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Player Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of 300\'s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of 100\'s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of 50\'s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Number of Geki\'s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Number of Katsu\'s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Number of Misses";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Score";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.perfectNo);
            this.panel2.Controls.Add(this.perfectYes);
            this.panel2.Location = new System.Drawing.Point(108, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 23);
            this.panel2.TabIndex = 6;
            // 
            // perfectNo
            // 
            this.perfectNo.AutoSize = true;
            this.perfectNo.Location = new System.Drawing.Point(52, 3);
            this.perfectNo.Name = "perfectNo";
            this.perfectNo.Size = new System.Drawing.Size(39, 17);
            this.perfectNo.TabIndex = 2;
            this.perfectNo.Text = "No";
            this.perfectNo.UseVisualStyleBackColor = true;
            this.perfectNo.CheckedChanged += new System.EventHandler(this.perfectNo_CheckedChanged);
            // 
            // perfectYes
            // 
            this.perfectYes.AutoSize = true;
            this.perfectYes.Checked = true;
            this.perfectYes.Location = new System.Drawing.Point(3, 3);
            this.perfectYes.Name = "perfectYes";
            this.perfectYes.Size = new System.Drawing.Size(43, 17);
            this.perfectYes.TabIndex = 1;
            this.perfectYes.TabStop = true;
            this.perfectYes.Text = "Yes";
            this.perfectYes.UseVisualStyleBackColor = true;
            this.perfectYes.CheckedChanged += new System.EventHandler(this.perfectYes_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Perfect Combo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(66, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Mods";
            // 
            // modNofail
            // 
            this.modNofail.AutoSize = true;
            this.modNofail.Location = new System.Drawing.Point(108, 314);
            this.modNofail.Name = "modNofail";
            this.modNofail.Size = new System.Drawing.Size(59, 17);
            this.modNofail.TabIndex = 56;
            this.modNofail.Text = "No Fail";
            this.modNofail.UseVisualStyleBackColor = true;
            this.modNofail.CheckedChanged += new System.EventHandler(this.modNofail_CheckedChanged);
            // 
            // modEasy
            // 
            this.modEasy.AutoSize = true;
            this.modEasy.Location = new System.Drawing.Point(194, 314);
            this.modEasy.Name = "modEasy";
            this.modEasy.Size = new System.Drawing.Size(49, 17);
            this.modEasy.TabIndex = 57;
            this.modEasy.Text = "Easy";
            this.modEasy.UseVisualStyleBackColor = true;
            this.modEasy.CheckedChanged += new System.EventHandler(this.modEasy_CheckedChanged);
            // 
            // modHidden
            // 
            this.modHidden.AutoSize = true;
            this.modHidden.Location = new System.Drawing.Point(194, 337);
            this.modHidden.Name = "modHidden";
            this.modHidden.Size = new System.Drawing.Size(60, 17);
            this.modHidden.TabIndex = 58;
            this.modHidden.Text = "Hidden";
            this.modHidden.UseVisualStyleBackColor = true;
            this.modHidden.CheckedChanged += new System.EventHandler(this.modHidden_CheckedChanged);
            // 
            // modHardRock
            // 
            this.modHardRock.AutoSize = true;
            this.modHardRock.Location = new System.Drawing.Point(108, 337);
            this.modHardRock.Name = "modHardRock";
            this.modHardRock.Size = new System.Drawing.Size(78, 17);
            this.modHardRock.TabIndex = 59;
            this.modHardRock.Text = "Hard Rock";
            this.modHardRock.UseVisualStyleBackColor = true;
            this.modHardRock.CheckedChanged += new System.EventHandler(this.modHardRock_CheckedChanged);
            // 
            // modSuddenDeath
            // 
            this.modSuddenDeath.AutoSize = true;
            this.modSuddenDeath.Location = new System.Drawing.Point(280, 383);
            this.modSuddenDeath.Name = "modSuddenDeath";
            this.modSuddenDeath.Size = new System.Drawing.Size(95, 17);
            this.modSuddenDeath.TabIndex = 60;
            this.modSuddenDeath.Text = "Sudden Death";
            this.modSuddenDeath.UseVisualStyleBackColor = true;
            this.modSuddenDeath.CheckedChanged += new System.EventHandler(this.modSuddenDeath_CheckedChanged);
            // 
            // modAuto
            // 
            this.modAuto.AutoSize = true;
            this.modAuto.Location = new System.Drawing.Point(280, 360);
            this.modAuto.Name = "modAuto";
            this.modAuto.Size = new System.Drawing.Size(48, 17);
            this.modAuto.TabIndex = 65;
            this.modAuto.Text = "Auto";
            this.modAuto.UseVisualStyleBackColor = true;
            this.modAuto.CheckedChanged += new System.EventHandler(this.modAuto_CheckedChanged);
            // 
            // modRelax
            // 
            this.modRelax.AutoSize = true;
            this.modRelax.Location = new System.Drawing.Point(108, 360);
            this.modRelax.Name = "modRelax";
            this.modRelax.Size = new System.Drawing.Size(53, 17);
            this.modRelax.TabIndex = 64;
            this.modRelax.Text = "Relax";
            this.modRelax.UseVisualStyleBackColor = true;
            this.modRelax.CheckedChanged += new System.EventHandler(this.modRelax_CheckedChanged);
            // 
            // modHalfTime
            // 
            this.modHalfTime.AutoSize = true;
            this.modHalfTime.Location = new System.Drawing.Point(280, 314);
            this.modHalfTime.Name = "modHalfTime";
            this.modHalfTime.Size = new System.Drawing.Size(71, 17);
            this.modHalfTime.TabIndex = 63;
            this.modHalfTime.Text = "Half Time";
            this.modHalfTime.UseVisualStyleBackColor = true;
            this.modHalfTime.CheckedChanged += new System.EventHandler(this.modHalfTime_CheckedChanged);
            // 
            // modNightcore
            // 
            this.modNightcore.AutoSize = true;
            this.modNightcore.Location = new System.Drawing.Point(194, 406);
            this.modNightcore.Name = "modNightcore";
            this.modNightcore.Size = new System.Drawing.Size(72, 17);
            this.modNightcore.TabIndex = 62;
            this.modNightcore.Text = "Nightcore";
            this.modNightcore.UseVisualStyleBackColor = true;
            this.modNightcore.CheckedChanged += new System.EventHandler(this.modNightcore_CheckedChanged);
            // 
            // modDoubleTime
            // 
            this.modDoubleTime.AutoSize = true;
            this.modDoubleTime.Location = new System.Drawing.Point(108, 406);
            this.modDoubleTime.Name = "modDoubleTime";
            this.modDoubleTime.Size = new System.Drawing.Size(86, 17);
            this.modDoubleTime.TabIndex = 61;
            this.modDoubleTime.Text = "Double Time";
            this.modDoubleTime.UseVisualStyleBackColor = true;
            this.modDoubleTime.CheckedChanged += new System.EventHandler(this.modDoubleTime_CheckedChanged);
            // 
            // modPerfect
            // 
            this.modPerfect.AutoSize = true;
            this.modPerfect.Location = new System.Drawing.Point(194, 383);
            this.modPerfect.Name = "modPerfect";
            this.modPerfect.Size = new System.Drawing.Size(60, 17);
            this.modPerfect.TabIndex = 69;
            this.modPerfect.Text = "Perfect";
            this.modPerfect.UseVisualStyleBackColor = true;
            this.modPerfect.CheckedChanged += new System.EventHandler(this.modPerfect_CheckedChanged);
            // 
            // modAutopilot
            // 
            this.modAutopilot.AutoSize = true;
            this.modAutopilot.Location = new System.Drawing.Point(194, 360);
            this.modAutopilot.Name = "modAutopilot";
            this.modAutopilot.Size = new System.Drawing.Size(67, 17);
            this.modAutopilot.TabIndex = 68;
            this.modAutopilot.Text = "Autopilot";
            this.modAutopilot.UseVisualStyleBackColor = true;
            this.modAutopilot.CheckedChanged += new System.EventHandler(this.modAutopilot_CheckedChanged);
            // 
            // modSpunOut
            // 
            this.modSpunOut.AutoSize = true;
            this.modSpunOut.Location = new System.Drawing.Point(108, 383);
            this.modSpunOut.Name = "modSpunOut";
            this.modSpunOut.Size = new System.Drawing.Size(71, 17);
            this.modSpunOut.TabIndex = 67;
            this.modSpunOut.Text = "Spun Out";
            this.modSpunOut.UseVisualStyleBackColor = true;
            this.modSpunOut.CheckedChanged += new System.EventHandler(this.modSpunOut_CheckedChanged);
            // 
            // modFlashlight
            // 
            this.modFlashlight.AutoSize = true;
            this.modFlashlight.Location = new System.Drawing.Point(280, 337);
            this.modFlashlight.Name = "modFlashlight";
            this.modFlashlight.Size = new System.Drawing.Size(70, 17);
            this.modFlashlight.TabIndex = 66;
            this.modFlashlight.Text = "Flashlight";
            this.modFlashlight.UseVisualStyleBackColor = true;
            this.modFlashlight.CheckedChanged += new System.EventHandler(this.modFlashlight_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(248, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Max Combo";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(439, 24);
            this.menuStrip.TabIndex = 74;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "Open     (Ctrl + O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "Save       (Ctrl + S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reloadToolStripMenuItem.Text = "Reload   (Ctrl + R)";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.sourceCodeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Graph Data";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(221, 52);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 78;
            // 
            // txtGraph
            // 
            this.txtGraph.Location = new System.Drawing.Point(108, 260);
            this.txtGraph.Name = "txtGraph";
            this.txtGraph.Size = new System.Drawing.Size(313, 20);
            this.txtGraph.TabIndex = 76;
            // 
            // txtMaxCombo
            // 
            this.txtMaxCombo.Location = new System.Drawing.Point(321, 235);
            this.txtMaxCombo.Name = "txtMaxCombo";
            this.txtMaxCombo.Size = new System.Drawing.Size(100, 20);
            this.txtMaxCombo.TabIndex = 72;
            this.txtMaxCombo.Text = "0";
            this.txtMaxCombo.Value = ((ushort)(0));
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(108, 235);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 24;
            this.txtScore.Text = "0";
            this.txtScore.Value = 0;
            // 
            // txtCountMiss
            // 
            this.txtCountMiss.Location = new System.Drawing.Point(321, 210);
            this.txtCountMiss.Name = "txtCountMiss";
            this.txtCountMiss.Size = new System.Drawing.Size(100, 20);
            this.txtCountMiss.TabIndex = 21;
            this.txtCountMiss.Text = "0";
            this.txtCountMiss.Value = ((ushort)(0));
            // 
            // txtCountKatsu
            // 
            this.txtCountKatsu.Location = new System.Drawing.Point(321, 185);
            this.txtCountKatsu.Name = "txtCountKatsu";
            this.txtCountKatsu.Size = new System.Drawing.Size(100, 20);
            this.txtCountKatsu.TabIndex = 19;
            this.txtCountKatsu.Text = "0";
            this.txtCountKatsu.Value = ((ushort)(0));
            // 
            // txtCountGeki
            // 
            this.txtCountGeki.Location = new System.Drawing.Point(321, 160);
            this.txtCountGeki.Name = "txtCountGeki";
            this.txtCountGeki.Size = new System.Drawing.Size(100, 20);
            this.txtCountGeki.TabIndex = 17;
            this.txtCountGeki.Text = "0";
            this.txtCountGeki.Value = ((ushort)(0));
            // 
            // txtCount50
            // 
            this.txtCount50.Location = new System.Drawing.Point(108, 210);
            this.txtCount50.Name = "txtCount50";
            this.txtCount50.Size = new System.Drawing.Size(100, 20);
            this.txtCount50.TabIndex = 15;
            this.txtCount50.Text = "0";
            this.txtCount50.Value = ((ushort)(0));
            // 
            // txtCount100
            // 
            this.txtCount100.Location = new System.Drawing.Point(108, 185);
            this.txtCount100.Name = "txtCount100";
            this.txtCount100.Size = new System.Drawing.Size(100, 20);
            this.txtCount100.TabIndex = 13;
            this.txtCount100.Text = "0";
            this.txtCount100.Value = ((ushort)(0));
            // 
            // txtCount300
            // 
            this.txtCount300.Location = new System.Drawing.Point(108, 160);
            this.txtCount300.Name = "txtCount300";
            this.txtCount300.Size = new System.Drawing.Size(100, 20);
            this.txtCount300.TabIndex = 11;
            this.txtCount300.Text = "0";
            this.txtCount300.Value = ((ushort)(0));
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(108, 133);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(313, 20);
            this.txtPlayerName.TabIndex = 10;
            // 
            // txtReplayHash
            // 
            this.txtReplayHash.Location = new System.Drawing.Point(108, 107);
            this.txtReplayHash.Name = "txtReplayHash";
            this.txtReplayHash.Size = new System.Drawing.Size(313, 20);
            this.txtReplayHash.TabIndex = 7;
            // 
            // txtBeatmapHash
            // 
            this.txtBeatmapHash.Location = new System.Drawing.Point(108, 80);
            this.txtBeatmapHash.Name = "txtBeatmapHash";
            this.txtBeatmapHash.Size = new System.Drawing.Size(313, 20);
            this.txtBeatmapHash.TabIndex = 6;
            // 
            // txtOsuVersion
            // 
            this.txtOsuVersion.Location = new System.Drawing.Point(108, 52);
            this.txtOsuVersion.Name = "txtOsuVersion";
            this.txtOsuVersion.Size = new System.Drawing.Size(100, 20);
            this.txtOsuVersion.TabIndex = 4;
            this.txtOsuVersion.Text = "0";
            this.txtOsuVersion.Value = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 431);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtGraph);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMaxCombo);
            this.Controls.Add(this.modPerfect);
            this.Controls.Add(this.modAutopilot);
            this.Controls.Add(this.modSpunOut);
            this.Controls.Add(this.modFlashlight);
            this.Controls.Add(this.modAuto);
            this.Controls.Add(this.modRelax);
            this.Controls.Add(this.modHalfTime);
            this.Controls.Add(this.modNightcore);
            this.Controls.Add(this.modDoubleTime);
            this.Controls.Add(this.modSuddenDeath);
            this.Controls.Add(this.modHardRock);
            this.Controls.Add(this.modHidden);
            this.Controls.Add(this.modEasy);
            this.Controls.Add(this.modNofail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCountMiss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCountKatsu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCountGeki);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCount50);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCount100);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCount300);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReplayHash);
            this.Controls.Add(this.txtBeatmapHash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOsuVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Replay Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton modeStandard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton modeMania;
        private System.Windows.Forms.RadioButton modeCatchTheBeat;
        private System.Windows.Forms.RadioButton modeTaiko;
        private System.Windows.Forms.Label label2;
        private IntTextBox txtOsuVersion;
        private System.Windows.Forms.Label label3;
        private StringTextBox txtBeatmapHash;
        private StringTextBox txtReplayHash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private StringTextBox txtPlayerName;
        private ShortTextBox txtCount300;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ShortTextBox txtCount100;
        private System.Windows.Forms.Label label8;
        private ShortTextBox txtCount50;
        private System.Windows.Forms.Label label9;
        private ShortTextBox txtCountGeki;
        private System.Windows.Forms.Label label10;
        private ShortTextBox txtCountKatsu;
        private System.Windows.Forms.Label label11;
        private ShortTextBox txtCountMiss;
        private IntTextBox txtScore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton perfectNo;
        private System.Windows.Forms.RadioButton perfectYes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox modNofail;
        private System.Windows.Forms.CheckBox modEasy;
        private System.Windows.Forms.CheckBox modHidden;
        private System.Windows.Forms.CheckBox modHardRock;
        private System.Windows.Forms.CheckBox modSuddenDeath;
        private System.Windows.Forms.CheckBox modAuto;
        private System.Windows.Forms.CheckBox modRelax;
        private System.Windows.Forms.CheckBox modHalfTime;
        private System.Windows.Forms.CheckBox modNightcore;
        private System.Windows.Forms.CheckBox modDoubleTime;
        private System.Windows.Forms.CheckBox modPerfect;
        private System.Windows.Forms.CheckBox modAutopilot;
        private System.Windows.Forms.CheckBox modSpunOut;
        private System.Windows.Forms.CheckBox modFlashlight;
        private System.Windows.Forms.Label label16;
        private ShortTextBox txtMaxCombo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private StringTextBox txtGraph;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}

