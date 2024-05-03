using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectApp
{
    public partial class SplashScreen : Form
    {
        PictureBox picture = new PictureBox(); // Declare the PictureBox outside of any method

        public SplashScreen()
        {
            InitializeComponent();
            InitializePictureBox(); // Call the method to initialize PictureBox
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            FinalProject finalProject = new FinalProject();
            finalProject.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
            this.Hide();
        }

        private void InitializePictureBox()
        { // Create and set properties for each PictureBox
            PictureBox pbSylviaPlath = new PictureBox
            {
                Name = "pbSylviaPlath",
                Size = new Size(258, 134),
                Location = new Point(58, 108),
                Image = Image.FromFile(@"C:\Users\rinla\Desktop\AWD Photos\Sylvia Plath.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom // Set SizeMode to Zoom
            };
            Controls.Add(pbSylviaPlath); // Add PictureBox to the form

            PictureBox pbJhumpaLahiri = new PictureBox
            {
                Name = "pbJhumpaLahiri",
                Size = new Size(258, 134),
                Location = new Point(58, 108),
                Image = Image.FromFile(@"C:\Users\rinla\Desktop\AWD Photos\Jhumpa Lahiri.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom // Set SizeMode to Zoom
            };
            Controls.Add(pbJhumpaLahiri); // Add PictureBox to the form

            PictureBox pbStephenKing = new PictureBox
            {
                Name = "pbStephenKing",
                Size = new Size(258, 134),
                Location = new Point(58, 108),
                Image = Image.FromFile(@"C:\Users\rinla\Desktop\AWD Photos\Stephen King.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom // Set SizeMode to Zoom
            };
            Controls.Add(pbStephenKing); // Add PictureBox to the form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
