
namespace TDS2014B_Tekvisa_Test
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tek_lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tek_lbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tek_lbl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeviceRefresh = new System.Windows.Forms.Button();
            this.chkCH1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCH4 = new System.Windows.Forms.CheckBox();
            this.chkCH3 = new System.Windows.Forms.CheckBox();
            this.chkCH2 = new System.Windows.Forms.CheckBox();
            this.btnSetupTDS2014B = new System.Windows.Forms.Button();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.tmRead = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(591, 64);
            this.listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tek_lbl1,
            this.tek_lbl2,
            this.tek_lbl3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 36);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tek_lbl1
            // 
            this.tek_lbl1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tek_lbl1.Name = "tek_lbl1";
            this.tek_lbl1.Size = new System.Drawing.Size(50, 29);
            this.tek_lbl1.Text = "tek1";
            // 
            // tek_lbl2
            // 
            this.tek_lbl2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tek_lbl2.Name = "tek_lbl2";
            this.tek_lbl2.Size = new System.Drawing.Size(50, 29);
            this.tek_lbl2.Text = "tek2";
            // 
            // tek_lbl3
            // 
            this.tek_lbl3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tek_lbl3.Name = "tek_lbl3";
            this.tek_lbl3.Size = new System.Drawing.Size(50, 29);
            this.tek_lbl3.Text = "tek3";
            // 
            // btnDeviceRefresh
            // 
            this.btnDeviceRefresh.Location = new System.Drawing.Point(619, 12);
            this.btnDeviceRefresh.Name = "btnDeviceRefresh";
            this.btnDeviceRefresh.Size = new System.Drawing.Size(88, 31);
            this.btnDeviceRefresh.TabIndex = 2;
            this.btnDeviceRefresh.Text = "Refresh";
            this.btnDeviceRefresh.UseVisualStyleBackColor = true;
            this.btnDeviceRefresh.Click += new System.EventHandler(this.btnDeviceRefresh_Click);
            // 
            // chkCH1
            // 
            this.chkCH1.AutoSize = true;
            this.chkCH1.Checked = true;
            this.chkCH1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCH1.Location = new System.Drawing.Point(15, 36);
            this.chkCH1.Name = "chkCH1";
            this.chkCH1.Size = new System.Drawing.Size(70, 24);
            this.chkCH1.TabIndex = 3;
            this.chkCH1.Text = "CH1";
            this.chkCH1.UseVisualStyleBackColor = true;
            this.chkCH1.CheckedChanged += new System.EventHandler(this.chkCH1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCH4);
            this.groupBox1.Controls.Add(this.chkCH3);
            this.groupBox1.Controls.Add(this.chkCH2);
            this.groupBox1.Controls.Add(this.chkCH1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel ON/OFF";
            // 
            // chkCH4
            // 
            this.chkCH4.AutoSize = true;
            this.chkCH4.Checked = true;
            this.chkCH4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCH4.Location = new System.Drawing.Point(243, 36);
            this.chkCH4.Name = "chkCH4";
            this.chkCH4.Size = new System.Drawing.Size(70, 24);
            this.chkCH4.TabIndex = 6;
            this.chkCH4.Text = "CH4";
            this.chkCH4.UseVisualStyleBackColor = true;
            this.chkCH4.CheckedChanged += new System.EventHandler(this.chkCH4_CheckedChanged);
            // 
            // chkCH3
            // 
            this.chkCH3.AutoSize = true;
            this.chkCH3.Checked = true;
            this.chkCH3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCH3.Location = new System.Drawing.Point(167, 36);
            this.chkCH3.Name = "chkCH3";
            this.chkCH3.Size = new System.Drawing.Size(70, 24);
            this.chkCH3.TabIndex = 5;
            this.chkCH3.Text = "CH3";
            this.chkCH3.UseVisualStyleBackColor = true;
            this.chkCH3.CheckedChanged += new System.EventHandler(this.chkCH3_CheckedChanged);
            // 
            // chkCH2
            // 
            this.chkCH2.AutoSize = true;
            this.chkCH2.Checked = true;
            this.chkCH2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCH2.Location = new System.Drawing.Point(91, 36);
            this.chkCH2.Name = "chkCH2";
            this.chkCH2.Size = new System.Drawing.Size(70, 24);
            this.chkCH2.TabIndex = 4;
            this.chkCH2.Text = "CH2";
            this.chkCH2.UseVisualStyleBackColor = true;
            this.chkCH2.CheckedChanged += new System.EventHandler(this.chkCH2_CheckedChanged);
            // 
            // btnSetupTDS2014B
            // 
            this.btnSetupTDS2014B.Location = new System.Drawing.Point(390, 132);
            this.btnSetupTDS2014B.Name = "btnSetupTDS2014B";
            this.btnSetupTDS2014B.Size = new System.Drawing.Size(152, 74);
            this.btnSetupTDS2014B.TabIndex = 5;
            this.btnSetupTDS2014B.Text = "Setup TDS201B for Measurement";
            this.btnSetupTDS2014B.UseVisualStyleBackColor = true;
            this.btnSetupTDS2014B.Click += new System.EventHandler(this.btnSetupTDS2014B_Click);
            // 
            // txtinfo
            // 
            this.txtinfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtinfo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtinfo.Location = new System.Drawing.Point(0, 370);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtinfo.Size = new System.Drawing.Size(989, 176);
            this.txtinfo.TabIndex = 6;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(567, 132);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(140, 74);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Start Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tmRead
            // 
            this.tmRead.Interval = 1000;
            this.tmRead.Tick += new System.EventHandler(this.tmRead_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 582);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.btnSetupTDS2014B);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeviceRefresh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl1;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl2;
        private System.Windows.Forms.ToolStripStatusLabel tek_lbl3;
        private System.Windows.Forms.Button btnDeviceRefresh;
        private System.Windows.Forms.CheckBox chkCH1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCH4;
        private System.Windows.Forms.CheckBox chkCH3;
        private System.Windows.Forms.CheckBox chkCH2;
        private System.Windows.Forms.Button btnSetupTDS2014B;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Timer tmRead;
    }
}

