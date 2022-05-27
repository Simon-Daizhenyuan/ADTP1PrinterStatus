namespace ADTP1PrinterStatus
{
    partial class Form1
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
            this.onlineLbl = new System.Windows.Forms.Label();
            this.activeLbl = new System.Windows.Forms.Label();
            this.busyLbl = new System.Windows.Forms.Label();
            this.onlineDataErrorLbl = new System.Windows.Forms.Label();
            this.stockErrorLbl = new System.Windows.Forms.Label();
            this.onlineErrorLbl = new System.Windows.Forms.Label();
            this.hardwareFailureLbl = new System.Windows.Forms.Label();
            this.operatorCorrectableErrorLbl = new System.Windows.Forms.Label();
            this.lowBatteryLbl = new System.Windows.Forms.Label();
            this.formatErrorLbl = new System.Windows.Forms.Label();
            this.waitingToDispenseLabelLbl = new System.Windows.Forms.Label();
            this.ribbonErrorLbl = new System.Windows.Forms.Label();
            this.enqResponseLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printerStatusCB = new System.Windows.Forms.CheckBox();
            this.portCB = new System.Windows.Forms.ComboBox();
            this.ipAddressTB = new System.Windows.Forms.TextBox();
            this.comPortTB = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlineLbl
            // 
            this.onlineLbl.AutoSize = true;
            this.onlineLbl.Enabled = false;
            this.onlineLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineLbl.Location = new System.Drawing.Point(93, 186);
            this.onlineLbl.Name = "onlineLbl";
            this.onlineLbl.Size = new System.Drawing.Size(58, 19);
            this.onlineLbl.TabIndex = 0;
            this.onlineLbl.Text = "Online";
            // 
            // activeLbl
            // 
            this.activeLbl.AutoSize = true;
            this.activeLbl.Enabled = false;
            this.activeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeLbl.Location = new System.Drawing.Point(93, 228);
            this.activeLbl.Name = "activeLbl";
            this.activeLbl.Size = new System.Drawing.Size(56, 19);
            this.activeLbl.TabIndex = 1;
            this.activeLbl.Text = "Active";
            // 
            // busyLbl
            // 
            this.busyLbl.AutoSize = true;
            this.busyLbl.Enabled = false;
            this.busyLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyLbl.Location = new System.Drawing.Point(93, 278);
            this.busyLbl.Name = "busyLbl";
            this.busyLbl.Size = new System.Drawing.Size(49, 19);
            this.busyLbl.TabIndex = 2;
            this.busyLbl.Text = "Busy";
            // 
            // onlineDataErrorLbl
            // 
            this.onlineDataErrorLbl.AutoSize = true;
            this.onlineDataErrorLbl.Enabled = false;
            this.onlineDataErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineDataErrorLbl.Location = new System.Drawing.Point(93, 321);
            this.onlineDataErrorLbl.Name = "onlineDataErrorLbl";
            this.onlineDataErrorLbl.Size = new System.Drawing.Size(140, 19);
            this.onlineDataErrorLbl.TabIndex = 3;
            this.onlineDataErrorLbl.Text = "Online Data Error";
            // 
            // stockErrorLbl
            // 
            this.stockErrorLbl.AutoSize = true;
            this.stockErrorLbl.Enabled = false;
            this.stockErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockErrorLbl.Location = new System.Drawing.Point(308, 321);
            this.stockErrorLbl.Name = "stockErrorLbl";
            this.stockErrorLbl.Size = new System.Drawing.Size(96, 19);
            this.stockErrorLbl.TabIndex = 7;
            this.stockErrorLbl.Text = "Stock Error";
            // 
            // onlineErrorLbl
            // 
            this.onlineErrorLbl.AutoSize = true;
            this.onlineErrorLbl.Enabled = false;
            this.onlineErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineErrorLbl.Location = new System.Drawing.Point(308, 278);
            this.onlineErrorLbl.Name = "onlineErrorLbl";
            this.onlineErrorLbl.Size = new System.Drawing.Size(101, 19);
            this.onlineErrorLbl.TabIndex = 6;
            this.onlineErrorLbl.Text = "Online Error";
            // 
            // hardwareFailureLbl
            // 
            this.hardwareFailureLbl.AutoSize = true;
            this.hardwareFailureLbl.Enabled = false;
            this.hardwareFailureLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareFailureLbl.Location = new System.Drawing.Point(308, 228);
            this.hardwareFailureLbl.Name = "hardwareFailureLbl";
            this.hardwareFailureLbl.Size = new System.Drawing.Size(139, 19);
            this.hardwareFailureLbl.TabIndex = 5;
            this.hardwareFailureLbl.Text = "Hardware Failure";
            // 
            // operatorCorrectableErrorLbl
            // 
            this.operatorCorrectableErrorLbl.AutoSize = true;
            this.operatorCorrectableErrorLbl.Enabled = false;
            this.operatorCorrectableErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorCorrectableErrorLbl.Location = new System.Drawing.Point(308, 186);
            this.operatorCorrectableErrorLbl.Name = "operatorCorrectableErrorLbl";
            this.operatorCorrectableErrorLbl.Size = new System.Drawing.Size(212, 19);
            this.operatorCorrectableErrorLbl.TabIndex = 4;
            this.operatorCorrectableErrorLbl.Text = "Operator Correctable Error";
            // 
            // lowBatteryLbl
            // 
            this.lowBatteryLbl.AutoSize = true;
            this.lowBatteryLbl.Enabled = false;
            this.lowBatteryLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowBatteryLbl.Location = new System.Drawing.Point(552, 321);
            this.lowBatteryLbl.Name = "lowBatteryLbl";
            this.lowBatteryLbl.Size = new System.Drawing.Size(101, 19);
            this.lowBatteryLbl.TabIndex = 11;
            this.lowBatteryLbl.Text = "Low Battery";
            // 
            // formatErrorLbl
            // 
            this.formatErrorLbl.AutoSize = true;
            this.formatErrorLbl.Enabled = false;
            this.formatErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatErrorLbl.Location = new System.Drawing.Point(552, 278);
            this.formatErrorLbl.Name = "formatErrorLbl";
            this.formatErrorLbl.Size = new System.Drawing.Size(106, 19);
            this.formatErrorLbl.TabIndex = 10;
            this.formatErrorLbl.Text = "Format Error";
            // 
            // waitingToDispenseLabelLbl
            // 
            this.waitingToDispenseLabelLbl.AutoSize = true;
            this.waitingToDispenseLabelLbl.Enabled = false;
            this.waitingToDispenseLabelLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingToDispenseLabelLbl.Location = new System.Drawing.Point(552, 228);
            this.waitingToDispenseLabelLbl.Name = "waitingToDispenseLabelLbl";
            this.waitingToDispenseLabelLbl.Size = new System.Drawing.Size(210, 19);
            this.waitingToDispenseLabelLbl.TabIndex = 9;
            this.waitingToDispenseLabelLbl.Text = "Waiting To Dispense Label";
            // 
            // ribbonErrorLbl
            // 
            this.ribbonErrorLbl.AutoSize = true;
            this.ribbonErrorLbl.Enabled = false;
            this.ribbonErrorLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonErrorLbl.Location = new System.Drawing.Point(552, 186);
            this.ribbonErrorLbl.Name = "ribbonErrorLbl";
            this.ribbonErrorLbl.Size = new System.Drawing.Size(108, 19);
            this.ribbonErrorLbl.TabIndex = 8;
            this.ribbonErrorLbl.Text = "Ribbon Error";
            // 
            // enqResponseLbl
            // 
            this.enqResponseLbl.AutoSize = true;
            this.enqResponseLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enqResponseLbl.Location = new System.Drawing.Point(235, 122);
            this.enqResponseLbl.Name = "enqResponseLbl";
            this.enqResponseLbl.Size = new System.Drawing.Size(126, 19);
            this.enqResponseLbl.TabIndex = 12;
            this.enqResponseLbl.Text = "ENQ Response";
            this.enqResponseLbl.Click += new System.EventHandler(this.enqResponseLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "ENQ Response: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printerStatusCB
            // 
            this.printerStatusCB.AutoSize = true;
            this.printerStatusCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerStatusCB.Location = new System.Drawing.Point(33, 40);
            this.printerStatusCB.Name = "printerStatusCB";
            this.printerStatusCB.Size = new System.Drawing.Size(182, 24);
            this.printerStatusCB.TabIndex = 14;
            this.printerStatusCB.Text = "Monitor Printer Status";
            this.printerStatusCB.UseVisualStyleBackColor = true;
            this.printerStatusCB.CheckedChanged += new System.EventHandler(this.printerStatusCB_CheckedChanged);
            // 
            // portCB
            // 
            this.portCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portCB.FormattingEnabled = true;
            this.portCB.Items.AddRange(new object[] {
            "TCP/IP",
            "COM"});
            this.portCB.Location = new System.Drawing.Point(513, 43);
            this.portCB.Name = "portCB";
            this.portCB.Size = new System.Drawing.Size(121, 28);
            this.portCB.TabIndex = 15;
            this.portCB.SelectedIndexChanged += new System.EventHandler(this.portCB_SelectedIndexChanged);
            // 
            // ipAddressTB
            // 
            this.ipAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressTB.Location = new System.Drawing.Point(656, 43);
            this.ipAddressTB.Name = "ipAddressTB";
            this.ipAddressTB.Size = new System.Drawing.Size(139, 26);
            this.ipAddressTB.TabIndex = 16;
            this.ipAddressTB.Text = "ipAddressTB";
            this.ipAddressTB.TextChanged += new System.EventHandler(this.ipAddressTB_TextChanged);
            // 
            // comPortTB
            // 
            this.comPortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortTB.Location = new System.Drawing.Point(656, 75);
            this.comPortTB.Name = "comPortTB";
            this.comPortTB.Size = new System.Drawing.Size(139, 26);
            this.comPortTB.TabIndex = 17;
            this.comPortTB.Text = "comPortTB";
            this.comPortTB.TextChanged += new System.EventHandler(this.comPortTB_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(157, 21);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 407);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comPortTB);
            this.Controls.Add(this.ipAddressTB);
            this.Controls.Add(this.portCB);
            this.Controls.Add(this.printerStatusCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enqResponseLbl);
            this.Controls.Add(this.lowBatteryLbl);
            this.Controls.Add(this.formatErrorLbl);
            this.Controls.Add(this.waitingToDispenseLabelLbl);
            this.Controls.Add(this.ribbonErrorLbl);
            this.Controls.Add(this.stockErrorLbl);
            this.Controls.Add(this.onlineErrorLbl);
            this.Controls.Add(this.hardwareFailureLbl);
            this.Controls.Add(this.operatorCorrectableErrorLbl);
            this.Controls.Add(this.onlineDataErrorLbl);
            this.Controls.Add(this.busyLbl);
            this.Controls.Add(this.activeLbl);
            this.Controls.Add(this.onlineLbl);
            this.Name = "Form1";
            this.Text = "ADTP1 Printer Status V1.0 (May 2022)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label onlineLbl;
        private System.Windows.Forms.Label activeLbl;
        private System.Windows.Forms.Label busyLbl;
        private System.Windows.Forms.Label onlineDataErrorLbl;
        private System.Windows.Forms.Label stockErrorLbl;
        private System.Windows.Forms.Label onlineErrorLbl;
        private System.Windows.Forms.Label hardwareFailureLbl;
        private System.Windows.Forms.Label operatorCorrectableErrorLbl;
        private System.Windows.Forms.Label lowBatteryLbl;
        private System.Windows.Forms.Label formatErrorLbl;
        private System.Windows.Forms.Label waitingToDispenseLabelLbl;
        private System.Windows.Forms.Label ribbonErrorLbl;
        private System.Windows.Forms.Label enqResponseLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox printerStatusCB;
        private System.Windows.Forms.ComboBox portCB;
        private System.Windows.Forms.TextBox ipAddressTB;
        private System.Windows.Forms.TextBox comPortTB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

