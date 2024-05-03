using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;


namespace FinalProjectApp
{
    public partial class SearchPage : Form
    {
        private string receivedIsbn;

        // Define an event to request details
        public event EventHandler<string> DetailsRequested;

        public SearchPage(string data)
        {
            InitializeComponent();
            receivedIsbn = data;
            FillInTheFields();
        }

        private void FillInTheFields()
        {
            var bookContext = new BookContext();

            //MessageBox.Show("The Received ISBN was: " + receivedIsbn, "PASSED IN");

            var book = bookContext.Books
                .Where(b1 => b1.Isbn.ToString() == receivedIsbn)
                .Select(b2 => new { b2.Img, b2.Isbn, b2.BookName, b2.AuthorName, b2.PublishYear })
                .FirstOrDefault();

            if (book != null)
            {
                pbResult.Image = Image.FromFile(book.Img);
                lblTitle.Text = book.BookName;
                lblYear.Text = "(" + book.PublishYear.ToString() + ")";
                lblISBNNumber.Text = book.Isbn;
                lblAuthor.Text = book.AuthorName;
            }
            else
            {
                MessageBox.Show("Must Have Been A Bad Query", "BAD QUERY");
            }


        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            ShowSplashScreen();
        }

        private void splashScreentMenuItem_Click(object sender, EventArgs e)
        {
            ShowSplashScreen();
        }

        private void ShowSplashScreen()
        {
            this.Hide();
            SplashScreen splash = new SplashScreen();
            splash.Show();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            GoToMainPage();
        }

        private void mainPageMenuItem_Click(object sender, EventArgs e)
        {
            GoToMainPage();
        }

        private void GoToMainPage()
        {
            ClearDetailPageFields();
            this.Hide();
            FinalProject MainPage = new FinalProject();
            MainPage.ShowDialog();
        }

        private void ClearDetailPageFields()
        {
            pbResult.Image = null;
            lblAuthor.Text = "";
            lblISBNNumber.Text = "";
            lblTitle.Text = "";
            lblYear.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ShowHelpScreen();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelpScreen();
        }

        private void ShowHelpScreen()
        {
            this.Hide();
            HelpPage help = new HelpPage();
            help.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                   "Do You Really Want To Exit?",
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

