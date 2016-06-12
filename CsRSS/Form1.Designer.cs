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
            this.URLtextBox = new System.Windows.Forms.TextBox();
            this.buttonURL = new System.Windows.Forms.Button();
            this.TitlescomboBox = new System.Windows.Forms.ComboBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.URLcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // URLtextBox
            // 
            this.URLtextBox.Location = new System.Drawing.Point(12, 31);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.Size = new System.Drawing.Size(351, 20);
            this.URLtextBox.TabIndex = 0;
            this.URLtextBox.Text = "RSS URL";
            // 
            // buttonURL
            // 
            this.buttonURL.Location = new System.Drawing.Point(369, 28);
            this.buttonURL.Name = "buttonURL";
            this.buttonURL.Size = new System.Drawing.Size(75, 23);
            this.buttonURL.TabIndex = 1;
            this.buttonURL.Text = "Odśwież";
            this.buttonURL.UseVisualStyleBackColor = true;
            this.buttonURL.Click += new System.EventHandler(this.buttonURL_Click);
            // 
            // TitlescomboBox
            // 
            this.TitlescomboBox.FormattingEnabled = true;
            this.TitlescomboBox.Location = new System.Drawing.Point(12, 73);
            this.TitlescomboBox.Name = "TitlescomboBox";
            this.TitlescomboBox.Size = new System.Drawing.Size(351, 21);
            this.TitlescomboBox.TabIndex = 2;
            this.TitlescomboBox.Text = "Tytuł RSS";
            this.TitlescomboBox.SelectedIndexChanged += new System.EventHandler(this.TitlescomboBox_SelectedIndexChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptiontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptiontextBox.Location = new System.Drawing.Point(12, 117);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.ReadOnly = true;
            this.DescriptiontextBox.Size = new System.Drawing.Size(351, 306);
            this.DescriptiontextBox.TabIndex = 3;
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Location = new System.Drawing.Point(369, 117);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(75, 23);
            this.buttonGoTo.TabIndex = 4;
            this.buttonGoTo.Text = "Idź do...";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // URLcomboBox
            // 
            this.URLcomboBox.FormattingEnabled = true;
            this.URLcomboBox.Location = new System.Drawing.Point(13, 4);
            this.URLcomboBox.Name = "URLcomboBox";
            this.URLcomboBox.Size = new System.Drawing.Size(350, 21);
            this.URLcomboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 435);
            this.Controls.Add(this.URLcomboBox);
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.TitlescomboBox);
            this.Controls.Add(this.buttonURL);
            this.Controls.Add(this.URLtextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RSS Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLtextBox;
        private System.Windows.Forms.Button buttonURL;
        private System.Windows.Forms.ComboBox TitlescomboBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.ComboBox URLcomboBox;
    }
}

