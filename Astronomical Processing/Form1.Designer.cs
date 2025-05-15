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
            components = new System.ComponentModel.Container();
            lstNeutrinoData = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSort = new Button();
            txtEdit = new TextBox();
            btnApplyEdit = new Button();
            lblStatusMessage = new Label();
            txtMidExtreme = new TextBox();
            btnMidExtreme = new Button();
            txtMode = new TextBox();
            btnMode = new Button();
            txtAverage = new TextBox();
            btnAverage = new Button();
            txtRange = new TextBox();
            btnRange = new Button();
            toolTip1 = new ToolTip(components);
            btnSequentialSearch = new Button();
            txtSequentialSearch = new TextBox();
            SuspendLayout();
            // 
            // lstNeutrinoData
            // 
            lstNeutrinoData.FormattingEnabled = true;
            lstNeutrinoData.ItemHeight = 15;
            lstNeutrinoData.Location = new Point(17, 22);
            lstNeutrinoData.Margin = new Padding(2);
            lstNeutrinoData.Name = "lstNeutrinoData";
            lstNeutrinoData.Size = new Size(117, 364);
            lstNeutrinoData.TabIndex = 0;
            lstNeutrinoData.SelectedIndexChanged += lstNeutrinoData_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(162, 64);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(346, 62);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 20);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Binary Search";
            toolTip1.SetToolTip(btnSearch, "Click to search using binary search");
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(471, 62);
            btnSort.Margin = new Padding(2);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(78, 20);
            btnSort.TabIndex = 3;
            btnSort.Text = "Sort";
            toolTip1.SetToolTip(btnSort, "Click to sort the data using Bubble Sort");
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(162, 106);
            txtEdit.Margin = new Padding(2);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(163, 23);
            txtEdit.TabIndex = 4;
            // 
            // btnApplyEdit
            // 
            btnApplyEdit.Location = new Point(346, 104);
            btnApplyEdit.Margin = new Padding(2);
            btnApplyEdit.Name = "btnApplyEdit";
            btnApplyEdit.Size = new Size(78, 20);
            btnApplyEdit.TabIndex = 5;
            btnApplyEdit.Text = "Apply Edit";
            toolTip1.SetToolTip(btnApplyEdit, "Click to apply new values");
            btnApplyEdit.UseVisualStyleBackColor = true;
            btnApplyEdit.Click += btnApplyEdit_Click_1;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Location = new Point(273, 9);
            lblStatusMessage.Margin = new Padding(2, 0, 2, 0);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(88, 15);
            lblStatusMessage.TabIndex = 6;
            lblStatusMessage.Text = "Status Message";
            // 
            // txtMidExtreme
            // 
            txtMidExtreme.Location = new Point(162, 146);
            txtMidExtreme.Name = "txtMidExtreme";
            txtMidExtreme.ReadOnly = true;
            txtMidExtreme.Size = new Size(163, 23);
            txtMidExtreme.TabIndex = 7;
            // 
            // btnMidExtreme
            // 
            btnMidExtreme.Location = new Point(346, 145);
            btnMidExtreme.Name = "btnMidExtreme";
            btnMidExtreme.Size = new Size(88, 23);
            btnMidExtreme.TabIndex = 8;
            btnMidExtreme.Text = "MidExtreme";
            toolTip1.SetToolTip(btnMidExtreme, "Calculate and display MidExtreme");
            btnMidExtreme.UseVisualStyleBackColor = true;
            btnMidExtreme.Click += btnMidExtreme_Click;
            // 
            // txtMode
            // 
            txtMode.Location = new Point(162, 193);
            txtMode.Name = "txtMode";
            txtMode.ReadOnly = true;
            txtMode.Size = new Size(163, 23);
            txtMode.TabIndex = 9;
            // 
            // btnMode
            // 
            btnMode.Location = new Point(346, 193);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(88, 23);
            btnMode.TabIndex = 10;
            btnMode.Text = "Mode";
            toolTip1.SetToolTip(btnMode, "Calculate and display the mode (most frequent)");
            btnMode.UseVisualStyleBackColor = true;
            btnMode.Click += btnMode_Click;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(162, 239);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(163, 23);
            txtAverage.TabIndex = 11;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(346, 239);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(88, 23);
            btnAverage.TabIndex = 12;
            btnAverage.Text = "Average";
            toolTip1.SetToolTip(btnAverage, "Calculate the average value");
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // txtRange
            // 
            txtRange.Location = new Point(162, 294);
            txtRange.Name = "txtRange";
            txtRange.ReadOnly = true;
            txtRange.Size = new Size(163, 23);
            txtRange.TabIndex = 13;
            // 
            // btnRange
            // 
            btnRange.Location = new Point(346, 294);
            btnRange.Name = "btnRange";
            btnRange.Size = new Size(88, 23);
            btnRange.TabIndex = 14;
            btnRange.Text = "Range";
            toolTip1.SetToolTip(btnRange, "Calculate and display the range(max-min)");
            btnRange.UseVisualStyleBackColor = true;
            btnRange.Click += btnRange_Click;
            // 
            // btnSequentialSearch
            // 
            btnSequentialSearch.Location = new Point(346, 342);
            btnSequentialSearch.Name = "btnSequentialSearch";
            btnSequentialSearch.Size = new Size(163, 23);
            btnSequentialSearch.TabIndex = 16;
            btnSequentialSearch.Text = "Seqeuential Search";
            toolTip1.SetToolTip(btnSequentialSearch, "Click to display sequential search");
            btnSequentialSearch.UseVisualStyleBackColor = true;
            btnSequentialSearch.Click += btnSequentialSearch_Click;
            // 
            // txtSequentialSearch
            // 
            txtSequentialSearch.Location = new Point(162, 342);
            txtSequentialSearch.Name = "txtSequentialSearch";
            txtSequentialSearch.Size = new Size(163, 23);
            txtSequentialSearch.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 417);
            Controls.Add(btnSequentialSearch);
            Controls.Add(txtSequentialSearch);
            Controls.Add(btnRange);
            Controls.Add(txtRange);
            Controls.Add(btnAverage);
            Controls.Add(txtAverage);
            Controls.Add(btnMode);
            Controls.Add(txtMode);
            Controls.Add(btnMidExtreme);
            Controls.Add(txtMidExtreme);
            Controls.Add(lblStatusMessage);
            Controls.Add(btnApplyEdit);
            Controls.Add(txtEdit);
            Controls.Add(btnSort);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lstNeutrinoData);
            Margin = new Padding(2);
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
        private TextBox txtMidExtreme;
        private Button btnMidExtreme;
        private TextBox txtMode;
        private Button btnMode;
        private TextBox txtAverage;
        private Button btnAverage;
        private TextBox txtRange;
        private Button btnRange;
        private ToolTip toolTip1;
        private TextBox txtSequentialSearch;
        private Button btnSequentialSearch;
    }
}
