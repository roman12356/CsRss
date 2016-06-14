namespace CsRSS
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
            this.buttonURL = new System.Windows.Forms.Button();
            this.TitlescomboBox = new System.Windows.Forms.ComboBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.URLcomboBox = new System.Windows.Forms.ComboBox();
            this.buttonDodajKanal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonURL
            // 
            this.buttonURL.Location = new System.Drawing.Point(491, 15);
            this.buttonURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonURL.Name = "buttonURL";
            this.buttonURL.Size = new System.Drawing.Size(100, 28);
            this.buttonURL.TabIndex = 1;
            this.buttonURL.Text = "Odśwież";
            this.buttonURL.UseVisualStyleBackColor = true;
            this.buttonURL.Click += new System.EventHandler(this.buttonURL_Click);
            // 
            // TitlescomboBox
            // 
            this.TitlescomboBox.FormattingEnabled = true;
            this.TitlescomboBox.Location = new System.Drawing.Point(16, 90);
            this.TitlescomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitlescomboBox.Name = "TitlescomboBox";
            this.TitlescomboBox.Size = new System.Drawing.Size(467, 24);
            this.TitlescomboBox.TabIndex = 2;
            this.TitlescomboBox.Text = "Tytuł RSS";
            this.TitlescomboBox.SelectedIndexChanged += new System.EventHandler(this.TitlescomboBox_SelectedIndexChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptiontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptiontextBox.Location = new System.Drawing.Point(16, 144);
            this.DescriptiontextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.ReadOnly = true;
            this.DescriptiontextBox.Size = new System.Drawing.Size(467, 376);
            this.DescriptiontextBox.TabIndex = 3;
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Location = new System.Drawing.Point(492, 144);
            this.buttonGoTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(100, 28);
            this.buttonGoTo.TabIndex = 4;
            this.buttonGoTo.Text = "Idź do...";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // URLcomboBox
            // 
            this.URLcomboBox.FormattingEnabled = true;
            this.URLcomboBox.Location = new System.Drawing.Point(16, 15);
            this.URLcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URLcomboBox.Name = "URLcomboBox";
            this.URLcomboBox.Size = new System.Drawing.Size(465, 24);
            this.URLcomboBox.TabIndex = 5;
            // 
            // buttonDodajKanal
            // 
            this.buttonDodajKanal.Location = new System.Drawing.Point(492, 48);
            this.buttonDodajKanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodajKanal.Name = "buttonDodajKanal";
            this.buttonDodajKanal.Size = new System.Drawing.Size(100, 28);
            this.buttonDodajKanal.TabIndex = 6;
            this.buttonDodajKanal.Text = "Dodaj kanał";
            this.buttonDodajKanal.UseVisualStyleBackColor = true;
            this.buttonDodajKanal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 535);
            this.Controls.Add(this.buttonDodajKanal);
            this.Controls.Add(this.URLcomboBox);
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.TitlescomboBox);
            this.Controls.Add(this.buttonURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RSS Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonURL;
        private System.Windows.Forms.ComboBox TitlescomboBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.ComboBox URLcomboBox;
        private System.Windows.Forms.Button buttonDodajKanal;
    }
}

