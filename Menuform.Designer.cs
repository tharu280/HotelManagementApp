
namespace Loginpage
{
    partial class Menuform
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
            this.btncheckin = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonstatus = new System.Windows.Forms.Button();
            this.labelstatus1 = new System.Windows.Forms.Label();
            this.labelstatus2 = new System.Windows.Forms.Label();
            this.statustopiclabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.Color.Indigo;
            this.btncheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckin.FlatAppearance.BorderSize = 0;
            this.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.ForeColor = System.Drawing.Color.White;
            this.btncheckin.Location = new System.Drawing.Point(59, 245);
            this.btncheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(185, 38);
            this.btncheckin.TabIndex = 0;
            this.btncheckin.Text = "Client check in";
            this.btncheckin.UseVisualStyleBackColor = false;
            this.btncheckin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.Indigo;
            this.btncheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckout.FlatAppearance.BorderSize = 0;
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.Location = new System.Drawing.Point(59, 351);
            this.btncheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(185, 38);
            this.btncheckout.TabIndex = 1;
            this.btncheckout.Text = "Client check out";
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Indigo;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(59, 455);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(185, 38);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update Client info";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(36, 661);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(229, 38);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttonstatus);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btncheckin);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Location = new System.Drawing.Point(-31, -57);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 731);
            this.panel1.TabIndex = 5;
            // 
            // buttonstatus
            // 
            this.buttonstatus.BackColor = System.Drawing.Color.Indigo;
            this.buttonstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstatus.FlatAppearance.BorderSize = 0;
            this.buttonstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstatus.ForeColor = System.Drawing.Color.White;
            this.buttonstatus.Location = new System.Drawing.Point(59, 135);
            this.buttonstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonstatus.Name = "buttonstatus";
            this.buttonstatus.Size = new System.Drawing.Size(185, 38);
            this.buttonstatus.TabIndex = 4;
            this.buttonstatus.Text = "Check status";
            this.buttonstatus.UseVisualStyleBackColor = false;
            this.buttonstatus.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // labelstatus1
            // 
            this.labelstatus1.AutoSize = true;
            this.labelstatus1.BackColor = System.Drawing.Color.Transparent;
            this.labelstatus1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelstatus1.Location = new System.Drawing.Point(291, 90);
            this.labelstatus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatus1.Name = "labelstatus1";
            this.labelstatus1.Size = new System.Drawing.Size(0, 26);
            this.labelstatus1.TabIndex = 6;
            this.labelstatus1.Visible = false;
            this.labelstatus1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelstatus2
            // 
            this.labelstatus2.AutoSize = true;
            this.labelstatus2.BackColor = System.Drawing.Color.Transparent;
            this.labelstatus2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelstatus2.Location = new System.Drawing.Point(291, 130);
            this.labelstatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstatus2.Name = "labelstatus2";
            this.labelstatus2.Size = new System.Drawing.Size(0, 26);
            this.labelstatus2.TabIndex = 7;
            this.labelstatus2.Visible = false;
            // 
            // statustopiclabel
            // 
            this.statustopiclabel.AutoSize = true;
            this.statustopiclabel.BackColor = System.Drawing.Color.Transparent;
            this.statustopiclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustopiclabel.Location = new System.Drawing.Point(289, 36);
            this.statustopiclabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statustopiclabel.Name = "statustopiclabel";
            this.statustopiclabel.Size = new System.Drawing.Size(0, 36);
            this.statustopiclabel.TabIndex = 8;
            this.statustopiclabel.Visible = false;
            this.statustopiclabel.Click += new System.EventHandler(this.statustopiclabel_Click);
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Loginpage.Properties.Resources._9062;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 651);
            this.Controls.Add(this.statustopiclabel);
            this.Controls.Add(this.labelstatus2);
            this.Controls.Add(this.labelstatus1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menuform";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonstatus;
        private System.Windows.Forms.Label labelstatus1;
        private System.Windows.Forms.Label labelstatus2;
        private System.Windows.Forms.Label statustopiclabel;
    }
}