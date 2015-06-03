namespace FormsClient
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
            this.Reserve = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.custo_Panel = new System.Windows.Forms.Panel();
            this.cus_LogBox = new System.Windows.Forms.RichTextBox();
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cus_CusID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cus_PhoneBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cus_Email = new System.Windows.Forms.TextBox();
            this.cus_Phone = new System.Windows.Forms.TextBox();
            this.cus_Name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.GetBestSeatsBtn = new System.Windows.Forms.Button();
            this.GetAvailableSeatsBtn = new System.Windows.Forms.Button();
            this.sch_Panel = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.sch_Log = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.DateSearchBox = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.SchViewBox = new System.Windows.Forms.RichTextBox();
            this.sch_HallID = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.idBox1 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.idSearchBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sch_MovieID = new System.Windows.Forms.TextBox();
            this.sch_Time = new System.Windows.Forms.TextBox();
            this.sch_Date = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Scheduler = new System.Windows.Forms.Button();
            this.Scheduler_Panel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.MovieBox = new System.Windows.Forms.RichTextBox();
            this.SchedulerBox = new System.Windows.Forms.RichTextBox();
            this.GetMovieButton = new System.Windows.Forms.Button();
            this.GetSchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.res_CusName = new System.Windows.Forms.TextBox();
            this.res_CusPhone = new System.Windows.Forms.TextBox();
            this.res_CusEmail = new System.Windows.Forms.TextBox();
            this.CreateCustomerBtn = new System.Windows.Forms.Button();
            this.FindCustomerBtn = new System.Windows.Forms.Button();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvailableSeatBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SeatListBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.MovieTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SchID1Box = new System.Windows.Forms.TextBox();
            this.SeatBox = new System.Windows.Forms.TextBox();
            this.SchID2Box = new System.Windows.Forms.TextBox();
            this.ReserveListBox = new System.Windows.Forms.RichTextBox();
            this.GetResBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RowBox = new System.Windows.Forms.TextBox();
            this.SeatsBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SchIdBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CusPhoneBox = new System.Windows.Forms.TextBox();
            this.BookBox = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.res_CustoInfo = new System.Windows.Forms.TextBox();
            this.custo_Panel.SuspendLayout();
            this.sch_Panel.SuspendLayout();
            this.Scheduler_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(12, 12);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(97, 27);
            this.Reserve.TabIndex = 3;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.res_Reservation_Click);
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(115, 12);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(103, 27);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // custo_Panel
            // 
            this.custo_Panel.Controls.Add(this.cus_LogBox);
            this.custo_Panel.Controls.Add(this.DeleteCustomerBtn);
            this.custo_Panel.Controls.Add(this.button3);
            this.custo_Panel.Controls.Add(this.cus_CusID);
            this.custo_Panel.Controls.Add(this.label20);
            this.custo_Panel.Controls.Add(this.label15);
            this.custo_Panel.Controls.Add(this.cus_PhoneBox);
            this.custo_Panel.Controls.Add(this.button1);
            this.custo_Panel.Controls.Add(this.button2);
            this.custo_Panel.Controls.Add(this.cus_Email);
            this.custo_Panel.Controls.Add(this.cus_Phone);
            this.custo_Panel.Controls.Add(this.cus_Name);
            this.custo_Panel.Controls.Add(this.label16);
            this.custo_Panel.Controls.Add(this.label17);
            this.custo_Panel.Controls.Add(this.label18);
            this.custo_Panel.Controls.Add(this.label19);
            this.custo_Panel.Location = new System.Drawing.Point(1, 42);
            this.custo_Panel.Name = "custo_Panel";
            this.custo_Panel.Size = new System.Drawing.Size(789, 417);
            this.custo_Panel.TabIndex = 6;
            this.custo_Panel.Visible = false;
            this.custo_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_3);
            // 
            // cus_LogBox
            // 
            this.cus_LogBox.Location = new System.Drawing.Point(350, 30);
            this.cus_LogBox.Name = "cus_LogBox";
            this.cus_LogBox.Size = new System.Drawing.Size(425, 232);
            this.cus_LogBox.TabIndex = 49;
            this.cus_LogBox.Text = "";
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(3, 194);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(72, 23);
            this.DeleteCustomerBtn.TabIndex = 48;
            this.DeleteCustomerBtn.Text = "Delete";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cus_CusID
            // 
            this.cus_CusID.Location = new System.Drawing.Point(70, 37);
            this.cus_CusID.Name = "cus_CusID";
            this.cus_CusID.ReadOnly = true;
            this.cus_CusID.Size = new System.Drawing.Size(100, 20);
            this.cus_CusID.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(173, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 44;
            this.label15.Text = "Phone:";
            // 
            // cus_PhoneBox
            // 
            this.cus_PhoneBox.Location = new System.Drawing.Point(220, 64);
            this.cus_PhoneBox.Name = "cus_PhoneBox";
            this.cus_PhoneBox.Size = new System.Drawing.Size(105, 20);
            this.cus_PhoneBox.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Find Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Create new Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // cus_Email
            // 
            this.cus_Email.Location = new System.Drawing.Point(70, 131);
            this.cus_Email.Name = "cus_Email";
            this.cus_Email.Size = new System.Drawing.Size(100, 20);
            this.cus_Email.TabIndex = 40;
            // 
            // cus_Phone
            // 
            this.cus_Phone.Location = new System.Drawing.Point(70, 97);
            this.cus_Phone.Name = "cus_Phone";
            this.cus_Phone.Size = new System.Drawing.Size(100, 20);
            this.cus_Phone.TabIndex = 39;
            // 
            // cus_Name
            // 
            this.cus_Name.Location = new System.Drawing.Point(70, 64);
            this.cus_Name.Name = "cus_Name";
            this.cus_Name.Size = new System.Drawing.Size(100, 20);
            this.cus_Name.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 24);
            this.label16.TabIndex = 37;
            this.label16.Text = "Customer information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "Phone:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 15);
            this.label19.TabIndex = 34;
            this.label19.Text = "Name:";
            // 
            // GetBestSeatsBtn
            // 
            this.GetBestSeatsBtn.Location = new System.Drawing.Point(349, 436);
            this.GetBestSeatsBtn.Name = "GetBestSeatsBtn";
            this.GetBestSeatsBtn.Size = new System.Drawing.Size(189, 23);
            this.GetBestSeatsBtn.TabIndex = 33;
            this.GetBestSeatsBtn.Text = "Get best seats";
            this.GetBestSeatsBtn.UseVisualStyleBackColor = true;
            this.GetBestSeatsBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // GetAvailableSeatsBtn
            // 
            this.GetAvailableSeatsBtn.Location = new System.Drawing.Point(571, 436);
            this.GetAvailableSeatsBtn.Name = "GetAvailableSeatsBtn";
            this.GetAvailableSeatsBtn.Size = new System.Drawing.Size(189, 23);
            this.GetAvailableSeatsBtn.TabIndex = 27;
            this.GetAvailableSeatsBtn.Text = "Get available seats";
            this.GetAvailableSeatsBtn.UseVisualStyleBackColor = true;
            this.GetAvailableSeatsBtn.Click += new System.EventHandler(this.GetAvailableSeatsBtn_Click);
            // 
            // sch_Panel
            // 
            this.sch_Panel.Controls.Add(this.label30);
            this.sch_Panel.Controls.Add(this.sch_Log);
            this.sch_Panel.Controls.Add(this.label29);
            this.sch_Panel.Controls.Add(this.DateSearchBox);
            this.sch_Panel.Controls.Add(this.button9);
            this.sch_Panel.Controls.Add(this.SchViewBox);
            this.sch_Panel.Controls.Add(this.sch_HallID);
            this.sch_Panel.Controls.Add(this.label28);
            this.sch_Panel.Controls.Add(this.label27);
            this.sch_Panel.Controls.Add(this.button5);
            this.sch_Panel.Controls.Add(this.button6);
            this.sch_Panel.Controls.Add(this.idBox1);
            this.sch_Panel.Controls.Add(this.label22);
            this.sch_Panel.Controls.Add(this.idSearchBox);
            this.sch_Panel.Controls.Add(this.button7);
            this.sch_Panel.Controls.Add(this.button8);
            this.sch_Panel.Controls.Add(this.sch_MovieID);
            this.sch_Panel.Controls.Add(this.sch_Time);
            this.sch_Panel.Controls.Add(this.sch_Date);
            this.sch_Panel.Controls.Add(this.label23);
            this.sch_Panel.Controls.Add(this.label24);
            this.sch_Panel.Controls.Add(this.label25);
            this.sch_Panel.Controls.Add(this.label26);
            this.sch_Panel.Location = new System.Drawing.Point(1, 42);
            this.sch_Panel.Name = "sch_Panel";
            this.sch_Panel.Size = new System.Drawing.Size(806, 417);
            this.sch_Panel.TabIndex = 8;
            this.sch_Panel.Visible = false;
            this.sch_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sch_Panel_Paint);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(13, 271);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 24);
            this.label30.TabIndex = 71;
            this.label30.Text = "Log";
            // 
            // sch_Log
            // 
            this.sch_Log.Location = new System.Drawing.Point(13, 303);
            this.sch_Log.Name = "sch_Log";
            this.sch_Log.Size = new System.Drawing.Size(184, 45);
            this.sch_Log.TabIndex = 70;
            this.sch_Log.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(390, 303);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 69;
            this.label29.Text = "Date:";
            // 
            // DateSearchBox
            // 
            this.DateSearchBox.Location = new System.Drawing.Point(429, 300);
            this.DateSearchBox.Name = "DateSearchBox";
            this.DateSearchBox.Size = new System.Drawing.Size(118, 20);
            this.DateSearchBox.TabIndex = 68;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(393, 274);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 23);
            this.button9.TabIndex = 67;
            this.button9.Text = "Get Schedulers";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SchViewBox
            // 
            this.SchViewBox.Location = new System.Drawing.Point(393, 3);
            this.SchViewBox.Name = "SchViewBox";
            this.SchViewBox.Size = new System.Drawing.Size(379, 265);
            this.SchViewBox.TabIndex = 66;
            this.SchViewBox.Text = "";
            // 
            // sch_HallID
            // 
            this.sch_HallID.Location = new System.Drawing.Point(68, 155);
            this.sch_HallID.Name = "sch_HallID";
            this.sch_HallID.Size = new System.Drawing.Size(100, 20);
            this.sch_HallID.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 15);
            this.label28.TabIndex = 64;
            this.label28.Text = "Hall ID:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 15);
            this.label27.TabIndex = 63;
            this.label27.Text = "ID:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 23);
            this.button6.TabIndex = 61;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // idBox1
            // 
            this.idBox1.Location = new System.Drawing.Point(68, 33);
            this.idBox1.Name = "idBox1";
            this.idBox1.ReadOnly = true;
            this.idBox1.Size = new System.Drawing.Size(100, 20);
            this.idBox1.TabIndex = 60;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(177, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "ID:";
            // 
            // idSearchBox
            // 
            this.idSearchBox.Location = new System.Drawing.Point(218, 60);
            this.idSearchBox.Name = "idSearchBox";
            this.idSearchBox.Size = new System.Drawing.Size(105, 20);
            this.idSearchBox.TabIndex = 58;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 23);
            this.button7.TabIndex = 57;
            this.button7.Text = "Find Scheduler";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 23);
            this.button8.TabIndex = 56;
            this.button8.Text = "Create new Customer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sch_MovieID
            // 
            this.sch_MovieID.Location = new System.Drawing.Point(68, 127);
            this.sch_MovieID.Name = "sch_MovieID";
            this.sch_MovieID.Size = new System.Drawing.Size(100, 20);
            this.sch_MovieID.TabIndex = 55;
            // 
            // sch_Time
            // 
            this.sch_Time.Location = new System.Drawing.Point(68, 93);
            this.sch_Time.Name = "sch_Time";
            this.sch_Time.Size = new System.Drawing.Size(100, 20);
            this.sch_Time.TabIndex = 54;
            // 
            // sch_Date
            // 
            this.sch_Date.Location = new System.Drawing.Point(68, 60);
            this.sch_Date.Name = "sch_Date";
            this.sch_Date.Size = new System.Drawing.Size(100, 20);
            this.sch_Date.TabIndex = 53;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 24);
            this.label23.TabIndex = 52;
            this.label23.Text = "Scheduler";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 15);
            this.label24.TabIndex = 51;
            this.label24.Text = "Movie ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 15);
            this.label25.TabIndex = 50;
            this.label25.Text = "Start time:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(8, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(36, 15);
            this.label26.TabIndex = 49;
            this.label26.Text = "Date:";
            // 
            // Scheduler
            // 
            this.Scheduler.Location = new System.Drawing.Point(224, 12);
            this.Scheduler.Name = "Scheduler";
            this.Scheduler.Size = new System.Drawing.Size(100, 27);
            this.Scheduler.TabIndex = 7;
            this.Scheduler.Text = "Scheduler";
            this.Scheduler.UseVisualStyleBackColor = true;
            this.Scheduler.Click += new System.EventHandler(this.Scheduler_Click);
            // 
            // Scheduler_Panel
            // 
            this.Scheduler_Panel.Controls.Add(this.textBox3);
            this.Scheduler_Panel.Location = new System.Drawing.Point(0, 32);
            this.Scheduler_Panel.Name = "Scheduler_Panel";
            this.Scheduler_Panel.Size = new System.Drawing.Size(787, 376);
            this.Scheduler_Panel.TabIndex = 1;
            this.Scheduler_Panel.Visible = false;
            this.Scheduler_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Scheduler_Panel_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "sched";
            // 
            // MovieBox
            // 
            this.MovieBox.Location = new System.Drawing.Point(349, 42);
            this.MovieBox.Name = "MovieBox";
            this.MovieBox.Size = new System.Drawing.Size(189, 229);
            this.MovieBox.TabIndex = 9;
            this.MovieBox.Text = "";
            this.MovieBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SchedulerBox
            // 
            this.SchedulerBox.Location = new System.Drawing.Point(563, 44);
            this.SchedulerBox.Name = "SchedulerBox";
            this.SchedulerBox.Size = new System.Drawing.Size(191, 200);
            this.SchedulerBox.TabIndex = 10;
            this.SchedulerBox.Text = "";
            // 
            // GetMovieButton
            // 
            this.GetMovieButton.Location = new System.Drawing.Point(349, 277);
            this.GetMovieButton.Name = "GetMovieButton";
            this.GetMovieButton.Size = new System.Drawing.Size(189, 23);
            this.GetMovieButton.TabIndex = 11;
            this.GetMovieButton.Text = "Get Movies";
            this.GetMovieButton.UseVisualStyleBackColor = true;
            this.GetMovieButton.Click += new System.EventHandler(this.GetMovieButton_Click);
            // 
            // GetSchButton
            // 
            this.GetSchButton.Location = new System.Drawing.Point(563, 277);
            this.GetSchButton.Name = "GetSchButton";
            this.GetSchButton.Size = new System.Drawing.Size(191, 23);
            this.GetSchButton.TabIndex = 12;
            this.GetSchButton.Text = "Get Schedulers";
            this.GetSchButton.UseVisualStyleBackColor = true;
            this.GetSchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Movie ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer information";
            // 
            // res_CusName
            // 
            this.res_CusName.Location = new System.Drawing.Point(69, 75);
            this.res_CusName.Name = "res_CusName";
            this.res_CusName.Size = new System.Drawing.Size(100, 20);
            this.res_CusName.TabIndex = 19;
            this.res_CusName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // res_CusPhone
            // 
            this.res_CusPhone.Location = new System.Drawing.Point(69, 108);
            this.res_CusPhone.Name = "res_CusPhone";
            this.res_CusPhone.Size = new System.Drawing.Size(100, 20);
            this.res_CusPhone.TabIndex = 20;
            // 
            // res_CusEmail
            // 
            this.res_CusEmail.Location = new System.Drawing.Point(69, 142);
            this.res_CusEmail.Name = "res_CusEmail";
            this.res_CusEmail.Size = new System.Drawing.Size(100, 20);
            this.res_CusEmail.TabIndex = 21;
            // 
            // CreateCustomerBtn
            // 
            this.CreateCustomerBtn.Location = new System.Drawing.Point(12, 178);
            this.CreateCustomerBtn.Name = "CreateCustomerBtn";
            this.CreateCustomerBtn.Size = new System.Drawing.Size(157, 23);
            this.CreateCustomerBtn.TabIndex = 22;
            this.CreateCustomerBtn.Text = "Create new Customer";
            this.CreateCustomerBtn.UseVisualStyleBackColor = true;
            this.CreateCustomerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindCustomerBtn
            // 
            this.FindCustomerBtn.Location = new System.Drawing.Point(12, 230);
            this.FindCustomerBtn.Name = "FindCustomerBtn";
            this.FindCustomerBtn.Size = new System.Drawing.Size(157, 23);
            this.FindCustomerBtn.TabIndex = 23;
            this.FindCustomerBtn.Text = "Find Customer";
            this.FindCustomerBtn.UseVisualStyleBackColor = true;
            this.FindCustomerBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(69, 263);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone:";
            // 
            // AvailableSeatBox
            // 
            this.AvailableSeatBox.Location = new System.Drawing.Point(571, 310);
            this.AvailableSeatBox.Name = "AvailableSeatBox";
            this.AvailableSeatBox.Size = new System.Drawing.Size(189, 68);
            this.AvailableSeatBox.TabIndex = 26;
            this.AvailableSeatBox.Text = "";
            this.AvailableSeatBox.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Scheduler ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SeatListBox
            // 
            this.SeatListBox.Location = new System.Drawing.Point(349, 310);
            this.SeatListBox.Name = "SeatListBox";
            this.SeatListBox.Size = new System.Drawing.Size(189, 68);
            this.SeatListBox.TabIndex = 30;
            this.SeatListBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Scheduler ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Seats to book:";
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.Location = new System.Drawing.Point(12, 425);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(157, 23);
            this.ReserveBtn.TabIndex = 37;
            this.ReserveBtn.Text = "Reserve!";
            this.ReserveBtn.UseVisualStyleBackColor = true;
            this.ReserveBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // MovieTextBox
            // 
            this.MovieTextBox.Location = new System.Drawing.Point(648, 250);
            this.MovieTextBox.Name = "MovieTextBox";
            this.MovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieTextBox.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Seats to Reserve";
            // 
            // SchID1Box
            // 
            this.SchID1Box.Location = new System.Drawing.Point(497, 384);
            this.SchID1Box.Name = "SchID1Box";
            this.SchID1Box.Size = new System.Drawing.Size(41, 20);
            this.SchID1Box.TabIndex = 40;
            // 
            // SeatBox
            // 
            this.SeatBox.Location = new System.Drawing.Point(497, 410);
            this.SeatBox.Name = "SeatBox";
            this.SeatBox.Size = new System.Drawing.Size(43, 20);
            this.SeatBox.TabIndex = 41;
            // 
            // SchID2Box
            // 
            this.SchID2Box.Location = new System.Drawing.Point(717, 389);
            this.SchID2Box.Name = "SchID2Box";
            this.SchID2Box.Size = new System.Drawing.Size(43, 20);
            this.SchID2Box.TabIndex = 42;
            // 
            // ReserveListBox
            // 
            this.ReserveListBox.Location = new System.Drawing.Point(207, 42);
            this.ReserveListBox.Name = "ReserveListBox";
            this.ReserveListBox.Size = new System.Drawing.Size(117, 229);
            this.ReserveListBox.TabIndex = 43;
            this.ReserveListBox.Text = "";
            // 
            // GetResBtn
            // 
            this.GetResBtn.Location = new System.Drawing.Point(207, 277);
            this.GetResBtn.Name = "GetResBtn";
            this.GetResBtn.Size = new System.Drawing.Size(117, 23);
            this.GetResBtn.TabIndex = 44;
            this.GetResBtn.Text = "Get Reservation";
            this.GetResBtn.UseVisualStyleBackColor = true;
            this.GetResBtn.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Rows:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Seats:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // RowBox
            // 
            this.RowBox.Location = new System.Drawing.Point(55, 318);
            this.RowBox.Name = "RowBox";
            this.RowBox.Size = new System.Drawing.Size(114, 20);
            this.RowBox.TabIndex = 47;
            // 
            // SeatsBox
            // 
            this.SeatsBox.Location = new System.Drawing.Point(55, 344);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(114, 20);
            this.SeatsBox.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Scheduler ID:";
            // 
            // SchIdBox3
            // 
            this.SchIdBox3.Location = new System.Drawing.Point(96, 373);
            this.SchIdBox3.Name = "SchIdBox3";
            this.SchIdBox3.Size = new System.Drawing.Size(73, 20);
            this.SchIdBox3.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Customer Phone:";
            // 
            // CusPhoneBox
            // 
            this.CusPhoneBox.Location = new System.Drawing.Point(96, 402);
            this.CusPhoneBox.Name = "CusPhoneBox";
            this.CusPhoneBox.Size = new System.Drawing.Size(73, 20);
            this.CusPhoneBox.TabIndex = 52;
            // 
            // BookBox
            // 
            this.BookBox.Location = new System.Drawing.Point(207, 310);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(117, 140);
            this.BookBox.TabIndex = 53;
            this.BookBox.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(360, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 0;
            // 
            // res_CustoInfo
            // 
            this.res_CustoInfo.Location = new System.Drawing.Point(15, 204);
            this.res_CustoInfo.Name = "res_CustoInfo";
            this.res_CustoInfo.Size = new System.Drawing.Size(154, 20);
            this.res_CustoInfo.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 460);
            this.Controls.Add(this.sch_Panel);
            this.Controls.Add(this.custo_Panel);
            this.Controls.Add(this.res_CustoInfo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.CusPhoneBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SchIdBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.RowBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GetResBtn);
            this.Controls.Add(this.ReserveListBox);
            this.Controls.Add(this.SchID2Box);
            this.Controls.Add(this.GetAvailableSeatsBtn);
            this.Controls.Add(this.GetBestSeatsBtn);
            this.Controls.Add(this.SeatBox);
            this.Controls.Add(this.SchID1Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MovieTextBox);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SeatListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AvailableSeatBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.FindCustomerBtn);
            this.Controls.Add(this.CreateCustomerBtn);
            this.Controls.Add(this.res_CusEmail);
            this.Controls.Add(this.res_CusPhone);
            this.Controls.Add(this.res_CusName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetSchButton);
            this.Controls.Add(this.GetMovieButton);
            this.Controls.Add(this.SchedulerBox);
            this.Controls.Add(this.MovieBox);
            this.Controls.Add(this.Scheduler);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Reserve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.custo_Panel.ResumeLayout(false);
            this.custo_Panel.PerformLayout();
            this.sch_Panel.ResumeLayout(false);
            this.sch_Panel.PerformLayout();
            this.Scheduler_Panel.ResumeLayout(false);
            this.Scheduler_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Panel custo_Panel;
        private System.Windows.Forms.Panel Scheduler_Panel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Scheduler;
        private System.Windows.Forms.Panel sch_Panel;
        private System.Windows.Forms.RichTextBox MovieBox;
        private System.Windows.Forms.RichTextBox SchedulerBox;
        private System.Windows.Forms.Button GetMovieButton;
        private System.Windows.Forms.Button GetSchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox res_CusName;
        private System.Windows.Forms.TextBox res_CusPhone;
        private System.Windows.Forms.TextBox res_CusEmail;
        private System.Windows.Forms.Button CreateCustomerBtn;
        private System.Windows.Forms.Button FindCustomerBtn;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox AvailableSeatBox;
        private System.Windows.Forms.Button GetAvailableSeatsBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox SeatListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GetBestSeatsBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.TextBox MovieTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SchID1Box;
        private System.Windows.Forms.TextBox SeatBox;
        private System.Windows.Forms.TextBox SchID2Box;
        private System.Windows.Forms.RichTextBox ReserveListBox;
        private System.Windows.Forms.Button GetResBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RowBox;
        private System.Windows.Forms.TextBox SeatsBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SchIdBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CusPhoneBox;
        private System.Windows.Forms.RichTextBox BookBox;
        private System.Windows.Forms.RichTextBox cus_LogBox;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cus_CusID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cus_PhoneBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cus_Email;
        private System.Windows.Forms.TextBox cus_Phone;
        private System.Windows.Forms.TextBox cus_Name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox idBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox idSearchBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox sch_MovieID;
        private System.Windows.Forms.TextBox sch_Time;
        private System.Windows.Forms.TextBox sch_Date;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox DateSearchBox;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox SchViewBox;
        private System.Windows.Forms.TextBox sch_HallID;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.RichTextBox sch_Log;
        private System.Windows.Forms.TextBox res_CustoInfo;

    }
}

