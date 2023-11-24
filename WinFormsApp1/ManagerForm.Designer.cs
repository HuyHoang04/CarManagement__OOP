namespace WinFormsApp1
{
    partial class ManagerForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            vehiclegridview = new DataGridView();
            levelbox = new TextBox();
            label11 = new Label();
            insurantbox = new TextBox();
            label6 = new Label();
            purposebox = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            donebutton = new Button();
            clearbutton = new Button();
            kmbox = new TextBox();
            buybox = new TextBox();
            brandbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            SeasonLabel = new Label();
            OccationLabel = new Label();
            OccationBox = new TextBox();
            Descriptionbox = new ComboBox();
            label14 = new Label();
            Done = new Button();
            Clear = new Button();
            SaleGridView = new DataGridView();
            DiscountPersent = new TextBox();
            EndDateBox = new TextBox();
            StartDateBox = new TextBox();
            CodeTittleBox = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehiclegridview).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SaleGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1379, 715);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(vehiclegridview);
            tabPage1.Controls.Add(levelbox);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(insurantbox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(purposebox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(donebutton);
            tabPage1.Controls.Add(clearbutton);
            tabPage1.Controls.Add(kmbox);
            tabPage1.Controls.Add(buybox);
            tabPage1.Controls.Add(brandbox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1371, 682);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Vehicle";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(234, 37);
            label7.Name = "label7";
            label7.Size = new Size(237, 46);
            label7.TabIndex = 30;
            label7.Text = "ADD VEHICLE";
            // 
            // vehiclegridview
            // 
            vehiclegridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehiclegridview.Location = new Point(698, 37);
            vehiclegridview.Name = "vehiclegridview";
            vehiclegridview.RowHeadersWidth = 51;
            vehiclegridview.RowTemplate.Height = 29;
            vehiclegridview.Size = new Size(650, 606);
            vehiclegridview.TabIndex = 29;
            vehiclegridview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // levelbox
            // 
            levelbox.Location = new Point(74, 260);
            levelbox.Multiline = true;
            levelbox.Name = "levelbox";
            levelbox.Size = new Size(224, 28);
            levelbox.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 218);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 27;
            label11.Text = "Level Of Vehicle";
            // 
            // insurantbox
            // 
            insurantbox.Location = new Point(410, 409);
            insurantbox.Multiline = true;
            insurantbox.Name = "insurantbox";
            insurantbox.Size = new Size(224, 28);
            insurantbox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 368);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 25;
            label6.Text = "Insurant";
            // 
            // purposebox
            // 
            purposebox.Location = new Point(74, 360);
            purposebox.Multiline = true;
            purposebox.Name = "purposebox";
            purposebox.Size = new Size(224, 28);
            purposebox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 319);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 23;
            label1.Text = "Name Purpose";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Four Seats Car ", "Motobike ", "Practice Driving Car ", "Tourist Car ", "Wedding " });
            comboBox1.Location = new Point(74, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // donebutton
            // 
            donebutton.Location = new Point(430, 576);
            donebutton.Name = "donebutton";
            donebutton.Size = new Size(172, 45);
            donebutton.TabIndex = 21;
            donebutton.Text = "Done";
            donebutton.UseVisualStyleBackColor = true;
            donebutton.Click += donebutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(126, 576);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(172, 45);
            clearbutton.TabIndex = 20;
            clearbutton.Text = "Clear";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // kmbox
            // 
            kmbox.Location = new Point(410, 309);
            kmbox.Multiline = true;
            kmbox.Name = "kmbox";
            kmbox.Size = new Size(224, 28);
            kmbox.TabIndex = 19;
            // 
            // buybox
            // 
            buybox.Location = new Point(410, 208);
            buybox.Multiline = true;
            buybox.Name = "buybox";
            buybox.Size = new Size(224, 28);
            buybox.TabIndex = 18;
            // 
            // brandbox
            // 
            brandbox.Location = new Point(74, 450);
            brandbox.Multiline = true;
            brandbox.Name = "brandbox";
            brandbox.Size = new Size(224, 28);
            brandbox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 269);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 15;
            label4.Text = "Kilometer Go";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 167);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 14;
            label5.Text = "Buy Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 409);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 13;
            label3.Text = "Brand";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 114);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 12;
            label2.Text = "Car Type";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SeasonLabel);
            tabPage2.Controls.Add(OccationLabel);
            tabPage2.Controls.Add(OccationBox);
            tabPage2.Controls.Add(Descriptionbox);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(Done);
            tabPage2.Controls.Add(Clear);
            tabPage2.Controls.Add(SaleGridView);
            tabPage2.Controls.Add(DiscountPersent);
            tabPage2.Controls.Add(EndDateBox);
            tabPage2.Controls.Add(StartDateBox);
            tabPage2.Controls.Add(CodeTittleBox);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1371, 682);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sale Off";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(97, 400);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(56, 20);
            SeasonLabel.TabIndex = 35;
            SeasonLabel.Text = "Season";
            // 
            // OccationLabel
            // 
            OccationLabel.AutoSize = true;
            OccationLabel.Location = new Point(85, 400);
            OccationLabel.Name = "OccationLabel";
            OccationLabel.Size = new Size(68, 20);
            OccationLabel.TabIndex = 34;
            OccationLabel.Text = "Occation";
            // 
            // OccationBox
            // 
            OccationBox.Location = new Point(188, 393);
            OccationBox.Name = "OccationBox";
            OccationBox.Size = new Size(247, 27);
            OccationBox.TabIndex = 33;
            // 
            // Descriptionbox
            // 
            Descriptionbox.FormattingEnabled = true;
            Descriptionbox.Items.AddRange(new object[] { "Holiday", "Customer Loyalty", "Seasonal_Increase", "Seasonal_Decrease" });
            Descriptionbox.Location = new Point(191, 190);
            Descriptionbox.Name = "Descriptionbox";
            Descriptionbox.Size = new Size(244, 28);
            Descriptionbox.TabIndex = 32;
            Descriptionbox.SelectedIndexChanged += Descriptionbox_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(214, 76);
            label14.Name = "label14";
            label14.Size = new Size(190, 46);
            label14.TabIndex = 31;
            label14.Text = "ADD SALE ";
            // 
            // Done
            // 
            Done.Location = new Point(326, 450);
            Done.Name = "Done";
            Done.Size = new Size(109, 29);
            Done.TabIndex = 12;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(191, 450);
            Clear.Name = "Clear";
            Clear.Size = new Size(109, 29);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            // 
            // SaleGridView
            // 
            SaleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SaleGridView.Location = new Point(553, 30);
            SaleGridView.Name = "SaleGridView";
            SaleGridView.RowHeadersWidth = 51;
            SaleGridView.RowTemplate.Height = 29;
            SaleGridView.Size = new Size(666, 490);
            SaleGridView.TabIndex = 10;
            // 
            // DiscountPersent
            // 
            DiscountPersent.Location = new Point(188, 338);
            DiscountPersent.Name = "DiscountPersent";
            DiscountPersent.Size = new Size(247, 27);
            DiscountPersent.TabIndex = 9;
            // 
            // EndDateBox
            // 
            EndDateBox.Location = new Point(188, 286);
            EndDateBox.Name = "EndDateBox";
            EndDateBox.Size = new Size(247, 27);
            EndDateBox.TabIndex = 8;
            // 
            // StartDateBox
            // 
            StartDateBox.Location = new Point(188, 240);
            StartDateBox.Name = "StartDateBox";
            StartDateBox.Size = new Size(247, 27);
            StartDateBox.TabIndex = 7;
            // 
            // CodeTittleBox
            // 
            CodeTittleBox.Location = new Point(188, 140);
            CodeTittleBox.Name = "CodeTittleBox";
            CodeTittleBox.Size = new Size(247, 27);
            CodeTittleBox.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 345);
            label13.Name = "label13";
            label13.Size = new Size(144, 20);
            label13.TabIndex = 4;
            label13.Text = "Discount Percentage";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(91, 293);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 3;
            label12.Text = "End Date";
            label12.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 247);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 2;
            label10.Text = "Start Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(76, 190);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 1;
            label9.Text = "Description";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 143);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 0;
            label8.Text = "CODE tittle";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1371, 682);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Review";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 718);
            Controls.Add(tabControl1);
            Name = "ManagerForm";
            Text = "Manager";
            Load += ManagerForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vehiclegridview).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SaleGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button donebutton;
        private Button clearbutton;
        private TextBox kmbox;
        private TextBox buybox;
        private TextBox brandbox;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox comboBox1;
        private TextBox insurantbox;
        private Label label6;
        private TextBox purposebox;
        private Label label1;
        private TextBox levelbox;
        private Label label11;
        private DataGridView vehiclegridview;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label13;
        private Button Done;
        private Button Clear;
        private DataGridView SaleGridView;
        private TextBox DiscountPersent;
        private TextBox EndDateBox;
        private TextBox StartDateBox;
        private TextBox CodeTittleBox;
        private Label label14;
        private ComboBox Descriptionbox;
        private Label OccationLabel;
        private TextBox OccationBox;
        private Label SeasonLabel;
    }
}