﻿namespace EASTester
{
    partial class frmRawEAS
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
            this.components = new System.ComponentModel.Container();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.ServerUrl = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cmboVersion = new System.Windows.Forms.ComboBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboCommand = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.chkOverrideSslCertificateVerification = new System.Windows.Forms.CheckBox();
            this.txtPolicyKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveExample = new System.Windows.Forms.Button();
            this.btnLoadExample = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.txtCertAuthFile = new System.Windows.Forms.TextBox();
            this.txtCertPassword = new System.Windows.Forms.TextBox();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.btnEncodingHelper = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusCause = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.chkOverrideProxyCredentials = new System.Windows.Forms.CheckBox();
            this.txtProxyServerDomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProxyServerPassword = new System.Windows.Forms.TextBox();
            this.txtProxyServerUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtProxyServerPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.txtProxyServerName = new System.Windows.Forms.TextBox();
            this.lblProxyServer = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.btnStatusCodeHelper = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtHexResponse = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnViewInBrowser = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkUseCertAuth = new System.Windows.Forms.CheckBox();
            this.btnSelectCertFile = new System.Windows.Forms.Button();
            this.btnProvisionSettings = new System.Windows.Forms.Button();
            this.btnProvision = new System.Windows.Forms.Button();
            this.lblCertPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEncodePostLine = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.helpProvider1.SetHelpString(this.txtDomain, "Domain of the user. If you entered an  SMTP address into the User field, then lea" +
        "ve this field blank.");
            this.txtDomain.Location = new System.Drawing.Point(104, 172);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(0);
            this.txtDomain.Name = "txtDomain";
            this.helpProvider1.SetShowHelp(this.txtDomain, true);
            this.txtDomain.Size = new System.Drawing.Size(190, 22);
            this.txtDomain.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.helpProvider1.SetHelpString(this.txtPassword, "User password.");
            this.txtPassword.Location = new System.Drawing.Point(104, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.helpProvider1.SetHelpString(this.txtUser, "User alias or smtp address.");
            this.txtUser.Location = new System.Drawing.Point(104, 124);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.Name = "txtUser";
            this.helpProvider1.SetShowHelp(this.txtUser, true);
            this.txtUser.Size = new System.Drawing.Size(190, 22);
            this.txtUser.TabIndex = 8;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(25, 172);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(60, 17);
            this.lblDomain.TabIndex = 11;
            this.lblDomain.Text = "Domain:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 147);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 122);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User:";
            // 
            // txtServerUrl
            // 
            this.helpProvider1.SetHelpString(this.txtServerUrl, "Mailbox domain or address.  Example: contoso.com");
            this.txtServerUrl.Location = new System.Drawing.Point(130, 46);
            this.txtServerUrl.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerUrl.Name = "txtServerUrl";
            this.helpProvider1.SetShowHelp(this.txtServerUrl, true);
            this.txtServerUrl.Size = new System.Drawing.Size(389, 22);
            this.txtServerUrl.TabIndex = 1;
            this.txtServerUrl.Text = "outlook.office365.com";
            this.txtServerUrl.TextChanged += new System.EventHandler(this.txtServerUrl_TextChanged);
            // 
            // ServerUrl
            // 
            this.ServerUrl.AutoSize = true;
            this.ServerUrl.Location = new System.Drawing.Point(6, 49);
            this.ServerUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Size = new System.Drawing.Size(120, 17);
            this.ServerUrl.TabIndex = 0;
            this.ServerUrl.Text = "Mail domain/addr:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(293, 96);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(1);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(91, 17);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "EAS Version:";
            // 
            // cmboVersion
            // 
            this.cmboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboVersion.FormattingEnabled = true;
            this.cmboVersion.ItemHeight = 16;
            this.cmboVersion.Items.AddRange(new object[] {
            "16.1",
            "16.0",
            "14.1",
            "14.0",
            "12.1"});
            this.cmboVersion.Location = new System.Drawing.Point(391, 95);
            this.cmboVersion.Margin = new System.Windows.Forms.Padding(4);
            this.cmboVersion.Name = "cmboVersion";
            this.cmboVersion.Size = new System.Drawing.Size(128, 24);
            this.cmboVersion.TabIndex = 18;
            this.cmboVersion.SelectedIndexChanged += new System.EventHandler(this.cmboVersion_SelectedIndexChanged);
            // 
            // txtRequest
            // 
            this.txtRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequest.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(0, 0);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(950, 90);
            this.txtRequest.TabIndex = 0;
            this.txtRequest.WordWrap = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(777, 201);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(172, 27);
            this.btnRun.TabIndex = 47;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Device Id:";
            // 
            // txtDeviceId
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceId, "TheID of the device.");
            this.txtDeviceId.Location = new System.Drawing.Point(391, 124);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(1);
            this.txtDeviceId.Name = "txtDeviceId";
            this.helpProvider1.SetShowHelp(this.txtDeviceId, true);
            this.txtDeviceId.Size = new System.Drawing.Size(128, 22);
            this.txtDeviceId.TabIndex = 20;
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // txtDeviceType
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceType, "Device Type");
            this.txtDeviceType.Location = new System.Drawing.Point(391, 151);
            this.txtDeviceType.Margin = new System.Windows.Forms.Padding(1);
            this.txtDeviceType.Name = "txtDeviceType";
            this.helpProvider1.SetShowHelp(this.txtDeviceType, true);
            this.txtDeviceType.Size = new System.Drawing.Size(128, 22);
            this.txtDeviceType.TabIndex = 22;
            this.txtDeviceType.TextChanged += new System.EventHandler(this.txtDeviceType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Device Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Command:";
            // 
            // cmboCommand
            // 
            this.cmboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCommand.FormattingEnabled = true;
            this.cmboCommand.Items.AddRange(new object[] {
            "SendMail",
            "SmartForward",
            "SmartReply",
            "Find",
            "FolderSync",
            "FolderCreate",
            "FolderDelete",
            "FolderUpdate",
            "ItemOperations",
            "GetAttachment",
            "GetItemEstimate",
            "MeetingResponse",
            "MoveItems",
            "Ping",
            "Provision",
            "ResolveRecipients",
            "Search",
            "Settings",
            "Sync",
            "ValidateCert",
            "Find"});
            this.cmboCommand.Location = new System.Drawing.Point(391, 179);
            this.cmboCommand.Margin = new System.Windows.Forms.Padding(4);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(128, 24);
            this.cmboCommand.TabIndex = 24;
            this.cmboCommand.SelectedIndexChanged += new System.EventHandler(this.cmboCommand_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(6, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Response:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(777, 101);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(172, 27);
            this.btnOptions.TabIndex = 44;
            this.btnOptions.Text = "Submit Options Request";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Checked = true;
            this.chkUseSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSSL.Location = new System.Drawing.Point(4, 196);
            this.chkUseSSL.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(89, 21);
            this.chkUseSSL.TabIndex = 13;
            this.chkUseSSL.Text = "Use SSL:";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // chkOverrideSslCertificateVerification
            // 
            this.chkOverrideSslCertificateVerification.AutoSize = true;
            this.chkOverrideSslCertificateVerification.Checked = true;
            this.chkOverrideSslCertificateVerification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpString(this.chkOverrideSslCertificateVerification, "Check to assume that all certificates are valid.");
            this.chkOverrideSslCertificateVerification.Location = new System.Drawing.Point(2, 221);
            this.chkOverrideSslCertificateVerification.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverrideSslCertificateVerification.Name = "chkOverrideSslCertificateVerification";
            this.helpProvider1.SetShowHelp(this.chkOverrideSslCertificateVerification, true);
            this.chkOverrideSslCertificateVerification.Size = new System.Drawing.Size(252, 21);
            this.chkOverrideSslCertificateVerification.TabIndex = 14;
            this.chkOverrideSslCertificateVerification.Text = "Override SSL certificate verification";
            this.chkOverrideSslCertificateVerification.UseVisualStyleBackColor = true;
            this.chkOverrideSslCertificateVerification.CheckedChanged += new System.EventHandler(this.chkOverrideSslCertificateVerification_CheckedChanged);
            // 
            // txtPolicyKey
            // 
            this.helpProvider1.SetHelpString(this.txtPolicyKey, "This is needed if there is a policy enforced.  Getting a  permanent policy key is" +
        " a two part process - see documentation on how to get it.");
            this.txtPolicyKey.Location = new System.Drawing.Point(391, 208);
            this.txtPolicyKey.Margin = new System.Windows.Forms.Padding(1);
            this.txtPolicyKey.Name = "txtPolicyKey";
            this.helpProvider1.SetShowHelp(this.txtPolicyKey, true);
            this.txtPolicyKey.Size = new System.Drawing.Size(128, 22);
            this.txtPolicyKey.TabIndex = 26;
            this.txtPolicyKey.TextChanged += new System.EventHandler(this.txtPolicyKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Policy Key:";
            // 
            // btnSaveExample
            // 
            this.btnSaveExample.Location = new System.Drawing.Point(122, 4);
            this.btnSaveExample.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveExample.Name = "btnSaveExample";
            this.btnSaveExample.Size = new System.Drawing.Size(112, 27);
            this.btnSaveExample.TabIndex = 1;
            this.btnSaveExample.Text = "Save Example";
            this.btnSaveExample.UseVisualStyleBackColor = true;
            this.btnSaveExample.Click += new System.EventHandler(this.btnSaveExample_Click);
            // 
            // btnLoadExample
            // 
            this.btnLoadExample.Location = new System.Drawing.Point(4, 4);
            this.btnLoadExample.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadExample.Name = "btnLoadExample";
            this.btnLoadExample.Size = new System.Drawing.Size(111, 27);
            this.btnLoadExample.TabIndex = 0;
            this.btnLoadExample.Text = "Load Example";
            this.btnLoadExample.UseVisualStyleBackColor = true;
            this.btnLoadExample.Click += new System.EventHandler(this.btnLoadExample_Click);
            // 
            // txtCertAuthFile
            // 
            this.helpProvider1.SetHelpString(this.txtCertAuthFile, "Domain of the user. If you entered an  SMTP address into the User field, then lea" +
        "ve this field blank.");
            this.txtCertAuthFile.Location = new System.Drawing.Point(105, 72);
            this.txtCertAuthFile.Margin = new System.Windows.Forms.Padding(0);
            this.txtCertAuthFile.Name = "txtCertAuthFile";
            this.helpProvider1.SetShowHelp(this.txtCertAuthFile, true);
            this.txtCertAuthFile.Size = new System.Drawing.Size(149, 22);
            this.txtCertAuthFile.TabIndex = 3;
            this.txtCertAuthFile.TextChanged += new System.EventHandler(this.txtCertAuthFile_TextChanged);
            // 
            // txtCertPassword
            // 
            this.helpProvider1.SetHelpString(this.txtCertPassword, "User password.");
            this.txtCertPassword.Location = new System.Drawing.Point(128, 97);
            this.txtCertPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtCertPassword.Name = "txtCertPassword";
            this.txtCertPassword.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtCertPassword, true);
            this.txtCertPassword.Size = new System.Drawing.Size(166, 22);
            this.txtCertPassword.TabIndex = 6;
            // 
            // txtUserAgent
            // 
            this.helpProvider1.SetHelpString(this.txtUserAgent, "This is needed if there is a policy enforced.  Getting a  permanent policy key is" +
        " a two part process - see documentation on how to get it.");
            this.txtUserAgent.Location = new System.Drawing.Point(391, 70);
            this.txtUserAgent.Margin = new System.Windows.Forms.Padding(1);
            this.txtUserAgent.Name = "txtUserAgent";
            this.helpProvider1.SetShowHelp(this.txtUserAgent, true);
            this.txtUserAgent.Size = new System.Drawing.Size(128, 22);
            this.txtUserAgent.TabIndex = 16;
            this.txtUserAgent.Text = "EASTester";
            // 
            // btnEncodingHelper
            // 
            this.btnEncodingHelper.Location = new System.Drawing.Point(777, 72);
            this.btnEncodingHelper.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncodingHelper.Name = "btnEncodingHelper";
            this.btnEncodingHelper.Size = new System.Drawing.Size(172, 27);
            this.btnEncodingHelper.TabIndex = 43;
            this.btnEncodingHelper.Text = "Encoding Helper";
            this.btnEncodingHelper.UseVisualStyleBackColor = true;
            this.btnEncodingHelper.Click += new System.EventHandler(this.btnEncodingHelper_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(4, 4);
            this.btnLoadSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(110, 27);
            this.btnLoadSettings.TabIndex = 0;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(122, 4);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(112, 27);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoadSettings);
            this.panel1.Controls.Add(this.btnSaveSettings);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoadExample);
            this.panel2.Controls.Add(this.btnSaveExample);
            this.panel2.Location = new System.Drawing.Point(255, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 36);
            this.panel2.TabIndex = 1;
            // 
            // lblStatusCause
            // 
            this.lblStatusCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusCause.AutoSize = true;
            this.lblStatusCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusCause.Location = new System.Drawing.Point(1, 461);
            this.lblStatusCause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusCause.Name = "lblStatusCause";
            this.lblStatusCause.Size = new System.Drawing.Size(244, 19);
            this.lblStatusCause.TabIndex = 35;
            this.lblStatusCause.Text = "Information on response status code:";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtInfo.Location = new System.Drawing.Point(1, 484);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.MaxLength = 0;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(953, 90);
            this.txtInfo.TabIndex = 48;
            // 
            // chkOverrideProxyCredentials
            // 
            this.chkOverrideProxyCredentials.Location = new System.Drawing.Point(552, 77);
            this.chkOverrideProxyCredentials.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverrideProxyCredentials.Name = "chkOverrideProxyCredentials";
            this.chkOverrideProxyCredentials.Size = new System.Drawing.Size(220, 22);
            this.chkOverrideProxyCredentials.TabIndex = 32;
            this.chkOverrideProxyCredentials.Text = "Override Proxy Server Credentials";
            this.chkOverrideProxyCredentials.UseVisualStyleBackColor = true;
            this.chkOverrideProxyCredentials.CheckedChanged += new System.EventHandler(this.chkOverrideProxyCredentials_CheckedChanged);
            // 
            // txtProxyServerDomain
            // 
            this.txtProxyServerDomain.Enabled = false;
            this.txtProxyServerDomain.Location = new System.Drawing.Point(655, 147);
            this.txtProxyServerDomain.Margin = new System.Windows.Forms.Padding(0);
            this.txtProxyServerDomain.Name = "txtProxyServerDomain";
            this.txtProxyServerDomain.Size = new System.Drawing.Size(112, 22);
            this.txtProxyServerDomain.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Domain:";
            // 
            // txtProxyServerPassword
            // 
            this.txtProxyServerPassword.Enabled = false;
            this.txtProxyServerPassword.Location = new System.Drawing.Point(655, 122);
            this.txtProxyServerPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtProxyServerPassword.Name = "txtProxyServerPassword";
            this.txtProxyServerPassword.PasswordChar = '•';
            this.txtProxyServerPassword.Size = new System.Drawing.Size(112, 22);
            this.txtProxyServerPassword.TabIndex = 36;
            // 
            // txtProxyServerUserName
            // 
            this.txtProxyServerUserName.Enabled = false;
            this.txtProxyServerUserName.Location = new System.Drawing.Point(655, 100);
            this.txtProxyServerUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtProxyServerUserName.Name = "txtProxyServerUserName";
            this.txtProxyServerUserName.Size = new System.Drawing.Size(112, 22);
            this.txtProxyServerUserName.TabIndex = 34;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(577, 100);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(42, 17);
            this.lblUserName.TabIndex = 33;
            this.lblUserName.Text = "User:";
            // 
            // txtProxyServerPort
            // 
            this.txtProxyServerPort.Location = new System.Drawing.Point(659, 52);
            this.txtProxyServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxyServerPort.Name = "txtProxyServerPort";
            this.txtProxyServerPort.Size = new System.Drawing.Size(108, 22);
            this.txtProxyServerPort.TabIndex = 31;
            this.txtProxyServerPort.Text = "8888";
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(547, 52);
            this.lblProxyPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(87, 21);
            this.lblProxyPort.TabIndex = 30;
            this.lblProxyPort.Text = "Proxy Port:";
            // 
            // txtProxyServerName
            // 
            this.txtProxyServerName.Location = new System.Drawing.Point(659, 27);
            this.txtProxyServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxyServerName.Name = "txtProxyServerName";
            this.txtProxyServerName.Size = new System.Drawing.Size(108, 22);
            this.txtProxyServerName.TabIndex = 29;
            this.txtProxyServerName.Text = "127.0.0.1";
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(547, 32);
            this.lblProxyServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(102, 21);
            this.lblProxyServer.TabIndex = 28;
            this.lblProxyServer.Text = "Proxy Server:";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(531, 7);
            this.chkUseProxy.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(144, 21);
            this.chkUseProxy.TabIndex = 27;
            this.chkUseProxy.Text = "Use Proxy Server:";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // btnStatusCodeHelper
            // 
            this.btnStatusCodeHelper.Location = new System.Drawing.Point(777, 40);
            this.btnStatusCodeHelper.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatusCodeHelper.Name = "btnStatusCodeHelper";
            this.btnStatusCodeHelper.Size = new System.Drawing.Size(172, 27);
            this.btnStatusCodeHelper.TabIndex = 42;
            this.btnStatusCodeHelper.Text = "Status Code Helper";
            this.btnStatusCodeHelper.UseVisualStyleBackColor = true;
            this.btnStatusCodeHelper.Click += new System.EventHandler(this.btnStatusCodeHelper_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 117);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(942, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IE  Rendered";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 4);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(934, 80);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResponse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(942, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text  Rendered";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtResponse.Location = new System.Drawing.Point(4, 4);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(934, 80);
            this.txtResponse.TabIndex = 16;
            this.txtResponse.WordWrap = false;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtHexResponse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(942, 88);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hex";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtHexResponse
            // 
            this.txtHexResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtHexResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHexResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexResponse.Location = new System.Drawing.Point(0, 0);
            this.txtHexResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtHexResponse.MaxLength = 0;
            this.txtHexResponse.Multiline = true;
            this.txtHexResponse.Name = "txtHexResponse";
            this.txtHexResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHexResponse.Size = new System.Drawing.Size(942, 88);
            this.txtHexResponse.TabIndex = 17;
            this.txtHexResponse.WordWrap = false;
            // 
            // btnViewInBrowser
            // 
            this.btnViewInBrowser.Location = new System.Drawing.Point(779, 132);
            this.btnViewInBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewInBrowser.Name = "btnViewInBrowser";
            this.btnViewInBrowser.Size = new System.Drawing.Size(172, 27);
            this.btnViewInBrowser.TabIndex = 45;
            this.btnViewInBrowser.Text = "View In Browser";
            this.btnViewInBrowser.UseVisualStyleBackColor = true;
            this.btnViewInBrowser.Click += new System.EventHandler(this.btnViewInBrowser_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(777, 7);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(172, 27);
            this.btnHelp.TabIndex = 41;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 247);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(950, 211);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 80;
            // 
            // chkUseCertAuth
            // 
            this.chkUseCertAuth.AutoSize = true;
            this.chkUseCertAuth.Location = new System.Drawing.Point(7, 70);
            this.chkUseCertAuth.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseCertAuth.Name = "chkUseCertAuth";
            this.chkUseCertAuth.Size = new System.Drawing.Size(93, 21);
            this.chkUseCertAuth.TabIndex = 2;
            this.chkUseCertAuth.Text = "Cert Auth:";
            this.chkUseCertAuth.UseVisualStyleBackColor = true;
            this.chkUseCertAuth.CheckedChanged += new System.EventHandler(this.chkUseCertAuth_CheckedChanged);
            // 
            // btnSelectCertFile
            // 
            this.btnSelectCertFile.Location = new System.Drawing.Point(257, 69);
            this.btnSelectCertFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectCertFile.Name = "btnSelectCertFile";
            this.btnSelectCertFile.Size = new System.Drawing.Size(37, 26);
            this.btnSelectCertFile.TabIndex = 4;
            this.btnSelectCertFile.Text = "...";
            this.btnSelectCertFile.UseVisualStyleBackColor = true;
            this.btnSelectCertFile.Click += new System.EventHandler(this.btnSelectCertFile_Click);
            // 
            // btnProvisionSettings
            // 
            this.btnProvisionSettings.Location = new System.Drawing.Point(531, 201);
            this.btnProvisionSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnProvisionSettings.Name = "btnProvisionSettings";
            this.btnProvisionSettings.Size = new System.Drawing.Size(236, 27);
            this.btnProvisionSettings.TabIndex = 39;
            this.btnProvisionSettings.Text = "Provision Settings";
            this.btnProvisionSettings.UseVisualStyleBackColor = true;
            this.btnProvisionSettings.Click += new System.EventHandler(this.btnSessionSettings_Click);
            // 
            // btnProvision
            // 
            this.btnProvision.Location = new System.Drawing.Point(777, 167);
            this.btnProvision.Margin = new System.Windows.Forms.Padding(4);
            this.btnProvision.Name = "btnProvision";
            this.btnProvision.Size = new System.Drawing.Size(172, 27);
            this.btnProvision.TabIndex = 46;
            this.btnProvision.Text = "Provision";
            this.btnProvision.UseVisualStyleBackColor = true;
            this.btnProvision.Click += new System.EventHandler(this.btnProvision_Click);
            // 
            // lblCertPassword
            // 
            this.lblCertPassword.AutoSize = true;
            this.lblCertPassword.Location = new System.Drawing.Point(25, 100);
            this.lblCertPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCertPassword.Name = "lblCertPassword";
            this.lblCertPassword.Size = new System.Drawing.Size(103, 17);
            this.lblCertPassword.TabIndex = 5;
            this.lblCertPassword.Text = "Cert Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Agent:";
            // 
            // chkEncodePostLine
            // 
            this.chkEncodePostLine.AutoSize = true;
            this.chkEncodePostLine.Checked = true;
            this.chkEncodePostLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncodePostLine.Location = new System.Drawing.Point(531, 174);
            this.chkEncodePostLine.Margin = new System.Windows.Forms.Padding(4);
            this.chkEncodePostLine.Name = "chkEncodePostLine";
            this.chkEncodePostLine.Size = new System.Drawing.Size(155, 21);
            this.chkEncodePostLine.TabIndex = 81;
            this.chkEncodePostLine.Text = "Encode POST Line:";
            this.chkEncodePostLine.UseVisualStyleBackColor = true;
            this.chkEncodePostLine.CheckedChanged += new System.EventHandler(this.chkEncodePostLine_CheckedChanged);
            // 
            // frmRawEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(954, 577);
            this.Controls.Add(this.chkEncodePostLine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserAgent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCertPassword);
            this.Controls.Add(this.lblCertPassword);
            this.Controls.Add(this.btnProvision);
            this.Controls.Add(this.btnProvisionSettings);
            this.Controls.Add(this.btnSelectCertFile);
            this.Controls.Add(this.txtCertAuthFile);
            this.Controls.Add(this.chkUseCertAuth);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnViewInBrowser);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblStatusCause);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStatusCodeHelper);
            this.Controls.Add(this.chkUseProxy);
            this.Controls.Add(this.chkOverrideProxyCredentials);
            this.Controls.Add(this.txtProxyServerDomain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProxyServerPassword);
            this.Controls.Add(this.txtProxyServerUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtProxyServerPort);
            this.Controls.Add(this.lblProxyPort);
            this.Controls.Add(this.txtProxyServerName);
            this.Controls.Add(this.lblProxyServer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEncodingHelper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPolicyKey);
            this.Controls.Add(this.chkOverrideSslCertificateVerification);
            this.Controls.Add(this.chkUseSSL);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboCommand);
            this.Controls.Add(this.txtDeviceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmboVersion);
            this.Controls.Add(this.ServerUrl);
            this.Controls.Add(this.txtServerUrl);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRawEAS";
            this.helpProvider1.SetShowHelp(this, false);
            this.Text = "EAS Conversations";
            this.Load += new System.EventHandler(this.frmRawEAS_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDomain;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label ServerUrl;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.ComboBox cmboVersion;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDeviceId;
        public System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmboCommand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.CheckBox chkOverrideSslCertificateVerification;
        public System.Windows.Forms.TextBox txtPolicyKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveExample;
        private System.Windows.Forms.Button btnLoadExample;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnEncodingHelper;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatusCause;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.CheckBox chkOverrideProxyCredentials;
        private System.Windows.Forms.TextBox txtProxyServerDomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProxyServerPassword;
        private System.Windows.Forms.TextBox txtProxyServerUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtProxyServerPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox txtProxyServerName;
        private System.Windows.Forms.Label lblProxyServer;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.Button btnStatusCodeHelper;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtHexResponse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnViewInBrowser;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkUseCertAuth;
        public System.Windows.Forms.TextBox txtCertAuthFile;
        private System.Windows.Forms.Button btnSelectCertFile;
        private System.Windows.Forms.Button btnProvisionSettings;
        private System.Windows.Forms.Button btnProvision;
        private System.Windows.Forms.Label lblCertPassword;
        public System.Windows.Forms.TextBox txtCertPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.CheckBox chkEncodePostLine;
    }
}

