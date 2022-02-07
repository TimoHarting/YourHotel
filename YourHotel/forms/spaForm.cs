using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using YourHotel.objects.restaurant;

namespace YourHotel.forms
{
    public partial class spaForm : Form
    {
        public spaForm()
        {
            InitializeComponent();
            LoadRooms();
            LoadArticles();
        }

        private void LoadArticles()
        {
            DataSet dset = new DataSet();
            dset = objects.spa.spaObject.Load();
            List<string> l = new List<string>();

            foreach (DataTable table in dset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    l.Add(row.ItemArray[0].ToString() + " " + row.ItemArray[1].ToString());
                }
            }

            for (int i = 0; i < l.Count; i++)
            {
                Button button = new Button();
                button.Location = new Point(0, 30 * i + 10);
                button.Click += new EventHandler(spaClicked);
                button.Tag = 0;
                button.Text = l[i];
                panel1.Controls.Add(button);
            }
        }

        private void spaClicked(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Button button = sender as Button;
            if (button != null)
            {
                switch ((int)button.Tag)
                {
                    case 0:
                        string spa = button.Text.Split(' ')[0];
                        double price = Convert.ToDouble(button.Text.Split(' ')[1]);

                        bookGrid.Rows.Add(spa, price);
                        break;
                }
            }
        }

        private void LoadRooms()
        {
            DataSet ds = new DataSet();
            ds = objects.hotel.room.LoadAll();

            List<string> u = new List<string>();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    roomNr.Items.Add(row.ItemArray[0].ToString());
                }
            }
        }

        private void hotelguestCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hotelguestCheck.Checked)
            {
                metroLabel7.Visible = true;
                roomNr.Visible = true;
            }
            else if (hotelguestCheck.Checked == false)
            {
                metroLabel7.Visible = false;
                roomNr.Visible = false;
            }
        }

        private void removeArticle_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;

                for (int i = 0; i < bookGrid.SelectedRows.Count; ++i)
                {
                    a = Convert.ToInt32(bookGrid.SelectedRows[i].Index);
                }

                bookGrid.Rows.RemoveAt(a);
            }
            catch (Exception ex)
            {

            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            if (hotelguestCheck.Checked)
            {
                DataSet ds = new DataSet();
                int customerId = 0;
                int roomId = Convert.ToInt32(roomNr.Text.ToString());
                ds = objects.hotel.room.LoadRoomCustomer(roomId);

                DataTable dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        customerId = Convert.ToInt32(dr[dc].ToString());
                    }
                }

                bill b = new bill();
                b.customer = customerId;
                b.state = "offen";
                int billId = b.Save();

                for (int i = 0; i < bookGrid.Rows.Count - 1; ++i)
                {
                    billDetail bd = new billDetail();
                    bd.article = bookGrid.Rows[i].Cells[0].Value.ToString();
                    bd.price = Convert.ToDouble(bookGrid.Rows[i].Cells[1].Value.ToString());
                    bd.id = billId;
                    bd.Save();
                }

                bookGrid.Rows.Clear();
            }
            else
            {
                bookGrid.Rows.Clear();
            }
        }
    }
}
