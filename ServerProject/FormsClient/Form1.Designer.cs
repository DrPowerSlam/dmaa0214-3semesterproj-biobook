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
            this.Reservation = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.custo_Panel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Scheduler = new System.Windows.Forms.Button();
            this.Scheduler_Panel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sch_Panel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.GetAvailableSeatsBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SeatListBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GetBestSeatsBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.MovieTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SchID1Box = new System.Windows.Forms.TextBox();
            this.SeatBox = new System.Windows.Forms.TextBox();
            this.SchID2Box = new System.Windows.Forms.TextBox();
            this.ReserveListBox = new System.Windows.Forms.RichTextBox();
            this.GetResBtn = new System.Windows.Forms.Button();
            this.custo_Panel.SuspendLayout();
            this.Scheduler_Panel.SuspendLayout();
            this.sch_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reservation
            // 
            this.Reservation.Location = new System.Drawing.Point(12, 12);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(97, 27);
            this.Reservation.TabIndex = 3;
            this.Reservation.Text = "Reservation";
            this.Reservation.UseVisualStyleBackColor = true;
            this.Reservation.Click += new System.EventHandler(this.res_Reservation_Click);
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
            this.custo_Panel.Controls.Add(this.textBox2);
            this.custo_Panel.Location = new System.Drawing.Point(766, 339);
            this.custo_Panel.Name = "custo_Panel";
            this.custo_Panel.Size = new System.Drawing.Size(21, 10);
            this.custo_Panel.TabIndex = 6;
            this.custo_Panel.Visible = false;
            this.custo_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_3);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "cust";
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
            // sch_Panel
            // 
            this.sch_Panel.Controls.Add(this.textBox4);
            this.sch_Panel.Location = new System.Drawing.Point(760, 352);
            this.sch_Panel.Name = "sch_Panel";
            this.sch_Panel.Size = new System.Drawing.Size(27, 10);
            this.sch_Panel.TabIndex = 8;
            this.sch_Panel.Visible = false;
            this.sch_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sch_Panel_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(302, 219);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "sch";
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
            this.FindCustomerBtn.Location = new System.Drawing.Point(12, 221);
            this.FindCustomerBtn.Name = "FindCustomerBtn";
            this.FindCustomerBtn.Size = new System.Drawing.Size(157, 23);
            this.FindCustomerBtn.TabIndex = 23;
            this.FindCustomerBtn.Text = "Find Customer";
            this.FindCustomerBtn.UseVisualStyleBackColor = true;
            this.FindCustomerBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(69, 247);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone:";
            // 
            // AvailableSeatBox
            // 
            this.AvailableSeatBox.Location = new System.Drawing.Point(571, 310);
            this.AvailableSeatBox.Name = "AvailableSeatBox";
            this.AvailableSeatBox.Size = new System.Drawing.Size(189, 83);
            this.AvailableSeatBox.TabIndex = 26;
            this.AvailableSeatBox.Text = "";
            this.AvailableSeatBox.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // GetAvailableSeatsBtn
            // 
            this.GetAvailableSeatsBtn.Location = new System.Drawing.Point(571, 425);
            this.GetAvailableSeatsBtn.Name = "GetAvailableSeatsBtn";
            this.GetAvailableSeatsBtn.Size = new System.Drawing.Size(189, 23);
            this.GetAvailableSeatsBtn.TabIndex = 27;
            this.GetAvailableSeatsBtn.Text = "Get available seats";
            this.GetAvailableSeatsBtn.UseVisualStyleBackColor = true;
            this.GetAvailableSeatsBtn.Click += new System.EventHandler(this.GetAvailableSeatsBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Scheduler ID:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Seats to book:";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(10, 339);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(126, 57);
            this.richTextBox8.TabIndex = 36;
            this.richTextBox8.Text = "";
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.Location = new System.Drawing.Point(10, 402);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(126, 23);
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
            this.SchID2Box.Location = new System.Drawing.Point(717, 399);
            this.SchID2Box.Name = "SchID2Box";
            this.SchID2Box.Size = new System.Drawing.Size(43, 20);
            this.SchID2Box.TabIndex = 42;
            // 
            // ReserveListBox
            // 
            this.ReserveListBox.Location = new System.Drawing.Point(207, 49);
            this.ReserveListBox.Name = "ReserveListBox";
            this.ReserveListBox.Size = new System.Drawing.Size(117, 329);
            this.ReserveListBox.TabIndex = 43;
            this.ReserveListBox.Text = "";
            // 
            // GetResBtn
            // 
            this.GetResBtn.Location = new System.Drawing.Point(207, 384);
            this.GetResBtn.Name = "GetResBtn";
            this.GetResBtn.Size = new System.Drawing.Size(117, 28);
            this.GetResBtn.TabIndex = 44;
            this.GetResBtn.Text = "Get Reservation";
            this.GetResBtn.UseVisualStyleBackColor = true;
            this.GetResBtn.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 460);
            this.Controls.Add(this.GetResBtn);
            this.Controls.Add(this.ReserveListBox);
            this.Controls.Add(this.SchID2Box);
            this.Controls.Add(this.SeatBox);
            this.Controls.Add(this.SchID1Box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MovieTextBox);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GetBestSeatsBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SeatListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GetAvailableSeatsBtn);
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
            this.Controls.Add(this.sch_Panel);
            this.Controls.Add(this.Scheduler);
            this.Controls.Add(this.custo_Panel);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Reservation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.custo_Panel.ResumeLayout(false);
            this.custo_Panel.PerformLayout();
            this.Scheduler_Panel.ResumeLayout(false);
            this.Scheduler_Panel.PerformLayout();
            this.sch_Panel.ResumeLayout(false);
            this.sch_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reservation;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Panel custo_Panel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel Scheduler_Panel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Scheduler;
        private System.Windows.Forms.Panel sch_Panel;
        private System.Windows.Forms.TextBox textBox4;
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
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.TextBox MovieTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SchID1Box;
        private System.Windows.Forms.TextBox SeatBox;
        private System.Windows.Forms.TextBox SchID2Box;
        private System.Windows.Forms.RichTextBox ReserveListBox;
        private System.Windows.Forms.Button GetResBtn;

    }
}

