using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using YourHotel.controller;

namespace YourHotel.forms
{
    public partial class restaurantForm : Form
    {
        public restaurantForm()
        {
            InitializeComponent();

            DataSet dset = new DataSet();
            dset = objects.foodCategory.LoadAll();
            List<string> l = new List<string>();

            foreach (DataTable table in dset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        l.Add(item.ToString());
                    }
                }
            }

            for (int i = 0; i < l.Count; i++)
            {
                Button button = new Button();
                button.Location = new Point(0, 30 * i + 10);
                button.Click += new EventHandler(categoryClicked);
                button.Tag = 0;
                button.Text = l[i];
                this.Controls.Add(button);
            }

            void categoryClicked(object sender, EventArgs e)
            {
                DataSet ds = new DataSet();
                Button button = sender as Button;
                if (button != null)
                {
                    switch ((int)button.Tag)
                    {
                        case 0:
                            string category = button.Text;
                            ds = resaurantFormController.selection(category);

                            List<string> u = new List<string>();

                            foreach (DataTable table in ds.Tables)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    u.Add(row.ItemArray[0].ToString() + " " + row.ItemArray[1].ToString());
                                }
                            }

                            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
                            {
                                panel1.Controls.RemoveAt(i);
                            }

                            for (int i = 0; i < u.Count; i++)
                            {
                                Button btn = new Button();
                                btn.Location = new Point(0, 30 * i + 10);
                                btn.Click += new EventHandler(foodClicked);
                                btn.Tag = 1;
                                btn.Text = u[i];
                                panel1.Controls.Add(btn);
                            }
                            break;
                    }
                }
            }

            void foodClicked(object sender, EventArgs e)
            {
                DataSet ds = new DataSet();
                Button button = sender as Button;
                if (button != null)
                {
                    switch ((int)button.Tag)
                    {
                        case 1:
                            //Nach kundenwahl name und preis in datenbank unter neuer rechnung speichern
                            string food = button.Text.Split(' ')[0];
                            double price = Convert.ToDouble(button.Text.Split(' ')[1]);
                            break;
                    }
                }
            }
        }
    }
}
