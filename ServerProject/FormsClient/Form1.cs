﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsClient.ServiceReference1;

namespace FormsClient
{
    public partial class Form1 : Form
    {
        // custom
        CustomerServiceClient client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void res_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void res_Customer_Click(object sender, EventArgs e)
        {
                      
        }

        private void res_Reservation_Click(object sender, EventArgs e)
        {
            sch_Panel.Visible = true;
            custo_Panel.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cust_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {
            sch_Panel.Visible = false;
            custo_Panel.Visible = true;
        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void Scheduler_Click(object sender, EventArgs e)
        {
            custo_Panel.Visible = false;
            sch_Panel.Visible = true;
        }

        private void Scheduler_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sch_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SchedulerBox.Clear();
            List<Scheduler> SchList = new List<Scheduler>();

            try
            {
                int ID = int.Parse(MovieTextBox.Text); 
                SchList = client.GetSchedulerListByMovieID(ID).ToList();
                if (0 < SchList.Count())
                {
                    string copier = "-----------------------------------------\n";
                    foreach (Scheduler sch in SchList)
                    {
                        copier += " ID: " + sch.SchID + "\n Date: " + sch.Date + "\n Time: " + sch.Starttime + "\n Hall: " + sch.HallID;
                        copier += "\n -----------------------------------\n";
                    }
                    SchedulerBox.AppendText(copier);
                }
                else
                {
                    SchedulerBox.AppendText("There are no Schedulers witht that movie");
                }

            }
            catch(Exception i)
            {
                SchedulerBox.AppendText("Something went wrong\n" + i);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetMovieButton_Click(object sender, EventArgs e)
        {
            List<Movie> movieList = new List<Movie>();
            movieList = client.GetAllMovies().ToList();
            string copier = "";
            foreach(Movie m in movieList)
            {
                string id = m.MovieID.ToString();
                copier += m.name + "  " + "id: " + id + "\n";
            }
            MovieBox.Clear();
            MovieBox.AppendText(copier);
        }

        private void MovieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {             
            try
            {
                int[] array = client.GetBestSeats(int.Parse(SeatBox.Text), int.Parse(SchID1Box.Text));
                string copier = "";
                SeatListBox.Clear();
                copier = "Row: " + array[1] + "\n" + "Seats: ";

                for (int i = 2; i < array.Length ; i++)
                {
                    copier += array[i].ToString() + ", ";
                }
                SeatListBox.AppendText(copier);
            }
            catch(Exception ex)
            {
                SeatListBox.AppendText("Something went wrong" + ex);
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void GetAvailableSeatsBtn_Click(object sender, EventArgs e)
        {
            AvailableSeatBox.Clear();
            int[][] array = client.GetAllAvailableSeats(int.Parse(SchID2Box.Text));
            string copier = "Row     Seats\n";
            for(int x = 0; x < array.Length; x++)
            {
                copier += x+1 + "     " + array[x][0];
                for(int y = 1; y < array[x].Length; y++)
                {
                        copier += "-" + array[x][y];
                }
                copier += "\n";
            }
            AvailableSeatBox.AppendText(copier);

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Customer c = client.GetCustomerByPhone(PhoneBox.Text);
                res_CusName.Text = c.name;
                res_CusPhone.Text = c.phoneNumber;
                res_CusEmail.Text = c.mail;
            }

            catch
            {
                res_CusPhone.Text = "None found";
                res_CusName.Text = "None found";
                res_CusEmail.Text = "None found";
            }
        }

        private void GetRes_Click(object sender, EventArgs e)
        {
            string copier = "";
            ReserveListBox.Clear();
            try
            {
                List<Reservation> list = client.GetResByCusPhone(PhoneBox.Text).ToList();

                foreach (Reservation res in list)
                {
                    copier += "Row: " + res.Row + "\nSeats: " + res.Seat + "\n";
                    copier += "-----------------------------------";
                }
                ReserveListBox.AppendText(copier);
            }
            catch(Exception exe)
            {
                ReserveListBox.AppendText("bad\n" + exe);
            }
        }
    }
}

