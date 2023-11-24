namespace ManagerForm
{
    partial class Customerform
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
            Createprofile = new TabControl();
            tabPage1 = new TabPage();
            clearbutton = new Button();
            donebutton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            phonenumberinput = new TextBox();
            addressinput = new TextBox();
            dobinput = new TextBox();
            idinput = new TextBox();
            nameinput = new TextBox();
            tabPage2 = new TabPage();
            Showallbutton = new Button();
            SearchButton = new Button();
            label1 = new Label();
            SearchID = new TextBox();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            label9 = new Label();
            DepositBox = new TextBox();
            TimeRentBox = new TextBox();
            HiredriverBox = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            SaleCode = new ComboBox();
            DayRentBox = new TextBox();
            buttonrent = new Button();
            buttonclear = new Button();
            label10 = new Label();
            label8 = new Label();
            FindCarBox = new TextBox();
            FindIdBox = new TextBox();
            tabPage4 = new TabPage();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            label13 = new Label();
            label21 = new Label();
            label22 = new Label();
            label20 = new Label();
            Datepost = new TextBox();
            Title = new TextBox();
            Content = new TextBox();
            NameCT = new TextBox();
            Reviewdone = new Button();
            Reviewclear = new Button();
            dataGridView3 = new DataGridView();
            label11 = new Label();
            Createprofile.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // Createprofile
            // 
            Createprofile.Controls.Add(tabPage1);
            Createprofile.Controls.Add(tabPage2);
            Createprofile.Controls.Add(tabPage3);
            Createprofile.Controls.Add(tabPage4);
            Createprofile.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Createprofile.Location = new Point(3, 3);
            Createprofile.Name = "Createprofile";
            Createprofile.SelectedIndex = 0;
            Createprofile.Size = new Size(1100, 510);
            Createprofile.TabIndex = 0;
            Createprofile.SelectedIndexChanged += Createprofile_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(clearbutton);
            tabPage1.Controls.Add(donebutton);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(phonenumberinput);
            tabPage1.Controls.Add(addressinput);
            tabPage1.Controls.Add(dobinput);
            tabPage1.Controls.Add(idinput);
            tabPage1.Controls.Add(nameinput);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1092, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Register";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            clearbutton.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            clearbutton.Location = new Point(334, 355);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(142, 68);
            clearbutton.TabIndex = 12;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // donebutton
            // 
            donebutton.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            donebutton.Location = new Point(579, 355);
            donebutton.Name = "donebutton";
            donebutton.Size = new Size(142, 68);
            donebutton.TabIndex = 11;
            donebutton.Text = "Done";
            donebutton.UseVisualStyleBackColor = true;
            donebutton.Click += donebutton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(568, 235);
            label7.Name = "label7";
            label7.Size = new Size(149, 36);
            label7.TabIndex = 10;
            label7.Text = "Phone number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(609, 175);
            label6.Name = "label6";
            label6.Size = new Size(91, 36);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 260);
            label5.Name = "label5";
            label5.Size = new Size(122, 36);
            label5.TabIndex = 8;
            label5.Text = "Day of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 202);
            label4.Name = "label4";
            label4.Size = new Size(33, 36);
            label4.TabIndex = 7;
            label4.Text = "ID";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 144);
            label3.Name = "label3";
            label3.Size = new Size(67, 36);
            label3.TabIndex = 6;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(387, 31);
            label2.Name = "label2";
            label2.Size = new Size(324, 57);
            label2.TabIndex = 5;
            label2.Text = "Create New Profile";
            label2.Click += label2_Click;
            // 
            // phonenumberinput
            // 
            phonenumberinput.Location = new Point(752, 244);
            phonenumberinput.Name = "phonenumberinput";
            phonenumberinput.Size = new Size(244, 31);
            phonenumberinput.TabIndex = 4;
            phonenumberinput.TextChanged += textBox5_TextChanged;
            // 
            // addressinput
            // 
            addressinput.Location = new Point(752, 184);
            addressinput.Name = "addressinput";
            addressinput.Size = new Size(244, 31);
            addressinput.TabIndex = 3;
            // 
            // dobinput
            // 
            dobinput.Location = new Point(221, 269);
            dobinput.Name = "dobinput";
            dobinput.Size = new Size(244, 31);
            dobinput.TabIndex = 2;
            // 
            // idinput
            // 
            idinput.Location = new Point(221, 211);
            idinput.Name = "idinput";
            idinput.Size = new Size(244, 31);
            idinput.TabIndex = 1;
            idinput.TextChanged += idinput_TextChanged;
            // 
            // nameinput
            // 
            nameinput.Location = new Point(221, 155);
            nameinput.Name = "nameinput";
            nameinput.Size = new Size(244, 31);
            nameinput.TabIndex = 0;
            nameinput.TextChanged += nameinput_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Showallbutton);
            tabPage2.Controls.Add(SearchButton);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(SearchID);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1092, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // Showallbutton
            // 
            Showallbutton.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Showallbutton.Location = new Point(162, 255);
            Showallbutton.Name = "Showallbutton";
            Showallbutton.Size = new Size(110, 40);
            Showallbutton.TabIndex = 4;
            Showallbutton.Text = "Show All";
            Showallbutton.UseVisualStyleBackColor = true;
            Showallbutton.Click += button2_Click;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchButton.Location = new Point(33, 255);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(110, 40);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 114);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 2;
            label1.Text = "Enter your ID";
            label1.Click += label1_Click;
            // 
            // SearchID
            // 
            SearchID.Location = new Point(33, 184);
            SearchID.Multiline = true;
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(239, 34);
            SearchID.TabIndex = 1;
            SearchID.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(317, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(737, 435);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(DepositBox);
            tabPage3.Controls.Add(TimeRentBox);
            tabPage3.Controls.Add(HiredriverBox);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(SaleCode);
            tabPage3.Controls.Add(DayRentBox);
            tabPage3.Controls.Add(buttonrent);
            tabPage3.Controls.Add(buttonclear);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(FindCarBox);
            tabPage3.Controls.Add(FindIdBox);
            tabPage3.Location = new Point(4, 33);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1092, 473);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rent";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(516, 153);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 20;
            label9.Text = "Deposit";
            // 
            // DepositBox
            // 
            DepositBox.Location = new Point(516, 188);
            DepositBox.Name = "DepositBox";
            DepositBox.Size = new Size(363, 31);
            DepositBox.TabIndex = 19;
            // 
            // TimeRentBox
            // 
            TimeRentBox.Location = new Point(516, 294);
            TimeRentBox.Name = "TimeRentBox";
            TimeRentBox.Size = new Size(363, 31);
            TimeRentBox.TabIndex = 18;
            // 
            // HiredriverBox
            // 
            HiredriverBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HiredriverBox.FormattingEnabled = true;
            HiredriverBox.ImeMode = ImeMode.Off;
            HiredriverBox.Items.AddRange(new object[] { "Yes", "No" });
            HiredriverBox.Location = new Point(516, 97);
            HiredriverBox.Name = "HiredriverBox";
            HiredriverBox.Size = new Size(177, 32);
            HiredriverBox.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(699, 62);
            label18.Name = "label18";
            label18.Size = new Size(111, 28);
            label18.TabIndex = 16;
            label18.Text = "Sale-off CODE";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(516, 62);
            label17.Name = "label17";
            label17.Size = new Size(97, 28);
            label17.TabIndex = 15;
            label17.Text = "Hire Driver";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(172, 253);
            label16.Name = "label16";
            label16.Size = new Size(80, 28);
            label16.TabIndex = 14;
            label16.Text = "Day Rent";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(516, 253);
            label15.Name = "label15";
            label15.Size = new Size(145, 28);
            label15.TabIndex = 13;
            label15.Text = "Time Rent (days)";
            label15.Click += label15_Click;
            // 
            // SaleCode
            // 
            SaleCode.DropDownStyle = ComboBoxStyle.DropDownList;
            SaleCode.FormattingEnabled = true;
            SaleCode.ImeMode = ImeMode.Off;
            SaleCode.Items.AddRange(new object[] { "SUMMER_TIME", "VACATION2023" });
            SaleCode.Location = new Point(699, 98);
            SaleCode.Name = "SaleCode";
            SaleCode.Size = new Size(180, 32);
            SaleCode.TabIndex = 11;
            SaleCode.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // DayRentBox
            // 
            DayRentBox.Location = new Point(172, 294);
            DayRentBox.Name = "DayRentBox";
            DayRentBox.PlaceholderText = "dd/mm/yyyy";
            DayRentBox.Size = new Size(321, 31);
            DayRentBox.TabIndex = 10;
            // 
            // buttonrent
            // 
            buttonrent.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonrent.Location = new Point(603, 380);
            buttonrent.Name = "buttonrent";
            buttonrent.Size = new Size(190, 53);
            buttonrent.TabIndex = 8;
            buttonrent.Text = "Rent";
            buttonrent.UseVisualStyleBackColor = true;
            buttonrent.Click += buttonrent_Click;
            // 
            // buttonclear
            // 
            buttonclear.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonclear.Location = new Point(228, 380);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(197, 53);
            buttonclear.TabIndex = 7;
            buttonclear.Text = "Clear";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += button1_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(168, 150);
            label10.Name = "label10";
            label10.Size = new Size(39, 28);
            label10.TabIndex = 6;
            label10.Text = "Car";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(168, 59);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 4;
            label8.Text = "Customer ID";
            label8.Click += label8_Click;
            // 
            // FindCarBox
            // 
            FindCarBox.Location = new Point(170, 188);
            FindCarBox.Name = "FindCarBox";
            FindCarBox.Size = new Size(321, 31);
            FindCarBox.TabIndex = 2;
            // 
            // FindIdBox
            // 
            FindIdBox.Location = new Point(168, 98);
            FindIdBox.Name = "FindIdBox";
            FindIdBox.Size = new Size(321, 31);
            FindIdBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(pictureBox5);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(label20);
            tabPage4.Controls.Add(Datepost);
            tabPage4.Controls.Add(Title);
            tabPage4.Controls.Add(Content);
            tabPage4.Controls.Add(NameCT);
            tabPage4.Controls.Add(Reviewdone);
            tabPage4.Controls.Add(Reviewclear);
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 33);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1092, 473);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Review";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.White_Star;
            pictureBox5.Location = new Point(389, 286);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.White_Star;
            pictureBox4.Location = new Point(353, 286);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.White_Star;
            pictureBox3.Location = new Point(317, 286);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.White_Star;
            pictureBox2.Location = new Point(281, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.White_Star;
            pictureBox1.Location = new Point(245, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(245, 250);
            label14.Name = "label14";
            label14.Size = new Size(47, 24);
            label14.TabIndex = 15;
            label14.Text = "Rating";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(245, 166);
            label13.Name = "label13";
            label13.Size = new Size(62, 24);
            label13.TabIndex = 14;
            label13.Text = "Datepost";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(245, 86);
            label21.Name = "label21";
            label21.Size = new Size(55, 24);
            label21.TabIndex = 13;
            label21.Text = "Content";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(43, 176);
            label22.Name = "label22";
            label22.Size = new Size(35, 24);
            label22.TabIndex = 12;
            label22.Text = "Title";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(43, 86);
            label20.Name = "label20";
            label20.Size = new Size(44, 24);
            label20.TabIndex = 11;
            label20.Text = "Name";
            // 
            // Datepost
            // 
            Datepost.Location = new Point(245, 203);
            Datepost.Multiline = true;
            Datepost.Name = "Datepost";
            Datepost.Size = new Size(183, 27);
            Datepost.TabIndex = 10;
            // 
            // Title
            // 
            Title.Location = new Point(43, 203);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.Size = new Size(163, 111);
            Title.TabIndex = 9;
            // 
            // Content
            // 
            Content.Location = new Point(245, 122);
            Content.Name = "Content";
            Content.Size = new Size(183, 31);
            Content.TabIndex = 8;
            // 
            // NameCT
            // 
            NameCT.Location = new Point(43, 122);
            NameCT.Name = "NameCT";
            NameCT.Size = new Size(163, 31);
            NameCT.TabIndex = 7;
            // 
            // Reviewdone
            // 
            Reviewdone.Location = new Point(261, 372);
            Reviewdone.Name = "Reviewdone";
            Reviewdone.Size = new Size(105, 48);
            Reviewdone.TabIndex = 6;
            Reviewdone.Text = "Done";
            Reviewdone.UseVisualStyleBackColor = true;
            Reviewdone.Click += Reviewdone_Click;
            // 
            // Reviewclear
            // 
            Reviewclear.Location = new Point(90, 372);
            Reviewclear.Name = "Reviewclear";
            Reviewclear.Size = new Size(105, 48);
            Reviewclear.TabIndex = 5;
            Reviewclear.Text = "Clear";
            Reviewclear.UseVisualStyleBackColor = true;
            Reviewclear.Click += Reviewclear_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(492, 30);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(558, 411);
            dataGridView3.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(163, 30);
            label11.Name = "label11";
            label11.Size = new Size(112, 44);
            label11.TabIndex = 0;
            label11.Text = " Review";
            label11.Click += label11_Click;
            // 
            // Customerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1107, 522);
            Controls.Add(Createprofile);
            Name = "Customerform";
            Text = "Form1";
            Load += Customerform_Load;
            Createprofile.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Createprofile;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private TextBox SearchID;
        private Label label1;
        private Button SearchButton;
        private Button donebutton;
        private Button Showall;
        private Button Showallbutton;
        private Label label2;
        private TextBox phonenumberinput;
        private TextBox addressinput;
        private TextBox dobinput;
        private TextBox idinput;
        private TextBox nameinput;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button clearbutton;
        private TextBox FindCarBox;
        private TextBox FindIdBox;
        private Label label10;
        private Label label8;
        private Button buttonrent;
        private Button buttonclear;
        private Label label11;
        private DataGridView dataGridView3;
        private Button Reviewdone;
        private Button Reviewclear;
        private TextBox NameCT;
        private TextBox Content;
        private TextBox Datepost;
        private TextBox Title;
        private Label label22;
        private Label label20;
        private Label label21;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox SaleCode;
        private TextBox DayRentBox;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ComboBox HiredriverBox;
        private TextBox TimeRentBox;
        private TextBox DepositBox;
        private Label label9;
    }
}