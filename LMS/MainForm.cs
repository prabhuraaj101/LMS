using LMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        LoadBooksData(DataGridViewBooks);

    }

    public void LoadBooksData(DataGridView DataGridViewBooks)
    {
        DataGridViewBooks.ReadOnly = true;
        DataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        List<Book> books = Book.GetBooksFromDB();

        DataGridViewBooks.DataSource = books;
    }
}
