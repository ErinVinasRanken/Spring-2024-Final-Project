namespace FinalProjectApp
{
    partial class HelpPage
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
            lblInstructions = new Label();
            btnSplashScreen = new Button();
            button3 = new Button();
            btnExit = new Button();
            btnMainPage = new Button();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.BackColor = SystemColors.Control;
            lblInstructions.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(42, 38);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(887, 423);
            lblInstructions.TabIndex = 0;
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnSplashScreen.Location = new Point(42, 508);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new Size(180, 40);
            btnSplashScreen.TabIndex = 1;
            btnSplashScreen.Text = "Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = true;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            button3.Location = new Point(394, 508);
            button3.Name = "button3";
            button3.Size = new Size(180, 40);
            button3.TabIndex = 2;
            button3.Text = "button2";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(749, 508);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnMainPage.Location = new Point(394, 508);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(180, 40);
            btnMainPage.TabIndex = 2;
            btnMainPage.Text = "Main Page";
            btnMainPage.UseVisualStyleBackColor = true;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // HelpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 575);
            Controls.Add(btnMainPage);
            Controls.Add(btnExit);
            Controls.Add(button3);
            Controls.Add(btnSplashScreen);
            Controls.Add(lblInstructions);
            Name = "HelpPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help Page";
            Load += HelpPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblInstructions;
        private Button btnSplashScreen;
        private Button button3;
        private Button btnExit;
        private Button btnMainPage;
    }
}