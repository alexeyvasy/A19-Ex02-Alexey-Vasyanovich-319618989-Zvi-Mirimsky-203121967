namespace FacebookApp
{
    public partial class FormAdvancedSearcher
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
        public void InitializeComponent()
        {
            this.buttonSeearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxEvents = new System.Windows.Forms.CheckBox();
            this.checkBoxGroups = new System.Windows.Forms.CheckBox();
            this.checkBoxFriends = new System.Windows.Forms.CheckBox();
            this.textBoxKeyPhrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownEndAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartAge = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxUserGroups = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSeearch
            // 
            this.buttonSeearch.Location = new System.Drawing.Point(621, 711);
            this.buttonSeearch.Name = "buttonSeearch";
            this.buttonSeearch.Size = new System.Drawing.Size(91, 45);
            this.buttonSeearch.TabIndex = 2;
            this.buttonSeearch.Text = "Search";
            this.buttonSeearch.UseVisualStyleBackColor = true;
            this.buttonSeearch.Click += new System.EventHandler(this.buttonSeearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMale);
            this.groupBox1.Controls.Add(this.checkBoxFemale);
            this.groupBox1.Location = new System.Drawing.Point(36, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender:";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Location = new System.Drawing.Point(21, 57);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(69, 24);
            this.checkBoxMale.TabIndex = 1;
            this.checkBoxMale.Text = "male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Checked = true;
            this.checkBoxFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFemale.Location = new System.Drawing.Point(21, 26);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(83, 24);
            this.checkBoxFemale.TabIndex = 0;
            this.checkBoxFemale.Text = "female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxEvents);
            this.groupBox2.Controls.Add(this.checkBoxGroups);
            this.groupBox2.Controls.Add(this.checkBoxFriends);
            this.groupBox2.Location = new System.Drawing.Point(36, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search in:";
            // 
            // checkBoxEvents
            // 
            this.checkBoxEvents.AutoSize = true;
            this.checkBoxEvents.Location = new System.Drawing.Point(21, 88);
            this.checkBoxEvents.Name = "checkBoxEvents";
            this.checkBoxEvents.Size = new System.Drawing.Size(84, 24);
            this.checkBoxEvents.TabIndex = 2;
            this.checkBoxEvents.Text = "Events";
            this.checkBoxEvents.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroups
            // 
            this.checkBoxGroups.AutoSize = true;
            this.checkBoxGroups.Location = new System.Drawing.Point(21, 57);
            this.checkBoxGroups.Name = "checkBoxGroups";
            this.checkBoxGroups.Size = new System.Drawing.Size(88, 24);
            this.checkBoxGroups.TabIndex = 1;
            this.checkBoxGroups.Text = "Groups";
            this.checkBoxGroups.UseVisualStyleBackColor = true;
            this.checkBoxGroups.CheckedChanged += new System.EventHandler(this.checkBoxGroups_CheckedChanged);
            // 
            // checkBoxFriends
            // 
            this.checkBoxFriends.AutoSize = true;
            this.checkBoxFriends.Location = new System.Drawing.Point(21, 26);
            this.checkBoxFriends.Name = "checkBoxFriends";
            this.checkBoxFriends.Size = new System.Drawing.Size(88, 24);
            this.checkBoxFriends.TabIndex = 0;
            this.checkBoxFriends.Text = "Friends";
            this.checkBoxFriends.UseVisualStyleBackColor = true;
            // 
            // textBoxKeyPhrase
            // 
            this.textBoxKeyPhrase.Location = new System.Drawing.Point(36, 502);
            this.textBoxKeyPhrase.Name = "textBoxKeyPhrase";
            this.textBoxKeyPhrase.Size = new System.Drawing.Size(303, 26);
            this.textBoxKeyPhrase.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key Phrase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "To:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownEndAge);
            this.groupBox3.Controls.Add(this.numericUpDownStartAge);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(36, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 115);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // numericUpDownEndAge
            // 
            this.numericUpDownEndAge.Location = new System.Drawing.Point(201, 52);
            this.numericUpDownEndAge.Name = "numericUpDownEndAge";
            this.numericUpDownEndAge.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownEndAge.TabIndex = 13;
            this.numericUpDownEndAge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownStartAge
            // 
            this.numericUpDownStartAge.Location = new System.Drawing.Point(62, 52);
            this.numericUpDownStartAge.Name = "numericUpDownStartAge";
            this.numericUpDownStartAge.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownStartAge.TabIndex = 12;
            // 
            // checkedListBoxUserGroups
            // 
            this.checkedListBoxUserGroups.FormattingEnabled = true;
            this.checkedListBoxUserGroups.Location = new System.Drawing.Point(346, 42);
            this.checkedListBoxUserGroups.Name = "checkedListBoxUserGroups";
            this.checkedListBoxUserGroups.Size = new System.Drawing.Size(255, 319);
            this.checkedListBoxUserGroups.TabIndex = 13;
            this.checkedListBoxUserGroups.Visible = false;
            // 
            // FormAdvancedSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 786);
            this.Controls.Add(this.checkedListBoxUserGroups);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKeyPhrase);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSeearch);
            this.Name = "FormAdvancedSearcher";
            this.Text = "FormAdvancedSearcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSeearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxEvents;
        private System.Windows.Forms.CheckBox checkBoxGroups;
        private System.Windows.Forms.CheckBox checkBoxFriends;
        private System.Windows.Forms.TextBox textBoxKeyPhrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.NumericUpDown numericUpDownEndAge;
        private System.Windows.Forms.NumericUpDown numericUpDownStartAge;
        private System.Windows.Forms.CheckedListBox checkedListBoxUserGroups;
    }
}