namespace SorterSetup
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelConnectedFlag = new System.Windows.Forms.Label();
            this.buttonRefreshPorts = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2Disconnect = new System.Windows.Forms.Button();
            this.buttonAddAnotherFilter = new System.Windows.Forms.Button();
            this.flowLayoutPanelFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDownElseConteiner = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElseConteiner)).BeginInit();
            this.groupBoxConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change state";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(73, 19);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.Location = new System.Drawing.Point(73, 63);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.textBoxBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(210, 41);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelConnectedFlag
            // 
            this.labelConnectedFlag.AutoSize = true;
            this.labelConnectedFlag.Location = new System.Drawing.Point(356, 27);
            this.labelConnectedFlag.Name = "labelConnectedFlag";
            this.labelConnectedFlag.Size = new System.Drawing.Size(79, 13);
            this.labelConnectedFlag.TabIndex = 6;
            this.labelConnectedFlag.Text = "Not Connected";
            // 
            // buttonRefreshPorts
            // 
            this.buttonRefreshPorts.Location = new System.Drawing.Point(210, 12);
            this.buttonRefreshPorts.Name = "buttonRefreshPorts";
            this.buttonRefreshPorts.Size = new System.Drawing.Size(99, 23);
            this.buttonRefreshPorts.TabIndex = 7;
            this.buttonRefreshPorts.Text = "Refresh ports list";
            this.buttonRefreshPorts.UseVisualStyleBackColor = true;
            this.buttonRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button2Disconnect
            // 
            this.button2Disconnect.Location = new System.Drawing.Point(210, 70);
            this.button2Disconnect.Name = "button2Disconnect";
            this.button2Disconnect.Size = new System.Drawing.Size(99, 23);
            this.button2Disconnect.TabIndex = 9;
            this.button2Disconnect.Text = "Disconnect";
            this.button2Disconnect.UseVisualStyleBackColor = true;
            this.button2Disconnect.Click += new System.EventHandler(this.button2Disconnect_Click);
            // 
            // buttonAddAnotherFilter
            // 
            this.buttonAddAnotherFilter.Location = new System.Drawing.Point(353, 131);
            this.buttonAddAnotherFilter.Name = "buttonAddAnotherFilter";
            this.buttonAddAnotherFilter.Size = new System.Drawing.Size(114, 23);
            this.buttonAddAnotherFilter.TabIndex = 12;
            this.buttonAddAnotherFilter.Text = "Add another filter";
            this.buttonAddAnotherFilter.UseVisualStyleBackColor = true;
            this.buttonAddAnotherFilter.Click += new System.EventHandler(this.buttonAddAnotherFilter_Click);
            // 
            // flowLayoutPanelFilters
            // 
            this.flowLayoutPanelFilters.AutoScroll = true;
            this.flowLayoutPanelFilters.Location = new System.Drawing.Point(7, 184);
            this.flowLayoutPanelFilters.Name = "flowLayoutPanelFilters";
            this.flowLayoutPanelFilters.Size = new System.Drawing.Size(565, 340);
            this.flowLayoutPanelFilters.TabIndex = 13;
            // 
            // numericUpDownElseConteiner
            // 
            this.numericUpDownElseConteiner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownElseConteiner.Location = new System.Drawing.Point(114, 9);
            this.numericUpDownElseConteiner.Name = "numericUpDownElseConteiner";
            this.numericUpDownElseConteiner.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownElseConteiner.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "All other to container";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(443, 543);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 25);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBoxConnection.Controls.Add(this.button2Disconnect);
            this.groupBoxConnection.Controls.Add(this.labelConnectedFlag);
            this.groupBoxConnection.Controls.Add(this.buttonConnect);
            this.groupBoxConnection.Controls.Add(this.label2);
            this.groupBoxConnection.Controls.Add(this.textBoxBaudRate);
            this.groupBoxConnection.Controls.Add(this.label1);
            this.groupBoxConnection.Controls.Add(this.comboBoxPorts);
            this.groupBoxConnection.Controls.Add(this.buttonRefreshPorts);
            this.groupBoxConnection.Location = new System.Drawing.Point(7, 12);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(560, 103);
            this.groupBoxConnection.TabIndex = 17;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.numericUpDownElseConteiner);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 34);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.flowLayoutPanelFilters);
            this.Controls.Add(this.buttonAddAnotherFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownElseConteiner)).EndInit();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelConnectedFlag;
        private System.Windows.Forms.Button buttonRefreshPorts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2Disconnect;
        private System.Windows.Forms.Button buttonAddAnotherFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFilters;
        private System.Windows.Forms.NumericUpDown numericUpDownElseConteiner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Panel panel1;
    }
}

