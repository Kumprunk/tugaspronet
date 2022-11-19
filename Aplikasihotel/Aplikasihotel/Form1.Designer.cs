namespace Aplikasihotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJenisroom = new System.Windows.Forms.ComboBox();
            this.txtPricerent = new System.Windows.Forms.TextBox();
            this.txtLamainap = new System.Windows.Forms.TextBox();
            this.txtPriceroom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSpare = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJenisroom);
            this.groupBox2.Controls.Add(this.txtPricerent);
            this.groupBox2.Controls.Add(this.txtLamainap);
            this.groupBox2.Controls.Add(this.txtPriceroom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(464, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(374, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ BOOKING PRICE ]";
            // 
            // txtJenisroom
            // 
            this.txtJenisroom.FormattingEnabled = true;
            this.txtJenisroom.Items.AddRange(new object[] {
            "VIP",
            "KELAS I",
            "KELAS II",
            "KELAS III"});
            this.txtJenisroom.Location = new System.Drawing.Point(163, 33);
            this.txtJenisroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJenisroom.Name = "txtJenisroom";
            this.txtJenisroom.Size = new System.Drawing.Size(195, 23);
            this.txtJenisroom.TabIndex = 14;
            this.txtJenisroom.SelectedIndexChanged += new System.EventHandler(this.txtJenisroom_SelectedIndexChanged);
            // 
            // txtPricerent
            // 
            this.txtPricerent.Location = new System.Drawing.Point(163, 151);
            this.txtPricerent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPricerent.Name = "txtPricerent";
            this.txtPricerent.Size = new System.Drawing.Size(195, 23);
            this.txtPricerent.TabIndex = 13;
            // 
            // txtLamainap
            // 
            this.txtLamainap.Location = new System.Drawing.Point(163, 106);
            this.txtLamainap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLamainap.Name = "txtLamainap";
            this.txtLamainap.Size = new System.Drawing.Size(195, 23);
            this.txtLamainap.TabIndex = 12;
            // 
            // txtPriceroom
            // 
            this.txtPriceroom.Location = new System.Drawing.Point(163, 70);
            this.txtPriceroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceroom.Name = "txtPriceroom";
            this.txtPriceroom.Size = new System.Drawing.Size(195, 23);
            this.txtPriceroom.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Biaya Sewa Kamar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lama Menginap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Harga Sewa Perhari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Jenis Kamar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Location = new System.Drawing.Point(18, 385);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(410, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[ NAVIGASI ]";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(225, 34);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(52, 34);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSpare);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtBayar);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(464, 367);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(374, 121);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[ PEMBAYARAN ]";
            // 
            // txtSpare
            // 
            this.txtSpare.Location = new System.Drawing.Point(163, 74);
            this.txtSpare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpare.Name = "txtSpare";
            this.txtSpare.Size = new System.Drawing.Size(195, 23);
            this.txtSpare.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kembalian";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(163, 38);
            this.txtBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(195, 23);
            this.txtBayar.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Jumlah Bayar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pemesan";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Telepon";
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(188, 74);
            this.txtTelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(218, 23);
            this.txtTelp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Booking";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(188, 112);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(218, 86);
            this.txtAddress.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(416, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ DATA PEMESAN ]";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(186, 228);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(219, 23);
            this.txtDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "HOTEL TRISNA ASIH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 511);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aplikasi Booking Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bindingSource1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox txtJenisroom;
        private TextBox txtPricerent;
        private TextBox txtLamainap;
        private TextBox txtPriceroom;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtTelp;
        private Label label3;
        private Label label4;
        private TextBox txtAddress;
        private GroupBox groupBox1;
        private DateTimePicker txtDate;
        private Button btnClose;
        private Button btnNew;
        private TextBox txtSpare;
        private Label label10;
        private TextBox txtBayar;
        private Label label11;
    }
}