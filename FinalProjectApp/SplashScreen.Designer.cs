namespace FinalProjectApp
{
    partial class SplashScreen
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
            lblTitle = new Label();
            lblSylviaPLath = new Label();
            lblStephenKing = new Label();
            lblJhumpaLahiri = new Label();
            pbSylviaPlath = new PictureBox();
            pbJhumpaLahiri = new PictureBox();
            pbStephenKing = new PictureBox();
            btnMainPage = new Button();
            btnHelp = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSylviaPlath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbJhumpaLahiri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStephenKing).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(435, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(455, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "3 Authors And Some Of Their Books";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSylviaPLath
            // 
            lblSylviaPLath.BackColor = SystemColors.Control;
            lblSylviaPLath.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSylviaPLath.Location = new Point(80, 269);
            lblSylviaPLath.Name = "lblSylviaPLath";
            lblSylviaPLath.Size = new Size(190, 46);
            lblSylviaPLath.TabIndex = 1;
            lblSylviaPLath.Text = "Sylvia Plath";
            lblSylviaPLath.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStephenKing
            // 
            lblStephenKing.BackColor = SystemColors.Control;
            lblStephenKing.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStephenKing.Location = new Point(565, 433);
            lblStephenKing.Name = "lblStephenKing";
            lblStephenKing.Size = new Size(187, 46);
            lblStephenKing.TabIndex = 2;
            lblStephenKing.Text = "Stephen King";
            lblStephenKing.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblJhumpaLahiri
            // 
            lblJhumpaLahiri.BackColor = SystemColors.Control;
            lblJhumpaLahiri.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJhumpaLahiri.Location = new Point(997, 269);
            lblJhumpaLahiri.Name = "lblJhumpaLahiri";
            lblJhumpaLahiri.Size = new Size(190, 46);
            lblJhumpaLahiri.TabIndex = 3;
            lblJhumpaLahiri.Text = "Jhumpa Lahiri";
            lblJhumpaLahiri.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbSylviaPlath
            // 
            pbSylviaPlath.Location = new Point(80, 56);
            pbSylviaPlath.Name = "pbSylviaPlath";
            pbSylviaPlath.Size = new Size(190, 185);
            pbSylviaPlath.TabIndex = 4;
            pbSylviaPlath.TabStop = false;
            // 
            // pbJhumpaLahiri
            // 
            pbJhumpaLahiri.Location = new Point(997, 56);
            pbJhumpaLahiri.Name = "pbJhumpaLahiri";
            pbJhumpaLahiri.Size = new Size(190, 185);
            pbJhumpaLahiri.TabIndex = 5;
            pbJhumpaLahiri.TabStop = false;
            // 
            // pbStephenKing
            // 
            pbStephenKing.Location = new Point(565, 196);
            pbStephenKing.Name = "pbStephenKing";
            pbStephenKing.Size = new Size(190, 185);
            pbStephenKing.TabIndex = 6;
            pbStephenKing.TabStop = false;
            // 
            // btnMainPage
            // 
            btnMainPage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMainPage.Location = new Point(91, 514);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(133, 41);
            btnMainPage.TabIndex = 7;
            btnMainPage.Text = "Main Page";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnHelp.Location = new Point(607, 525);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(133, 41);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(1095, 525);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 41);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 578);
            Controls.Add(btnExit);
            Controls.Add(btnHelp);
            Controls.Add(btnMainPage);
            Controls.Add(pbStephenKing);
            Controls.Add(pbJhumpaLahiri);
            Controls.Add(pbSylviaPlath);
            Controls.Add(lblJhumpaLahiri);
            Controls.Add(lblStephenKing);
            Controls.Add(lblSylviaPLath);
            Controls.Add(lblTitle);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            ((System.ComponentModel.ISupportInitialize)pbSylviaPlath).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbJhumpaLahiri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStephenKing).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSylviaPLath;
        private Label lblStephenKing;
        private Label lblJhumpaLahiri;
        private PictureBox pbSylviaPlath;
        private PictureBox pbJhumpaLahiri;
        private PictureBox pbStephenKing;
        private Button btnMainPage;
        private Button btnHelp;
        private Button btnExit;
    }
}