namespace YourHotel.forms
{
    partial class restaurantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableNr = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.book = new MetroFramework.Controls.MetroButton();
            this.bookGrid = new MetroFramework.Controls.MetroGrid();
            this.createBill = new MetroFramework.Controls.MetroButton();
            this.removeArticle = new MetroFramework.Controls.MetroButton();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 508);
            this.panel1.TabIndex = 0;
            // 
            // tableNr
            // 
            this.tableNr.FormattingEnabled = true;
            this.tableNr.ItemHeight = 23;
            this.tableNr.Location = new System.Drawing.Point(637, 447);
            this.tableNr.Name = "tableNr";
            this.tableNr.Size = new System.Drawing.Size(121, 29);
            this.tableNr.TabIndex = 1;
            this.tableNr.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(654, 425);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tischnummer";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(637, 497);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(121, 23);
            this.book.TabIndex = 3;
            this.book.Text = "Buchen";
            this.book.UseSelectable = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article,
            this.price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.bookGrid.EnableHeadersVisualStyles = false;
            this.bookGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.Location = new System.Drawing.Point(571, 34);
            this.bookGrid.MultiSelect = false;
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.bookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.Size = new System.Drawing.Size(255, 274);
            this.bookGrid.TabIndex = 4;
            // 
            // createBill
            // 
            this.createBill.Location = new System.Drawing.Point(12, 497);
            this.createBill.Name = "createBill";
            this.createBill.Size = new System.Drawing.Size(121, 23);
            this.createBill.TabIndex = 5;
            this.createBill.Text = "Rechnung erstellen";
            this.createBill.UseSelectable = true;
            this.createBill.Click += new System.EventHandler(this.createBill_Click);
            // 
            // removeArticle
            // 
            this.removeArticle.Location = new System.Drawing.Point(637, 314);
            this.removeArticle.Name = "removeArticle";
            this.removeArticle.Size = new System.Drawing.Size(121, 23);
            this.removeArticle.TabIndex = 6;
            this.removeArticle.Text = "Auswahl entfernen";
            this.removeArticle.UseSelectable = true;
            this.removeArticle.Click += new System.EventHandler(this.removeArticle_Click);
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
            // restaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.removeArticle);
            this.Controls.Add(this.createBill);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.book);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tableNr);
            this.Controls.Add(this.panel1);
            this.Name = "restaurantForm";
            this.Text = "restaurantForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox tableNr;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton book;
        private MetroFramework.Controls.MetroGrid bookGrid;
        private MetroFramework.Controls.MetroButton createBill;
        private MetroFramework.Controls.MetroButton removeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}