namespace FinalProjectApp
{
    partial class SearchPage
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
            pbResult = new PictureBox();
            lblTitle = new Label();
            lblYear = new Label();
            lblISBN = new Label();
            lblISBNNumber = new Label();
            lblBy = new Label();
            lblAuthor = new Label();
            btnSplashScreen = new Button();
            btnMainPage = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            SuspendLayout();
            // 
            // pbResult
            // 
            pbResult.Location = new Point(39, 31);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(263, 335);
            pbResult.TabIndex = 0;
            pbResult.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblTitle.Location = new Point(344, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(442, 39);
            lblTitle.TabIndex = 1;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            lblYear.BackColor = SystemColors.Control;
            lblYear.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblYear.Location = new Point(848, 60);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(131, 39);
            lblYear.TabIndex = 2;
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblISBN
            // 
            lblISBN.BackColor = SystemColors.Control;
            lblISBN.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblISBN.Location = new Point(344, 191);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(106, 39);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            lblISBN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblISBNNumber
            // 
            lblISBNNumber.BackColor = SystemColors.Control;
            lblISBNNumber.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblISBNNumber.Location = new Point(530, 191);
            lblISBNNumber.Name = "lblISBNNumber";
            lblISBNNumber.Size = new Size(256, 39);
            lblISBNNumber.TabIndex = 4;
            lblISBNNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBy
            // 
            lblBy.BackColor = SystemColors.Control;
            lblBy.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblBy.Location = new Point(334, 327);
            lblBy.Name = "lblBy";
            lblBy.Size = new Size(106, 39);
            lblBy.TabIndex = 5;
            lblBy.Text = "By:";
            lblBy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.BackColor = SystemColors.Control;
            lblAuthor.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            lblAuthor.Location = new Point(520, 327);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(256, 39);
            lblAuthor.TabIndex = 6;
            lblAuthor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSplashScreen.Location = new Point(29, 455);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new Size(185, 39);
            btnSplashScreen.TabIndex = 12;
            btnSplashScreen.Text = "Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = true;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnMainPage.Location = new Point(291, 455);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(185, 39);
            btnMainPage.TabIndex = 13;
            btnMainPage.Text = "Main Page";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnHelp.Location = new Point(570, 455);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(185, 39);
            btnHelp.TabIndex = 14;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(818, 455);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(185, 39);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SearchPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 553);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(btnMainPage);
            Controls.Add(btnSplashScreen);
            Controls.Add(lblAuthor);
            Controls.Add(lblBy);
            Controls.Add(lblISBNNumber);
            Controls.Add(lblISBN);
            Controls.Add(lblYear);
            Controls.Add(lblTitle);
            Controls.Add(pbResult);
            Name = "SearchPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Page";
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbResult;
        private Label lblTitle;
        private Label lblYear;
        private Label lblISBN;
        private Label lblISBNNumber;
        private Label lblBy;
        private Label lblAuthor;
        private Button btnSplashScreen;
        private Button btnMainPage;
        private Button btnHelp;
        private Button btnExit;
    }
}