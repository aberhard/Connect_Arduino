namespace Connect_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.ButtonVerbinden = new System.Windows.Forms.Button();
            this.ButtonTrennen = new System.Windows.Forms.Button();
            this.ButtonBlinken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(31, 31);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(34, 67);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "COM3";
            // 
            // ButtonVerbinden
            // 
            this.ButtonVerbinden.Location = new System.Drawing.Point(170, 63);
            this.ButtonVerbinden.Name = "ButtonVerbinden";
            this.ButtonVerbinden.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerbinden.TabIndex = 2;
            this.ButtonVerbinden.Text = "verbinden";
            this.ButtonVerbinden.UseVisualStyleBackColor = true;
            // 
            // ButtonTrennen
            // 
            this.ButtonTrennen.Location = new System.Drawing.Point(281, 63);
            this.ButtonTrennen.Name = "ButtonTrennen";
            this.ButtonTrennen.Size = new System.Drawing.Size(75, 23);
            this.ButtonTrennen.TabIndex = 2;
            this.ButtonTrennen.Text = "trennen";
            this.ButtonTrennen.UseVisualStyleBackColor = true;
            // 
            // ButtonBlinken
            // 
            this.ButtonBlinken.Location = new System.Drawing.Point(170, 105);
            this.ButtonBlinken.Name = "ButtonBlinken";
            this.ButtonBlinken.Size = new System.Drawing.Size(75, 23);
            this.ButtonBlinken.TabIndex = 2;
            this.ButtonBlinken.Text = "blinken";
            this.ButtonBlinken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 192);
            this.Controls.Add(this.ButtonBlinken);
            this.Controls.Add(this.ButtonTrennen);
            this.Controls.Add(this.ButtonVerbinden);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.lblPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button ButtonVerbinden;
        private System.Windows.Forms.Button ButtonTrennen;
        private System.Windows.Forms.Button ButtonBlinken;
    }
}

