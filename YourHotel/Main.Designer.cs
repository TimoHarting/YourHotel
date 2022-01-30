
namespace YourHotel
{
    partial class Main
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
            this.reservations = new MetroFramework.Controls.MetroButton();
            this.restaurant = new MetroFramework.Controls.MetroButton();
            this.spa = new MetroFramework.Controls.MetroButton();
            this.basedata = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // reservations
            // 
            this.reservations.Location = new System.Drawing.Point(32, 56);
            this.reservations.Name = "reservations";
            this.reservations.Size = new System.Drawing.Size(231, 66);
            this.reservations.TabIndex = 0;
            this.reservations.Text = "Reservierungen";
            this.reservations.UseSelectable = true;
            // 
            // restaurant
            // 
            this.restaurant.Location = new System.Drawing.Point(32, 128);
            this.restaurant.Name = "restaurant";
            this.restaurant.Size = new System.Drawing.Size(231, 66);
            this.restaurant.TabIndex = 1;
            this.restaurant.Text = "Restaurant";
            this.restaurant.UseSelectable = true;
            // 
            // spa
            // 
            this.spa.Location = new System.Drawing.Point(32, 200);
            this.spa.Name = "spa";
            this.spa.Size = new System.Drawing.Size(231, 66);
            this.spa.TabIndex = 2;
            this.spa.Text = "Spa";
            this.spa.UseSelectable = true;
            // 
            // basedata
            // 
            this.basedata.Location = new System.Drawing.Point(32, 350);
            this.basedata.Name = "basedata";
            this.basedata.Size = new System.Drawing.Size(231, 66);
            this.basedata.TabIndex = 3;
            this.basedata.Text = "Stammdaten";
            this.basedata.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 433);
            this.Controls.Add(this.basedata);
            this.Controls.Add(this.spa);
            this.Controls.Add(this.restaurant);
            this.Controls.Add(this.reservations);
            this.Name = "Main";
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton reservations;
        private MetroFramework.Controls.MetroButton restaurant;
        private MetroFramework.Controls.MetroButton spa;
        private MetroFramework.Controls.MetroButton basedata;
    }
}