namespace MultiThreadHardwareSim
{
    partial class Hardware
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
            this.buttonConnectDevice = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButtonSingleSiteEnable = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonConnectDevice
            // 
            this.buttonConnectDevice.Location = new System.Drawing.Point(12, 12);
            this.buttonConnectDevice.Name = "buttonConnectDevice";
            this.buttonConnectDevice.Size = new System.Drawing.Size(260, 23);
            this.buttonConnectDevice.TabIndex = 0;
            this.buttonConnectDevice.Text = "Connect Device";
            this.buttonConnectDevice.UseVisualStyleBackColor = true;
            this.buttonConnectDevice.Click += new System.EventHandler(this.buttonConnectDevice_Click);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(12, 41);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(260, 23);
            this.buttonProgram.TabIndex = 1;
            this.buttonProgram.Text = "Program Device";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(260, 20);
            this.textBox4.TabIndex = 5;
            // 
            // radioButtonSingleSiteEnable
            // 
            this.radioButtonSingleSiteEnable.AutoSize = true;
            this.radioButtonSingleSiteEnable.Location = new System.Drawing.Point(12, 194);
            this.radioButtonSingleSiteEnable.Name = "radioButtonSingleSiteEnable";
            this.radioButtonSingleSiteEnable.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSingleSiteEnable.TabIndex = 6;
            this.radioButtonSingleSiteEnable.TabStop = true;
            this.radioButtonSingleSiteEnable.Text = "SingleSiteEnable";
            this.radioButtonSingleSiteEnable.UseVisualStyleBackColor = true;
            // 
            // Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radioButtonSingleSiteEnable);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonProgram);
            this.Controls.Add(this.buttonConnectDevice);
            this.Name = "Hardware";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectDevice;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButtonSingleSiteEnable;
    }
}

