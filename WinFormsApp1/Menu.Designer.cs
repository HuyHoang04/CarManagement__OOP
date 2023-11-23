namespace WinFormsApp1
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 227, 213);
            button1.Location = new Point(244, 271);
            button1.Name = "button1";
            button1.Size = new Size(287, 146);
            button1.TabIndex = 0;
            button1.Text = "Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 227, 213);
            button2.Location = new Point(659, 271);
            button2.Name = "button2";
            button2.Size = new Size(287, 146);
            button2.TabIndex = 1;
            button2.Text = "Owner";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 166, 149);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 573);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 107, 93);
            ClientSize = new Size(1297, 597);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}