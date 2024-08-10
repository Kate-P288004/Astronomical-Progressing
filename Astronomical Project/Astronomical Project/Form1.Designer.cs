namespace Astronomical_Project
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
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblEditIndex = new System.Windows.Forms.Label();
            this.lblEditValue = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtEditIndex = new System.Windows.Forms.TextBox();
            this.txtEditValue = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.ItemHeight = 25;
            this.lstData.Location = new System.Drawing.Point(58, 410);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(647, 129);
            this.lstData.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(36, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 25);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblEditIndex
            // 
            this.lblEditIndex.AutoSize = true;
            this.lblEditIndex.Location = new System.Drawing.Point(36, 166);
            this.lblEditIndex.Name = "lblEditIndex";
            this.lblEditIndex.Size = new System.Drawing.Size(107, 25);
            this.lblEditIndex.TabIndex = 2;
            this.lblEditIndex.Text = "Edit Index";
            // 
            // lblEditValue
            // 
            this.lblEditValue.AutoSize = true;
            this.lblEditValue.Location = new System.Drawing.Point(36, 295);
            this.lblEditValue.Name = "lblEditValue";
            this.lblEditValue.Size = new System.Drawing.Size(115, 25);
            this.lblEditValue.TabIndex = 3;
            this.lblEditValue.Text = "New Value";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(178, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 31);
            this.txtSearch.TabIndex = 4;
            // 
            // txtEditIndex
            // 
            this.txtEditIndex.Location = new System.Drawing.Point(178, 160);
            this.txtEditIndex.Name = "txtEditIndex";
            this.txtEditIndex.Size = new System.Drawing.Size(100, 31);
            this.txtEditIndex.TabIndex = 5;
            // 
            // txtEditValue
            // 
            this.txtEditValue.Location = new System.Drawing.Point(178, 295);
            this.txtEditValue.Name = "txtEditValue";
            this.txtEditValue.Size = new System.Drawing.Size(100, 31);
            this.txtEditValue.TabIndex = 6;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(295, 617);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(170, 131);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(407, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 122);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(414, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 122);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 844);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtEditValue);
            this.Controls.Add(this.txtEditIndex);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblEditValue);
            this.Controls.Add(this.lblEditIndex);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lstData);
            this.Name = "Form1";
            this.Text = "Astronomic ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblEditIndex;
        private System.Windows.Forms.Label lblEditValue;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtEditIndex;
        private System.Windows.Forms.TextBox txtEditValue;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
    }
}

