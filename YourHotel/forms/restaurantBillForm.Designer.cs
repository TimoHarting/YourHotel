namespace YourHotel.forms
{
    partial class restaurantBillForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hotelguestCheck = new MetroFramework.Controls.MetroCheckBox();
            this.roomNr = new MetroFramework.Controls.MetroComboBox();
            this.bookGrid = new MetroFramework.Controls.MetroGrid();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.priceN = new MetroFramework.Controls.MetroLabel();
            this.mwst = new MetroFramework.Controls.MetroLabel();
            this.priceB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.confirm = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tableNr = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelguestCheck
            // 
            this.hotelguestCheck.AutoSize = true;
            this.hotelguestCheck.Location = new System.Drawing.Point(28, 33);
            this.hotelguestCheck.Name = "hotelguestCheck";
            this.hotelguestCheck.Size = new System.Drawing.Size(74, 15);
            this.hotelguestCheck.TabIndex = 0;
            this.hotelguestCheck.Text = "Hotelgast";
            this.hotelguestCheck.UseSelectable = true;
            this.hotelguestCheck.CheckedChanged += new System.EventHandler(this.hotelguestCheck_CheckedChanged);
            // 
            // roomNr
            // 
            this.roomNr.FormattingEnabled = true;
            this.roomNr.ItemHeight = 23;
            this.roomNr.Location = new System.Drawing.Point(28, 96);
            this.roomNr.Name = "roomNr";
            this.roomNr.Size = new System.Drawing.Size(121, 29);
            this.roomNr.TabIndex = 1;
            this.roomNr.UseSelectable = true;
            this.roomNr.Visible = false;
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article,
            this.price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bookGrid.EnableHeadersVisualStyles = false;
            this.bookGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.Location = new System.Drawing.Point(310, 12);
            this.bookGrid.MultiSelect = false;
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.ReadOnly = true;
            this.bookGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.Size = new System.Drawing.Size(265, 426);
            this.bookGrid.TabIndex = 5;
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
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(28, 318);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 23);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Preis Netto";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(28, 350);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "19% Mwst.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(28, 381);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Preis Brutto";
            // 
            // priceN
            // 
            this.priceN.Location = new System.Drawing.Point(125, 318);
            this.priceN.Name = "priceN";
            this.priceN.Size = new System.Drawing.Size(81, 23);
            this.priceN.TabIndex = 9;
            this.priceN.Text = "0";
            // 
            // mwst
            // 
            this.mwst.Location = new System.Drawing.Point(125, 350);
            this.mwst.Name = "mwst";
            this.mwst.Size = new System.Drawing.Size(81, 19);
            this.mwst.TabIndex = 10;
            this.mwst.Text = "0";
            // 
            // priceB
            // 
            this.priceB.Location = new System.Drawing.Point(125, 381);
            this.priceB.Name = "priceB";
            this.priceB.Size = new System.Drawing.Size(81, 19);
            this.priceB.TabIndex = 11;
            this.priceB.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 71);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Zimmer Nr";
            this.metroLabel7.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(74, 415);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "Abschließen";
            this.confirm.UseSelectable = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Tischnummer";
            // 
            // tableNr
            // 
            this.tableNr.FormattingEnabled = true;
            this.tableNr.ItemHeight = 23;
            this.tableNr.Location = new System.Drawing.Point(28, 169);
            this.tableNr.Name = "tableNr";
            this.tableNr.Size = new System.Drawing.Size(121, 29);
            this.tableNr.TabIndex = 14;
            this.tableNr.UseSelectable = true;
            this.tableNr.SelectedIndexChanged += new System.EventHandler(this.tableNr_SelectedIndexChanged);
            // 
            // restaurantBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tableNr);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.priceB);
            this.Controls.Add(this.mwst);
            this.Controls.Add(this.priceN);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.roomNr);
            this.Controls.Add(this.hotelguestCheck);
            this.Name = "restaurantBillForm";
            this.Text = "restaurantBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox hotelguestCheck;
        private MetroFramework.Controls.MetroComboBox roomNr;
        private MetroFramework.Controls.MetroGrid bookGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel priceN;
        private MetroFramework.Controls.MetroLabel mwst;
        private MetroFramework.Controls.MetroLabel priceB;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton confirm;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox tableNr;
    }
}