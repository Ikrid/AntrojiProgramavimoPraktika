using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new DuomenuContext())
            {
                if (context.Naudotojai.Any() == false)
                {
                    context.Naudotojai.Add(new User()
                    {
                        FirstName = "Adam",
                        LastName = "Nekrasas",
                        UserName = "Adam",
                        Password = "Nekrasas",
                        UserType = UserType.Administrator
                    });
                    context.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vartotojoVardas = textBox1.Text;
            var vartotojoSlaptazodis = textBox2.Text;

            if (string.IsNullOrEmpty(vartotojoVardas) || string.IsNullOrEmpty(vartotojoSlaptazodis))
            {
                LabelError.Text = "Tu duhas";
                return;
            }

            using (var context = new DuomenuContext())
            {
                var rezultatas = context.Naudotojai
                    .Include(item => item.Kursai)
                    .Include(item => item.Pazymiai)
                    .Include(item => item.Grupe)
                        .ThenInclude(item => item.Kursai)
                    .FirstOrDefault(t => t.UserName == vartotojoVardas && t.Password == vartotojoSlaptazodis);
                if (rezultatas == null)
                {
                    LabelError.Text = "Tu duhas";
                    return;
                }
                switch (rezultatas.UserType)
                {
                    case UserType.Administrator:
                        AdminForm form2 = new AdminForm();

                        form2.ShowDialog();
                        break;
                    case UserType.Lecturer:
                        LecturerForm form3 = new LecturerForm(rezultatas);
                        this.Hide();
                        form3.ShowDialog();
                        break;
                    case UserType.Student:
                        StudentForm studentForm = new(rezultatas);

                        studentForm.ShowDialog();
                        break;
                    default:
                        LabelError.Text = "Nezinoma klaida";
                        break;
                }
            }


        }
    }
}