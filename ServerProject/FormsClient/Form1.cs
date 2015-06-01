using System;
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
            sch_Panel.Visible = false;
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
            try
            {
                foreach (Movie m in movieList)
                {
                    string id = m.MovieID.ToString();
                    copier += m.name + "  " + "id: " + id + "\n";
                }
                MovieBox.Clear();
                if(copier == "")
                {
                    MovieBox.AppendText("No Movies Found");
                }
                MovieBox.AppendText(copier);
            }
            catch
            {
                MovieBox.AppendText("Something went wrong");
            }
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
            try
            {
                Customer cus = client.GetCustomerByPhone(CusPhoneBox.Text);
                client.MakeReservation(RowBox.Text, SeatsBox.Text, int.Parse(SchIdBox3.Text), cus.CusID);

                BookBox.AppendText("Reservation was made for " + cus.name);
            }
            catch
            {
                BookBox.AppendText("Customer doesn't exist, or the chosen seats aren't available");
            }
        }

        private void GetAvailableSeatsBtn_Click(object sender, EventArgs e)
        {
            AvailableSeatBox.Clear();

            try
            {
                int[][] array = client.GetAllAvailableSeats(int.Parse(SchID2Box.Text));
                string copier = "Row     Seats\n";
                for (int x = 0; x < array.Length; x++)
                {
                    copier += x + 1 + "     " + array[x][0];
                    for (int y = 1; y < array[x].Length; y++)
                    {
                        copier += "-" + array[x][y];
                    }
                    copier += "\n";
                }
                AvailableSeatBox.AppendText(copier);
            }
            catch
            {
                AvailableSeatBox.AppendText("Something went wrong, does the specified scheduler exist?");
            }

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
            catch
            {
                ReserveListBox.AppendText("No reservations found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client.MakeCustomer(res_CusName.Text, res_CusPhone.Text, null, res_CusEmail.Text);
            }
            catch
            {
                res_CusEmail.AppendText("Error when creating");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cus_LogBox.Clear();
            try
            {
                client.MakeCustomer(cus_Name.Text, cus_Phone.Text, null, cus_Email.Text);
                cus_LogBox.AppendText("Customer was createed\n");
            }
            catch
            {
                cus_LogBox.AppendText("Something went wrong while trying to create customer");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cus_LogBox.Clear();
            try
            {
                client.UpdateCustomer(int.Parse(cus_CusID.Text), cus_Name.Text, cus_Email.Text, cus_Phone.Text, null);
                cus_LogBox.AppendText("Customer was updated");
            }
            catch
            {
                cus_LogBox.AppendText("Nothing was changed, does the customer exist?");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cus_LogBox.Clear();
            try
            {
                client.DeleteCustomer(int.Parse(cus_CusID.Text));
                cus_LogBox.AppendText("Customer deleted");

            }
            catch
            {
                cus_LogBox.AppendText("Could not delete customer, does the selected customer exist?");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cus_LogBox.Clear();
            try
            {
                Customer cus = client.GetCustomerByPhone(cus_PhoneBox.Text);
                cus_Name.Text = cus.name;
                cus_Phone.Text = cus.phoneNumber;
                cus_Email.Text = cus.mail;
                cus_CusID.Text = cus.CusID.ToString();
            }
            catch
            {
                cus_LogBox.AppendText("Could not find customer");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SchViewBox.Clear();
            try
            {
                DateTime date = Convert.ToDateTime(DateSearchBox.Text);  
                List<Scheduler> list = client.GetSchListByDate(date).ToList();
                if (0 < list.Count())
                {
                    string copier = "-----------------------------------------\n";
                    foreach (Scheduler sch in list)
                    {
                        copier += " ID: " + sch.SchID + "\n Date: " + sch.Date + "\n Time: " + sch.Starttime + "\n Hall: " + sch.HallID;
                        copier += "\n -----------------------------------\n";
                    }
                    SchedulerBox.AppendText(copier);
                }
                else
                {
                    SchedulerBox.AppendText("There are no Schedulers for that date");
                }
            }
            catch
            {
                SchViewBox.AppendText("Something went wrong");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sch_Log.Clear();
            try
            {
                DateTime date = Convert.ToDateTime(sch_Date.Text);
                TimeSpan time = TimeSpan.Parse(sch_Time.Text);

                client.MakeScheduler(date, time, int.Parse(sch_MovieID.Text), int.Parse(sch_HallID.Text));
                sch_Log.AppendText("Succesfully created scheduler");
            }
            catch
            {
                sch_Log.AppendText("Something went wrong, scheduler not created");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sch_Log.Clear();

            try
            {
                Scheduler sch = client.GetSchedulerByID(int.Parse(idSearchBox.Text));
                sch_Date.Text = sch.Date.ToString();
                sch_Time.Text = sch.Starttime.ToString();
                sch_MovieID.Text = sch.MovieID.ToString();
                sch_HallID.Text = sch.HallID.ToString();
                idBox1.Text = sch.SchID.ToString();
            }
            catch
            {
                sch_Log.AppendText("Could not find Scheduler");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sch_Log.Clear();
            try
            {
                client.DeleteSch(int.Parse(idBox1.Text));
                sch_Log.AppendText("Scheduler Deleted succesfully");
            }
            catch
            {
                sch_Log.AppendText("Scheduler could not be deleted, does the selected scheduler exist?");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sch_Log.Clear();
            try
            {
                DateTime date = Convert.ToDateTime(sch_Date.Text);
                TimeSpan time = TimeSpan.Parse(sch_Time.Text);
                client.UpdateScheduler(int.Parse(idBox1.Text), date, time, int.Parse(sch_MovieID.Text), int.Parse(sch_HallID.Text));
                sch_Log.AppendText("Scheduler updated succesfully");
            }

            catch
            {
                sch_Log.AppendText("Scheduler was not found, nothing was updated");
            }
            
        }
    }
}

