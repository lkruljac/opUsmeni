namespace SorterSetup
{
    partial class Form2
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
            this.Break = new System.Windows.Forms.Button();
            this.richTextBoxMonitor = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Break
            // 
            this.Break.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Break.BackColor = System.Drawing.Color.Red;
            this.Break.Location = new System.Drawing.Point(1108, 654);
            this.Break.Name = "Break";
            this.Break.Size = new System.Drawing.Size(75, 23);
            this.Break.TabIndex = 1;
            this.Break.Text = "Break";
            this.Break.UseVisualStyleBackColor = false;
            this.Break.Click += new System.EventHandler(this.break_Click);
            // 
            // richTextBoxMonitor
            // 
            this.richTextBoxMonitor.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxMonitor.Name = "richTextBoxMonitor";
            this.richTextBoxMonitor.Size = new System.Drawing.Size(1124, 42);
            this.richTextBoxMonitor.TabIndex = 0;
            this.richTextBoxMonitor.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1171, 576);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1195, 689);
            this.Controls.Add(this.Break);
            this.Controls.Add(this.richTextBoxMonitor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMonitor;
        private System.Windows.Forms.Button Break;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}