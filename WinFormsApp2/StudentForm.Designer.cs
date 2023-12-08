namespace WinFormsApp2
{
    partial class StudentForm
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
            StudentoVardasPavarde = new Label();
            StudenoGrupe = new Label();
            StudentoDalykai = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridViewDalykai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDalykai).BeginInit();
            SuspendLayout();
            // 
            // StudentoVardasPavarde
            // 
            StudentoVardasPavarde.AutoSize = true;
            StudentoVardasPavarde.Location = new Point(83, 18);
            StudentoVardasPavarde.Name = "StudentoVardasPavarde";
            StudentoVardasPavarde.Size = new Size(41, 15);
            StudentoVardasPavarde.TabIndex = 0;
            StudentoVardasPavarde.Text = "Vardas";
            // 
            // StudenoGrupe
            // 
            StudenoGrupe.AutoSize = true;
            StudenoGrupe.Location = new Point(108, 48);
            StudenoGrupe.Name = "StudenoGrupe";
            StudenoGrupe.Size = new Size(39, 15);
            StudenoGrupe.TabIndex = 1;
            StudenoGrupe.Text = "Grupe";
            // 
            // StudentoDalykai
            // 
            StudentoDalykai.AutoSize = true;
            StudentoDalykai.Location = new Point(35, 118);
            StudentoDalykai.Name = "StudentoDalykai";
            StudentoDalykai.Size = new Size(45, 15);
            StudentoDalykai.TabIndex = 2;
            StudentoDalykai.Text = "Dalykai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Vardas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 48);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Akademine grupe:";
            // 
            // dataGridViewDalykai
            // 
            dataGridViewDalykai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDalykai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDalykai.Location = new Point(35, 136);
            dataGridViewDalykai.Name = "dataGridViewDalykai";
            dataGridViewDalykai.RowTemplate.Height = 25;
            dataGridViewDalykai.Size = new Size(725, 287);
            dataGridViewDalykai.TabIndex = 7;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDalykai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StudentoDalykai);
            Controls.Add(StudenoGrupe);
            Controls.Add(StudentoVardasPavarde);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDalykai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentoVardasPavarde;
        private Label StudenoGrupe;
        private Label StudentoDalykai;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewDalykai;
    }
}