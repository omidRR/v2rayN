namespace v2rayN.Forms
{
    partial class OptionSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionSettingForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkdefAllowInsecure = new System.Windows.Forms.CheckBox();
            this.chksniffingEnabled2 = new System.Windows.Forms.CheckBox();
            this.chksniffingEnabled = new System.Windows.Forms.CheckBox();
            this.chkmuxEnabled = new System.Windows.Forms.CheckBox();
            this.chkAllowIn2 = new System.Windows.Forms.CheckBox();
            this.chkudpEnabled2 = new System.Windows.Forms.CheckBox();
            this.cmbprotocol2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalPort2 = new System.Windows.Forms.TextBox();
            this.cmbprotocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkudpEnabled = new System.Windows.Forms.CheckBox();
            this.chklogEnabled = new System.Windows.Forms.CheckBox();
            this.cmbloglevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkDnsObjectDoc = new System.Windows.Forms.LinkLabel();
            this.txtremoteDNS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkKcpcongestion = new System.Windows.Forms.CheckBox();
            this.txtKcpwriteBufferSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKcpreadBufferSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKcpdownlinkCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKcpuplinkCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKcptti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKcpmtu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.txtautoUpdateInterval = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkIgnoreGeoUpdateCore = new System.Windows.Forms.CheckBox();
            this.cmbCoreType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkKeepOlderDedupl = new System.Windows.Forms.CheckBox();
            this.cbFreshrate = new System.Windows.Forms.ComboBox();
            this.lbFreshrate = new System.Windows.Forms.Label();
            this.chkEnableStatistics = new System.Windows.Forms.CheckBox();
            this.chkAllowLANConn = new System.Windows.Forms.CheckBox();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsystemProxyExceptions = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.chkdefAllowInsecure);
            this.groupBox1.Controls.Add(this.chksniffingEnabled2);
            this.groupBox1.Controls.Add(this.chksniffingEnabled);
            this.groupBox1.Controls.Add(this.chkmuxEnabled);
            this.groupBox1.Controls.Add(this.chkAllowIn2);
            this.groupBox1.Controls.Add(this.chkudpEnabled2);
            this.groupBox1.Controls.Add(this.cmbprotocol2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocalPort2);
            this.groupBox1.Controls.Add(this.cmbprotocol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkudpEnabled);
            this.groupBox1.Controls.Add(this.chklogEnabled);
            this.groupBox1.Controls.Add(this.cmbloglevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtlocalPort);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkdefAllowInsecure
            // 
            resources.ApplyResources(this.chkdefAllowInsecure, "chkdefAllowInsecure");
            this.chkdefAllowInsecure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkdefAllowInsecure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkdefAllowInsecure.Name = "chkdefAllowInsecure";
            this.chkdefAllowInsecure.UseVisualStyleBackColor = false;
            // 
            // chksniffingEnabled2
            // 
            resources.ApplyResources(this.chksniffingEnabled2, "chksniffingEnabled2");
            this.chksniffingEnabled2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chksniffingEnabled2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chksniffingEnabled2.Name = "chksniffingEnabled2";
            this.chksniffingEnabled2.UseVisualStyleBackColor = false;
            // 
            // chksniffingEnabled
            // 
            resources.ApplyResources(this.chksniffingEnabled, "chksniffingEnabled");
            this.chksniffingEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chksniffingEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chksniffingEnabled.Name = "chksniffingEnabled";
            this.chksniffingEnabled.UseVisualStyleBackColor = false;
            // 
            // chkmuxEnabled
            // 
            resources.ApplyResources(this.chkmuxEnabled, "chkmuxEnabled");
            this.chkmuxEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkmuxEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkmuxEnabled.Name = "chkmuxEnabled";
            this.chkmuxEnabled.UseVisualStyleBackColor = false;
            // 
            // chkAllowIn2
            // 
            resources.ApplyResources(this.chkAllowIn2, "chkAllowIn2");
            this.chkAllowIn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkAllowIn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAllowIn2.Name = "chkAllowIn2";
            this.chkAllowIn2.UseVisualStyleBackColor = false;
            this.chkAllowIn2.CheckedChanged += new System.EventHandler(this.chkAllowIn2_CheckedChanged);
            // 
            // chkudpEnabled2
            // 
            resources.ApplyResources(this.chkudpEnabled2, "chkudpEnabled2");
            this.chkudpEnabled2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkudpEnabled2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkudpEnabled2.Name = "chkudpEnabled2";
            this.chkudpEnabled2.UseVisualStyleBackColor = false;
            // 
            // cmbprotocol2
            // 
            this.cmbprotocol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbprotocol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbprotocol2, "cmbprotocol2");
            this.cmbprotocol2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbprotocol2.FormattingEnabled = true;
            this.cmbprotocol2.Items.AddRange(new object[] {
            resources.GetString("cmbprotocol2.Items"),
            resources.GetString("cmbprotocol2.Items1")});
            this.cmbprotocol2.Name = "cmbprotocol2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            // 
            // txtlocalPort2
            // 
            this.txtlocalPort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtlocalPort2, "txtlocalPort2");
            this.txtlocalPort2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtlocalPort2.Name = "txtlocalPort2";
            // 
            // cmbprotocol
            // 
            this.cmbprotocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbprotocol, "cmbprotocol");
            this.cmbprotocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbprotocol.FormattingEnabled = true;
            this.cmbprotocol.Items.AddRange(new object[] {
            resources.GetString("cmbprotocol.Items"),
            resources.GetString("cmbprotocol.Items1")});
            this.cmbprotocol.Name = "cmbprotocol";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // chkudpEnabled
            // 
            resources.ApplyResources(this.chkudpEnabled, "chkudpEnabled");
            this.chkudpEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkudpEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkudpEnabled.Name = "chkudpEnabled";
            this.chkudpEnabled.UseVisualStyleBackColor = false;
            // 
            // chklogEnabled
            // 
            resources.ApplyResources(this.chklogEnabled, "chklogEnabled");
            this.chklogEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chklogEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chklogEnabled.Name = "chklogEnabled";
            this.chklogEnabled.UseVisualStyleBackColor = false;
            // 
            // cmbloglevel
            // 
            this.cmbloglevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbloglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbloglevel, "cmbloglevel");
            this.cmbloglevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbloglevel.FormattingEnabled = true;
            this.cmbloglevel.Items.AddRange(new object[] {
            resources.GetString("cmbloglevel.Items"),
            resources.GetString("cmbloglevel.Items1"),
            resources.GetString("cmbloglevel.Items2"),
            resources.GetString("cmbloglevel.Items3"),
            resources.GetString("cmbloglevel.Items4")});
            this.cmbloglevel.Name = "cmbloglevel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Name = "label5";
            // 
            // txtlocalPort
            // 
            this.txtlocalPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtlocalPort, "txtlocalPort");
            this.txtlocalPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtlocalPort.Name = "txtlocalPort";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Name = "label2";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.linkDnsObjectDoc);
            this.tabPage2.Controls.Add(this.txtremoteDNS);
            this.tabPage2.Controls.Add(this.label14);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // linkDnsObjectDoc
            // 
            resources.ApplyResources(this.linkDnsObjectDoc, "linkDnsObjectDoc");
            this.linkDnsObjectDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.linkDnsObjectDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkDnsObjectDoc.Name = "linkDnsObjectDoc";
            this.linkDnsObjectDoc.TabStop = true;
            this.linkDnsObjectDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDnsObjectDoc_LinkClicked);
            // 
            // txtremoteDNS
            // 
            this.txtremoteDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtremoteDNS, "txtremoteDNS");
            this.txtremoteDNS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtremoteDNS.Name = "txtremoteDNS";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Name = "label14";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage6.Controls.Add(this.chkKcpcongestion);
            this.tabPage6.Controls.Add(this.txtKcpwriteBufferSize);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.txtKcpreadBufferSize);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txtKcpdownlinkCapacity);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.txtKcpuplinkCapacity);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.txtKcptti);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.txtKcpmtu);
            this.tabPage6.Controls.Add(this.label6);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            // 
            // chkKcpcongestion
            // 
            resources.ApplyResources(this.chkKcpcongestion, "chkKcpcongestion");
            this.chkKcpcongestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkKcpcongestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkKcpcongestion.Name = "chkKcpcongestion";
            this.chkKcpcongestion.UseVisualStyleBackColor = false;
            // 
            // txtKcpwriteBufferSize
            // 
            this.txtKcpwriteBufferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcpwriteBufferSize, "txtKcpwriteBufferSize");
            this.txtKcpwriteBufferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcpwriteBufferSize.Name = "txtKcpwriteBufferSize";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Name = "label10";
            // 
            // txtKcpreadBufferSize
            // 
            this.txtKcpreadBufferSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcpreadBufferSize, "txtKcpreadBufferSize");
            this.txtKcpreadBufferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcpreadBufferSize.Name = "txtKcpreadBufferSize";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Name = "label11";
            // 
            // txtKcpdownlinkCapacity
            // 
            this.txtKcpdownlinkCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcpdownlinkCapacity, "txtKcpdownlinkCapacity");
            this.txtKcpdownlinkCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcpdownlinkCapacity.Name = "txtKcpdownlinkCapacity";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Name = "label8";
            // 
            // txtKcpuplinkCapacity
            // 
            this.txtKcpuplinkCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcpuplinkCapacity, "txtKcpuplinkCapacity");
            this.txtKcpuplinkCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcpuplinkCapacity.Name = "txtKcpuplinkCapacity";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Name = "label9";
            // 
            // txtKcptti
            // 
            this.txtKcptti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcptti, "txtKcptti");
            this.txtKcptti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcptti.Name = "txtKcptti";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Name = "label7";
            // 
            // txtKcpmtu
            // 
            this.txtKcpmtu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtKcpmtu, "txtKcpmtu");
            this.txtKcpmtu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKcpmtu.Name = "txtKcpmtu";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Name = "label6";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage7.Controls.Add(this.txtautoUpdateInterval);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.chkIgnoreGeoUpdateCore);
            this.tabPage7.Controls.Add(this.cmbCoreType);
            this.tabPage7.Controls.Add(this.label4);
            this.tabPage7.Controls.Add(this.chkKeepOlderDedupl);
            this.tabPage7.Controls.Add(this.cbFreshrate);
            this.tabPage7.Controls.Add(this.lbFreshrate);
            this.tabPage7.Controls.Add(this.chkEnableStatistics);
            this.tabPage7.Controls.Add(this.chkAllowLANConn);
            this.tabPage7.Controls.Add(this.chkAutoRun);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            // 
            // txtautoUpdateInterval
            // 
            this.txtautoUpdateInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtautoUpdateInterval, "txtautoUpdateInterval");
            this.txtautoUpdateInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtautoUpdateInterval.Name = "txtautoUpdateInterval";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Name = "label15";
            // 
            // chkIgnoreGeoUpdateCore
            // 
            resources.ApplyResources(this.chkIgnoreGeoUpdateCore, "chkIgnoreGeoUpdateCore");
            this.chkIgnoreGeoUpdateCore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkIgnoreGeoUpdateCore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkIgnoreGeoUpdateCore.Name = "chkIgnoreGeoUpdateCore";
            this.chkIgnoreGeoUpdateCore.UseVisualStyleBackColor = false;
            // 
            // cmbCoreType
            // 
            this.cmbCoreType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbCoreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbCoreType, "cmbCoreType");
            this.cmbCoreType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCoreType.FormattingEnabled = true;
            this.cmbCoreType.Items.AddRange(new object[] {
            resources.GetString("cmbCoreType.Items"),
            resources.GetString("cmbCoreType.Items1")});
            this.cmbCoreType.Name = "cmbCoreType";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            // 
            // chkKeepOlderDedupl
            // 
            resources.ApplyResources(this.chkKeepOlderDedupl, "chkKeepOlderDedupl");
            this.chkKeepOlderDedupl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkKeepOlderDedupl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkKeepOlderDedupl.Name = "chkKeepOlderDedupl";
            this.chkKeepOlderDedupl.UseVisualStyleBackColor = false;
            // 
            // cbFreshrate
            // 
            this.cbFreshrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbFreshrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbFreshrate, "cbFreshrate");
            this.cbFreshrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFreshrate.FormattingEnabled = true;
            this.cbFreshrate.Name = "cbFreshrate";
            // 
            // lbFreshrate
            // 
            resources.ApplyResources(this.lbFreshrate, "lbFreshrate");
            this.lbFreshrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbFreshrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFreshrate.Name = "lbFreshrate";
            // 
            // chkEnableStatistics
            // 
            resources.ApplyResources(this.chkEnableStatistics, "chkEnableStatistics");
            this.chkEnableStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkEnableStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkEnableStatistics.Name = "chkEnableStatistics";
            this.chkEnableStatistics.UseVisualStyleBackColor = false;
            // 
            // chkAllowLANConn
            // 
            resources.ApplyResources(this.chkAllowLANConn, "chkAllowLANConn");
            this.chkAllowLANConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkAllowLANConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAllowLANConn.Name = "chkAllowLANConn";
            this.chkAllowLANConn.UseVisualStyleBackColor = false;
            // 
            // chkAutoRun
            // 
            resources.ApplyResources(this.chkAutoRun, "chkAutoRun");
            this.chkAutoRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkAutoRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtsystemProxyExceptions);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Name = "label12";
            // 
            // txtsystemProxyExceptions
            // 
            this.txtsystemProxyExceptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.txtsystemProxyExceptions, "txtsystemProxyExceptions");
            this.txtsystemProxyExceptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtsystemProxyExceptions.Name = "txtsystemProxyExceptions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOK);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Name = "panel2";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Name = "panel1";
            // 
            // OptionSettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionSettingForm";
            this.Load += new System.EventHandler(this.OptionSettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbloglevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chklogEnabled;
        private System.Windows.Forms.CheckBox chkudpEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbprotocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprotocol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalPort2;
        private System.Windows.Forms.CheckBox chkudpEnabled2;
        private System.Windows.Forms.CheckBox chkAllowIn2;
        private System.Windows.Forms.CheckBox chkmuxEnabled;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtKcpmtu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKcptti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKcpwriteBufferSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKcpreadBufferSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKcpdownlinkCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKcpuplinkCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKcpcongestion;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.CheckBox chkAllowLANConn;
        private System.Windows.Forms.CheckBox chksniffingEnabled;
        private System.Windows.Forms.CheckBox chksniffingEnabled2;
        private System.Windows.Forms.CheckBox chkEnableStatistics;
        private System.Windows.Forms.ComboBox cbFreshrate;
        private System.Windows.Forms.Label lbFreshrate;
        private System.Windows.Forms.CheckBox chkKeepOlderDedupl;
        private System.Windows.Forms.CheckBox chkdefAllowInsecure;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkDnsObjectDoc;
        private System.Windows.Forms.TextBox txtremoteDNS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCoreType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIgnoreGeoUpdateCore;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtsystemProxyExceptions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtautoUpdateInterval;
        private System.Windows.Forms.Label label15;
    }
}