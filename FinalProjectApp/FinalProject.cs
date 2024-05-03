using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace FinalProjectApp
{
    public partial class FinalProject : Form
    {
        string theIsbn = "";

        public FinalProject()
        {
            InitializeComponent();
        }

        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            ShowSplashScreen();
        }

        private void splashMenuItem_Click(object sender, EventArgs e)
        {
            ShowSplashScreen();
        }

        private void ShowSplashScreen()
        {
            this.Hide();
            SplashScreen splash = new SplashScreen();
            splash.Show();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearchForm();
        }

        private void searchMenuItem_Click(object sender, EventArgs e)
        {
            ShowSearchForm();
        }

        private void ShowSearchForm()
        {
            var bookContext = new BookContext();

            dgResults.Rows.Clear();
            dgResults.Columns.Clear();

            if (txtSearch.Text.Trim() == "" &&
                cbAuthor.SelectedIndex == -1)
            {
                MessageBox.Show("No Search Term Entered. Program Ending",
                                "YOU MUST ENTER A SEARCH TERM!");
                return;
            }

            if (txtSearch.Text != "")
            {
                var books = (from b in bookContext.Books
                             where b.Isbn.ToString() == txtSearch.Text
                             select b).ToList();

                if (books.Count == 0)
                {
                    MessageBox.Show("No Book Matching Inputted ISBN",
                                    "NON-EXISTENT ISBN");
                    txtSearch.Text = "";
                    txtSearch.Focus();
                    return;
                }

                foreach (var book in books)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgResults);

                    // Assuming ISBN is stored in Cells[1], you can set its value like this
                    row.Cells[1].Value = book.Isbn;

                    // Set other cell values if needed
                    // row.Cells[0].Value = book.SomeProperty;
                    // row.Cells[2].Value = book.SomeOtherProperty;

                    dgResults.Rows.Add(row);
                }

                // Wire up the CellClick event handler here
                dgResults.CellClick += dgvBooks_CellContentClick;

                DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
                {
                    btnDetails.Name = "button";
                    btnDetails.HeaderText = "Details";
                    btnDetails.Text = "Details";
                    btnDetails.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dgResults.Columns.Add(btnDetails);
                }

                return;
            }

            if (cbAuthor.SelectedIndex > -1)
            {
                var books = (from b in bookContext.Books
                             where b.AuthorName.ToString() ==
                             cbAuthor.SelectedItem.ToString()
                             select b).ToList();

                dgResults.DataSource = books;

                DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn();
                {
                    btnDetails.Name = "button";
                    btnDetails.HeaderText = "Details";
                    btnDetails.Text = "Details";
                    btnDetails.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dgResults.Columns.Add(btnDetails);
                }

                var books2 = from b in bookContext.Books
                             select b.Isbn;

                // Wire up the CellClick event handler here
                dgResults.CellClick += dgvBooks_CellContentClick;

                return;
            }
        }

        private void FinalProject_Load(object sender, EventArgs e)
        {
            this.dgResults.Rows.Clear();

            var bookContext = new BookContext();
            var authors = (from b in bookContext.Books
                           select b.AuthorName).Distinct();

            foreach (string author in authors)
            {
                cbAuthor.Items.Add(author);
            }
        }
        
        private void dgvBooks_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dgResults.Rows.Count)
            {
                var rowIndex = e.RowIndex;

                // Check if the cell at index 1 is not null
                if (dgResults.Rows[rowIndex].Cells[1] != null)
                {
                    var isbnCell = dgResults.Rows[rowIndex].Cells[1];

                    // Check if the cell value is not null
                    if (isbnCell.Value != null)
                    {
                        theIsbn = isbnCell.Value.ToString();
                        // Proceed with the rest of your code
                        this.Hide();
                        SearchPage search = new SearchPage(theIsbn);
                        search.Show();
                    }
                    else
                    {
                        MessageBox.Show("ISBN value is null.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Cell is null.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid row index.", "Error");
            }

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            this.dgResults.DataSource = null;
            this.dgResults.Rows.Clear();
        }
    }
}

