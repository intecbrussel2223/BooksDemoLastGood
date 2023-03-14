namespace BooksDemo
{
    partial class Form1
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
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnGetAllBooks = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCountryId = new System.Windows.Forms.Label();
            this.lblHeaderID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cboCountryId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.NavajoWhite;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(44, 161);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(319, 108);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // btnGetAllBooks
            // 
            this.btnGetAllBooks.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGetAllBooks.Location = new System.Drawing.Point(44, 276);
            this.btnGetAllBooks.Name = "btnGetAllBooks";
            this.btnGetAllBooks.Size = new System.Drawing.Size(154, 23);
            this.btnGetAllBooks.TabIndex = 1;
            this.btnGetAllBooks.Text = "Get All Books";
            this.btnGetAllBooks.UseVisualStyleBackColor = false;
            this.btnGetAllBooks.Click += new System.EventHandler(this.btnGetAllBooks_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtAuthor.Location = new System.Drawing.Point(62, 29);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTitle.Location = new System.Drawing.Point(183, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtPrice.Location = new System.Drawing.Point(306, 29);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(62, 13);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(205, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(328, 13);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblCountryId
            // 
            this.lblCountryId.AutoSize = true;
            this.lblCountryId.Location = new System.Drawing.Point(447, 13);
            this.lblCountryId.Name = "lblCountryId";
            this.lblCountryId.Size = new System.Drawing.Size(57, 13);
            this.lblCountryId.TabIndex = 9;
            this.lblCountryId.Text = "Country ID";
            // 
            // lblHeaderID
            // 
            this.lblHeaderID.AutoSize = true;
            this.lblHeaderID.Location = new System.Drawing.Point(12, 13);
            this.lblHeaderID.Name = "lblHeaderID";
            this.lblHeaderID.Size = new System.Drawing.Size(18, 13);
            this.lblHeaderID.TabIndex = 10;
            this.lblHeaderID.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 11;
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnInsertBook.Location = new System.Drawing.Point(62, 69);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(100, 23);
            this.btnInsertBook.TabIndex = 12;
            this.btnInsertBook.Text = "Add New Book";
            this.btnInsertBook.UseVisualStyleBackColor = false;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdateBook.Location = new System.Drawing.Point(183, 69);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateBook.TabIndex = 13;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDeleteBook.Location = new System.Drawing.Point(370, 208);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteBook.TabIndex = 14;
            this.btnDeleteBook.Text = "Delete ";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSearchTitle.Location = new System.Drawing.Point(44, 135);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(319, 20);
            this.txtSearchTitle.TabIndex = 15;
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSearchByTitle.Location = new System.Drawing.Point(370, 135);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(102, 23);
            this.btnSearchByTitle.TabIndex = 16;
            this.btnSearchByTitle.Text = "Search Title ";
            this.btnSearchByTitle.UseVisualStyleBackColor = false;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(100, 392);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(325, 95);
            this.listBox1.TabIndex = 18;
            // 
            // cboCountryId
            // 
            this.cboCountryId.FormattingEnabled = true;
            this.cboCountryId.Location = new System.Drawing.Point(425, 29);
            this.cboCountryId.Name = "cboCountryId";
            this.cboCountryId.Size = new System.Drawing.Size(121, 21);
            this.cboCountryId.TabIndex = 19;
            this.cboCountryId.SelectedIndexChanged += new System.EventHandler(this.cboCountryId_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(574, 515);
            this.Controls.Add(this.cboCountryId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnInsertBook);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblHeaderID);
            this.Controls.Add(this.lblCountryId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnGetAllBooks);
            this.Controls.Add(this.lstBooks);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnGetAllBooks;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCountryId;
        private System.Windows.Forms.Label lblHeaderID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cboCountryId;
    }
}

