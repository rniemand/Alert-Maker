namespace Alert_Maker
{
    partial class AlertMakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertMakerForm));
            this.button_createAlert = new System.Windows.Forms.Button();
            this.textBox_alertID = new System.Windows.Forms.TextBox();
            this.richTextBox_alertText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_eventLog = new System.Windows.Forms.ComboBox();
            this.comboBox_severity = new System.Windows.Forms.ComboBox();
            this.textBox_eventSource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Output = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_createAlert
            // 
            this.button_createAlert.Location = new System.Drawing.Point(77, 230);
            this.button_createAlert.Name = "button_createAlert";
            this.button_createAlert.Size = new System.Drawing.Size(195, 38);
            this.button_createAlert.TabIndex = 0;
            this.button_createAlert.Text = "Create Event";
            this.button_createAlert.UseVisualStyleBackColor = true;
            this.button_createAlert.Click += new System.EventHandler(this.CreateAlertClick);
            // 
            // textBox_alertID
            // 
            this.textBox_alertID.Location = new System.Drawing.Point(77, 92);
            this.textBox_alertID.Name = "textBox_alertID";
            this.textBox_alertID.Size = new System.Drawing.Size(195, 20);
            this.textBox_alertID.TabIndex = 1;
            this.textBox_alertID.Text = "100";
            // 
            // richTextBox_alertText
            // 
            this.richTextBox_alertText.Location = new System.Drawing.Point(77, 118);
            this.richTextBox_alertText.Name = "richTextBox_alertText";
            this.richTextBox_alertText.Size = new System.Drawing.Size(195, 93);
            this.richTextBox_alertText.TabIndex = 2;
            this.richTextBox_alertText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alert ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alert Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event Log:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Severity:";
            // 
            // comboBox_eventLog
            // 
            this.comboBox_eventLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eventLog.FormattingEnabled = true;
            this.comboBox_eventLog.Location = new System.Drawing.Point(77, 12);
            this.comboBox_eventLog.Name = "comboBox_eventLog";
            this.comboBox_eventLog.Size = new System.Drawing.Size(195, 21);
            this.comboBox_eventLog.TabIndex = 7;
            // 
            // comboBox_severity
            // 
            this.comboBox_severity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_severity.FormattingEnabled = true;
            this.comboBox_severity.Location = new System.Drawing.Point(77, 39);
            this.comboBox_severity.Name = "comboBox_severity";
            this.comboBox_severity.Size = new System.Drawing.Size(195, 21);
            this.comboBox_severity.TabIndex = 8;
            // 
            // textBox_eventSource
            // 
            this.textBox_eventSource.Location = new System.Drawing.Point(77, 66);
            this.textBox_eventSource.Name = "textBox_eventSource";
            this.textBox_eventSource.Size = new System.Drawing.Size(195, 20);
            this.textBox_eventSource.TabIndex = 9;
            this.textBox_eventSource.Text = "My Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Source:";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(74, 214);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(35, 13);
            this.label_Output.TabIndex = 11;
            this.label_Output.Text = "label6";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 230);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(59, 38);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.CloseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_eventSource);
            this.Controls.Add(this.comboBox_severity);
            this.Controls.Add(this.comboBox_eventLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_alertText);
            this.Controls.Add(this.textBox_alertID);
            this.Controls.Add(this.button_createAlert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 318);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 318);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert Creater - Richard Niemand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_createAlert;
        private System.Windows.Forms.TextBox textBox_alertID;
        private System.Windows.Forms.RichTextBox richTextBox_alertText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_eventLog;
        private System.Windows.Forms.ComboBox comboBox_severity;
        private System.Windows.Forms.TextBox textBox_eventSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Button button_close;
    }
}

