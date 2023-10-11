namespace Anket
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
            load = new Button();
            textBox1 = new TextBox();
            name = new Label();
            surname = new Label();
            father = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            country = new Label();
            city = new Label();
            phone = new Label();
            birth_date = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            gender = new Label();
            man = new RadioButton();
            woman = new RadioButton();
            save = new Button();
            Anket = new Label();
            SuspendLayout();
            // 
            // load
            // 
            load.Location = new Point(698, 22);
            load.Name = "load";
            load.Size = new Size(122, 35);
            load.TabIndex = 0;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(33, 78);
            name.Name = "name";
            name.Size = new Size(51, 20);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(33, 127);
            surname.Name = "surname";
            surname.Size = new Size(73, 20);
            surname.TabIndex = 3;
            surname.Text = "Surname";
            surname.Click += label2_Click;
            // 
            // father
            // 
            father.AutoSize = true;
            father.Location = new Point(33, 174);
            father.Name = "father";
            father.Size = new Size(101, 20);
            father.TabIndex = 4;
            father.Text = "Father Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 28);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(168, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 28);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(33, 226);
            country.Name = "country";
            country.Size = new Size(68, 20);
            country.TabIndex = 8;
            country.Text = "Country";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(33, 267);
            city.Name = "city";
            city.Size = new Size(38, 20);
            city.TabIndex = 9;
            city.Text = "City";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(33, 304);
            phone.Name = "phone";
            phone.Size = new Size(55, 20);
            phone.TabIndex = 10;
            phone.Text = "Phone";
            // 
            // birth_date
            // 
            birth_date.AutoSize = true;
            birth_date.Location = new Point(33, 347);
            birth_date.Name = "birth_date";
            birth_date.Size = new Size(73, 20);
            birth_date.TabIndex = 11;
            birth_date.Text = "Birthday";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 218);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 28);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(168, 259);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 28);
            textBox6.TabIndex = 13;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(168, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 28);
            textBox7.TabIndex = 14;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(168, 339);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 28);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(33, 392);
            gender.Name = "gender";
            gender.Size = new Size(62, 20);
            gender.TabIndex = 16;
            gender.Text = "Gender";
            // 
            // man
            // 
            man.AutoSize = true;
            man.Location = new Point(168, 388);
            man.Name = "man";
            man.Size = new Size(61, 24);
            man.TabIndex = 17;
            man.TabStop = true;
            man.Text = "man";
            man.UseVisualStyleBackColor = true;
            man.CheckedChanged += man_CheckedChanged;
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(235, 388);
            woman.Name = "woman";
            woman.Size = new Size(84, 24);
            woman.TabIndex = 18;
            woman.TabStop = true;
            woman.Text = "woman";
            woman.UseVisualStyleBackColor = true;
            woman.CheckedChanged += woman_CheckedChanged;
            // 
            // save
            // 
            save.Location = new Point(428, 382);
            save.Name = "save";
            save.Size = new Size(125, 37);
            save.TabIndex = 19;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Anket
            // 
            Anket.AutoSize = true;
            Anket.Location = new Point(33, 22);
            Anket.Name = "Anket";
            Anket.Size = new Size(52, 20);
            Anket.TabIndex = 20;
            Anket.Text = "Anket";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(Anket);
            Controls.Add(save);
            Controls.Add(woman);
            Controls.Add(man);
            Controls.Add(gender);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(birth_date);
            Controls.Add(phone);
            Controls.Add(city);
            Controls.Add(country);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(father);
            Controls.Add(surname);
            Controls.Add(name);
            Controls.Add(textBox1);
            Controls.Add(load);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Anket";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button load;
        private TextBox textBox1;
        private Label name;
        private Label surname;
        private Label father;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label country;
        private Label city;
        private Label phone;
        private Label birth_date;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DateTimePicker dateTimePicker1;
        private Label gender;
        private RadioButton man;
        private RadioButton woman;
        private Button save;
        private Label Anket;
    }
}