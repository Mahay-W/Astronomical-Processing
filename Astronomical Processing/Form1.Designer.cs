namespace Astronomical_Processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstNeutrinoData = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSort = new Button();
            txtEdit = new TextBox();
            btnApplyEdit = new Button();
            lblStatusMessage = new Label();
            SuspendLayout();
            // 
            // lstNeutrinoData
            // 
            lstNeutrinoData.FormattingEnabled = true;
            lstNeutrinoData.ItemHeight = 25;
            lstNeutrinoData.Location = new Point(24, 37);
            lstNeutrinoData.Name = "lstNeutrinoData";
            lstNeutrinoData.Size = new Size(166, 604);
            lstNeutrinoData.TabIndex = 0;
            lstNeutrinoData.SelectedIndexChanged += lstNeutrinoData_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(231, 106);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(495, 104);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(654, 103);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 3;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(231, 177);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(231, 31);
            txtEdit.TabIndex = 4;
            // 
            // btnApplyEdit
            // 
            btnApplyEdit.Location = new Point(495, 174);
            btnApplyEdit.Name = "btnApplyEdit";
            btnApplyEdit.Size = new Size(112, 34);
            btnApplyEdit.TabIndex = 5;
            btnApplyEdit.Text = "Apply Edit";
            btnApplyEdit.UseVisualStyleBackColor = true;
            btnApplyEdit.Click += btnApplyEdit_Click_1;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Location = new Point(231, 48);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(135, 25);
            lblStatusMessage.TabIndex = 6;
            lblStatusMessage.Text = "Status Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 695);
            Controls.Add(lblStatusMessage);
            Controls.Add(btnApplyEdit);
            Controls.Add(txtEdit);
            Controls.Add(btnSort);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lstNeutrinoData);
            Name = "Form1";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ListBox lstNeutrinoData;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSort;
        private TextBox txtEdit;
        private Button btnApplyEdit;
        private Label lblStatusMessage;
    }
}
