namespace MultipleInstanceApiTest
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtInstances = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfAssets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbAiringId = new System.Windows.Forms.RadioButton();
            this.rbHealthCheck = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(186, 59);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(329, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "http://api-ondemand-tools-dev.turner.com";
            // 
            // txtInstances
            // 
            this.txtInstances.Location = new System.Drawing.Point(186, 108);
            this.txtInstances.Name = "txtInstances";
            this.txtInstances.Size = new System.Drawing.Size(100, 20);
            this.txtInstances.TabIndex = 1;
            this.txtInstances.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "API URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No of Instances";
            // 
            // txtNoOfAssets
            // 
            this.txtNoOfAssets.Location = new System.Drawing.Point(186, 150);
            this.txtNoOfAssets.Name = "txtNoOfAssets";
            this.txtNoOfAssets.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfAssets.TabIndex = 5;
            this.txtNoOfAssets.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "No of assets per instance";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(635, 276);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Results";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(186, 189);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtPrefix.TabIndex = 9;
            this.txtPrefix.Text = "CLIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asset Prefix";
            // 
            // rbAiringId
            // 
            this.rbAiringId.AutoSize = true;
            this.rbAiringId.Checked = true;
            this.rbAiringId.Location = new System.Drawing.Point(41, 261);
            this.rbAiringId.Name = "rbAiringId";
            this.rbAiringId.Size = new System.Drawing.Size(63, 17);
            this.rbAiringId.TabIndex = 11;
            this.rbAiringId.TabStop = true;
            this.rbAiringId.Text = "Airing Id";
            this.rbAiringId.UseVisualStyleBackColor = true;
            // 
            // rbHealthCheck
            // 
            this.rbHealthCheck.AutoSize = true;
            this.rbHealthCheck.Location = new System.Drawing.Point(140, 261);
            this.rbHealthCheck.Name = "rbHealthCheck";
            this.rbHealthCheck.Size = new System.Drawing.Size(90, 17);
            this.rbHealthCheck.TabIndex = 12;
            this.rbHealthCheck.Text = "Health Check";
            this.rbHealthCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 618);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbHealthCheck);
            this.Controls.Add(this.rbAiringId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoOfAssets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInstances);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtInstances;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoOfAssets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbAiringId;
        private System.Windows.Forms.RadioButton rbHealthCheck;
        private System.Windows.Forms.Button button2;
    }
}

