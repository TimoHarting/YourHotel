namespace YourHotel.forms
{
    partial class spaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.removeArticle = new MetroFramework.Controls.MetroButton();
            this.bookGrid = new MetroFramework.Controls.MetroGrid();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.roomNr = new MetroFramework.Controls.MetroComboBox();
            this.hotelguestCheck = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeArticle
            // 
            this.removeArticle.Location = new System.Drawing.Point(632, 315);
            this.removeArticle.Name = "removeArticle";
            this.removeArticle.Size = new System.Drawing.Size(121, 23);
            this.removeArticle.TabIndex = 13;
            this.removeArticle.Text = "Auswahl entfernen";
            this.removeArticle.UseSelectable = true;
            this.removeArticle.Click += new System.EventHandler(this.removeArticle_Click);
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article,
            this.price});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.bookGrid.EnableHeadersVisualStyles = false;
            this.bookGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.Location = new System.Drawing.Point(566, 35);
            this.bookGrid.MultiSelect = false;
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.bookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.Size = new System.Drawing.Size(255, 274);
            this.bookGrid.TabIndex = 11;
            // 
            // article
            // 
            this.article.HeaderText = "Artikel";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Preis";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(632, 498);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(121, 23);
            this.book.TabIndex = 10;
            this.book.Text = "Buchen";
            this.book.UseSelectable = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(134, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 508);
            this.panel1.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(655, 399);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Zimmer Nr";
            this.metroLabel7.Visible = false;
            // 
            // roomNr
            // 
            this.roomNr.FormattingEnabled = true;
            this.roomNr.ItemHeight = 23;
            this.roomNr.Location = new System.Drawing.Point(632, 421);
            this.roomNr.Name = "roomNr";
            this.roomNr.Size = new System.Drawing.Size(121, 29);
            this.roomNr.TabIndex = 15;
            this.roomNr.UseSelectable = true;
            this.roomNr.Visible = false;
            // 
            // hotelguestCheck
            // 
            this.hotelguestCheck.AutoSize = true;
            this.hotelguestCheck.Location = new System.Drawing.Point(655, 381);
            this.hotelguestCheck.Name = "hotelguestCheck";
            this.hotelguestCheck.Size = new System.Drawing.Size(74, 15);
            this.hotelguestCheck.TabIndex = 14;
            this.hotelguestCheck.Text = "Hotelgast";
            this.hotelguestCheck.UseSelectable = true;
            this.hotelguestCheck.CheckedChanged += new System.EventHandler(this.hotelguestCheck_CheckedChanged);
            // 
            // spaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 533);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.roomNr);
            this.Controls.Add(this.hotelguestCheck);
            this.Controls.Add(this.removeArticle);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.book);
            this.Controls.Add(this.panel1);
            this.Name = "spaForm";
            this.Text = "spaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton removeArticle;
        private MetroFramework.Controls.MetroGrid bookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroButton book;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox roomNr;
        private MetroFramework.Controls.MetroCheckBox hotelguestCheck;
    }
}