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
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.listBoxData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(35, 43);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(126, 316);
            this.listBoxData.TabIndex = 0;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(194, 80);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 30);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblEditIndex
            // 
            this.lblEditIndex.AutoSize = true;
            this.lblEditIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditIndex.Location = new System.Drawing.Point(205, 167);
            this.lblEditIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditIndex.Name = "lblEditIndex";
            this.lblEditIndex.Size = new System.Drawing.Size(78, 30);
            this.lblEditIndex.TabIndex = 2;
            this.lblEditIndex.Text = "Index";
            // 
            // lblEditValue
            // 
            this.lblEditValue.AutoSize = true;
            this.lblEditValue.Location = new System.Drawing.Point(207, 252);
            this.lblEditValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditValue.Name = "lblEditValue";
            this.lblEditValue.Size = new System.Drawing.Size(83, 30);
            this.lblEditValue.TabIndex = 3;
            this.lblEditValue.Text = "Value";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(292, 76);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(216, 37);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxEditIndex
            // 
            this.textBoxEditIndex.Location = new System.Drawing.Point(288, 160);
            this.textBoxEditIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEditIndex.Name = "textBoxEditIndex";
            this.textBoxEditIndex.Size = new System.Drawing.Size(216, 37);
            this.textBoxEditIndex.TabIndex = 5;
            this.textBoxEditIndex.TextChanged += new System.EventHandler(this.textBoxEditIndex_TextChanged);
            // 
            // textBoxEditValue
            // 
            this.textBoxEditValue.Location = new System.Drawing.Point(288, 249);
            this.textBoxEditValue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEditValue.Name = "textBoxEditValue";
            this.textBoxEditValue.Size = new System.Drawing.Size(211, 37);
            this.textBoxEditValue.TabIndex = 6;
            this.textBoxEditValue.TextChanged += new System.EventHandler(this.textBoxEditValue_TextChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSort.Location = new System.Drawing.Point(35, 486);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(140, 60);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(221, 486);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 60);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(412, 486);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(144, 60);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Astronomic.Properties.Resources._5815e12cacb43391232acc0cadeee1d3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 626);
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
            this.Text = "Astronomic ";
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
    }
}

