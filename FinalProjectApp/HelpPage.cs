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
    public partial class HelpPage : Form
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        private void HelpPage_Load(object sender, EventArgs e)
        {
            FillHelpForm();
        }

        private void FillHelpForm()
        {
            string helpStr = "";
            helpStr += "Create a Book Store Application that stores books for a minimum of 3 authors. This data must be stored in a List<Book> to receive credit.\r\n\r\n One author should have < 5 books.\r\n\r\n One author should have 5 – 10 books.\r\n\r\n One author should have > 10 books.\r\n\r\n Use real book information that can be found online.";
            helpStr += "The Author Drop Down List should allow for filtering results by Author from the Search Form (using the LINQ Where() function).\r\n\r\n This drop-down list should be programmatically populated when the form loads (using the LINQ Select() and Unique() functions).";
            helpStr += "On the Search Form when the user clicks the search button, a LINQ search can be performed by both (using the LINQ Where() function):\r\n\r\n Book Name.\r\n\r\n Book ISBN.";
            helpStr += "On the Search Form after the search button is clicked, the correct result data should be returned and displayed below the search controls. Result data includes:\r\n\r\n ISBN.\r\n\r\n Name.\r\n\r\n Author.\r\n\r\n Year. If > 5 results are returned, the application should implement paging. Any search results with less than 5 books should disable or hide the paging controls. (Use the LINQ Skip() and Take() functions to page the results. Don’t forget to round up when determining how many pages are in the result!).";
            helpStr += "When the details button is clicked for a book on the Search Form, a Book Details Form is displayed";
            helpStr += "The associated book data should be displayed in the Book Details Form:\r\n\r\n Book Name, Year.\r\n\r\n ISBN.\r\n\r\n Author.\r\n\r\n Image of that book.\r\n\r\n Past Reviews for that book.";
            helpStr += "The user can add new reviews to a book using the Book Details Form.\r\n\r\n The application implements the Book class given in the UML diagram.\r\n\r\n The application implements the Review class given in the UML diagram.\r\n\r\n The application implements the SearchForm class given in the UML diagram.";
            helpStr += "The application implements the DetailsForm given in the UML diagram. The user creates his/her own 10 – 20-minute video explaining the project and giving his/her feelings on the class and the AWD Program.";

            lblInstructions.Text = helpStr;
        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            this.Hide();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            FinalProject finalProject = new FinalProject();
            finalProject.Show();
            this.Hide();
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
