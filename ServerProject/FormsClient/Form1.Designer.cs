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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.MovieTextBox = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create new Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Find Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(69, 247);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 24;
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
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(571, 310);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(189, 68);
            this.richTextBox4.TabIndex = 26;
            this.richTextBox4.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Get available seats";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Scheduler ID:";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(671, 384);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(89, 21);
            this.richTextBox5.TabIndex = 29;
            this.richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(349, 310);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(189, 68);
            this.richTextBox6.TabIndex = 30;
            this.richTextBox6.Text = "";
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
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(457, 383);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(81, 21);
            this.richTextBox7.TabIndex = 32;
            this.richTextBox7.Text = "";
            this.richTextBox7.TextChanged += new System.EventHandler(this.richTextBox7_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Get best seats";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Seats to book:";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(10, 350);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(107, 46);
            this.richTextBox8.TabIndex = 36;
            this.richTextBox8.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 37;
            this.button5.Text = "Reserve!";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MovieTextBox
            // 
            this.MovieTextBox.Location = new System.Drawing.Point(648, 250);
            this.MovieTextBox.Name = "MovieTextBox";
            this.MovieTextBox.Size = new System.Drawing.Size(100, 20);
            this.MovieTextBox.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 460);
            this.Controls.Add(this.MovieTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox MovieTextBox;

    }
}

