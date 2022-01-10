namespace ISO_To_CHD_Converter
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenSourceDir = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.checkedListBoxImages = new System.Windows.Forms.CheckedListBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxConditions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOpenSourceDir
            // 
            this.buttonOpenSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenSourceDir.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenSourceDir.Image")));
            this.buttonOpenSourceDir.Location = new System.Drawing.Point(416, 43);
            this.buttonOpenSourceDir.Name = "buttonOpenSourceDir";
            this.buttonOpenSourceDir.Size = new System.Drawing.Size(65, 23);
            this.buttonOpenSourceDir.TabIndex = 0;
            this.buttonOpenSourceDir.UseVisualStyleBackColor = true;
            this.buttonOpenSourceDir.Click += new System.EventHandler(this.buttonOpenSourceDir_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.Location = new System.Drawing.Point(15, 45);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(395, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder containing Bin/Cue images";
            // 
            // checkBoxIncludeSubfolders
            // 
            this.checkBoxIncludeSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIncludeSubfolders.AutoSize = true;
            this.checkBoxIncludeSubfolders.Checked = true;
            this.checkBoxIncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeSubfolders.Location = new System.Drawing.Point(487, 47);
            this.checkBoxIncludeSubfolders.Name = "checkBoxIncludeSubfolders";
            this.checkBoxIncludeSubfolders.Size = new System.Drawing.Size(112, 17);
            this.checkBoxIncludeSubfolders.TabIndex = 3;
            this.checkBoxIncludeSubfolders.Text = "Include subfolders";
            this.checkBoxIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxImages
            // 
            this.checkedListBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxImages.FormattingEnabled = true;
            this.checkedListBoxImages.Location = new System.Drawing.Point(15, 131);
            this.checkedListBoxImages.Name = "checkedListBoxImages";
            this.checkedListBoxImages.Size = new System.Drawing.Size(587, 289);
            this.checkedListBoxImages.TabIndex = 4;
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(15, 428);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(71, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output Folder";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(15, 445);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(398, 20);
            this.textBoxOutput.TabIndex = 6;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutput.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutput.Image")));
            this.buttonOutput.Location = new System.Drawing.Point(419, 443);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(65, 23);
            this.buttonOutput.TabIndex = 5;
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConvert.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvert.Image")));
            this.buttonConvert.Location = new System.Drawing.Point(15, 500);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(117, 49);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Image = ((System.Drawing.Image)(resources.GetObject("buttonImport.Image")));
            this.buttonImport.Location = new System.Drawing.Point(15, 71);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(114, 54);
            this.buttonImport.TabIndex = 9;
            this.buttonImport.Text = "Import";
            this.buttonImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Checked = true;
            this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll.Location = new System.Drawing.Point(135, 108);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(71, 17);
            this.checkBoxAll.TabIndex = 10;
            this.checkBoxAll.Text = "Check All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(77, 479);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(52, 13);
            this.labelCurrent.TabIndex = 11;
            this.labelCurrent.Text = "No image";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(15, 479);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(61, 13);
            this.labelImage.TabIndex = 12;
            this.labelImage.Text = "Converting:";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(259, 105);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilter.TabIndex = 13;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(487, 104);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(48, 21);
            this.buttonFilter.TabIndex = 14;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxConditions
            // 
            this.comboBoxConditions.FormattingEnabled = true;
            this.comboBoxConditions.Items.AddRange(new object[] {
            "Begins with",
            "Contains"});
            this.comboBoxConditions.Location = new System.Drawing.Point(365, 104);
            this.comboBoxConditions.Name = "comboBoxConditions";
            this.comboBoxConditions.Size = new System.Drawing.Size(108, 21);
            this.comboBoxConditions.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 561);
            this.Controls.Add(this.comboBoxConditions);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.checkedListBoxImages);
            this.Controls.Add(this.checkBoxIncludeSubfolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonOpenSourceDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "CHD Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenSourceDir;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxIncludeSubfolders;
        private System.Windows.Forms.CheckedListBox checkedListBoxImages;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxConditions;
    }
}

