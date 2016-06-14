namespace CsRSS
{
    partial class Add_Url
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
            this.URL_ListBox = new System.Windows.Forms.ListBox();
            this.URL_TextBox = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL_ListBox
            // 
            this.URL_ListBox.FormattingEnabled = true;
            this.URL_ListBox.ItemHeight = 16;
            this.URL_ListBox.Location = new System.Drawing.Point(17, 48);
            this.URL_ListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URL_ListBox.Name = "URL_ListBox";
            this.URL_ListBox.Size = new System.Drawing.Size(296, 340);
            this.URL_ListBox.TabIndex = 2;
            // 
            // URL_TextBox
            // 
            this.URL_TextBox.Location = new System.Drawing.Point(17, 16);
            this.URL_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URL_TextBox.Name = "URL_TextBox";
            this.URL_TextBox.Size = new System.Drawing.Size(296, 22);
            this.URL_TextBox.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(321, 10);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(100, 28);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(321, 48);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(100, 28);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // Add_Url
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 407);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.URL_TextBox);
            this.Controls.Add(this.URL_ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 446);
            this.MinimumSize = new System.Drawing.Size(450, 446);
            this.Name = "Add_Url";
            this.ShowIcon = false;
            this.Text = "Add_Url";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Url_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox URL_ListBox;
        private System.Windows.Forms.TextBox URL_TextBox;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
    }
}