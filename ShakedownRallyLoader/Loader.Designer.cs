namespace ShakedownRallyLoader
{
    partial class Loader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtGamePath = new TextBox();
            folderBrowserDialog_GamePath = new FolderBrowserDialog();
            btnFindPath = new Button();
            btnLoadAssets = new Button();
            listBoxMaps = new ListBox();
            listBoxCars = new ListBox();
            label2 = new Label();
            label3 = new Label();
            btnSaveConfig = new Button();
            btnSaveDefault = new Button();
            btnLaunchGame = new Button();
            btnSaveAndLaunch = new Button();
            btnStartWithoutSaving = new Button();
            toolTipStart = new ToolTip(components);
            toolTipSaveStart = new ToolTip(components);
            toolTipStartWithoutSaving = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Shakedown Rally Path";
            // 
            // txtGamePath
            // 
            txtGamePath.Location = new Point(135, 6);
            txtGamePath.Name = "txtGamePath";
            txtGamePath.Size = new Size(544, 23);
            txtGamePath.TabIndex = 1;
            // 
            // folderBrowserDialog_GamePath
            // 
            folderBrowserDialog_GamePath.AddToRecent = false;
            folderBrowserDialog_GamePath.Description = "Shakedown Rally Path";
            folderBrowserDialog_GamePath.ShowHiddenFiles = true;
            // 
            // btnFindPath
            // 
            btnFindPath.Location = new Point(685, 6);
            btnFindPath.Name = "btnFindPath";
            btnFindPath.Size = new Size(75, 23);
            btnFindPath.TabIndex = 2;
            btnFindPath.Text = "Select Path";
            btnFindPath.UseVisualStyleBackColor = true;
            btnFindPath.Click += btnFindPath_Click;
            // 
            // btnLoadAssets
            // 
            btnLoadAssets.Location = new Point(12, 38);
            btnLoadAssets.Name = "btnLoadAssets";
            btnLoadAssets.Size = new Size(95, 23);
            btnLoadAssets.TabIndex = 3;
            btnLoadAssets.Text = "Load Assets";
            btnLoadAssets.UseVisualStyleBackColor = true;
            btnLoadAssets.Click += btnLoadAssets_Click;
            // 
            // listBoxMaps
            // 
            listBoxMaps.DisplayMember = "Key";
            listBoxMaps.FormattingEnabled = true;
            listBoxMaps.ItemHeight = 15;
            listBoxMaps.Location = new Point(389, 97);
            listBoxMaps.Name = "listBoxMaps";
            listBoxMaps.Size = new Size(371, 244);
            listBoxMaps.TabIndex = 4;
            listBoxMaps.ValueMember = "Value";
            // 
            // listBoxCars
            // 
            listBoxCars.DisplayMember = "Key";
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 15;
            listBoxCars.Location = new Point(12, 97);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(371, 244);
            listBoxCars.TabIndex = 5;
            listBoxCars.ValueMember = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Cars";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 79);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Maps";
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(119, 354);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(101, 23);
            btnSaveConfig.TabIndex = 8;
            btnSaveConfig.Text = "Save Config";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // btnSaveDefault
            // 
            btnSaveDefault.Location = new Point(12, 354);
            btnSaveDefault.Name = "btnSaveDefault";
            btnSaveDefault.Size = new Size(101, 23);
            btnSaveDefault.TabIndex = 9;
            btnSaveDefault.Text = "Save Default";
            btnSaveDefault.UseVisualStyleBackColor = true;
            btnSaveDefault.Click += btnSaveDefault_Click;
            // 
            // btnLaunchGame
            // 
            btnLaunchGame.Location = new Point(659, 354);
            btnLaunchGame.Name = "btnLaunchGame";
            btnLaunchGame.Size = new Size(101, 23);
            btnLaunchGame.TabIndex = 10;
            btnLaunchGame.Text = "Start";
            btnLaunchGame.UseVisualStyleBackColor = true;
            btnLaunchGame.Click += btnLaunchGame_Click;
            // 
            // btnSaveAndLaunch
            // 
            btnSaveAndLaunch.Location = new Point(554, 354);
            btnSaveAndLaunch.Name = "btnSaveAndLaunch";
            btnSaveAndLaunch.Size = new Size(99, 23);
            btnSaveAndLaunch.TabIndex = 11;
            btnSaveAndLaunch.Text = "Save and Start";
            btnSaveAndLaunch.UseVisualStyleBackColor = true;
            btnSaveAndLaunch.Click += btnSaveAndLaunch_Click;
            // 
            // btnStartWithoutSaving
            // 
            btnStartWithoutSaving.Location = new Point(415, 354);
            btnStartWithoutSaving.Name = "btnStartWithoutSaving";
            btnStartWithoutSaving.Size = new Size(133, 23);
            btnStartWithoutSaving.TabIndex = 12;
            btnStartWithoutSaving.Text = "Start Without Saving";
            btnStartWithoutSaving.UseVisualStyleBackColor = true;
            btnStartWithoutSaving.Click += btnStartWithoutSaving_Click;
            // 
            // Loader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 389);
            Controls.Add(btnStartWithoutSaving);
            Controls.Add(btnSaveAndLaunch);
            Controls.Add(btnLaunchGame);
            Controls.Add(btnSaveDefault);
            Controls.Add(btnSaveConfig);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxCars);
            Controls.Add(listBoxMaps);
            Controls.Add(btnLoadAssets);
            Controls.Add(btnFindPath);
            Controls.Add(txtGamePath);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(783, 428);
            Name = "Loader";
            Text = "Shakedown Rally Loader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGamePath;
        private FolderBrowserDialog folderBrowserDialog_GamePath;
        private Button btnFindPath;
        private Button btnLoadAssets;
        private ListBox listBoxMaps;
        private ListBox listBoxCars;
        private Label label2;
        private Label label3;
        private Button btnSaveConfig;
        private Button btnSaveDefault;
        private Button btnLaunchGame;
        private Button btnSaveAndLaunch;
        private Button btnStartWithoutSaving;
        private ToolTip toolTipStart;
        private ToolTip toolTipSaveStart;
        private ToolTip toolTipStartWithoutSaving;
    }
}
