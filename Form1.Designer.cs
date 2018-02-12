namespace EventGridWindowsFormsApp
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
            this.sendEventButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EventTopicTextBox = new System.Windows.Forms.TextBox();
            this.EventTopicLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendEventButton
            // 
            this.sendEventButton.Location = new System.Drawing.Point(32, 117);
            this.sendEventButton.Name = "sendEventButton";
            this.sendEventButton.Size = new System.Drawing.Size(75, 23);
            this.sendEventButton.TabIndex = 0;
            this.sendEventButton.Text = "Send Event";
            this.sendEventButton.UseVisualStyleBackColor = true;
            this.sendEventButton.Click += new System.EventHandler(this.sendEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Grid Tester";
            // 
            // EventTopicTextBox
            // 
            this.EventTopicTextBox.Location = new System.Drawing.Point(35, 79);
            this.EventTopicTextBox.Name = "EventTopicTextBox";
            this.EventTopicTextBox.Size = new System.Drawing.Size(512, 20);
            this.EventTopicTextBox.TabIndex = 2;
            // 
            // EventTopicLabel
            // 
            this.EventTopicLabel.AutoSize = true;
            this.EventTopicLabel.Location = new System.Drawing.Point(38, 60);
            this.EventTopicLabel.Name = "EventTopicLabel";
            this.EventTopicLabel.Size = new System.Drawing.Size(65, 13);
            this.EventTopicLabel.TabIndex = 3;
            this.EventTopicLabel.Text = "Event Topic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 352);
            this.Controls.Add(this.EventTopicLabel);
            this.Controls.Add(this.EventTopicTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendEventButton);
            this.Name = "Form1";
            this.Text = "Event Grid Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendEventButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventTopicTextBox;
        private System.Windows.Forms.Label EventTopicLabel;
    }
}

