using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class StudentForm : Form
    {
        public StudentForm(User user)
        {
            InitializeComponent();
            StudentoVardasPavarde.Text = string.Format("{0} {1}", user.FirstName, user.LastName);
            dataGridViewDalykai.DataSource = user.Grupe?.Kursai.Select(item => new
            {
                Dalykai = item.Name,
                Pazymiai = string.Join(",", item.Pazymiai.Where(t => t.UserId == user.Id).Select(item => item.Value))
            }).ToList();
        }
    }
}
