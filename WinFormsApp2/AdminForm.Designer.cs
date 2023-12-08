namespace WinFormsApp2
{
    partial class AdminForm
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
            label1 = new Label();
            TextBoxGrupesPavadinimas = new TextBox();
            label2 = new Label();
            ButtonSukurtiGrupe = new Button();
            label3 = new Label();
            ButtonIstrintiGrupe = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            ButtonSukurtiNaudotoja = new Button();
            comboBoxNaudotuju = new ComboBox();
            ButtonIstrintiNaudotoja = new Button();
            comboBoxGrupiu = new ComboBox();
            label8 = new Label();
            TextBoxKursoPavadinimas = new TextBox();
            label9 = new Label();
            ButtonSukurtiKursa = new Button();
            comboBox1 = new ComboBox();
            label10 = new Label();
            ButtonIstrintiKursa = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ButtonPriskirtiDestytoja = new Button();
            ButtonPriskirtiGrupe = new Button();
            comboBoxUserType = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox10 = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBoxStudentoPriskirstimo = new ComboBox();
            comboBoxGrupesPrieStudento = new ComboBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            ButtonStudentoGrupes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Grupiu valdymas";
            // 
            // TextBoxGrupesPavadinimas
            // 
            TextBoxGrupesPavadinimas.Location = new Point(12, 56);
            TextBoxGrupesPavadinimas.Name = "TextBoxGrupesPavadinimas";
            TextBoxGrupesPavadinimas.Size = new Size(162, 23);
            TextBoxGrupesPavadinimas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 2;
            label2.Text = "Kuriamos grupes pavadinimas";
            // 
            // ButtonSukurtiGrupe
            // 
            ButtonSukurtiGrupe.Location = new Point(180, 55);
            ButtonSukurtiGrupe.Name = "ButtonSukurtiGrupe";
            ButtonSukurtiGrupe.Size = new Size(75, 23);
            ButtonSukurtiGrupe.TabIndex = 3;
            ButtonSukurtiGrupe.Text = "Sukurti";
            ButtonSukurtiGrupe.UseVisualStyleBackColor = true;
            ButtonSukurtiGrupe.Click += ButtonSukurtiGrupe_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 5;
            label3.Text = "Ištrinamosios grupes pavadinimas";
            // 
            // ButtonIstrintiGrupe
            // 
            ButtonIstrintiGrupe.Location = new Point(180, 109);
            ButtonIstrintiGrupe.Name = "ButtonIstrintiGrupe";
            ButtonIstrintiGrupe.Size = new Size(75, 23);
            ButtonIstrintiGrupe.TabIndex = 6;
            ButtonIstrintiGrupe.Text = "Ištrinti";
            ButtonIstrintiGrupe.UseVisualStyleBackColor = true;
            ButtonIstrintiGrupe.Click += ButtonIstrintiGrupe_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 271);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 7;
            label4.Text = "Naudotojo valdymas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Vardas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 340);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "Pavarde";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 358);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 384);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 12;
            label7.Text = "UserType";
            // 
            // ButtonSukurtiNaudotoja
            // 
            ButtonSukurtiNaudotoja.Location = new Point(180, 313);
            ButtonSukurtiNaudotoja.Name = "ButtonSukurtiNaudotoja";
            ButtonSukurtiNaudotoja.Size = new Size(75, 23);
            ButtonSukurtiNaudotoja.TabIndex = 14;
            ButtonSukurtiNaudotoja.Text = "Sukurti";
            ButtonSukurtiNaudotoja.UseVisualStyleBackColor = true;
            ButtonSukurtiNaudotoja.Click += ButtonSukurtiNaudotoja_Click;
            // 
            // comboBoxNaudotuju
            // 
            comboBoxNaudotuju.FormattingEnabled = true;
            comboBoxNaudotuju.Location = new Point(276, 313);
            comboBoxNaudotuju.Name = "comboBoxNaudotuju";
            comboBoxNaudotuju.Size = new Size(121, 23);
            comboBoxNaudotuju.TabIndex = 15;
            // 
            // ButtonIstrintiNaudotoja
            // 
            ButtonIstrintiNaudotoja.Location = new Point(403, 314);
            ButtonIstrintiNaudotoja.Name = "ButtonIstrintiNaudotoja";
            ButtonIstrintiNaudotoja.Size = new Size(75, 23);
            ButtonIstrintiNaudotoja.TabIndex = 16;
            ButtonIstrintiNaudotoja.Text = "Ištrinti";
            ButtonIstrintiNaudotoja.UseVisualStyleBackColor = true;
            ButtonIstrintiNaudotoja.Click += ButtonIstrintiNaudotoja_Click;
            // 
            // comboBoxGrupiu
            // 
            comboBoxGrupiu.FormattingEnabled = true;
            comboBoxGrupiu.Location = new Point(12, 109);
            comboBoxGrupiu.Name = "comboBoxGrupiu";
            comboBoxGrupiu.Size = new Size(162, 23);
            comboBoxGrupiu.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(851, 18);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 18;
            label8.Text = "Kursu valdymas";
            // 
            // TextBoxKursoPavadinimas
            // 
            TextBoxKursoPavadinimas.Location = new Point(731, 55);
            TextBoxKursoPavadinimas.Name = "TextBoxKursoPavadinimas";
            TextBoxKursoPavadinimas.Size = new Size(162, 23);
            TextBoxKursoPavadinimas.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(731, 38);
            label9.Name = "label9";
            label9.Size = new Size(154, 15);
            label9.TabIndex = 20;
            label9.Text = "Kuriamo kurso pavadinimas";
            // 
            // ButtonSukurtiKursa
            // 
            ButtonSukurtiKursa.Location = new Point(899, 55);
            ButtonSukurtiKursa.Name = "ButtonSukurtiKursa";
            ButtonSukurtiKursa.Size = new Size(75, 23);
            ButtonSukurtiKursa.TabIndex = 21;
            ButtonSukurtiKursa.Text = "Sukurti";
            ButtonSukurtiKursa.UseVisualStyleBackColor = true;
            ButtonSukurtiKursa.Click += ButtonSukurtiKursa_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(731, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(731, 91);
            label10.Name = "label10";
            label10.Size = new Size(169, 15);
            label10.TabIndex = 23;
            label10.Text = "Ištrinamojo kurso pavadinimas";
            // 
            // ButtonIstrintiKursa
            // 
            ButtonIstrintiKursa.Location = new Point(899, 108);
            ButtonIstrintiKursa.Name = "ButtonIstrintiKursa";
            ButtonIstrintiKursa.Size = new Size(75, 23);
            ButtonIstrintiKursa.TabIndex = 24;
            ButtonIstrintiKursa.Text = "Ištrinti";
            ButtonIstrintiKursa.UseVisualStyleBackColor = true;
            ButtonIstrintiKursa.Click += ButtonIstrintiKursa_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(569, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(162, 23);
            comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(749, 167);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(162, 23);
            comboBox3.TabIndex = 26;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(569, 217);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(162, 23);
            comboBox4.TabIndex = 27;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(749, 217);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(162, 23);
            comboBox5.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(569, 149);
            label11.Name = "label11";
            label11.Size = new Size(174, 15);
            label11.TabIndex = 29;
            label11.Text = "Priskiariamo kurso pavadinimas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(569, 199);
            label12.Name = "label12";
            label12.Size = new Size(174, 15);
            label12.TabIndex = 30;
            label12.Text = "Priskiariamo kurso pavadinimas";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(749, 149);
            label13.Name = "label13";
            label13.Size = new Size(191, 15);
            label13.TabIndex = 31;
            label13.Text = "Priskeriamo destytojo pavadinimas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(749, 199);
            label14.Name = "label14";
            label14.Size = new Size(187, 15);
            label14.TabIndex = 32;
            label14.Text = "Priskiariamoji grupes pavadinimas";
            // 
            // ButtonPriskirtiDestytoja
            // 
            ButtonPriskirtiDestytoja.Location = new Point(930, 166);
            ButtonPriskirtiDestytoja.Name = "ButtonPriskirtiDestytoja";
            ButtonPriskirtiDestytoja.Size = new Size(75, 23);
            ButtonPriskirtiDestytoja.TabIndex = 33;
            ButtonPriskirtiDestytoja.Text = "Priskirti";
            ButtonPriskirtiDestytoja.UseVisualStyleBackColor = true;
            ButtonPriskirtiDestytoja.Click += ButtonPriskirtiDestytoja_Click;
            // 
            // ButtonPriskirtiGrupe
            // 
            ButtonPriskirtiGrupe.Location = new Point(930, 217);
            ButtonPriskirtiGrupe.Name = "ButtonPriskirtiGrupe";
            ButtonPriskirtiGrupe.Size = new Size(75, 23);
            ButtonPriskirtiGrupe.TabIndex = 34;
            ButtonPriskirtiGrupe.Text = "Priskirti";
            ButtonPriskirtiGrupe.UseVisualStyleBackColor = true;
            ButtonPriskirtiGrupe.Click += ButtonPriskirtiGrupe_Click;
            // 
            // comboBoxUserType
            // 
            comboBoxUserType.FormattingEnabled = true;
            comboBoxUserType.Location = new Point(12, 402);
            comboBoxUserType.Name = "comboBoxUserType";
            comboBoxUserType.Size = new Size(162, 23);
            comboBoxUserType.TabIndex = 35;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(569, 272);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(162, 23);
            comboBox7.TabIndex = 36;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(749, 272);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(162, 23);
            comboBox8.TabIndex = 37;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(569, 328);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(162, 23);
            comboBox9.TabIndex = 38;
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(749, 328);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(162, 23);
            comboBox10.TabIndex = 39;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(569, 254);
            label15.Name = "label15";
            label15.Size = new Size(176, 15);
            label15.TabIndex = 40;
            label15.Text = "Atskiriamojo kurso pavadinimas";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(569, 310);
            label16.Name = "label16";
            label16.Size = new Size(176, 15);
            label16.TabIndex = 41;
            label16.Text = "Atskiriamojo kurso pavadinimas";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(750, 254);
            label17.Name = "label17";
            label17.Size = new Size(196, 15);
            label17.TabIndex = 42;
            label17.Text = "Atskiriamojo destytojo pavadinimas";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(750, 310);
            label18.Name = "label18";
            label18.Size = new Size(183, 15);
            label18.TabIndex = 43;
            label18.Text = "Atskiriamojo grupes pavadinimas";
            // 
            // button1
            // 
            button1.Location = new Point(930, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            button1.Text = "Atskirti";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(930, 328);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 45;
            button2.Text = "Atskirti";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxStudentoPriskirstimo
            // 
            comboBoxStudentoPriskirstimo.FormattingEnabled = true;
            comboBoxStudentoPriskirstimo.Location = new Point(276, 372);
            comboBoxStudentoPriskirstimo.Name = "comboBoxStudentoPriskirstimo";
            comboBoxStudentoPriskirstimo.Size = new Size(121, 23);
            comboBoxStudentoPriskirstimo.TabIndex = 46;
            // 
            // comboBoxGrupesPrieStudento
            // 
            comboBoxGrupesPrieStudento.FormattingEnabled = true;
            comboBoxGrupesPrieStudento.Location = new Point(276, 418);
            comboBoxGrupesPrieStudento.Name = "comboBoxGrupesPrieStudento";
            comboBoxGrupesPrieStudento.Size = new Size(121, 23);
            comboBoxGrupesPrieStudento.TabIndex = 47;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(276, 295);
            label19.Name = "label19";
            label19.Size = new Size(86, 15);
            label19.TabIndex = 48;
            label19.Text = "Userio trinimas";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(276, 354);
            label20.Name = "label20";
            label20.Size = new Size(124, 15);
            label20.TabIndex = 49;
            label20.Text = "Studento priskirstimas";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(276, 400);
            label21.Name = "label21";
            label21.Size = new Size(113, 15);
            label21.TabIndex = 50;
            label21.Text = "Grupes priskirstimas";
            // 
            // ButtonStudentoGrupes
            // 
            ButtonStudentoGrupes.Location = new Point(406, 371);
            ButtonStudentoGrupes.Name = "ButtonStudentoGrupes";
            ButtonStudentoGrupes.Size = new Size(75, 23);
            ButtonStudentoGrupes.TabIndex = 51;
            ButtonStudentoGrupes.Text = "Priskirti";
            ButtonStudentoGrupes.UseVisualStyleBackColor = true;
            ButtonStudentoGrupes.Click += ButtonStudentoGrupes_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 490);
            Controls.Add(ButtonStudentoGrupes);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(comboBoxGrupesPrieStudento);
            Controls.Add(comboBoxStudentoPriskirstimo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(comboBox10);
            Controls.Add(comboBox9);
            Controls.Add(comboBox8);
            Controls.Add(comboBox7);
            Controls.Add(comboBoxUserType);
            Controls.Add(ButtonPriskirtiGrupe);
            Controls.Add(ButtonPriskirtiDestytoja);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(ButtonIstrintiKursa);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(ButtonSukurtiKursa);
            Controls.Add(label9);
            Controls.Add(TextBoxKursoPavadinimas);
            Controls.Add(label8);
            Controls.Add(comboBoxGrupiu);
            Controls.Add(ButtonIstrintiNaudotoja);
            Controls.Add(comboBoxNaudotuju);
            Controls.Add(ButtonSukurtiNaudotoja);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(ButtonIstrintiGrupe);
            Controls.Add(label3);
            Controls.Add(ButtonSukurtiGrupe);
            Controls.Add(label2);
            Controls.Add(TextBoxGrupesPavadinimas);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "Form2";
            FormClosed += AdminForm_FormClosed;
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxGrupesPavadinimas;
        private Label label2;
        private Button ButtonSukurtiGrupe;
        private Label label3;
        private Button ButtonIstrintiGrupe;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Button ButtonSukurtiNaudotoja;
        private ComboBox comboBoxNaudotuju;
        private Button ButtonIstrintiNaudotoja;
        private ComboBox comboBoxGrupiu;
        private Label label8;
        private TextBox TextBoxKursoPavadinimas;
        private Label label9;
        private Button ButtonSukurtiKursa;
        private ComboBox comboBox1;
        private Label label10;
        private Button ButtonIstrintiKursa;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button ButtonPriskirtiDestytoja;
        private Button ButtonPriskirtiGrupe;
        private ComboBox comboBoxUserType;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button button1;
        private Button button2;
        private ComboBox comboBoxStudentoPriskirstimo;
        private ComboBox comboBoxGrupesPrieStudento;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button ButtonStudentoGrupes;
    }
}