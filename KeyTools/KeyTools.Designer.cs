
using System;

namespace KeyCheckGui
{
    partial class KeyTools
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
        protected void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusIcon = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.keyResultGroup = new System.Windows.Forms.GroupBox();
            this.keyField = new System.Windows.Forms.TextBox();
            this.updateDevicesButton = new System.Windows.Forms.Button();
            this.keyGroup = new System.Windows.Forms.GroupBox();
            this.clearDevicesButton = new System.Windows.Forms.Button();
            this.serversList = new System.Windows.Forms.ComboBox();
            this.authIcon = new System.Windows.Forms.Label();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.serverGroup = new System.Windows.Forms.GroupBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.chekKeyGroup = new System.Windows.Forms.GroupBox();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.tabKeyDevices = new System.Windows.Forms.TabPage();
            this.elementInfo = new System.Windows.Forms.GroupBox();
            this.processorGroup = new System.Windows.Forms.GroupBox();
            this.processorInfo = new System.Windows.Forms.Label();
            this.processotNameLabel = new System.Windows.Forms.Label();
            this.ramGroup = new System.Windows.Forms.GroupBox();
            this.ramInfo = new System.Windows.Forms.Label();
            this.ramSizeLabel = new System.Windows.Forms.Label();
            this.graphicsGroup = new System.Windows.Forms.GroupBox();
            this.graphicsSizeInfo = new System.Windows.Forms.Label();
            this.graphicsNameLabel = new System.Windows.Forms.Label();
            this.graphicsNameInfo = new System.Windows.Forms.Label();
            this.graphichsVersionLabel = new System.Windows.Forms.Label();
            this.graphicsVersionInfo = new System.Windows.Forms.Label();
            this.graphicsSizeLabel = new System.Windows.Forms.Label();
            this.deviceGroup = new System.Windows.Forms.GroupBox();
            this.hardwareIdLabel = new System.Windows.Forms.Label();
            this.osInfo = new System.Windows.Forms.Label();
            this.deviceTypeInfo = new System.Windows.Forms.Label();
            this.deviceNameInfo = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.modelInfo = new System.Windows.Forms.Label();
            this.deviceTypeLabel = new System.Windows.Forms.Label();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.deviceIdInfo = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.devicesGridView = new System.Windows.Forms.DataGridView();
            this.tabDataTools = new System.Windows.Forms.TabPage();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.imagesCountLabel = new System.Windows.Forms.Label();
            this.serverTestsLabel = new System.Windows.Forms.Label();
            this.serverFactsLabel = new System.Windows.Forms.Label();
            this.dataForCheckGroup = new System.Windows.Forms.GroupBox();
            this.loadFromJsonButton = new System.Windows.Forms.Button();
            this.checkDataTypeBox = new System.Windows.Forms.ComboBox();
            this.checkDataButton = new System.Windows.Forms.Button();
            this.checkableDataList = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.lessonsPage = new System.Windows.Forms.TabPage();
            this.getMylessonsButton = new System.Windows.Forms.Button();
            this.avbalibleLessonsGroup = new System.Windows.Forms.GroupBox();
            this.keyResultGroup.SuspendLayout();
            this.keyGroup.SuspendLayout();
            this.serverGroup.SuspendLayout();
            this.chekKeyGroup.SuspendLayout();
            this.tabKeyDevices.SuspendLayout();
            this.elementInfo.SuspendLayout();
            this.processorGroup.SuspendLayout();
            this.ramGroup.SuspendLayout();
            this.graphicsGroup.SuspendLayout();
            this.deviceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).BeginInit();
            this.tabDataTools.SuspendLayout();
            this.dataForCheckGroup.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.lessonsPage.SuspendLayout();
            this.avbalibleLessonsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 28);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 15);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // statusIcon
            // 
            this.statusIcon.AutoSize = true;
            this.statusIcon.Location = new System.Drawing.Point(50, 28);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(57, 15);
            this.statusIcon.TabIndex = 1;
            this.statusIcon.Text = "unknown";
            this.statusIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(94, 28);
            this.errorText.MaximumSize = new System.Drawing.Size(0, 30);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(38, 15);
            this.errorText.TabIndex = 3;
            this.errorText.Text = "label2";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.errorText.Visible = false;
            // 
            // keyResultGroup
            // 
            this.keyResultGroup.Controls.Add(this.errorText);
            this.keyResultGroup.Controls.Add(this.statusIcon);
            this.keyResultGroup.Controls.Add(this.statusLabel);
            this.keyResultGroup.Location = new System.Drawing.Point(443, 76);
            this.keyResultGroup.Name = "keyResultGroup";
            this.keyResultGroup.Size = new System.Drawing.Size(511, 59);
            this.keyResultGroup.TabIndex = 33;
            this.keyResultGroup.TabStop = false;
            this.keyResultGroup.Text = "Check {KEY} for {PRODUCT}";
            // 
            // keyField
            // 
            this.keyField.Location = new System.Drawing.Point(6, 21);
            this.keyField.Name = "keyField";
            this.keyField.PlaceholderText = "Enter key for check";
            this.keyField.Size = new System.Drawing.Size(213, 23);
            this.keyField.TabIndex = 0;
            this.keyField.TextChanged += new System.EventHandler(this.OnKeyChanged);
            // 
            // updateDevicesButton
            // 
            this.updateDevicesButton.Enabled = false;
            this.updateDevicesButton.Location = new System.Drawing.Point(225, 21);
            this.updateDevicesButton.Name = "updateDevicesButton";
            this.updateDevicesButton.Size = new System.Drawing.Size(214, 24);
            this.updateDevicesButton.TabIndex = 1;
            this.updateDevicesButton.Text = "Update devices";
            this.updateDevicesButton.UseVisualStyleBackColor = true;
            this.updateDevicesButton.Click += new System.EventHandler(this.OnUpdateDevicesClick);
            // 
            // keyGroup
            // 
            this.keyGroup.Controls.Add(this.clearDevicesButton);
            this.keyGroup.Controls.Add(this.updateDevicesButton);
            this.keyGroup.Controls.Add(this.keyField);
            this.keyGroup.Location = new System.Drawing.Point(509, 13);
            this.keyGroup.Name = "keyGroup";
            this.keyGroup.Size = new System.Drawing.Size(445, 57);
            this.keyGroup.TabIndex = 31;
            this.keyGroup.TabStop = false;
            this.keyGroup.Text = "Enter the key to get his devices";
            // 
            // clearDevicesButton
            // 
            this.clearDevicesButton.Location = new System.Drawing.Point(225, 22);
            this.clearDevicesButton.Name = "clearDevicesButton";
            this.clearDevicesButton.Size = new System.Drawing.Size(214, 24);
            this.clearDevicesButton.TabIndex = 2;
            this.clearDevicesButton.Text = "Clear key data";
            this.clearDevicesButton.UseVisualStyleBackColor = true;
            this.clearDevicesButton.Visible = false;
            this.clearDevicesButton.Click += new System.EventHandler(this.OnClearDevicesButton_Click);
            // 
            // serversList
            // 
            this.serversList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serversList.FormattingEnabled = true;
            this.serversList.Location = new System.Drawing.Point(6, 22);
            this.serversList.Name = "serversList";
            this.serversList.Size = new System.Drawing.Size(218, 23);
            this.serversList.TabIndex = 21;
            this.serversList.SelectedIndexChanged += new System.EventHandler(this.OnChangeServer);
            // 
            // authIcon
            // 
            this.authIcon.AutoSize = true;
            this.authIcon.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authIcon.ForeColor = System.Drawing.Color.Crimson;
            this.authIcon.Location = new System.Drawing.Point(230, 22);
            this.authIcon.Name = "authIcon";
            this.authIcon.Size = new System.Drawing.Size(23, 24);
            this.authIcon.TabIndex = 22;
            this.authIcon.Text = "X";
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(260, 21);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(213, 24);
            this.authorizationButton.TabIndex = 23;
            this.authorizationButton.Text = "Authorization";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.OnAuthorizationClick);
            // 
            // serverGroup
            // 
            this.serverGroup.Controls.Add(this.authorizationButton);
            this.serverGroup.Controls.Add(this.authIcon);
            this.serverGroup.Controls.Add(this.serversList);
            this.serverGroup.Location = new System.Drawing.Point(13, 13);
            this.serverGroup.Name = "serverGroup";
            this.serverGroup.Size = new System.Drawing.Size(490, 57);
            this.serverGroup.TabIndex = 30;
            this.serverGroup.TabStop = false;
            this.serverGroup.Text = "Select server and authorize";
            // 
            // checkButton
            // 
            this.checkButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(253, 21);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(153, 23);
            this.checkButton.TabIndex = 26;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.OnCheckKey);
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productLabel.Location = new System.Drawing.Point(6, 22);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(80, 23);
            this.productLabel.TabIndex = 6;
            this.productLabel.Text = "Product :";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productLabel.UseMnemonic = false;
            // 
            // chekKeyGroup
            // 
            this.chekKeyGroup.Controls.Add(this.productLabel);
            this.chekKeyGroup.Controls.Add(this.productBox);
            this.chekKeyGroup.Controls.Add(this.checkButton);
            this.chekKeyGroup.Location = new System.Drawing.Point(13, 76);
            this.chekKeyGroup.Name = "chekKeyGroup";
            this.chekKeyGroup.Size = new System.Drawing.Size(424, 59);
            this.chekKeyGroup.TabIndex = 29;
            this.chekKeyGroup.TabStop = false;
            this.chekKeyGroup.Text = "Check key for product";
            // 
            // productBox
            // 
            this.productBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(92, 21);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(142, 23);
            this.productBox.TabIndex = 27;
            // 
            // tabKeyDevices
            // 
            this.tabKeyDevices.BackColor = System.Drawing.SystemColors.Control;
            this.tabKeyDevices.Controls.Add(this.elementInfo);
            this.tabKeyDevices.Controls.Add(this.devicesGridView);
            this.tabKeyDevices.Location = new System.Drawing.Point(4, 24);
            this.tabKeyDevices.Name = "tabKeyDevices";
            this.tabKeyDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeyDevices.Size = new System.Drawing.Size(937, 468);
            this.tabKeyDevices.TabIndex = 2;
            this.tabKeyDevices.Text = "Devices";
            // 
            // elementInfo
            // 
            this.elementInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.elementInfo.Controls.Add(this.processorGroup);
            this.elementInfo.Controls.Add(this.ramGroup);
            this.elementInfo.Controls.Add(this.graphicsGroup);
            this.elementInfo.Controls.Add(this.deviceGroup);
            this.elementInfo.Location = new System.Drawing.Point(447, 7);
            this.elementInfo.Name = "elementInfo";
            this.elementInfo.Size = new System.Drawing.Size(422, 455);
            this.elementInfo.TabIndex = 29;
            this.elementInfo.TabStop = false;
            this.elementInfo.Text = "Information";
            // 
            // processorGroup
            // 
            this.processorGroup.Controls.Add(this.processorInfo);
            this.processorGroup.Controls.Add(this.processotNameLabel);
            this.processorGroup.Location = new System.Drawing.Point(6, 351);
            this.processorGroup.Name = "processorGroup";
            this.processorGroup.Size = new System.Drawing.Size(409, 55);
            this.processorGroup.TabIndex = 19;
            this.processorGroup.TabStop = false;
            this.processorGroup.Text = "Processor";
            // 
            // processorInfo
            // 
            this.processorInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.processorInfo.AutoSize = true;
            this.processorInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processorInfo.Location = new System.Drawing.Point(86, 23);
            this.processorInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.processorInfo.Name = "processorInfo";
            this.processorInfo.Size = new System.Drawing.Size(0, 15);
            this.processorInfo.TabIndex = 22;
            this.processorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processotNameLabel
            // 
            this.processotNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.processotNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processotNameLabel.Location = new System.Drawing.Point(6, 19);
            this.processotNameLabel.Name = "processotNameLabel";
            this.processotNameLabel.Size = new System.Drawing.Size(74, 23);
            this.processotNameLabel.TabIndex = 21;
            this.processotNameLabel.Text = "Name :";
            this.processotNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.processotNameLabel.UseMnemonic = false;
            // 
            // ramGroup
            // 
            this.ramGroup.Controls.Add(this.ramInfo);
            this.ramGroup.Controls.Add(this.ramSizeLabel);
            this.ramGroup.Location = new System.Drawing.Point(6, 290);
            this.ramGroup.Name = "ramGroup";
            this.ramGroup.Size = new System.Drawing.Size(409, 55);
            this.ramGroup.TabIndex = 23;
            this.ramGroup.TabStop = false;
            this.ramGroup.Text = "RAM";
            // 
            // ramInfo
            // 
            this.ramInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ramInfo.AutoSize = true;
            this.ramInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramInfo.Location = new System.Drawing.Point(86, 23);
            this.ramInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.Size = new System.Drawing.Size(0, 15);
            this.ramInfo.TabIndex = 22;
            this.ramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ramSizeLabel
            // 
            this.ramSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ramSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramSizeLabel.Location = new System.Drawing.Point(6, 19);
            this.ramSizeLabel.Name = "ramSizeLabel";
            this.ramSizeLabel.Size = new System.Drawing.Size(74, 23);
            this.ramSizeLabel.TabIndex = 21;
            this.ramSizeLabel.Text = "Size :";
            this.ramSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ramSizeLabel.UseMnemonic = false;
            // 
            // graphicsGroup
            // 
            this.graphicsGroup.Controls.Add(this.graphicsSizeInfo);
            this.graphicsGroup.Controls.Add(this.graphicsNameLabel);
            this.graphicsGroup.Controls.Add(this.graphicsNameInfo);
            this.graphicsGroup.Controls.Add(this.graphichsVersionLabel);
            this.graphicsGroup.Controls.Add(this.graphicsVersionInfo);
            this.graphicsGroup.Controls.Add(this.graphicsSizeLabel);
            this.graphicsGroup.Location = new System.Drawing.Point(6, 180);
            this.graphicsGroup.Name = "graphicsGroup";
            this.graphicsGroup.Size = new System.Drawing.Size(409, 104);
            this.graphicsGroup.TabIndex = 5;
            this.graphicsGroup.TabStop = false;
            this.graphicsGroup.Text = "Graphics";
            // 
            // graphicsSizeInfo
            // 
            this.graphicsSizeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsSizeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsSizeInfo.Location = new System.Drawing.Point(86, 46);
            this.graphicsSizeInfo.Name = "graphicsSizeInfo";
            this.graphicsSizeInfo.Size = new System.Drawing.Size(252, 23);
            this.graphicsSizeInfo.TabIndex = 18;
            this.graphicsSizeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphicsNameLabel
            // 
            this.graphicsNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsNameLabel.Location = new System.Drawing.Point(6, 23);
            this.graphicsNameLabel.Name = "graphicsNameLabel";
            this.graphicsNameLabel.Size = new System.Drawing.Size(74, 23);
            this.graphicsNameLabel.TabIndex = 13;
            this.graphicsNameLabel.Text = "Name :";
            this.graphicsNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphicsNameLabel.UseMnemonic = false;
            // 
            // graphicsNameInfo
            // 
            this.graphicsNameInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsNameInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsNameInfo.Location = new System.Drawing.Point(86, 23);
            this.graphicsNameInfo.Name = "graphicsNameInfo";
            this.graphicsNameInfo.Size = new System.Drawing.Size(252, 23);
            this.graphicsNameInfo.TabIndex = 14;
            this.graphicsNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphichsVersionLabel
            // 
            this.graphichsVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphichsVersionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphichsVersionLabel.Location = new System.Drawing.Point(6, 69);
            this.graphichsVersionLabel.Name = "graphichsVersionLabel";
            this.graphichsVersionLabel.Size = new System.Drawing.Size(74, 23);
            this.graphichsVersionLabel.TabIndex = 15;
            this.graphichsVersionLabel.Text = "Version :";
            this.graphichsVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphichsVersionLabel.UseMnemonic = false;
            // 
            // graphicsVersionInfo
            // 
            this.graphicsVersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsVersionInfo.AutoSize = true;
            this.graphicsVersionInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsVersionInfo.Location = new System.Drawing.Point(86, 73);
            this.graphicsVersionInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.graphicsVersionInfo.Name = "graphicsVersionInfo";
            this.graphicsVersionInfo.Size = new System.Drawing.Size(0, 15);
            this.graphicsVersionInfo.TabIndex = 16;
            this.graphicsVersionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphicsSizeLabel
            // 
            this.graphicsSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.graphicsSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.graphicsSizeLabel.Location = new System.Drawing.Point(6, 46);
            this.graphicsSizeLabel.Name = "graphicsSizeLabel";
            this.graphicsSizeLabel.Size = new System.Drawing.Size(74, 23);
            this.graphicsSizeLabel.TabIndex = 17;
            this.graphicsSizeLabel.Text = "Size :";
            this.graphicsSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphicsSizeLabel.UseMnemonic = false;
            // 
            // deviceGroup
            // 
            this.deviceGroup.Controls.Add(this.hardwareIdLabel);
            this.deviceGroup.Controls.Add(this.osInfo);
            this.deviceGroup.Controls.Add(this.deviceTypeInfo);
            this.deviceGroup.Controls.Add(this.deviceNameInfo);
            this.deviceGroup.Controls.Add(this.osLabel);
            this.deviceGroup.Controls.Add(this.modelInfo);
            this.deviceGroup.Controls.Add(this.deviceTypeLabel);
            this.deviceGroup.Controls.Add(this.deviceNameLabel);
            this.deviceGroup.Controls.Add(this.deviceIdInfo);
            this.deviceGroup.Controls.Add(this.modelLabel);
            this.deviceGroup.Location = new System.Drawing.Point(6, 22);
            this.deviceGroup.Name = "deviceGroup";
            this.deviceGroup.Size = new System.Drawing.Size(409, 152);
            this.deviceGroup.TabIndex = 0;
            this.deviceGroup.TabStop = false;
            this.deviceGroup.Text = "Device";
            // 
            // hardwareIdLabel
            // 
            this.hardwareIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hardwareIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hardwareIdLabel.Location = new System.Drawing.Point(6, 19);
            this.hardwareIdLabel.Name = "hardwareIdLabel";
            this.hardwareIdLabel.Size = new System.Drawing.Size(80, 23);
            this.hardwareIdLabel.TabIndex = 5;
            this.hardwareIdLabel.Text = "Hardware id :";
            this.hardwareIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hardwareIdLabel.UseMnemonic = false;
            // 
            // osInfo
            // 
            this.osInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osInfo.AutoSize = true;
            this.osInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osInfo.Location = new System.Drawing.Point(92, 69);
            this.osInfo.MaximumSize = new System.Drawing.Size(252, 15);
            this.osInfo.Name = "osInfo";
            this.osInfo.Size = new System.Drawing.Size(0, 15);
            this.osInfo.TabIndex = 20;
            this.osInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceTypeInfo
            // 
            this.deviceTypeInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceTypeInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceTypeInfo.Location = new System.Drawing.Point(92, 42);
            this.deviceTypeInfo.Name = "deviceTypeInfo";
            this.deviceTypeInfo.Size = new System.Drawing.Size(158, 23);
            this.deviceTypeInfo.TabIndex = 12;
            this.deviceTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceNameInfo
            // 
            this.deviceNameInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceNameInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceNameInfo.Location = new System.Drawing.Point(92, 88);
            this.deviceNameInfo.Name = "deviceNameInfo";
            this.deviceNameInfo.Size = new System.Drawing.Size(252, 23);
            this.deviceNameInfo.TabIndex = 10;
            this.deviceNameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // osLabel
            // 
            this.osLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.osLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osLabel.Location = new System.Drawing.Point(6, 65);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(80, 23);
            this.osLabel.TabIndex = 19;
            this.osLabel.Text = "OS :";
            this.osLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.osLabel.UseMnemonic = false;
            // 
            // modelInfo
            // 
            this.modelInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modelInfo.AutoSize = true;
            this.modelInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelInfo.Location = new System.Drawing.Point(92, 115);
            this.modelInfo.MaximumSize = new System.Drawing.Size(252, 30);
            this.modelInfo.Name = "modelInfo";
            this.modelInfo.Size = new System.Drawing.Size(0, 15);
            this.modelInfo.TabIndex = 8;
            this.modelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deviceTypeLabel
            // 
            this.deviceTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceTypeLabel.Location = new System.Drawing.Point(6, 42);
            this.deviceTypeLabel.Name = "deviceTypeLabel";
            this.deviceTypeLabel.Size = new System.Drawing.Size(80, 23);
            this.deviceTypeLabel.TabIndex = 11;
            this.deviceTypeLabel.Text = "Type :";
            this.deviceTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deviceTypeLabel.UseMnemonic = false;
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceNameLabel.Location = new System.Drawing.Point(6, 88);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(80, 23);
            this.deviceNameLabel.TabIndex = 9;
            this.deviceNameLabel.Text = "Name :";
            this.deviceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deviceNameLabel.UseMnemonic = false;
            // 
            // deviceIdInfo
            // 
            this.deviceIdInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deviceIdInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deviceIdInfo.Location = new System.Drawing.Point(92, 19);
            this.deviceIdInfo.Name = "deviceIdInfo";
            this.deviceIdInfo.Size = new System.Drawing.Size(252, 23);
            this.deviceIdInfo.TabIndex = 6;
            this.deviceIdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelLabel
            // 
            this.modelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modelLabel.Location = new System.Drawing.Point(6, 111);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(80, 23);
            this.modelLabel.TabIndex = 7;
            this.modelLabel.Text = "Model :";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modelLabel.UseMnemonic = false;
            // 
            // devicesGridView
            // 
            this.devicesGridView.AllowUserToAddRows = false;
            this.devicesGridView.AllowUserToDeleteRows = false;
            this.devicesGridView.AllowUserToResizeColumns = false;
            this.devicesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.devicesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.devicesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.devicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devicesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.devicesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.devicesGridView.Location = new System.Drawing.Point(7, 7);
            this.devicesGridView.MaximumSize = new System.Drawing.Size(500, 455);
            this.devicesGridView.MinimumSize = new System.Drawing.Size(364, 47);
            this.devicesGridView.MultiSelect = false;
            this.devicesGridView.Name = "devicesGridView";
            this.devicesGridView.RowHeadersVisible = false;
            this.devicesGridView.RowTemplate.Height = 25;
            this.devicesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devicesGridView.Size = new System.Drawing.Size(434, 455);
            this.devicesGridView.TabIndex = 0;
            // 
            // tabDataTools
            // 
            this.tabDataTools.BackColor = System.Drawing.SystemColors.Control;
            this.tabDataTools.Controls.Add(this.loadDataButton);
            this.tabDataTools.Controls.Add(this.imagesCountLabel);
            this.tabDataTools.Controls.Add(this.serverTestsLabel);
            this.tabDataTools.Controls.Add(this.serverFactsLabel);
            this.tabDataTools.Controls.Add(this.dataForCheckGroup);
            this.tabDataTools.Location = new System.Drawing.Point(4, 24);
            this.tabDataTools.Name = "tabDataTools";
            this.tabDataTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataTools.Size = new System.Drawing.Size(937, 468);
            this.tabDataTools.TabIndex = 1;
            this.tabDataTools.Text = "Data tools [0]";
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(6, 6);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(181, 42);
            this.loadDataButton.TabIndex = 11;
            this.loadDataButton.Text = "Load data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            // 
            // imagesCountLabel
            // 
            this.imagesCountLabel.AutoSize = true;
            this.imagesCountLabel.Location = new System.Drawing.Point(193, 33);
            this.imagesCountLabel.Name = "imagesCountLabel";
            this.imagesCountLabel.Size = new System.Drawing.Size(114, 15);
            this.imagesCountLabel.TabIndex = 6;
            this.imagesCountLabel.Text = "Images count: None";
            // 
            // serverTestsLabel
            // 
            this.serverTestsLabel.AutoSize = true;
            this.serverTestsLabel.Location = new System.Drawing.Point(193, 20);
            this.serverTestsLabel.Name = "serverTestsLabel";
            this.serverTestsLabel.Size = new System.Drawing.Size(101, 15);
            this.serverTestsLabel.TabIndex = 4;
            this.serverTestsLabel.Text = "Tests count: None";
            // 
            // serverFactsLabel
            // 
            this.serverFactsLabel.AutoSize = true;
            this.serverFactsLabel.Location = new System.Drawing.Point(193, 3);
            this.serverFactsLabel.Name = "serverFactsLabel";
            this.serverFactsLabel.Size = new System.Drawing.Size(103, 15);
            this.serverFactsLabel.TabIndex = 5;
            this.serverFactsLabel.Text = "Facts count: None";
            // 
            // dataForCheckGroup
            // 
            this.dataForCheckGroup.Controls.Add(this.loadFromJsonButton);
            this.dataForCheckGroup.Controls.Add(this.checkDataTypeBox);
            this.dataForCheckGroup.Controls.Add(this.checkDataButton);
            this.dataForCheckGroup.Controls.Add(this.checkableDataList);
            this.dataForCheckGroup.Location = new System.Drawing.Point(6, 51);
            this.dataForCheckGroup.Name = "dataForCheckGroup";
            this.dataForCheckGroup.Size = new System.Drawing.Size(278, 411);
            this.dataForCheckGroup.TabIndex = 10;
            this.dataForCheckGroup.TabStop = false;
            this.dataForCheckGroup.Text = "Select type and set checkable data";
            // 
            // loadFromJsonButton
            // 
            this.loadFromJsonButton.Location = new System.Drawing.Point(7, 327);
            this.loadFromJsonButton.Name = "loadFromJsonButton";
            this.loadFromJsonButton.Size = new System.Drawing.Size(266, 36);
            this.loadFromJsonButton.TabIndex = 3;
            this.loadFromJsonButton.Text = "Load from json";
            this.loadFromJsonButton.UseVisualStyleBackColor = true;
            // 
            // checkDataTypeBox
            // 
            this.checkDataTypeBox.FormattingEnabled = true;
            this.checkDataTypeBox.Location = new System.Drawing.Point(7, 23);
            this.checkDataTypeBox.Name = "checkDataTypeBox";
            this.checkDataTypeBox.Size = new System.Drawing.Size(265, 23);
            this.checkDataTypeBox.TabIndex = 2;
            this.checkDataTypeBox.Text = "Image id";
            // 
            // checkDataButton
            // 
            this.checkDataButton.Location = new System.Drawing.Point(6, 369);
            this.checkDataButton.Name = "checkDataButton";
            this.checkDataButton.Size = new System.Drawing.Size(266, 36);
            this.checkDataButton.TabIndex = 0;
            this.checkDataButton.Text = "Check id\'s usage in data";
            this.checkDataButton.UseVisualStyleBackColor = true;
            // 
            // checkableDataList
            // 
            this.checkableDataList.Location = new System.Drawing.Point(6, 52);
            this.checkableDataList.Multiline = true;
            this.checkableDataList.Name = "checkableDataList";
            this.checkableDataList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.checkableDataList.Size = new System.Drawing.Size(266, 269);
            this.checkableDataList.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKeyDevices);
            this.tabControl.Controls.Add(this.lessonsPage);
            this.tabControl.Controls.Add(this.tabDataTools);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(13, 141);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(945, 496);
            this.tabControl.TabIndex = 35;
            // 
            // lessonsPage
            // 
            this.lessonsPage.BackColor = System.Drawing.SystemColors.Control;
            this.lessonsPage.Controls.Add(this.avbalibleLessonsGroup);
            this.lessonsPage.Location = new System.Drawing.Point(4, 24);
            this.lessonsPage.Name = "lessonsPage";
            this.lessonsPage.Size = new System.Drawing.Size(937, 468);
            this.lessonsPage.TabIndex = 3;
            this.lessonsPage.Text = "Lessons";
            // 
            // getMylessonsButton
            // 
            this.getMylessonsButton.Location = new System.Drawing.Point(6, 22);
            this.getMylessonsButton.Name = "getMylessonsButton";
            this.getMylessonsButton.Size = new System.Drawing.Size(100, 23);
            this.getMylessonsButton.TabIndex = 0;
            this.getMylessonsButton.Text = "Get my lessons";
            this.getMylessonsButton.UseVisualStyleBackColor = true;
            this.getMylessonsButton.Click += OnGetMyLessonsClick;
            // 
            // groupBox1
            // 
            this.avbalibleLessonsGroup.Controls.Add(this.getMylessonsButton);
            this.avbalibleLessonsGroup.Location = new System.Drawing.Point(3, 3);
            this.avbalibleLessonsGroup.Name = "avbalibleLessonsGroup";
            this.avbalibleLessonsGroup.Size = new System.Drawing.Size(246, 462);
            this.avbalibleLessonsGroup.TabIndex = 1;
            this.avbalibleLessonsGroup.TabStop = false;
            this.avbalibleLessonsGroup.Text = "AvalibleLessons";
            // 
            // KeyTools
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 651);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.keyResultGroup);
            this.Controls.Add(this.keyGroup);
            this.Controls.Add(this.serverGroup);
            this.Controls.Add(this.chekKeyGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KeyTools";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyTools";
            this.keyResultGroup.ResumeLayout(false);
            this.keyResultGroup.PerformLayout();
            this.keyGroup.ResumeLayout(false);
            this.keyGroup.PerformLayout();
            this.serverGroup.ResumeLayout(false);
            this.serverGroup.PerformLayout();
            this.chekKeyGroup.ResumeLayout(false);
            this.tabKeyDevices.ResumeLayout(false);
            this.elementInfo.ResumeLayout(false);
            this.processorGroup.ResumeLayout(false);
            this.processorGroup.PerformLayout();
            this.ramGroup.ResumeLayout(false);
            this.ramGroup.PerformLayout();
            this.graphicsGroup.ResumeLayout(false);
            this.graphicsGroup.PerformLayout();
            this.deviceGroup.ResumeLayout(false);
            this.deviceGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).EndInit();
            this.tabDataTools.ResumeLayout(false);
            this.tabDataTools.PerformLayout();
            this.dataForCheckGroup.ResumeLayout(false);
            this.dataForCheckGroup.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.lessonsPage.ResumeLayout(false);
            this.avbalibleLessonsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusIcon;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.GroupBox keyResultGroup;
        private System.Windows.Forms.TextBox keyField;
        private System.Windows.Forms.Button updateDevicesButton;
        private System.Windows.Forms.GroupBox keyGroup;
        private System.Windows.Forms.ComboBox serversList;
        private System.Windows.Forms.Label authIcon;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.GroupBox serverGroup;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.GroupBox chekKeyGroup;
        internal System.Windows.Forms.ComboBox productBox;
        internal System.Windows.Forms.TabPage tabKeyDevices;
        internal System.Windows.Forms.GroupBox elementInfo;
        private System.Windows.Forms.GroupBox processorGroup;
        internal System.Windows.Forms.Label processorInfo;
        private System.Windows.Forms.Label processotNameLabel;
        private System.Windows.Forms.GroupBox ramGroup;
        internal System.Windows.Forms.Label ramInfo;
        private System.Windows.Forms.Label ramSizeLabel;
        private System.Windows.Forms.GroupBox graphicsGroup;
        internal System.Windows.Forms.Label graphicsSizeInfo;
        private System.Windows.Forms.Label graphicsNameLabel;
        internal System.Windows.Forms.Label graphicsNameInfo;
        private System.Windows.Forms.Label graphichsVersionLabel;
        internal System.Windows.Forms.Label graphicsVersionInfo;
        private System.Windows.Forms.Label graphicsSizeLabel;
        private System.Windows.Forms.GroupBox deviceGroup;
        private System.Windows.Forms.Label hardwareIdLabel;
        internal System.Windows.Forms.Label osInfo;
        internal System.Windows.Forms.Label deviceTypeInfo;
        internal System.Windows.Forms.Label deviceNameInfo;
        private System.Windows.Forms.Label osLabel;
        internal System.Windows.Forms.Label modelInfo;
        private System.Windows.Forms.Label deviceTypeLabel;
        private System.Windows.Forms.Label deviceNameLabel;
        internal System.Windows.Forms.Label deviceIdInfo;
        private System.Windows.Forms.Label modelLabel;
        internal System.Windows.Forms.DataGridView devicesGridView;
        internal System.Windows.Forms.TabPage tabDataTools;
        internal System.Windows.Forms.Button checkDataButton;
        internal System.Windows.Forms.Label imagesCountLabel;
        internal System.Windows.Forms.Label serverTestsLabel;
        internal System.Windows.Forms.Label serverFactsLabel;
        private System.Windows.Forms.GroupBox dataForCheckGroup;
        internal System.Windows.Forms.TextBox checkableDataList;
        internal System.Windows.Forms.TabControl tabControl;
        internal System.Windows.Forms.Button loadDataButton;
        internal System.Windows.Forms.Button clearDevicesButton;
        internal System.Windows.Forms.ComboBox checkDataTypeBox;
        internal System.Windows.Forms.Button loadFromJsonButton;
        internal System.Windows.Forms.TabPage lessonsPage;
        internal System.Windows.Forms.Button getMylessonsButton;
        private System.Windows.Forms.GroupBox avbalibleLessonsGroup;
    }
}