using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class LecturerForm : Form
    {
        public LecturerForm(User user)
        {
            InitializeComponent();
            comboBox1.DataSource = user.Kursai.Select(s => s.Name).ToList();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var kursas = comboBox1.SelectedItem;
            if (kursas != null)
            {
                var context = new DuomenuContext();
                var kursasEntity = context.Kursai
                    .Include(item => item.Grupes)
                    .FirstOrDefault(item => item.Name == kursas);

                if (kursasEntity != null)
                {
                    comboBox2.SelectedItem = null;
                    comboBox2.DataSource = kursasEntity.Grupes.Select(item => item.Name).ToList();
                }
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var grupe = comboBox2.SelectedItem;
            if (grupe != null)
            {
                var context = new DuomenuContext();
                var grupeEntity = context.Grupes
                    .Include(item => item.Naudotojai)
                    .FirstOrDefault(item => item.Name == grupe);
                if (grupeEntity != null)
                {
                    comboBox3.SelectedItem = null;
                    comboBox3.DataSource = grupeEntity.Naudotojai.Select(item => $"{item.FirstName} {item.LastName}").ToList();
                }
            }
            else
            {
                comboBox3.SelectedItem = null;
                comboBox3.DataSource = null;
            }
        }

        private void ButtonPazymioPateikimo_Click(object sender, EventArgs e)
        {
            // Duomenu Surinkimas
            if (comboBox1.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                string pazymysPazymys = textBox1.Text;
                string kursoName = comboBox1.SelectedItem.ToString();
                string[] parts = comboBox3.SelectedItem.ToString().Split(' ');
                string vardas = parts[0];
                string pavarde = parts[1];
                var context = new DuomenuContext();

                if (int.TryParse(pazymysPazymys, out int pazymysValue))
                {
                    var kursas = context.Kursai.FirstOrDefault(k => k.Name == kursoName);
                    var studentas = context.Naudotojai.FirstOrDefault(s => s.FirstName == vardas && s.LastName == pavarde);
                    if (studentas != null && kursas != null)
                    {
                        studentas.Pazymiai.Add(new Pazymys()
                        {
                            KursasId = kursas.Id,
                            UserId = studentas.Id,
                            Value = pazymysValue,
                        });
                        context.SaveChanges();
                    }
                }

            }
        }
    }
}
