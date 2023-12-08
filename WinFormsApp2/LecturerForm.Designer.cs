namespace WinFormsApp2
{
    partial class LecturerForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            ButtonPazymioPateikimo = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(365, 123);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(507, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            
            // 
            // ButtonPazymioPateikimo
            // 
            ButtonPazymioPateikimo.Location = new Point(636, 122);
            ButtonPazymioPateikimo.Name = "ButtonPazymioPateikimo";
            ButtonPazymioPateikimo.Size = new Size(75, 23);
            ButtonPazymioPateikimo.TabIndex = 5;
            ButtonPazymioPateikimo.Text = "Pateikti";
            ButtonPazymioPateikimo.UseVisualStyleBackColor = true;
            ButtonPazymioPateikimo.Click += ButtonPazymioPateikimo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 105);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Kursas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 105);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Grupe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 105);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Studentas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 105);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Pazymys";
            // 
            // LecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtonPazymioPateikimo);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "LecturerForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Button ButtonPazymioPateikimo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}