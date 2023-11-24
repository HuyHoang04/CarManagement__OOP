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
            decoralabel = new Label();
            fridgelabel = new Label();
            backuplabel = new Label();
            toollabel = new Label();
            sparelabel = new Label();
            specialbox = new TextBox();
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
            tabControl1.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1379, 715);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(decoralabel);
            tabPage1.Controls.Add(fridgelabel);
            tabPage1.Controls.Add(backuplabel);
            tabPage1.Controls.Add(toollabel);
            tabPage1.Controls.Add(sparelabel);
            tabPage1.Controls.Add(specialbox);
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
            tabPage1.Font = new Font("Agency FB", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.ButtonHighlight;
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1371, 674);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Vehicle";
            tabPage1.Click += tabPage1_Click_1;
            // 
            // decoralabel
            // 
            decoralabel.AutoSize = true;
            decoralabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            decoralabel.Location = new Point(405, 409);
            decoralabel.Name = "decoralabel";
            decoralabel.Size = new Size(94, 28);
            decoralabel.TabIndex = 36;
            decoralabel.Text = "Decoration";
            // 
            // fridgelabel
            // 
            fridgelabel.AutoSize = true;
            fridgelabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            fridgelabel.Location = new Point(405, 409);
            fridgelabel.Name = "fridgelabel";
            fridgelabel.Size = new Size(92, 28);
            fridgelabel.TabIndex = 35;
            fridgelabel.Text = "Mini Fridge";
            // 
            // backuplabel
            // 
            backuplabel.AutoSize = true;
            backuplabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            backuplabel.Location = new Point(405, 409);
            backuplabel.Name = "backuplabel";
            backuplabel.Size = new Size(122, 28);
            backuplabel.TabIndex = 34;
            backuplabel.Text = "Backup Brake ";
            // 
            // toollabel
            // 
            toollabel.AutoSize = true;
            toollabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            toollabel.Location = new Point(405, 409);
            toollabel.Name = "toollabel";
            toollabel.Size = new Size(77, 28);
            toollabel.TabIndex = 33;
            toollabel.Text = "Tool Box";
            // 
            // sparelabel
            // 
            sparelabel.AutoSize = true;
            sparelabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sparelabel.Location = new Point(405, 409);
            sparelabel.Name = "sparelabel";
            sparelabel.Size = new Size(93, 28);
            sparelabel.TabIndex = 32;
            sparelabel.Text = "Spare Tire";
            // 
            // specialbox
            // 
            specialbox.Location = new Point(405, 450);
            specialbox.Multiline = true;
            specialbox.Name = "specialbox";
            specialbox.Size = new Size(224, 28);
            specialbox.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(262, 49);
            label7.Name = "label7";
            label7.Size = new Size(173, 44);
            label7.TabIndex = 30;
            label7.Text = "ADD VEHICLE";
            // 
            // vehiclegridview
            // 
            vehiclegridview.BackgroundColor = Color.DimGray;
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
            label11.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(74, 218);
            label11.Name = "label11";
            label11.Size = new Size(130, 28);
            label11.TabIndex = 27;
            label11.Text = "Level Of Vehicle";
            // 
            // insurantbox
            // 
            insurantbox.Location = new Point(405, 360);
            insurantbox.Multiline = true;
            insurantbox.Name = "insurantbox";
            insurantbox.Size = new Size(224, 28);
            insurantbox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(405, 319);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
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
            label1.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 319);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 23;
            label1.Text = "Name Purpose";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Four Seats Car ", "Motobike ", "Practice Driving Car ", "Tourist Car ", "Wedding Car " });
            comboBox1.Location = new Point(74, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 30);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // donebutton
            // 
            donebutton.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            donebutton.ForeColor = SystemColors.ActiveCaptionText;
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
            clearbutton.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            clearbutton.ForeColor = SystemColors.ActiveCaptionText;
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
            kmbox.Location = new Point(405, 260);
            kmbox.Multiline = true;
            kmbox.Name = "kmbox";
            kmbox.Size = new Size(224, 28);
            kmbox.TabIndex = 19;
            // 
            // buybox
            // 
            buybox.Location = new Point(405, 163);
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
            label4.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(405, 218);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 15;
            label4.Text = "Kilometer Go";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(405, 114);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 14;
            label5.Text = "Buy Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 409);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 13;
            label3.Text = "Brand";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 114);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 12;
            label2.Text = "Car Type";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
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
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1371, 674);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sale Off";
            tabPage2.Click += tabPage2_Click;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SeasonLabel.Location = new Point(97, 400);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(67, 28);
            SeasonLabel.TabIndex = 35;
            SeasonLabel.Text = "Season";
            // 
            // OccationLabel
            // 
            OccationLabel.AutoSize = true;
            OccationLabel.Location = new Point(85, 400);
            OccationLabel.Name = "OccationLabel";
            OccationLabel.Size = new Size(77, 28);
            OccationLabel.TabIndex = 34;
            OccationLabel.Text = "Occation";
            // 
            // OccationBox
            // 
            OccationBox.Location = new Point(188, 393);
            OccationBox.Name = "OccationBox";
            OccationBox.Size = new Size(247, 35);
            OccationBox.TabIndex = 33;
            // 
            // Descriptionbox
            // 
            Descriptionbox.FormattingEnabled = true;
            Descriptionbox.Items.AddRange(new object[] { "Holiday", "Customer Loyalty", "Seasonal_Increase", "Seasonal_Decrease" });
            Descriptionbox.Location = new Point(188, 190);
            Descriptionbox.Name = "Descriptionbox";
            Descriptionbox.Size = new Size(244, 36);
            Descriptionbox.TabIndex = 32;
            Descriptionbox.SelectedIndexChanged += Descriptionbox_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Agency FB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(155, 54);
            label14.Name = "label14";
            label14.Size = new Size(174, 53);
            label14.TabIndex = 31;
            label14.Text = "ADD SALE ";
            // 
            // Done
            // 
            Done.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Done.ForeColor = Color.Black;
            Done.Location = new Point(326, 483);
            Done.Name = "Done";
            Done.Size = new Size(109, 43);
            Done.TabIndex = 12;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.Black;
            Clear.Location = new Point(155, 483);
            Clear.Name = "Clear";
            Clear.Size = new Size(109, 43);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // SaleGridView
            // 
            SaleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SaleGridView.Location = new Point(494, 45);
            SaleGridView.Name = "SaleGridView";
            SaleGridView.RowHeadersWidth = 51;
            SaleGridView.RowTemplate.Height = 29;
            SaleGridView.Size = new Size(790, 522);
            SaleGridView.TabIndex = 10;
            SaleGridView.CellContentClick += SaleGridView_CellContentClick;
            // 
            // DiscountPersent
            // 
            DiscountPersent.Location = new Point(188, 338);
            DiscountPersent.Name = "DiscountPersent";
            DiscountPersent.Size = new Size(247, 35);
            DiscountPersent.TabIndex = 9;
            // 
            // EndDateBox
            // 
            EndDateBox.Location = new Point(188, 286);
            EndDateBox.Name = "EndDateBox";
            EndDateBox.Size = new Size(247, 35);
            EndDateBox.TabIndex = 8;
            // 
            // StartDateBox
            // 
            StartDateBox.Location = new Point(188, 240);
            StartDateBox.Name = "StartDateBox";
            StartDateBox.Size = new Size(247, 35);
            StartDateBox.TabIndex = 7;
            // 
            // CodeTittleBox
            // 
            CodeTittleBox.Location = new Point(188, 140);
            CodeTittleBox.Name = "CodeTittleBox";
            CodeTittleBox.Size = new Size(247, 35);
            CodeTittleBox.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(17, 345);
            label13.Name = "label13";
            label13.Size = new Size(169, 28);
            label13.TabIndex = 4;
            label13.Text = "Discount Percentage";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(91, 293);
            label12.Name = "label12";
            label12.Size = new Size(76, 28);
            label12.TabIndex = 3;
            label12.Text = "End Date";
            label12.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(85, 247);
            label10.Name = "label10";
            label10.Size = new Size(90, 28);
            label10.TabIndex = 2;
            label10.Text = "Start Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(76, 190);
            label9.Name = "label9";
            label9.Size = new Size(98, 28);
            label9.TabIndex = 1;
            label9.Text = "Description";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(78, 143);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 0;
            label8.Text = "CODE tittle";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1371, 674);
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
        private TextBox specialbox;
        private Label decoralabel;
        private Label fridgelabel;
        private Label backuplabel;
        private Label toollabel;
        private Label sparelabel;
    }
}