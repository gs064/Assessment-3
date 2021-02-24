namespace MovieSystem
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
            this.tabcustomerrecord = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datagridviewCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewRetalRecord = new System.Windows.Forms.DataGridView();
            this.CAddress = new System.Windows.Forms.Label();
            this.CustomerInsert = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.InsertMovie = new System.Windows.Forms.Button();
            this.UpdateMovie = new System.Windows.Forms.Button();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.IssueMovies = new System.Windows.Forms.Button();
            this.ReturnMovies = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerLastName = new System.Windows.Forms.TextBox();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.MoviesID = new System.Windows.Forms.TextBox();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.MovieRating = new System.Windows.Forms.TextBox();
            this.MovieCopies = new System.Windows.Forms.TextBox();
            this.MovieGenre = new System.Windows.Forms.TextBox();
            this.MoviePlot = new System.Windows.Forms.TextBox();
            this.MovieCost = new System.Windows.Forms.TextBox();
            this.RentalMovieID = new System.Windows.Forms.TextBox();
            this.MovieReleaseDate = new System.Windows.Forms.TextBox();
            this.RentalCustomerID = new System.Windows.Forms.TextBox();
            this.RentalsMovieID = new System.Windows.Forms.TextBox();
            this.RentalIssueDate = new System.Windows.Forms.TextBox();
            this.RentalReturnDate = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.Label();
            this.CFirstName = new System.Windows.Forms.Label();
            this.CLastName = new System.Windows.Forms.Label();
            this.CPhone = new System.Windows.Forms.Label();
            this.MovieID = new System.Windows.Forms.Label();
            this.MoviesTitle = new System.Windows.Forms.Label();
            this.MoviesRating = new System.Windows.Forms.Label();
            this.MoviesCopies = new System.Windows.Forms.Label();
            this.MoviesPlot = new System.Windows.Forms.Label();
            this.MoviesGenure = new System.Windows.Forms.Label();
            this.MoviesCost = new System.Windows.Forms.Label();
            this.MoviesReleaseDate = new System.Windows.Forms.Label();
            this.RentalID = new System.Windows.Forms.Label();
            this.RCustID = new System.Windows.Forms.Label();
            this.RMovieID = new System.Windows.Forms.Label();
            this.RRentalDate = new System.Windows.Forms.Label();
            this.RRentDate = new System.Windows.Forms.Label();
            this.ShowAllMovies = new System.Windows.Forms.RadioButton();
            this.ShowRentalMovies = new System.Windows.Forms.RadioButton();
            this.ShowMostPopular = new System.Windows.Forms.RadioButton();
            this.tabcustomerrecord.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcustomerrecord
            // 
            this.tabcustomerrecord.Controls.Add(this.tabPage1);
            this.tabcustomerrecord.Controls.Add(this.tabPage2);
            this.tabcustomerrecord.Controls.Add(this.tabPage3);
            this.tabcustomerrecord.Location = new System.Drawing.Point(16, 12);
            this.tabcustomerrecord.Name = "tabcustomerrecord";
            this.tabcustomerrecord.SelectedIndex = 0;
            this.tabcustomerrecord.Size = new System.Drawing.Size(1108, 336);
            this.tabcustomerrecord.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datagridviewCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Record";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datagridviewCustomer
            // 
            this.datagridviewCustomer.AllowUserToAddRows = false;
            this.datagridviewCustomer.AllowUserToDeleteRows = false;
            this.datagridviewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewCustomer.Location = new System.Drawing.Point(-4, 0);
            this.datagridviewCustomer.Name = "datagridviewCustomer";
            this.datagridviewCustomer.ReadOnly = true;
            this.datagridviewCustomer.RowTemplate.Height = 28;
            this.datagridviewCustomer.Size = new System.Drawing.Size(1090, 302);
            this.datagridviewCustomer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(0, 6);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.RowTemplate.Height = 28;
            this.dataGridViewMovie.Size = new System.Drawing.Size(1097, 291);
            this.dataGridViewMovie.TabIndex = 0;
            this.dataGridViewMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewRetalRecord);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1100, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movie Rental Record";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRetalRecord
            // 
            this.dataGridViewRetalRecord.AllowUserToAddRows = false;
            this.dataGridViewRetalRecord.AllowUserToDeleteRows = false;
            this.dataGridViewRetalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetalRecord.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewRetalRecord.Name = "dataGridViewRetalRecord";
            this.dataGridViewRetalRecord.ReadOnly = true;
            this.dataGridViewRetalRecord.RowTemplate.Height = 28;
            this.dataGridViewRetalRecord.Size = new System.Drawing.Size(1098, 300);
            this.dataGridViewRetalRecord.TabIndex = 0;
            // 
            // CAddress
            // 
            this.CAddress.AutoSize = true;
            this.CAddress.Location = new System.Drawing.Point(12, 532);
            this.CAddress.Name = "CAddress";
            this.CAddress.Size = new System.Drawing.Size(83, 20);
            this.CAddress.TabIndex = 28;
            this.CAddress.Text = "C Address";
            // 
            // CustomerInsert
            // 
            this.CustomerInsert.Location = new System.Drawing.Point(254, 373);
            this.CustomerInsert.Name = "CustomerInsert";
            this.CustomerInsert.Size = new System.Drawing.Size(143, 54);
            this.CustomerInsert.TabIndex = 1;
            this.CustomerInsert.Text = "Insert Customer";
            this.CustomerInsert.UseVisualStyleBackColor = true;
            this.CustomerInsert.Click += new System.EventHandler(this.CustomerInsert_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Location = new System.Drawing.Point(254, 437);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(143, 58);
            this.UpdateCustomer.TabIndex = 1;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(254, 510);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(141, 57);
            this.DeleteCustomer.TabIndex = 2;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // InsertMovie
            // 
            this.InsertMovie.Location = new System.Drawing.Point(675, 372);
            this.InsertMovie.Name = "InsertMovie";
            this.InsertMovie.Size = new System.Drawing.Size(143, 40);
            this.InsertMovie.TabIndex = 3;
            this.InsertMovie.Text = "Insert Movie";
            this.InsertMovie.UseVisualStyleBackColor = true;
            this.InsertMovie.Click += new System.EventHandler(this.InsertMovie_Click);
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.Location = new System.Drawing.Point(675, 425);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(143, 38);
            this.UpdateMovie.TabIndex = 4;
            this.UpdateMovie.Text = "Update Movie";
            this.UpdateMovie.UseVisualStyleBackColor = true;
            this.UpdateMovie.Click += new System.EventHandler(this.UpdateMovie_Click);
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(675, 478);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(140, 37);
            this.DeleteMovie.TabIndex = 5;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // IssueMovies
            // 
            this.IssueMovies.Location = new System.Drawing.Point(903, 367);
            this.IssueMovies.Name = "IssueMovies";
            this.IssueMovies.Size = new System.Drawing.Size(99, 63);
            this.IssueMovies.TabIndex = 6;
            this.IssueMovies.Text = "Issue Movies";
            this.IssueMovies.UseVisualStyleBackColor = true;
            this.IssueMovies.Click += new System.EventHandler(this.IssueMovies_Click);
            // 
            // ReturnMovies
            // 
            this.ReturnMovies.Location = new System.Drawing.Point(1016, 367);
            this.ReturnMovies.Name = "ReturnMovies";
            this.ReturnMovies.Size = new System.Drawing.Size(98, 63);
            this.ReturnMovies.TabIndex = 7;
            this.ReturnMovies.Text = "Return Movies";
            this.ReturnMovies.UseVisualStyleBackColor = true;
            this.ReturnMovies.Click += new System.EventHandler(this.ReturnMovies_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(107, 375);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(119, 26);
            this.CustomerID.TabIndex = 8;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(107, 431);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(119, 26);
            this.CustomerName.TabIndex = 9;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Location = new System.Drawing.Point(107, 478);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(119, 26);
            this.CustomerLastName.TabIndex = 10;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Location = new System.Drawing.Point(107, 529);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(119, 26);
            this.CustomerAddress.TabIndex = 11;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(107, 585);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(120, 26);
            this.CustomerPhone.TabIndex = 12;
            // 
            // MoviesID
            // 
            this.MoviesID.Location = new System.Drawing.Point(535, 372);
            this.MoviesID.Name = "MoviesID";
            this.MoviesID.Size = new System.Drawing.Size(123, 26);
            this.MoviesID.TabIndex = 13;
            // 
            // MovieTitle
            // 
            this.MovieTitle.Location = new System.Drawing.Point(535, 404);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(123, 26);
            this.MovieTitle.TabIndex = 14;
            // 
            // MovieRating
            // 
            this.MovieRating.Location = new System.Drawing.Point(535, 436);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.Size = new System.Drawing.Size(123, 26);
            this.MovieRating.TabIndex = 15;
            // 
            // MovieCopies
            // 
            this.MovieCopies.Location = new System.Drawing.Point(535, 469);
            this.MovieCopies.Name = "MovieCopies";
            this.MovieCopies.Size = new System.Drawing.Size(123, 26);
            this.MovieCopies.TabIndex = 16;
            // 
            // MovieGenre
            // 
            this.MovieGenre.Location = new System.Drawing.Point(535, 501);
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.Size = new System.Drawing.Size(123, 26);
            this.MovieGenre.TabIndex = 17;
            // 
            // MoviePlot
            // 
            this.MoviePlot.Location = new System.Drawing.Point(535, 533);
            this.MoviePlot.Name = "MoviePlot";
            this.MoviePlot.Size = new System.Drawing.Size(123, 26);
            this.MoviePlot.TabIndex = 18;
            // 
            // MovieCost
            // 
            this.MovieCost.Location = new System.Drawing.Point(535, 564);
            this.MovieCost.Name = "MovieCost";
            this.MovieCost.Size = new System.Drawing.Size(123, 26);
            this.MovieCost.TabIndex = 19;
            // 
            // RentalMovieID
            // 
            this.RentalMovieID.Location = new System.Drawing.Point(1009, 447);
            this.RentalMovieID.Name = "RentalMovieID";
            this.RentalMovieID.Size = new System.Drawing.Size(100, 26);
            this.RentalMovieID.TabIndex = 20;
            // 
            // MovieReleaseDate
            // 
            this.MovieReleaseDate.Location = new System.Drawing.Point(535, 597);
            this.MovieReleaseDate.Name = "MovieReleaseDate";
            this.MovieReleaseDate.Size = new System.Drawing.Size(123, 26);
            this.MovieReleaseDate.TabIndex = 21;
            // 
            // RentalCustomerID
            // 
            this.RentalCustomerID.Location = new System.Drawing.Point(1010, 483);
            this.RentalCustomerID.Name = "RentalCustomerID";
            this.RentalCustomerID.Size = new System.Drawing.Size(99, 26);
            this.RentalCustomerID.TabIndex = 22;
            // 
            // RentalsMovieID
            // 
            this.RentalsMovieID.Location = new System.Drawing.Point(1009, 521);
            this.RentalsMovieID.Name = "RentalsMovieID";
            this.RentalsMovieID.Size = new System.Drawing.Size(100, 26);
            this.RentalsMovieID.TabIndex = 23;
            // 
            // RentalIssueDate
            // 
            this.RentalIssueDate.Location = new System.Drawing.Point(1008, 559);
            this.RentalIssueDate.Name = "RentalIssueDate";
            this.RentalIssueDate.Size = new System.Drawing.Size(100, 26);
            this.RentalIssueDate.TabIndex = 24;
            // 
            // RentalReturnDate
            // 
            this.RentalReturnDate.Location = new System.Drawing.Point(1008, 595);
            this.RentalReturnDate.Name = "RentalReturnDate";
            this.RentalReturnDate.Size = new System.Drawing.Size(100, 26);
            this.RentalReturnDate.TabIndex = 25;
            this.RentalReturnDate.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Location = new System.Drawing.Point(12, 378);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(37, 20);
            this.CID.TabIndex = 1;
            this.CID.Text = "CID";
            // 
            // CFirstName
            // 
            this.CFirstName.AutoSize = true;
            this.CFirstName.Location = new System.Drawing.Point(12, 431);
            this.CFirstName.Name = "CFirstName";
            this.CFirstName.Size = new System.Drawing.Size(97, 20);
            this.CFirstName.TabIndex = 26;
            this.CFirstName.Text = "C FirstName";
            // 
            // CLastName
            // 
            this.CLastName.AutoSize = true;
            this.CLastName.Location = new System.Drawing.Point(12, 481);
            this.CLastName.Name = "CLastName";
            this.CLastName.Size = new System.Drawing.Size(97, 20);
            this.CLastName.TabIndex = 27;
            this.CLastName.Text = "C LastName";
            // 
            // CPhone
            // 
            this.CPhone.AutoSize = true;
            this.CPhone.Location = new System.Drawing.Point(12, 585);
            this.CPhone.Name = "CPhone";
            this.CPhone.Size = new System.Drawing.Size(70, 20);
            this.CPhone.TabIndex = 29;
            this.CPhone.Text = "C Phone";
            // 
            // MovieID
            // 
            this.MovieID.AutoSize = true;
            this.MovieID.Location = new System.Drawing.Point(430, 375);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(71, 20);
            this.MovieID.TabIndex = 30;
            this.MovieID.Text = "Movie ID";
            // 
            // MoviesTitle
            // 
            this.MoviesTitle.AutoSize = true;
            this.MoviesTitle.Location = new System.Drawing.Point(430, 407);
            this.MoviesTitle.Name = "MoviesTitle";
            this.MoviesTitle.Size = new System.Drawing.Size(83, 20);
            this.MoviesTitle.TabIndex = 31;
            this.MoviesTitle.Text = "Movie Title";
            // 
            // MoviesRating
            // 
            this.MoviesRating.AutoSize = true;
            this.MoviesRating.Location = new System.Drawing.Point(430, 442);
            this.MoviesRating.Name = "MoviesRating";
            this.MoviesRating.Size = new System.Drawing.Size(101, 20);
            this.MoviesRating.TabIndex = 32;
            this.MoviesRating.Text = "Movie Rating";
            // 
            // MoviesCopies
            // 
            this.MoviesCopies.AutoSize = true;
            this.MoviesCopies.Location = new System.Drawing.Point(430, 472);
            this.MoviesCopies.Name = "MoviesCopies";
            this.MoviesCopies.Size = new System.Drawing.Size(58, 20);
            this.MoviesCopies.TabIndex = 33;
            this.MoviesCopies.Text = "Copies";
            // 
            // MoviesPlot
            // 
            this.MoviesPlot.AutoSize = true;
            this.MoviesPlot.Location = new System.Drawing.Point(430, 539);
            this.MoviesPlot.Name = "MoviesPlot";
            this.MoviesPlot.Size = new System.Drawing.Size(36, 20);
            this.MoviesPlot.TabIndex = 34;
            this.MoviesPlot.Text = "Plot";
            // 
            // MoviesGenure
            // 
            this.MoviesGenure.AutoSize = true;
            this.MoviesGenure.Location = new System.Drawing.Point(430, 507);
            this.MoviesGenure.Name = "MoviesGenure";
            this.MoviesGenure.Size = new System.Drawing.Size(54, 20);
            this.MoviesGenure.TabIndex = 35;
            this.MoviesGenure.Text = "Genre";
            // 
            // MoviesCost
            // 
            this.MoviesCost.AutoSize = true;
            this.MoviesCost.Location = new System.Drawing.Point(430, 570);
            this.MoviesCost.Name = "MoviesCost";
            this.MoviesCost.Size = new System.Drawing.Size(42, 20);
            this.MoviesCost.TabIndex = 36;
            this.MoviesCost.Text = "Cost";
            // 
            // MoviesReleaseDate
            // 
            this.MoviesReleaseDate.AutoSize = true;
            this.MoviesReleaseDate.Location = new System.Drawing.Point(430, 600);
            this.MoviesReleaseDate.Name = "MoviesReleaseDate";
            this.MoviesReleaseDate.Size = new System.Drawing.Size(107, 20);
            this.MoviesReleaseDate.TabIndex = 37;
            this.MoviesReleaseDate.Text = "Release Date";
            // 
            // RentalID
            // 
            this.RentalID.AutoSize = true;
            this.RentalID.Location = new System.Drawing.Point(907, 450);
            this.RentalID.Name = "RentalID";
            this.RentalID.Size = new System.Drawing.Size(77, 20);
            this.RentalID.TabIndex = 38;
            this.RentalID.Text = "Rental ID";
            // 
            // RCustID
            // 
            this.RCustID.AutoSize = true;
            this.RCustID.Location = new System.Drawing.Point(907, 489);
            this.RCustID.Name = "RCustID";
            this.RCustID.Size = new System.Drawing.Size(63, 20);
            this.RCustID.TabIndex = 39;
            this.RCustID.Text = "Cust ID";
            // 
            // RMovieID
            // 
            this.RMovieID.AutoSize = true;
            this.RMovieID.Location = new System.Drawing.Point(907, 524);
            this.RMovieID.Name = "RMovieID";
            this.RMovieID.Size = new System.Drawing.Size(71, 20);
            this.RMovieID.TabIndex = 40;
            this.RMovieID.Text = "Movie ID";
            // 
            // RRentalDate
            // 
            this.RRentalDate.AutoSize = true;
            this.RRentalDate.Location = new System.Drawing.Point(907, 562);
            this.RRentalDate.Name = "RRentalDate";
            this.RRentalDate.Size = new System.Drawing.Size(95, 20);
            this.RRentalDate.TabIndex = 41;
            this.RRentalDate.Text = "Rental Date";
            // 
            // RRentDate
            // 
            this.RRentDate.AutoSize = true;
            this.RRentDate.Location = new System.Drawing.Point(905, 598);
            this.RRentDate.Name = "RRentDate";
            this.RRentDate.Size = new System.Drawing.Size(97, 20);
            this.RRentDate.TabIndex = 42;
            this.RRentDate.Text = "Return Date";
            // 
            // ShowAllMovies
            // 
            this.ShowAllMovies.AutoSize = true;
            this.ShowAllMovies.Location = new System.Drawing.Point(664, 533);
            this.ShowAllMovies.Name = "ShowAllMovies";
            this.ShowAllMovies.Size = new System.Drawing.Size(148, 24);
            this.ShowAllMovies.TabIndex = 43;
            this.ShowAllMovies.TabStop = true;
            this.ShowAllMovies.Text = "Show All Movies";
            this.ShowAllMovies.UseVisualStyleBackColor = true;
            this.ShowAllMovies.CheckedChanged += new System.EventHandler(this.ShowAllMovies_CheckedChanged);
            // 
            // ShowRentalMovies
            // 
            this.ShowRentalMovies.AutoSize = true;
            this.ShowRentalMovies.Location = new System.Drawing.Point(664, 570);
            this.ShowRentalMovies.Name = "ShowRentalMovies";
            this.ShowRentalMovies.Size = new System.Drawing.Size(178, 24);
            this.ShowRentalMovies.TabIndex = 44;
            this.ShowRentalMovies.TabStop = true;
            this.ShowRentalMovies.Text = "Show Rental Movies";
            this.ShowRentalMovies.UseVisualStyleBackColor = true;
            this.ShowRentalMovies.CheckedChanged += new System.EventHandler(this.ShowRentalMovies_CheckedChanged);
            // 
            // ShowMostPopular
            // 
            this.ShowMostPopular.AutoSize = true;
            this.ShowMostPopular.Location = new System.Drawing.Point(664, 603);
            this.ShowMostPopular.Name = "ShowMostPopular";
            this.ShowMostPopular.Size = new System.Drawing.Size(185, 24);
            this.ShowMostPopular.TabIndex = 45;
            this.ShowMostPopular.TabStop = true;
            this.ShowMostPopular.Text = "Show Popular Movies";
            this.ShowMostPopular.UseVisualStyleBackColor = true;
            this.ShowMostPopular.CheckedChanged += new System.EventHandler(this.ShowMostPopular_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 684);
            this.Controls.Add(this.ShowMostPopular);
            this.Controls.Add(this.ShowRentalMovies);
            this.Controls.Add(this.ShowAllMovies);
            this.Controls.Add(this.RRentDate);
            this.Controls.Add(this.CAddress);
            this.Controls.Add(this.RRentalDate);
            this.Controls.Add(this.RMovieID);
            this.Controls.Add(this.RCustID);
            this.Controls.Add(this.RentalID);
            this.Controls.Add(this.MoviesReleaseDate);
            this.Controls.Add(this.MoviesCost);
            this.Controls.Add(this.MoviesGenure);
            this.Controls.Add(this.MoviesPlot);
            this.Controls.Add(this.MoviesCopies);
            this.Controls.Add(this.MoviesRating);
            this.Controls.Add(this.MoviesTitle);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.CLastName);
            this.Controls.Add(this.CPhone);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.CFirstName);
            this.Controls.Add(this.RentalReturnDate);
            this.Controls.Add(this.RentalIssueDate);
            this.Controls.Add(this.RentalsMovieID);
            this.Controls.Add(this.RentalCustomerID);
            this.Controls.Add(this.MovieReleaseDate);
            this.Controls.Add(this.RentalMovieID);
            this.Controls.Add(this.MovieCost);
            this.Controls.Add(this.MoviePlot);
            this.Controls.Add(this.MovieGenre);
            this.Controls.Add(this.MovieCopies);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.MoviesID);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.ReturnMovies);
            this.Controls.Add(this.IssueMovies);
            this.Controls.Add(this.DeleteMovie);
            this.Controls.Add(this.UpdateMovie);
            this.Controls.Add(this.InsertMovie);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.CustomerInsert);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.tabcustomerrecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcustomerrecord.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcustomerrecord;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView datagridviewCustomer;
        private System.Windows.Forms.Button CustomerInsert;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button InsertMovie;
        private System.Windows.Forms.Button UpdateMovie;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.DataGridView dataGridViewRetalRecord;
        private System.Windows.Forms.Button IssueMovies;
        private System.Windows.Forms.Button ReturnMovies;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerLastName;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.TextBox MoviesID;
        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.TextBox MovieRating;
        private System.Windows.Forms.TextBox MovieCopies;
        private System.Windows.Forms.TextBox MovieGenre;
        private System.Windows.Forms.TextBox MoviePlot;
        private System.Windows.Forms.TextBox MovieCost;
        private System.Windows.Forms.TextBox RentalMovieID;
        private System.Windows.Forms.TextBox MovieReleaseDate;
        private System.Windows.Forms.TextBox RentalCustomerID;
        private System.Windows.Forms.TextBox RentalsMovieID;
        private System.Windows.Forms.TextBox RentalIssueDate;
        private System.Windows.Forms.TextBox RentalReturnDate;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.Label CFirstName;
        private System.Windows.Forms.Label CLastName;
        private System.Windows.Forms.Label CAddress;
        private System.Windows.Forms.Label CPhone;
        private System.Windows.Forms.Label MovieID;
        private System.Windows.Forms.Label MoviesTitle;
        private System.Windows.Forms.Label MoviesRating;
        private System.Windows.Forms.Label MoviesCopies;
        private System.Windows.Forms.Label MoviesPlot;
        private System.Windows.Forms.Label MoviesGenure;
        private System.Windows.Forms.Label MoviesCost;
        private System.Windows.Forms.Label MoviesReleaseDate;
        private System.Windows.Forms.Label RentalID;
        private System.Windows.Forms.Label RCustID;
        private System.Windows.Forms.Label RMovieID;
        private System.Windows.Forms.Label RRentalDate;
        private System.Windows.Forms.Label RRentDate;
        private System.Windows.Forms.RadioButton ShowAllMovies;
        private System.Windows.Forms.RadioButton ShowRentalMovies;
        private System.Windows.Forms.RadioButton ShowMostPopular;
    }
}

