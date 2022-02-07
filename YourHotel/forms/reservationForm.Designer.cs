
namespace YourHotel.forms
{
    partial class reservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookGrid = new MetroFramework.Controls.MetroGrid();
            this.editRow = new MetroFramework.Controls.MetroButton();
            this.removeRow = new MetroFramework.Controls.MetroButton();
            this.starttime = new MetroFramework.Controls.MetroDateTime();
            this.endtime = new MetroFramework.Controls.MetroDateTime();
            this.privateBusiness = new MetroFramework.Controls.MetroComboBox();
            this.roomNr = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.newCustomer = new MetroFramework.Controls.MetroRadioButton();
            this.oldCustomer = new MetroFramework.Controls.MetroRadioButton();
            this.firstname = new MetroFramework.Controls.MetroTextBox();
            this.lastname = new MetroFramework.Controls.MetroTextBox();
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.tel = new MetroFramework.Controls.MetroTextBox();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.customerNr = new MetroFramework.Controls.MetroComboBox();
            this.book = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.boardNr = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.pricePerNight = new MetroFramework.Controls.MetroLabel();
            this.nightCount = new MetroFramework.Controls.MetroLabel();
            this.boardPrice = new MetroFramework.Controls.MetroLabel();
            this.completePricePerNight = new MetroFramework.Controls.MetroLabel();
            this.netPrice = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.mwst = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.gross = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookGrid
            // 
            this.bookGrid.AllowUserToResizeRows = false;
            this.bookGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.bookGrid.EnableHeadersVisualStyles = false;
            this.bookGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bookGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookGrid.Location = new System.Drawing.Point(548, 12);
            this.bookGrid.MultiSelect = false;
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bookGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookGrid.Size = new System.Drawing.Size(560, 582);
            this.bookGrid.TabIndex = 0;
            // 
            // editRow
            // 
            this.editRow.Location = new System.Drawing.Point(548, 599);
            this.editRow.Name = "editRow";
            this.editRow.Size = new System.Drawing.Size(117, 23);
            this.editRow.TabIndex = 1;
            this.editRow.Text = "Auswahl bearbeiten";
            this.editRow.UseSelectable = true;
            // 
            // removeRow
            // 
            this.removeRow.Location = new System.Drawing.Point(703, 599);
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(117, 23);
            this.removeRow.TabIndex = 2;
            this.removeRow.Text = "Auswahl entfernen";
            this.removeRow.UseSelectable = true;
            // 
            // starttime
            // 
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.starttime.Location = new System.Drawing.Point(286, 74);
            this.starttime.MinimumSize = new System.Drawing.Size(0, 29);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(200, 29);
            this.starttime.TabIndex = 3;
            this.starttime.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
            // 
            // endtime
            // 
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endtime.Location = new System.Drawing.Point(286, 128);
            this.endtime.MinimumSize = new System.Drawing.Size(0, 29);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(200, 29);
            this.endtime.TabIndex = 4;
            this.endtime.Value = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
            this.endtime.ValueChanged += new System.EventHandler(this.endtime_ValueChanged);
            // 
            // privateBusiness
            // 
            this.privateBusiness.FormattingEnabled = true;
            this.privateBusiness.ItemHeight = 23;
            this.privateBusiness.Items.AddRange(new object[] {
            "Privatkunde",
            "Geschäftskunde"});
            this.privateBusiness.Location = new System.Drawing.Point(12, 395);
            this.privateBusiness.Name = "privateBusiness";
            this.privateBusiness.Size = new System.Drawing.Size(199, 29);
            this.privateBusiness.TabIndex = 5;
            this.privateBusiness.UseSelectable = true;
            // 
            // roomNr
            // 
            this.roomNr.FormattingEnabled = true;
            this.roomNr.ItemHeight = 23;
            this.roomNr.Location = new System.Drawing.Point(286, 182);
            this.roomNr.Name = "roomNr";
            this.roomNr.Size = new System.Drawing.Size(200, 29);
            this.roomNr.TabIndex = 6;
            this.roomNr.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 373);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Privat/Geschäftskunde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(288, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Anreisedatum";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(286, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Abreisedatum";
            // 
            // newCustomer
            // 
            this.newCustomer.AutoSize = true;
            this.newCustomer.Checked = true;
            this.newCustomer.Location = new System.Drawing.Point(13, 13);
            this.newCustomer.Name = "newCustomer";
            this.newCustomer.Size = new System.Drawing.Size(78, 15);
            this.newCustomer.TabIndex = 10;
            this.newCustomer.TabStop = true;
            this.newCustomer.Text = "Neukunde";
            this.newCustomer.UseSelectable = true;
            this.newCustomer.CheckedChanged += new System.EventHandler(this.newCustomer_CheckedChanged);
            // 
            // oldCustomer
            // 
            this.oldCustomer.AutoSize = true;
            this.oldCustomer.Location = new System.Drawing.Point(109, 13);
            this.oldCustomer.Name = "oldCustomer";
            this.oldCustomer.Size = new System.Drawing.Size(103, 15);
            this.oldCustomer.TabIndex = 11;
            this.oldCustomer.Text = "Bestandskunde";
            this.oldCustomer.UseSelectable = true;
            // 
            // firstname
            // 
            // 
            // 
            // 
            this.firstname.CustomButton.Image = null;
            this.firstname.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.firstname.CustomButton.Name = "";
            this.firstname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.firstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstname.CustomButton.TabIndex = 1;
            this.firstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstname.CustomButton.UseSelectable = true;
            this.firstname.CustomButton.Visible = false;
            this.firstname.Lines = new string[0];
            this.firstname.Location = new System.Drawing.Point(11, 125);
            this.firstname.MaxLength = 32767;
            this.firstname.Name = "firstname";
            this.firstname.PasswordChar = '\0';
            this.firstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstname.SelectedText = "";
            this.firstname.SelectionLength = 0;
            this.firstname.SelectionStart = 0;
            this.firstname.ShortcutsEnabled = true;
            this.firstname.Size = new System.Drawing.Size(199, 29);
            this.firstname.TabIndex = 12;
            this.firstname.UseSelectable = true;
            this.firstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastname
            // 
            // 
            // 
            // 
            this.lastname.CustomButton.Image = null;
            this.lastname.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.lastname.CustomButton.Name = "";
            this.lastname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.lastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastname.CustomButton.TabIndex = 1;
            this.lastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastname.CustomButton.UseSelectable = true;
            this.lastname.CustomButton.Visible = false;
            this.lastname.Lines = new string[0];
            this.lastname.Location = new System.Drawing.Point(11, 179);
            this.lastname.MaxLength = 32767;
            this.lastname.Name = "lastname";
            this.lastname.PasswordChar = '\0';
            this.lastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastname.SelectedText = "";
            this.lastname.SelectionLength = 0;
            this.lastname.SelectionStart = 0;
            this.lastname.ShortcutsEnabled = true;
            this.lastname.Size = new System.Drawing.Size(199, 29);
            this.lastname.TabIndex = 13;
            this.lastname.UseSelectable = true;
            this.lastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // email
            // 
            // 
            // 
            // 
            this.email.CustomButton.Image = null;
            this.email.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.email.CustomButton.Name = "";
            this.email.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email.CustomButton.TabIndex = 1;
            this.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email.CustomButton.UseSelectable = true;
            this.email.CustomButton.Visible = false;
            this.email.Lines = new string[0];
            this.email.Location = new System.Drawing.Point(11, 233);
            this.email.MaxLength = 32767;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = true;
            this.email.Size = new System.Drawing.Size(199, 29);
            this.email.TabIndex = 14;
            this.email.UseSelectable = true;
            this.email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tel
            // 
            // 
            // 
            // 
            this.tel.CustomButton.Image = null;
            this.tel.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.tel.CustomButton.Name = "";
            this.tel.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tel.CustomButton.TabIndex = 1;
            this.tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tel.CustomButton.UseSelectable = true;
            this.tel.CustomButton.Visible = false;
            this.tel.Lines = new string[0];
            this.tel.Location = new System.Drawing.Point(12, 287);
            this.tel.MaxLength = 32767;
            this.tel.Name = "tel";
            this.tel.PasswordChar = '\0';
            this.tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tel.SelectedText = "";
            this.tel.SelectionLength = 0;
            this.tel.SelectionStart = 0;
            this.tel.ShortcutsEnabled = true;
            this.tel.Size = new System.Drawing.Size(199, 29);
            this.tel.TabIndex = 15;
            this.tel.UseSelectable = true;
            this.tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // address
            // 
            // 
            // 
            // 
            this.address.CustomButton.Image = null;
            this.address.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.address.CustomButton.Name = "";
            this.address.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address.CustomButton.TabIndex = 1;
            this.address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address.CustomButton.UseSelectable = true;
            this.address.CustomButton.Visible = false;
            this.address.Lines = new string[0];
            this.address.Location = new System.Drawing.Point(12, 341);
            this.address.MaxLength = 32767;
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address.SelectedText = "";
            this.address.SelectionLength = 0;
            this.address.SelectionStart = 0;
            this.address.ShortcutsEnabled = true;
            this.address.Size = new System.Drawing.Size(199, 29);
            this.address.TabIndex = 16;
            this.address.UseSelectable = true;
            this.address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // customerNr
            // 
            this.customerNr.Enabled = false;
            this.customerNr.FormattingEnabled = true;
            this.customerNr.ItemHeight = 23;
            this.customerNr.Location = new System.Drawing.Point(11, 74);
            this.customerNr.Name = "customerNr";
            this.customerNr.Size = new System.Drawing.Size(198, 29);
            this.customerNr.TabIndex = 17;
            this.customerNr.UseSelectable = true;
            this.customerNr.SelectedIndexChanged += new System.EventHandler(this.customerNr_SelectedIndexChanged);
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(285, 281);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(201, 29);
            this.book.TabIndex = 18;
            this.book.Text = "Buchen";
            this.book.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(286, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Zimmer";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(286, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Verpflegung";
            // 
            // boardNr
            // 
            this.boardNr.FormattingEnabled = true;
            this.boardNr.ItemHeight = 23;
            this.boardNr.Location = new System.Drawing.Point(286, 236);
            this.boardNr.Name = "boardNr";
            this.boardNr.Size = new System.Drawing.Size(200, 29);
            this.boardNr.TabIndex = 20;
            this.boardNr.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(12, 451);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(143, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Anzahl der Nächte";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(11, 480);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(144, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Preis pro Nacht";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(11, 509);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(144, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Verpflegungskosten";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 542);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(144, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "Gesamtpreis pro Nacht";
            // 
            // pricePerNight
            // 
            this.pricePerNight.Location = new System.Drawing.Point(172, 480);
            this.pricePerNight.Name = "pricePerNight";
            this.pricePerNight.Size = new System.Drawing.Size(76, 19);
            this.pricePerNight.TabIndex = 26;
            this.pricePerNight.Text = "0,00";
            // 
            // nightCount
            // 
            this.nightCount.Location = new System.Drawing.Point(172, 451);
            this.nightCount.Name = "nightCount";
            this.nightCount.Size = new System.Drawing.Size(76, 19);
            this.nightCount.TabIndex = 27;
            this.nightCount.Text = "0";
            this.nightCount.TextChanged += new System.EventHandler(this.nightCount_TextChanged);
            // 
            // boardPrice
            // 
            this.boardPrice.Location = new System.Drawing.Point(172, 509);
            this.boardPrice.Name = "boardPrice";
            this.boardPrice.Size = new System.Drawing.Size(76, 19);
            this.boardPrice.TabIndex = 28;
            this.boardPrice.Text = "0,00";
            // 
            // completePricePerNight
            // 
            this.completePricePerNight.Location = new System.Drawing.Point(172, 542);
            this.completePricePerNight.Name = "completePricePerNight";
            this.completePricePerNight.Size = new System.Drawing.Size(76, 19);
            this.completePricePerNight.TabIndex = 29;
            this.completePricePerNight.Text = "0,00";
            // 
            // netPrice
            // 
            this.netPrice.Location = new System.Drawing.Point(172, 574);
            this.netPrice.Name = "netPrice";
            this.netPrice.Size = new System.Drawing.Size(76, 19);
            this.netPrice.TabIndex = 31;
            this.netPrice.Text = "0,00";
            // 
            // metroLabel15
            // 
            this.metroLabel15.Location = new System.Drawing.Point(11, 574);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(144, 19);
            this.metroLabel15.TabIndex = 30;
            this.metroLabel15.Text = "Aufenthaltpreis";
            // 
            // mwst
            // 
            this.mwst.Location = new System.Drawing.Point(172, 607);
            this.mwst.Name = "mwst";
            this.mwst.Size = new System.Drawing.Size(76, 19);
            this.mwst.TabIndex = 33;
            this.mwst.Text = "0,00";
            // 
            // metroLabel17
            // 
            this.metroLabel17.Location = new System.Drawing.Point(11, 607);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(144, 19);
            this.metroLabel17.TabIndex = 32;
            this.metroLabel17.Text = "Mwst. 19%";
            // 
            // gross
            // 
            this.gross.Location = new System.Drawing.Point(172, 638);
            this.gross.Name = "gross";
            this.gross.Size = new System.Drawing.Size(76, 19);
            this.gross.TabIndex = 35;
            this.gross.Text = "0,00";
            // 
            // metroLabel19
            // 
            this.metroLabel19.Location = new System.Drawing.Point(11, 638);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(144, 19);
            this.metroLabel19.TabIndex = 34;
            this.metroLabel19.Text = "Bruttopreis";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(11, 106);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 36;
            this.metroLabel10.Text = "Vorname";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(11, 157);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 19);
            this.metroLabel11.TabIndex = 37;
            this.metroLabel11.Text = "Nachname";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(11, 211);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 19);
            this.metroLabel12.TabIndex = 38;
            this.metroLabel12.Text = "E-Mail";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(11, 265);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 19);
            this.metroLabel13.TabIndex = 39;
            this.metroLabel13.Text = "Telefonnummer";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(12, 319);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(63, 19);
            this.metroLabel14.TabIndex = 40;
            this.metroLabel14.Text = "Addresse";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(11, 52);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(102, 19);
            this.metroLabel16.TabIndex = 41;
            this.metroLabel16.Text = "Kundennummer";
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 669);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.gross);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.mwst);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.netPrice);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.completePricePerNight);
            this.Controls.Add(this.boardPrice);
            this.Controls.Add(this.nightCount);
            this.Controls.Add(this.pricePerNight);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.boardNr);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.book);
            this.Controls.Add(this.customerNr);
            this.Controls.Add(this.address);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.oldCustomer);
            this.Controls.Add(this.newCustomer);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.roomNr);
            this.Controls.Add(this.privateBusiness);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.removeRow);
            this.Controls.Add(this.editRow);
            this.Controls.Add(this.bookGrid);
            this.Name = "reservationForm";
            this.Text = "Reservierungen";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid bookGrid;
        private MetroFramework.Controls.MetroButton editRow;
        private MetroFramework.Controls.MetroButton removeRow;
        private MetroFramework.Controls.MetroDateTime starttime;
        private MetroFramework.Controls.MetroDateTime endtime;
        private MetroFramework.Controls.MetroComboBox privateBusiness;
        private MetroFramework.Controls.MetroComboBox roomNr;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton newCustomer;
        private MetroFramework.Controls.MetroRadioButton oldCustomer;
        private MetroFramework.Controls.MetroTextBox firstname;
        private MetroFramework.Controls.MetroTextBox lastname;
        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox tel;
        private MetroFramework.Controls.MetroTextBox address;
        private MetroFramework.Controls.MetroComboBox customerNr;
        private MetroFramework.Controls.MetroButton book;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox boardNr;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel pricePerNight;
        private MetroFramework.Controls.MetroLabel nightCount;
        private MetroFramework.Controls.MetroLabel boardPrice;
        private MetroFramework.Controls.MetroLabel completePricePerNight;
        private MetroFramework.Controls.MetroLabel netPrice;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel mwst;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel gross;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel16;
    }
}