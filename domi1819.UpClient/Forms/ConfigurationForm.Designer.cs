﻿using domi1819.DarkControls;

namespace domi1819.UpClient.Forms
{
    partial class ConfigurationForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.uiConnectionGroupLabel = new System.Windows.Forms.Label();
            this.uiServerAddressLabel = new System.Windows.Forms.Label();
            this.uiUserIdLabel = new System.Windows.Forms.Label();
            this.uiPasswordLabel = new System.Windows.Forms.Label();
            this.uiPasswordTextBox = new domi1819.DarkControls.DarkTextBox();
            this.uiUserIdTextBox = new domi1819.DarkControls.DarkTextBox();
            this.uiServerAddressTextBox = new domi1819.DarkControls.DarkTextBox();
            this.uiPreferencesGroupLabel = new System.Windows.Forms.Label();
            this.uiLocalCopyCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiSnapFileAreaCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiUpdateBehaviorGroupLabel = new System.Windows.Forms.Label();
            this.uiAutoInstallUpdatesCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiIndicateUpdatesCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiNeverCheckForUpdatesCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiCancelButton = new domi1819.DarkControls.DarkButton();
            this.uiSaveButton = new domi1819.DarkControls.DarkButton();
            this.uiNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.uiCryptoKeyTextBox = new domi1819.DarkControls.DarkTextBox();
            this.uiCryptoKeyBrowseButton = new domi1819.DarkControls.DarkButton();
            this.uiCryptoKeyLabel = new System.Windows.Forms.Label();
            this.darkButton1 = new domi1819.DarkControls.DarkButton();
            this.uiPngFormatCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiJpgFormatCheckBox = new domi1819.DarkControls.DarkCheckBox();
            this.uiScreenshotFormatLabel = new System.Windows.Forms.Label();
            this.darkButton2 = new domi1819.DarkControls.DarkButton();
            this.uiDarkColorView = new domi1819.DarkControls.DarkColorView();
            this.SuspendLayout();
            // 
            // uiConnectionGroupLabel
            // 
            this.uiConnectionGroupLabel.AutoSize = true;
            this.uiConnectionGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiConnectionGroupLabel.Location = new System.Drawing.Point(9, 11);
            this.uiConnectionGroupLabel.Name = "uiConnectionGroupLabel";
            this.uiConnectionGroupLabel.Size = new System.Drawing.Size(71, 13);
            this.uiConnectionGroupLabel.TabIndex = 0;
            this.uiConnectionGroupLabel.Text = "Connection";
            // 
            // uiServerAddressLabel
            // 
            this.uiServerAddressLabel.AutoSize = true;
            this.uiServerAddressLabel.Location = new System.Drawing.Point(9, 34);
            this.uiServerAddressLabel.Name = "uiServerAddressLabel";
            this.uiServerAddressLabel.Size = new System.Drawing.Size(38, 13);
            this.uiServerAddressLabel.TabIndex = 0;
            this.uiServerAddressLabel.Text = "Server";
            // 
            // uiUserIdLabel
            // 
            this.uiUserIdLabel.AutoSize = true;
            this.uiUserIdLabel.Location = new System.Drawing.Point(9, 60);
            this.uiUserIdLabel.Name = "uiUserIdLabel";
            this.uiUserIdLabel.Size = new System.Drawing.Size(43, 13);
            this.uiUserIdLabel.TabIndex = 2;
            this.uiUserIdLabel.Text = "User ID";
            // 
            // uiPasswordLabel
            // 
            this.uiPasswordLabel.AutoSize = true;
            this.uiPasswordLabel.Location = new System.Drawing.Point(9, 86);
            this.uiPasswordLabel.Name = "uiPasswordLabel";
            this.uiPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.uiPasswordLabel.TabIndex = 4;
            this.uiPasswordLabel.Text = "Password";
            // 
            // uiPasswordTextBox
            // 
            this.uiPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiPasswordTextBox.Location = new System.Drawing.Point(68, 82);
            this.uiPasswordTextBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiPasswordTextBox.Name = "uiPasswordTextBox";
            this.uiPasswordTextBox.Size = new System.Drawing.Size(154, 20);
            this.uiPasswordTextBox.TabIndex = 3;
            this.uiPasswordTextBox.TextValue = "";
            this.uiPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // uiUserIdTextBox
            // 
            this.uiUserIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiUserIdTextBox.Location = new System.Drawing.Point(68, 56);
            this.uiUserIdTextBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiUserIdTextBox.Name = "uiUserIdTextBox";
            this.uiUserIdTextBox.Size = new System.Drawing.Size(154, 20);
            this.uiUserIdTextBox.TabIndex = 2;
            this.uiUserIdTextBox.TextValue = "";
            this.uiUserIdTextBox.UseSystemPasswordChar = false;
            // 
            // uiServerAddressTextBox
            // 
            this.uiServerAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiServerAddressTextBox.Location = new System.Drawing.Point(68, 30);
            this.uiServerAddressTextBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiServerAddressTextBox.Name = "uiServerAddressTextBox";
            this.uiServerAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.uiServerAddressTextBox.TabIndex = 1;
            this.uiServerAddressTextBox.TextValue = "";
            this.uiServerAddressTextBox.UseSystemPasswordChar = false;
            // 
            // uiPreferencesGroupLabel
            // 
            this.uiPreferencesGroupLabel.AutoSize = true;
            this.uiPreferencesGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPreferencesGroupLabel.Location = new System.Drawing.Point(9, 170);
            this.uiPreferencesGroupLabel.Name = "uiPreferencesGroupLabel";
            this.uiPreferencesGroupLabel.Size = new System.Drawing.Size(75, 13);
            this.uiPreferencesGroupLabel.TabIndex = 6;
            this.uiPreferencesGroupLabel.Text = "Preferences";
            // 
            // uiLocalCopyCheckBox
            // 
            this.uiLocalCopyCheckBox.AutoSize = true;
            this.uiLocalCopyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiLocalCopyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLocalCopyCheckBox.Location = new System.Drawing.Point(12, 186);
            this.uiLocalCopyCheckBox.Name = "uiLocalCopyCheckBox";
            this.uiLocalCopyCheckBox.RadioStyle = false;
            this.uiLocalCopyCheckBox.Size = new System.Drawing.Size(179, 17);
            this.uiLocalCopyCheckBox.TabIndex = 7;
            this.uiLocalCopyCheckBox.Text = "Save local copies of screenshots";
            this.uiLocalCopyCheckBox.UseVisualStyleBackColor = false;
            // 
            // uiSnapFileAreaCheckBox
            // 
            this.uiSnapFileAreaCheckBox.AutoSize = true;
            this.uiSnapFileAreaCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiSnapFileAreaCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSnapFileAreaCheckBox.Location = new System.Drawing.Point(12, 206);
            this.uiSnapFileAreaCheckBox.Name = "uiSnapFileAreaCheckBox";
            this.uiSnapFileAreaCheckBox.RadioStyle = false;
            this.uiSnapFileAreaCheckBox.Size = new System.Drawing.Size(191, 17);
            this.uiSnapFileAreaCheckBox.TabIndex = 8;
            this.uiSnapFileAreaCheckBox.Text = "Snap file drop area to anchor points";
            this.uiSnapFileAreaCheckBox.UseVisualStyleBackColor = false;
            // 
            // uiUpdateBehaviorGroupLabel
            // 
            this.uiUpdateBehaviorGroupLabel.AutoSize = true;
            this.uiUpdateBehaviorGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUpdateBehaviorGroupLabel.Location = new System.Drawing.Point(9, 354);
            this.uiUpdateBehaviorGroupLabel.Name = "uiUpdateBehaviorGroupLabel";
            this.uiUpdateBehaviorGroupLabel.Size = new System.Drawing.Size(101, 13);
            this.uiUpdateBehaviorGroupLabel.TabIndex = 8;
            this.uiUpdateBehaviorGroupLabel.Text = "Update behavior";
            // 
            // uiAutoInstallUpdatesCheckBox
            // 
            this.uiAutoInstallUpdatesCheckBox.AutoSize = true;
            this.uiAutoInstallUpdatesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiAutoInstallUpdatesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiAutoInstallUpdatesCheckBox.Location = new System.Drawing.Point(12, 373);
            this.uiAutoInstallUpdatesCheckBox.Name = "uiAutoInstallUpdatesCheckBox";
            this.uiAutoInstallUpdatesCheckBox.RadioStyle = true;
            this.uiAutoInstallUpdatesCheckBox.Size = new System.Drawing.Size(155, 17);
            this.uiAutoInstallUpdatesCheckBox.TabIndex = 13;
            this.uiAutoInstallUpdatesCheckBox.Text = "Automatically install updates";
            this.uiAutoInstallUpdatesCheckBox.UseVisualStyleBackColor = false;
            this.uiAutoInstallUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.RadioCheckBoxesOnCheckedChanged);
            // 
            // uiIndicateUpdatesCheckBox
            // 
            this.uiIndicateUpdatesCheckBox.AutoSize = true;
            this.uiIndicateUpdatesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiIndicateUpdatesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIndicateUpdatesCheckBox.Location = new System.Drawing.Point(12, 393);
            this.uiIndicateUpdatesCheckBox.Name = "uiIndicateUpdatesCheckBox";
            this.uiIndicateUpdatesCheckBox.RadioStyle = true;
            this.uiIndicateUpdatesCheckBox.Size = new System.Drawing.Size(170, 17);
            this.uiIndicateUpdatesCheckBox.TabIndex = 14;
            this.uiIndicateUpdatesCheckBox.Text = "Show a notice for new updates";
            this.uiIndicateUpdatesCheckBox.UseVisualStyleBackColor = false;
            this.uiIndicateUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.RadioCheckBoxesOnCheckedChanged);
            // 
            // uiNeverCheckForUpdatesCheckBox
            // 
            this.uiNeverCheckForUpdatesCheckBox.AutoSize = true;
            this.uiNeverCheckForUpdatesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiNeverCheckForUpdatesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiNeverCheckForUpdatesCheckBox.Location = new System.Drawing.Point(12, 413);
            this.uiNeverCheckForUpdatesCheckBox.Name = "uiNeverCheckForUpdatesCheckBox";
            this.uiNeverCheckForUpdatesCheckBox.RadioStyle = true;
            this.uiNeverCheckForUpdatesCheckBox.Size = new System.Drawing.Size(141, 17);
            this.uiNeverCheckForUpdatesCheckBox.TabIndex = 15;
            this.uiNeverCheckForUpdatesCheckBox.Text = "Never check for updates";
            this.uiNeverCheckForUpdatesCheckBox.UseVisualStyleBackColor = false;
            this.uiNeverCheckForUpdatesCheckBox.CheckedChanged += new System.EventHandler(this.RadioCheckBoxesOnCheckedChanged);
            // 
            // uiCancelButton
            // 
            this.uiCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiCancelButton.FlatAppearance.BorderSize = 0;
            this.uiCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.uiCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.uiCancelButton.Location = new System.Drawing.Point(12, 439);
            this.uiCancelButton.Name = "uiCancelButton";
            this.uiCancelButton.Size = new System.Drawing.Size(102, 23);
            this.uiCancelButton.TabIndex = 16;
            this.uiCancelButton.Text = "Close";
            this.uiCancelButton.UseVisualStyleBackColor = false;
            this.uiCancelButton.Click += new System.EventHandler(this.CancelButtonOnClick);
            // 
            // uiSaveButton
            // 
            this.uiSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiSaveButton.FlatAppearance.BorderSize = 0;
            this.uiSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.uiSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.uiSaveButton.Location = new System.Drawing.Point(120, 439);
            this.uiSaveButton.Name = "uiSaveButton";
            this.uiSaveButton.Size = new System.Drawing.Size(102, 23);
            this.uiSaveButton.TabIndex = 0;
            this.uiSaveButton.Text = "Save";
            this.uiSaveButton.UseVisualStyleBackColor = false;
            this.uiSaveButton.Click += new System.EventHandler(this.SaveButtonOnClick);
            // 
            // uiNotifyIcon
            // 
            this.uiNotifyIcon.BalloonTipText = "w";
            this.uiNotifyIcon.BalloonTipTitle = "w";
            this.uiNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("uiNotifyIcon.Icon")));
            this.uiNotifyIcon.Text = "^up";
            this.uiNotifyIcon.Visible = true;
            this.uiNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconOnMouseDoubleClick);
            // 
            // uiCryptoKeyTextBox
            // 
            this.uiCryptoKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiCryptoKeyTextBox.Location = new System.Drawing.Point(68, 109);
            this.uiCryptoKeyTextBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiCryptoKeyTextBox.Name = "uiCryptoKeyTextBox";
            this.uiCryptoKeyTextBox.Size = new System.Drawing.Size(124, 20);
            this.uiCryptoKeyTextBox.TabIndex = 4;
            this.uiCryptoKeyTextBox.TextValue = "";
            this.uiCryptoKeyTextBox.UseSystemPasswordChar = false;
            // 
            // uiCryptoKeyBrowseButton
            // 
            this.uiCryptoKeyBrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiCryptoKeyBrowseButton.FlatAppearance.BorderSize = 0;
            this.uiCryptoKeyBrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.uiCryptoKeyBrowseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.uiCryptoKeyBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiCryptoKeyBrowseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.uiCryptoKeyBrowseButton.Location = new System.Drawing.Point(198, 109);
            this.uiCryptoKeyBrowseButton.Name = "uiCryptoKeyBrowseButton";
            this.uiCryptoKeyBrowseButton.Size = new System.Drawing.Size(24, 20);
            this.uiCryptoKeyBrowseButton.TabIndex = 5;
            this.uiCryptoKeyBrowseButton.Text = "...";
            this.uiCryptoKeyBrowseButton.UseVisualStyleBackColor = false;
            this.uiCryptoKeyBrowseButton.Click += new System.EventHandler(this.CryptoKeyBrowseButtonClick);
            // 
            // uiCryptoKeyLabel
            // 
            this.uiCryptoKeyLabel.AutoSize = true;
            this.uiCryptoKeyLabel.Location = new System.Drawing.Point(9, 113);
            this.uiCryptoKeyLabel.Name = "uiCryptoKeyLabel";
            this.uiCryptoKeyLabel.Size = new System.Drawing.Size(57, 13);
            this.uiCryptoKeyLabel.TabIndex = 13;
            this.uiCryptoKeyLabel.Text = "Crypto key";
            // 
            // darkButton1
            // 
            this.darkButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.darkButton1.FlatAppearance.BorderSize = 0;
            this.darkButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.darkButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.darkButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.darkButton1.Location = new System.Drawing.Point(12, 135);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Size = new System.Drawing.Size(210, 23);
            this.darkButton1.TabIndex = 6;
            this.darkButton1.Text = "Account details";
            this.darkButton1.UseVisualStyleBackColor = false;
            this.darkButton1.Click += new System.EventHandler(this.AccountDetailsButtonClick);
            // 
            // uiPngFormatCheckBox
            // 
            this.uiPngFormatCheckBox.AutoSize = true;
            this.uiPngFormatCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiPngFormatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPngFormatCheckBox.Location = new System.Drawing.Point(12, 306);
            this.uiPngFormatCheckBox.Name = "uiPngFormatCheckBox";
            this.uiPngFormatCheckBox.RadioStyle = true;
            this.uiPngFormatCheckBox.Size = new System.Drawing.Size(81, 17);
            this.uiPngFormatCheckBox.TabIndex = 11;
            this.uiPngFormatCheckBox.Text = "PNG (fancy)";
            this.uiPngFormatCheckBox.UseVisualStyleBackColor = false;
            this.uiPngFormatCheckBox.CheckedChanged += new System.EventHandler(this.FormatRadioCheckBoxesOnCheckedChanged);
            // 
            // uiJpgFormatCheckBox
            // 
            this.uiJpgFormatCheckBox.AutoSize = true;
            this.uiJpgFormatCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uiJpgFormatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiJpgFormatCheckBox.Location = new System.Drawing.Point(12, 326);
            this.uiJpgFormatCheckBox.Name = "uiJpgFormatCheckBox";
            this.uiJpgFormatCheckBox.RadioStyle = true;
            this.uiJpgFormatCheckBox.Size = new System.Drawing.Size(76, 17);
            this.uiJpgFormatCheckBox.TabIndex = 12;
            this.uiJpgFormatCheckBox.Text = "JPEG (fast)";
            this.uiJpgFormatCheckBox.UseVisualStyleBackColor = false;
            this.uiJpgFormatCheckBox.CheckedChanged += new System.EventHandler(this.FormatRadioCheckBoxesOnCheckedChanged);
            // 
            // uiScreenshotFormatLabel
            // 
            this.uiScreenshotFormatLabel.AutoSize = true;
            this.uiScreenshotFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiScreenshotFormatLabel.Location = new System.Drawing.Point(9, 290);
            this.uiScreenshotFormatLabel.Name = "uiScreenshotFormatLabel";
            this.uiScreenshotFormatLabel.Size = new System.Drawing.Size(110, 13);
            this.uiScreenshotFormatLabel.TabIndex = 8;
            this.uiScreenshotFormatLabel.Text = "Screenshot format";
            // 
            // darkButton2
            // 
            this.darkButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.darkButton2.FlatAppearance.BorderSize = 0;
            this.darkButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.darkButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.darkButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.darkButton2.Location = new System.Drawing.Point(12, 229);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Size = new System.Drawing.Size(210, 21);
            this.darkButton2.TabIndex = 9;
            this.darkButton2.Text = "Hotkeys...";
            this.darkButton2.UseVisualStyleBackColor = false;
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // uiDarkColorView
            // 
            this.uiDarkColorView.AllowEdit = true;
            this.uiDarkColorView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uiDarkColorView.Color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(192)))));
            this.uiDarkColorView.CustomText = "Theme color: ";
            this.uiDarkColorView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.uiDarkColorView.Location = new System.Drawing.Point(12, 256);
            this.uiDarkColorView.MaximumSize = new System.Drawing.Size(2000000000, 23);
            this.uiDarkColorView.MinimumSize = new System.Drawing.Size(100, 23);
            this.uiDarkColorView.Name = "uiDarkColorView";
            this.uiDarkColorView.Size = new System.Drawing.Size(210, 23);
            this.uiDarkColorView.TabIndex = 10;
            this.uiDarkColorView.ColorSelected += new System.EventHandler(this.DarkColorViewColorSelected);
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.uiSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 474);
            this.Controls.Add(this.uiDarkColorView);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.uiCryptoKeyLabel);
            this.Controls.Add(this.uiCryptoKeyBrowseButton);
            this.Controls.Add(this.uiCryptoKeyTextBox);
            this.Controls.Add(this.uiSaveButton);
            this.Controls.Add(this.uiCancelButton);
            this.Controls.Add(this.uiScreenshotFormatLabel);
            this.Controls.Add(this.uiUpdateBehaviorGroupLabel);
            this.Controls.Add(this.uiJpgFormatCheckBox);
            this.Controls.Add(this.uiNeverCheckForUpdatesCheckBox);
            this.Controls.Add(this.uiPngFormatCheckBox);
            this.Controls.Add(this.uiIndicateUpdatesCheckBox);
            this.Controls.Add(this.uiAutoInstallUpdatesCheckBox);
            this.Controls.Add(this.uiSnapFileAreaCheckBox);
            this.Controls.Add(this.uiLocalCopyCheckBox);
            this.Controls.Add(this.uiPreferencesGroupLabel);
            this.Controls.Add(this.uiPasswordTextBox);
            this.Controls.Add(this.uiPasswordLabel);
            this.Controls.Add(this.uiUserIdTextBox);
            this.Controls.Add(this.uiUserIdLabel);
            this.Controls.Add(this.uiServerAddressTextBox);
            this.Controls.Add(this.uiServerAddressLabel);
            this.Controls.Add(this.uiConnectionGroupLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiConnectionGroupLabel;
        private DarkTextBox uiServerAddressTextBox;
        private System.Windows.Forms.Label uiServerAddressLabel;
        private DarkTextBox uiUserIdTextBox;
        private System.Windows.Forms.Label uiUserIdLabel;
        private DarkTextBox uiPasswordTextBox;
        private System.Windows.Forms.Label uiPasswordLabel;
        private System.Windows.Forms.Label uiPreferencesGroupLabel;
        private DarkCheckBox uiLocalCopyCheckBox;
        private DarkCheckBox uiSnapFileAreaCheckBox;
        private System.Windows.Forms.Label uiUpdateBehaviorGroupLabel;
        private DarkCheckBox uiAutoInstallUpdatesCheckBox;
        private DarkCheckBox uiIndicateUpdatesCheckBox;
        private DarkCheckBox uiNeverCheckForUpdatesCheckBox;
        private DarkButton uiCancelButton;
        private DarkButton uiSaveButton;
        private System.Windows.Forms.NotifyIcon uiNotifyIcon;
        private DarkTextBox uiCryptoKeyTextBox;
        private DarkButton uiCryptoKeyBrowseButton;
        private System.Windows.Forms.Label uiCryptoKeyLabel;
        private DarkButton darkButton1;
        private DarkCheckBox uiPngFormatCheckBox;
        private DarkCheckBox uiJpgFormatCheckBox;
        private System.Windows.Forms.Label uiScreenshotFormatLabel;
        private DarkButton darkButton2;
        private DarkColorView uiDarkColorView;
    }
}