namespace FinalProjectApp
{
    partial class FinalProject
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
            lblSearchBy = new Label();
            lblAuthor = new Label();
            txtSearch = new TextBox();
            cbAuthor = new ComboBox();
            btnSearch = new Button();
            dgResults = new DataGridView();
            dgISBN = new DataGridViewTextBoxColumn();
            dgName = new DataGridViewTextBoxColumn();
            dgAuthor = new DataGridViewTextBoxColumn();
            dgYear = new DataGridViewTextBoxColumn();
            dgDetails = new DataGridViewTextBoxColumn();
            btnSplashScreen = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgResults).BeginInit();
            SuspendLayout();
            // 
            // lblSearchBy
            // 
            lblSearchBy.BackColor = Color.FromArgb(224, 224, 224);
            lblSearchBy.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblSearchBy.Location = new Point(57, 36);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(272, 33);
            lblSearchBy.TabIndex = 0;
            lblSearchBy.Text = "Search By Name Or ISBN:";
            lblSearchBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = Color.FromArgb(224, 224, 224);
            lblAuthor.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            lblAuthor.Location = new Point(444, 36);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(265, 33);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            txtSearch.Location = new Point(57, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(272, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(444, 99);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(265, 32);
            cbAuthor.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnSearch.Location = new Point(762, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(130, 39);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgResults
            // 
            dgResults.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResults.Columns.AddRange(new DataGridViewColumn[] { dgISBN, dgName, dgAuthor, dgYear, dgDetails });
            dgResults.Location = new Point(133, 170);
            dgResults.Name = "dgResults";
            dgResults.Size = new Size(543, 245);
            dgResults.TabIndex = 7;
            // 
            // dgISBN
            // 
            dgISBN.HeaderText = "ISBN";
            dgISBN.Name = "dgISBN";
            dgISBN.ReadOnly = true;
            // 
            // dgName
            // 
            dgName.HeaderText = "Name";
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            // 
            // dgAuthor
            // 
            dgAuthor.HeaderText = "Author";
            dgAuthor.Name = "dgAuthor";
            dgAuthor.ReadOnly = true;
            // 
            // dgYear
            // 
            dgYear.HeaderText = "Year";
            dgYear.Name = "dgYear";
            dgYear.ReadOnly = true;
            // 
            // dgDetails
            // 
            dgDetails.HeaderText = "Details";
            dgDetails.Name = "dgDetails";
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSplashScreen.Location = new Point(22, 471);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new Size(183, 43);
            btnSplashScreen.TabIndex = 8;
            btnSplashScreen.Text = "Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = true;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnHelp.Location = new Point(352, 471);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(183, 43);
            btnHelp.TabIndex = 9;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(762, 473);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 41);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FinalProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(920, 535);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(btnSplashScreen);
            Controls.Add(dgResults);
            Controls.Add(btnSearch);
            Controls.Add(cbAuthor);
            Controls.Add(txtSearch);
            Controls.Add(lblAuthor);
            Controls.Add(lblSearchBy);
            Name = "FinalProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Final Project";
            Load += FinalProject_Load;
            ((System.ComponentModel.ISupportInitialize)dgResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchBy;
        private Label lblAuthor;
        private TextBox txtSearch;
        private ComboBox cbAuthor;
        private Button btnSearch;
        //private Button btnClear;
        private DataGridView dgResults;
        private Button btnSplashScreen;
        private Button btnHelp;
        private Button btnExit;
        private DataGridViewTextBoxColumn dgISBN;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgAuthor;
        private DataGridViewTextBoxColumn dgYear;
        private DataGridViewTextBoxColumn dgDetails;
    }
}
