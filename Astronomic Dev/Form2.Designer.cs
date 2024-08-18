namespace Astronomic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblEditIndex = new System.Windows.Forms.Label();
            this.lblEditValue = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxEditIndex = new System.Windows.Forms.TextBox();
            this.textBoxEditValue = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxData.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 22;
            this.listBoxData.Location = new System.Drawing.Point(234, 210);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(144, 334);
            this.listBoxData.TabIndex = 0;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(37, 23);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "VALUE";
            // 
            // lblEditIndex
            // 
            this.lblEditIndex.AutoSize = true;
            this.lblEditIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditIndex.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditIndex.Location = new System.Drawing.Point(13, 89);
            this.lblEditIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditIndex.Name = "lblEditIndex";
            this.lblEditIndex.Size = new System.Drawing.Size(98, 19);
            this.lblEditIndex.TabIndex = 2;
            this.lblEditIndex.Text = "EDIT INDEX";
            // 
            // lblEditValue
            // 
            this.lblEditValue.AutoSize = true;
            this.lblEditValue.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditValue.Location = new System.Drawing.Point(13, 153);
            this.lblEditValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditValue.Name = "lblEditValue";
            this.lblEditValue.Size = new System.Drawing.Size(102, 19);
            this.lblEditValue.TabIndex = 3;
            this.lblEditValue.Text = "NEW VALUE";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxSearch.Location = new System.Drawing.Point(28, 45);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(69, 22);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxEditIndex
            // 
            this.textBoxEditIndex.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxEditIndex.Location = new System.Drawing.Point(28, 111);
            this.textBoxEditIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEditIndex.Name = "textBoxEditIndex";
            this.textBoxEditIndex.Size = new System.Drawing.Size(69, 22);
            this.textBoxEditIndex.TabIndex = 5;
            this.textBoxEditIndex.TextChanged += new System.EventHandler(this.textBoxEditIndex_TextChanged);
            // 
            // textBoxEditValue
            // 
            this.textBoxEditValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxEditValue.Location = new System.Drawing.Point(28, 175);
            this.textBoxEditValue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEditValue.Name = "textBoxEditValue";
            this.textBoxEditValue.Size = new System.Drawing.Size(69, 22);
            this.textBoxEditValue.TabIndex = 6;
            this.textBoxEditValue.TextChanged += new System.EventHandler(this.textBoxEditValue_TextChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(80, 294);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(120, 50);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "SORT";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(179, 31);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 48);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(179, 111);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 48);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(80, 377);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(120, 61);
            this.btnFill.TabIndex = 10;
            this.btnFill.Text = "FILL DATA";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 675);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxEditValue);
            this.Controls.Add(this.textBoxEditIndex);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblEditValue);
            this.Controls.Add(this.lblEditIndex);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.listBoxData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Astronomical Progressing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblEditIndex;
        private System.Windows.Forms.Label lblEditValue;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxEditIndex;
        private System.Windows.Forms.TextBox textBoxEditValue;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button btnFill;
    }
}

