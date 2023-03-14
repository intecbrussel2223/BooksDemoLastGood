using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BooksDemo.Models;

namespace BooksDemo
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        private List<Country> countries = new List<Country>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width= 608;
            //this.Height= 351;
            GetAllBooks();
            PopulateListBox();
            GetCountries();
            FillCboCountries();
        }

        private void FillCboCountries()
        {
            cboCountryId.Items.Clear();
            foreach (var item in countries)
            {
                cboCountryId.Items.Add(item.Id + " " + item.CountryName);
            }
            
        }
        private List<Country> GetCountries()
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                countries = connection.Query<Country>("select * from Country").ToList();
                return countries;
            }
        }
        private void btnGetAllBooks_Click(object sender, EventArgs e)
        {
            GetAllBooks();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            lstBooks.Items.Clear();
            foreach (var item in books)
            {
                lstBooks.Items.Add(item);
            }
        }

        private List<Book> GetAllBooks()
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                books = connection.Query<Book>("select * from book").ToList();
                return books;
            }
        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Author = txtAuthor.Text; 
            book.Title = txtTitle.Text;
            book.Price = decimal.Parse(txtPrice.Text);
            book.CountryId = cboCountryId.SelectedIndex+1;
            AddBook(book);
            GetAllBooks();  
            PopulateListBox();
        }

        private void AddBook(Book book)
        {
            string sql = "Insert into Book (Author, Title, Price, CountryId)" +
                "Values(@Author, @Title, @Price, @CountryId)";
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                connection.Execute(sql,book);
            }
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book selectedBook = new Book();  
            selectedBook = lstBooks.SelectedItem as Book;
            lblID.Text = selectedBook.id.ToString();
            txtAuthor.Text = selectedBook.Author;
            txtPrice.Text = selectedBook.Price.ToString();
            txtTitle.Text = selectedBook.Title;
            cboCountryId.Text = selectedBook.CountryId.ToString();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Book updatedBook = new Book();
            updatedBook.id = int.Parse(lblID.Text);
            updatedBook.Author = txtAuthor.Text;
            updatedBook.Title= txtTitle.Text;
            updatedBook.Price = decimal.Parse(txtPrice.Text);
            updatedBook.CountryId = int.Parse(cboCountryId.Text);
            UpdateBook(updatedBook);
            GetAllBooks();
            PopulateListBox();
        }

        private static void UpdateBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                connection.Execute("Update Book Set Title = @title, Author = @author, " +
                    "Price = @price, CountryId = @countryId WHERE Id = @Id",
                    new
                    {
                        Id = book.id,
                        Author = book.Author,
                        Title = book.Title,
                        Price = book.Price,
                        CountryId = book.CountryId
                    });
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBookById(int.Parse(lblID.Text));
            GetAllBooks();
            PopulateListBox();
        }

        private void DeleteBookById(int id)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                connection.Execute("Delete from book where Id=@id", new {Id = @id });
            }
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            FindTitle(txtSearchTitle.Text);
            lstBooks.Items.Clear();
            foreach (var item in books)
            {
                lstBooks.Items.Add(item);
            }
        }

        private List<Book> FindTitle(string title)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                books = connection.Query<Book>("Select * from book where Title Like @title escape '!'", 
                    new {title = "%" + title.Replace("%","!%") + "%"}).ToList();
                return books;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString.ConStr("Books")))
            {
                var sql = @"select b.Id, Title, Author, c.Id, CountryName
                            from Book b inner join Country c on b.CountryId = c.Id";

                var books = connection.Query<Book, Country, Book>(sql, (book, country) =>
                {
                    book.Countries = country;
                    return book;
                },
                splitOn: "Id").ToList(); 

                foreach (var item in books)
                {
                    listBox1.Items.Add(item.Title + " " + item.Countries );
                }

            }

         
        }

        private void cboCountryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
        }
    }
}
