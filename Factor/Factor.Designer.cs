namespace Factor
{
    partial class Factor
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.bttnGo = new System.Windows.Forms.Button();
            this.ResultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(120, 14);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(25, 17);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(89, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Number to factor:";
            // 
            // bttnGo
            // 
            this.bttnGo.Location = new System.Drawing.Point(238, 11);
            this.bttnGo.Name = "bttnGo";
            this.bttnGo.Size = new System.Drawing.Size(33, 23);
            this.bttnGo.TabIndex = 2;
            this.bttnGo.Text = "Go";
            this.bttnGo.UseVisualStyleBackColor = true;
            this.bttnGo.Click += new System.EventHandler(this.bttnGo_Click);
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.AutoSize = true;
            this.ResultsPanel.Location = new System.Drawing.Point(13, 58);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(258, 208);
            this.ResultsPanel.TabIndex = 3;
            this.ResultsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultsPanel_Paint);
            // 
            // Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.bttnGo);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputBox);
            this.Name = "Factor";
            this.Text = "Factor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button bttnGo;
        private System.Windows.Forms.FlowLayoutPanel ResultsPanel;
    }
}

