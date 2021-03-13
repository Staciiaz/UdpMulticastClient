
namespace UdpMulticastClient
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSavePlainText = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.RichTextBox();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.gridLog = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveLogFile = new System.Windows.Forms.Button();
            this.btnClearTab = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStatus);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(769, 553);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 71);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(19, 33);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Closed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavePlainText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPlain);
            this.groupBox2.Controls.Add(this.txtConsole);
            this.groupBox2.Controls.Add(this.gridLog);
            this.groupBox2.Controls.Add(this.btnSaveLogFile);
            this.groupBox2.Controls.Add(this.btnClearTab);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 612);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnSavePlainText
            // 
            this.btnSavePlainText.BackColor = System.Drawing.Color.Turquoise;
            this.btnSavePlainText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePlainText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePlainText.Location = new System.Drawing.Point(681, 331);
            this.btnSavePlainText.Name = "btnSavePlainText";
            this.btnSavePlainText.Size = new System.Drawing.Size(53, 23);
            this.btnSavePlainText.TabIndex = 105;
            this.btnSavePlainText.Text = "Save";
            this.btnSavePlainText.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(14, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Log File";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(14, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Console";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(384, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Plain Text";
            // 
            // txtPlain
            // 
            this.txtPlain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPlain.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPlain.Location = new System.Drawing.Point(387, 363);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.ReadOnly = true;
            this.txtPlain.Size = new System.Drawing.Size(347, 231);
            this.txtPlain.TabIndex = 100;
            this.txtPlain.Text = "";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Info;
            this.txtConsole.Location = new System.Drawing.Point(17, 48);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(717, 268);
            this.txtConsole.TabIndex = 99;
            this.txtConsole.Text = "";
            // 
            // gridLog
            // 
            this.gridLog.AllowUserToAddRows = false;
            this.gridLog.AllowUserToDeleteRows = false;
            this.gridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Timestamp,
            this.Data});
            this.gridLog.Location = new System.Drawing.Point(16, 363);
            this.gridLog.Name = "gridLog";
            this.gridLog.ReadOnly = true;
            this.gridLog.RowHeadersVisible = false;
            this.gridLog.Size = new System.Drawing.Size(348, 231);
            this.gridLog.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Timestamp
            // 
            this.Timestamp.DataPropertyName = "Timestamp";
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // btnSaveLogFile
            // 
            this.btnSaveLogFile.BackColor = System.Drawing.Color.Turquoise;
            this.btnSaveLogFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLogFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveLogFile.Location = new System.Drawing.Point(311, 331);
            this.btnSaveLogFile.Name = "btnSaveLogFile";
            this.btnSaveLogFile.Size = new System.Drawing.Size(53, 23);
            this.btnSaveLogFile.TabIndex = 101;
            this.btnSaveLogFile.Text = "Save";
            this.btnSaveLogFile.UseVisualStyleBackColor = false;
            // 
            // btnClearTab
            // 
            this.btnClearTab.BackColor = System.Drawing.Color.Tomato;
            this.btnClearTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearTab.Location = new System.Drawing.Point(659, 19);
            this.btnClearTab.Name = "btnClearTab";
            this.btnClearTab.Size = new System.Drawing.Size(75, 23);
            this.btnClearTab.TabIndex = 101;
            this.btnClearTab.Text = "Clear";
            this.btnClearTab.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(769, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(93, 73);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(185, 20);
            this.txtPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 33);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Chartreuse;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(110, 112);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 31);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 636);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UDP Multicast Receiver";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSavePlainText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtPlain;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.DataGridView gridLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button btnSaveLogFile;
        private System.Windows.Forms.Button btnClearTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnConnect;
    }
}

