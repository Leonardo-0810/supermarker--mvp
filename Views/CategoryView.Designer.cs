namespace Supermarker_mvp.Views
{
    partial class CategoryView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCategoryDetail = new System.Windows.Forms.TabPage();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtCategoryDescription = new System.Windows.Forms.TextBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.TxtCategoryId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageCategoryList = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgCategory = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageCategoryDetail.SuspendLayout();
            this.tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategory)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarker_mvp.Properties.Resources.buy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // tabPageCategoryDetail
            // 
            this.tabPageCategoryDetail.Controls.Add(this.BtnCancel);
            this.tabPageCategoryDetail.Controls.Add(this.BtnSave);
            this.tabPageCategoryDetail.Controls.Add(this.TxtCategoryDescription);
            this.tabPageCategoryDetail.Controls.Add(this.TxtCategoryName);
            this.tabPageCategoryDetail.Controls.Add(this.TxtCategoryId);
            this.tabPageCategoryDetail.Controls.Add(this.label5);
            this.tabPageCategoryDetail.Controls.Add(this.label4);
            this.tabPageCategoryDetail.Controls.Add(this.label3);
            this.tabPageCategoryDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            this.tabPageCategoryDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategoryDetail.Size = new System.Drawing.Size(792, 324);
            this.tabPageCategoryDetail.TabIndex = 1;
            this.tabPageCategoryDetail.Text = "Category Detail";
            this.tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarker_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(131, 237);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 46);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarker_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(21, 237);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(73, 46);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            this.TxtCategoryDescription.Location = new System.Drawing.Point(21, 132);
            this.TxtCategoryDescription.Multiline = true;
            this.TxtCategoryDescription.Name = "TxtCategoryDescription";
            this.TxtCategoryDescription.Size = new System.Drawing.Size(219, 80);
            this.TxtCategoryDescription.TabIndex = 7;
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(21, 83);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.TxtCategoryName.TabIndex = 5;
            // 
            // TxtCategoryId
            // 
            this.TxtCategoryId.Location = new System.Drawing.Point(21, 36);
            this.TxtCategoryId.Name = "TxtCategoryId";
            this.TxtCategoryId.ReadOnly = true;
            this.TxtCategoryId.Size = new System.Drawing.Size(100, 20);
            this.TxtCategoryId.TabIndex = 3;
            this.TxtCategoryId.Text = "0";
            this.TxtCategoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pay Mode Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pay Mode Id";
            // 
            // tabPageCategoryList
            // 
            this.tabPageCategoryList.Controls.Add(this.BtnClose);
            this.tabPageCategoryList.Controls.Add(this.BtnNew);
            this.tabPageCategoryList.Controls.Add(this.BtnEdit);
            this.tabPageCategoryList.Controls.Add(this.BtnDelete);
            this.tabPageCategoryList.Controls.Add(this.DgCategory);
            this.tabPageCategoryList.Controls.Add(this.BtnSearch);
            this.tabPageCategoryList.Controls.Add(this.TxtSearch);
            this.tabPageCategoryList.Controls.Add(this.label2);
            this.tabPageCategoryList.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoryList.Name = "tabPageCategoryList";
            this.tabPageCategoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategoryList.Size = new System.Drawing.Size(792, 324);
            this.tabPageCategoryList.TabIndex = 0;
            this.tabPageCategoryList.Text = "Category List";
            this.tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Image = global::Supermarker_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(676, 231);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 53);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Image = global::Supermarker_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(676, 47);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 53);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Image = global::Supermarker_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(676, 106);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 55);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Image = global::Supermarker_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(676, 167);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 58);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            this.DgCategory.AllowUserToAddRows = false;
            this.DgCategory.AllowUserToDeleteRows = false;
            this.DgCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCategory.Location = new System.Drawing.Point(11, 120);
            this.DgCategory.Name = "DgCategory";
            this.DgCategory.ReadOnly = true;
            this.DgCategory.Size = new System.Drawing.Size(562, 180);
            this.DgCategory.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(498, 47);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(11, 49);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(461, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCategoryList);
            this.tabControl1.Controls.Add(this.tabPageCategoryDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 350);
            this.tabControl1.TabIndex = 4;
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryView";
            this.Text = "CategoryView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageCategoryDetail.ResumeLayout(false);
            this.tabPageCategoryDetail.PerformLayout();
            this.tabPageCategoryList.ResumeLayout(false);
            this.tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategory)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCategoryDetail;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtCategoryDescription;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.TextBox TxtCategoryId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageCategoryList;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgCategory;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}