
namespace Loginpage
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.Color.Indigo;
            this.btncheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckin.FlatAppearance.BorderSize = 0;
            this.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.ForeColor = System.Drawing.Color.White;
            this.btncheckin.Location = new System.Drawing.Point(85, 87);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(172, 31);
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
            this.btncheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.Location = new System.Drawing.Point(85, 133);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(172, 31);
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
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(85, 186);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(172, 31);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update Client info";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Indigo;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(85, 393);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(172, 31);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::Loginpage.Properties.Resources._9062;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 529);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.btncheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlogout;
    }
}