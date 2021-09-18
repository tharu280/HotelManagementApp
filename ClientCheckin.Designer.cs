
namespace Loginpage
{
    partial class ClientCheckin
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
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdStandar = new System.Windows.Forms.RadioButton();
            this.rdDeluxe = new System.Windows.Forms.RadioButton();
            this.rdSuite = new System.Windows.Forms.RadioButton();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.Con = new System.Windows.Forms.TextBox();
            this.emailA = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.NoAdults = new System.Windows.Forms.TextBox();
            this.NoChild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(89, 517);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Indigo;
            this.btnSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Location = new System.Drawing.Point(768, 636);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 55);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdStandar
            // 
            this.rdStandar.AutoSize = true;
            this.rdStandar.BackColor = System.Drawing.Color.GhostWhite;
            this.rdStandar.Location = new System.Drawing.Point(768, 520);
            this.rdStandar.Name = "rdStandar";
            this.rdStandar.Size = new System.Drawing.Size(87, 21);
            this.rdStandar.TabIndex = 3;
            this.rdStandar.TabStop = true;
            this.rdStandar.Text = "Standard";
            this.rdStandar.UseVisualStyleBackColor = false;
            // 
            // rdDeluxe
            // 
            this.rdDeluxe.AutoSize = true;
            this.rdDeluxe.BackColor = System.Drawing.Color.GhostWhite;
            this.rdDeluxe.Location = new System.Drawing.Point(1015, 520);
            this.rdDeluxe.Name = "rdDeluxe";
            this.rdDeluxe.Size = new System.Drawing.Size(72, 21);
            this.rdDeluxe.TabIndex = 4;
            this.rdDeluxe.TabStop = true;
            this.rdDeluxe.Text = "Deluxe";
            this.rdDeluxe.UseVisualStyleBackColor = false;
            // 
            // rdSuite
            // 
            this.rdSuite.AutoSize = true;
            this.rdSuite.BackColor = System.Drawing.Color.GhostWhite;
            this.rdSuite.Location = new System.Drawing.Point(901, 520);
            this.rdSuite.Name = "rdSuite";
            this.rdSuite.Size = new System.Drawing.Size(61, 21);
            this.rdSuite.TabIndex = 5;
            this.rdSuite.TabStop = true;
            this.rdSuite.Text = "Suite";
            this.rdSuite.UseVisualStyleBackColor = false;
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCheckInTime.Location = new System.Drawing.Point(324, 517);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(131, 22);
            this.dtpCheckInTime.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 107);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 55);
            this.txtName.TabIndex = 7;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(768, 107);
            this.txtName2.Multiline = true;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(366, 55);
            this.txtName2.TabIndex = 8;
            // 
            // Con
            // 
            this.Con.Location = new System.Drawing.Point(768, 235);
            this.Con.Multiline = true;
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(366, 55);
            this.Con.TabIndex = 9;
            // 
            // emailA
            // 
            this.emailA.Location = new System.Drawing.Point(768, 355);
            this.emailA.Multiline = true;
            this.emailA.Name = "emailA";
            this.emailA.Size = new System.Drawing.Size(366, 55);
            this.emailA.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(89, 235);
            this.Add.Multiline = true;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(366, 55);
            this.Add.TabIndex = 11;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(89, 355);
            this.p.Multiline = true;
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(366, 55);
            this.p.TabIndex = 12;
            // 
            // NoAdults
            // 
            this.NoAdults.Location = new System.Drawing.Point(89, 636);
            this.NoAdults.Multiline = true;
            this.NoAdults.Name = "NoAdults";
            this.NoAdults.Size = new System.Drawing.Size(69, 41);
            this.NoAdults.TabIndex = 13;
            // 
            // NoChild
            // 
            this.NoChild.Location = new System.Drawing.Point(269, 636);
            this.NoChild.Multiline = true;
            this.NoChild.Name = "NoChild";
            this.NoChild.Size = new System.Drawing.Size(69, 41);
            this.NoChild.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(764, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(764, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(764, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(764, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Room Preference";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 48);
            this.label8.TabIndex = 22;
            this.label8.Text = "Check - in";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Adults Count";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 610);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Children Count";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Check-in Date";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(320, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Check-in Time";
            // 
            // ClientCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::Loginpage.Properties.Resources.psh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 746);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoChild);
            this.Controls.Add(this.NoAdults);
            this.Controls.Add(this.p);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.emailA);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.rdSuite);
            this.Controls.Add(this.rdDeluxe);
            this.Controls.Add(this.rdStandar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpCheckIn);
            this.Name = "ClientCheckin";
            this.Text = "ClientCheckin";
            this.Load += new System.EventHandler(this.ClientCheckin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rdStandar;
        private System.Windows.Forms.RadioButton rdDeluxe;
        private System.Windows.Forms.RadioButton rdSuite;
        private System.Windows.Forms.DateTimePicker dtpCheckInTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox Con;
        private System.Windows.Forms.TextBox emailA;
        private System.Windows.Forms.TextBox Add;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.TextBox NoAdults;
        private System.Windows.Forms.TextBox NoChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}