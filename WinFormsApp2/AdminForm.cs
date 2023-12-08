using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSukurtiGrupe_Click(object sender, EventArgs e)
        {
            var grupesPavadinimas1 = TextBoxGrupesPavadinimas.Text;

            if (string.IsNullOrEmpty(grupesPavadinimas1))
            {
                return;
            }





        }
        private void ButtonSukurtiGrupe_Click_1(object sender, EventArgs e)
        {
            Grupe grupe = new Grupe();
            grupe.Name = TextBoxGrupesPavadinimas.Text;

            var context = new DuomenuContext();
            context.Add(grupe);
            context.SaveChanges();
            comboBoxGrupiu.Items.Add(grupe.Name);
            comboBox5.Items.Add(grupe.Name);
            comboBox10.Items.Add(grupe.Name);
            comboBoxGrupesPrieStudento.Items.Add(grupe.Name);

            TextBoxGrupesPavadinimas.Text = "";

        }

        private void ButtonIstrintiGrupe_Click(object sender, EventArgs e)
        {
            string groupName = comboBoxGrupiu.Text;
            var context = new DuomenuContext();
            var grupe = context.Grupes.FirstOrDefault(t => t.Name == groupName);

            if (grupe != null)
            {
                context.Remove(grupe);
                context.SaveChanges();
                comboBoxGrupiu.Items.Remove(comboBoxGrupiu.SelectedItem);
                RemoveItemFromComboBox(comboBox5, groupName);
                RemoveItemFromComboBox(comboBox10, groupName);
            }
        }

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            var context = new DuomenuContext();
            var grupes = context.Grupes.ToList();
            var kursai = context.Kursai.ToList();
            var Naudotojai = context.Naudotojai.ToList();

            foreach (var kursas in kursai)
            {
                comboBox1.Items.Add(kursas.Name);
                comboBox2.Items.Add(kursas.Name);
                comboBox4.Items.Add(kursas.Name);
                comboBox7.Items.Add(kursas.Name);
                comboBox9.Items.Add(kursas.Name);
            }

            foreach (var user in Naudotojai)
            {
                string fullnanme = user.UserName + " " + user.Password;
                comboBoxNaudotuju.Items.Add(fullnanme);
                if (user.UserType == UserType.Lecturer)
                {
                    comboBox3.Items.Add(fullnanme);
                    comboBox8.Items.Add(fullnanme);

                }
                if (user.UserType == UserType.Student)
                {
                    comboBoxStudentoPriskirstimo.Items.Add(fullnanme);
                }

            }

            comboBoxUserType.DataSource = Enum.GetValues(typeof(UserType));
            comboBoxUserType.DisplayMember = "ToString";

            foreach (var grupe in grupes)
            {
                comboBoxGrupiu.Items.Add(grupe.Name);
                comboBox5.Items.Add(grupe.Name);
                comboBox10.Items.Add(grupe.Name);
                comboBoxGrupesPrieStudento.Items.Add(grupe.Name);
            }

        }

        private void ButtonSukurtiNaudotoja_Click(object sender, EventArgs e)
        {


            User user = new User();
            user.FirstName = textBox1.Text;
            user.LastName = textBox2.Text;
            user.UserName = textBox1.Text;
            user.Password = textBox2.Text;
            user.UserType = (UserType)comboBoxUserType.SelectedItem;

            var context = new DuomenuContext();
            context.Add(user);
            context.SaveChanges();
            comboBoxNaudotuju.Items.Add(user.FirstName + " " + user.LastName);
            if (user.UserType == UserType.Lecturer)
            {
                comboBox3.Items.Add(user.FirstName + " " + user.LastName);
                comboBox8.Items.Add(user.FirstName + " " + user.LastName);
            }
            if (user.UserType == UserType.Student)
            {
                comboBoxStudentoPriskirstimo.Items.Add(user.FirstName + " " + user.LastName);
            }


        }

        //      private void ButtonIstrintiNaudotoja_Click(object sender, EventArgs e)
        //{
        //          string naudotojoName = comboBoxNaudotuju.SelectedItem.ToString();
        //          var context = new DuomenuContext();
        //          var naudotojai = context.Naudotojai.FirstOrDefault(t => t.());
        //
        //          if (naudotojai != null)
        //          {
        //               context.Remove(naudotojai);
        //            }
        //
        //     }
        // }
        private void ButtonIstrintiNaudotoja_Click(object sender, EventArgs e)
        {
            string selectedUserName = comboBoxNaudotuju.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedUserName))
            {

                string[] nameParts = selectedUserName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                var context = new DuomenuContext();
                User userToDelete = context.Naudotojai.FirstOrDefault(u => u.FirstName == firstName && u.LastName == lastName);

                if (userToDelete != null)
                {
                    context.Naudotojai.Remove(userToDelete);
                    context.SaveChanges();

                    comboBoxNaudotuju.Items.Remove(selectedUserName);

                    MessageBox.Show($"Naudotojas {selectedUserName} pasalintas.");
                }
            }
        }

        private void ButtonSukurtiKursa_Click(object sender, EventArgs e)
        {
            Kursas kursas = new Kursas();
            kursas.Name = TextBoxKursoPavadinimas.Text;

            var context = new DuomenuContext();
            context.Add(kursas);
            context.SaveChanges();
            comboBox1.Items.Add(kursas.Name);
            comboBox2.Items.Add(kursas.Name);
            comboBox4.Items.Add(kursas.Name);
            comboBox7.Items.Add(kursas.Name);
            comboBox9.Items.Add(kursas.Name);

            TextBoxKursoPavadinimas.Text = "";

        }


        private void ButtonIstrintiKursa_Click(object sender, EventArgs e)
        {
            string kursoName = comboBox1.Text;
            var context = new DuomenuContext();
            var kursas = context.Kursai.FirstOrDefault(t => t.Name == kursoName);

            if (kursas != null)
            {
                context.Remove(kursas);
                context.SaveChanges();

                comboBox1.Items.Remove(comboBox1.SelectedItem);
                RemoveItemFromComboBox(comboBox2, kursoName);
                RemoveItemFromComboBox(comboBox4, kursoName);
                RemoveItemFromComboBox(comboBox7, kursoName);
                RemoveItemFromComboBox(comboBox9, kursoName);
            }
        }

        private void RemoveItemFromComboBox(ComboBox comboBox, string itemToRemove)
        {
            if (comboBox.Items.Contains(itemToRemove))
            {
                comboBox.Items.Remove(itemToRemove);
            }
        }



        private void ButtonPriskirtiDestytoja_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                string[] parts = comboBox3.SelectedItem.ToString().Split(' ');
                string vardas = parts[0];
                string pavarde = parts[1];

                var context = new DuomenuContext();
                var naudotojas = context.Naudotojai.FirstOrDefault(n => n.FirstName == vardas && n.LastName == pavarde);

                if (naudotojas != null)
                {
                    if (naudotojas.UserType == UserType.Lecturer)
                    {
                        var kursas = context.Kursai.FirstOrDefault(t => t.Name == comboBox2.SelectedItem.ToString());

                        if (kursas != null)
                        {
                            kursas.Naudotojai.Add(naudotojas);
                            context.SaveChanges();
                            MessageBox.Show($"Duomenys sujungti: {naudotojas.FirstName} {naudotojas.LastName} ir {kursas.Name}");
                        }

                    }

                }
            }

        }

        private void ButtonStudentoGrupes_Click(object sender, EventArgs e)
        {
            if (comboBoxStudentoPriskirstimo.SelectedItem != null && comboBoxGrupesPrieStudento.SelectedItem != null)
            {
                string[] parts = comboBoxStudentoPriskirstimo.SelectedItem.ToString().Split(' ');
                string vardas = parts[0];
                string pavarde = parts[1];

                string grupesPavadinimas = comboBoxGrupesPrieStudento.SelectedItem.ToString();

                var context = new DuomenuContext();
                var studentas = context.Naudotojai.FirstOrDefault(s => s.FirstName == vardas && s.LastName == pavarde);
                var grupe = context.Grupes.FirstOrDefault(g => g.Name == grupesPavadinimas);

                if (studentas != null && grupe != null)
                {
                    grupe.Naudotojai.Add(studentas);
                    context.SaveChanges();

                    MessageBox.Show($"Studentas {vardas} {pavarde} priskirtas grupei {grupe.Name}.");
                }
            }
        }

        private void ButtonPriskirtiGrupe_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
            {
                string kursoName = comboBox4.SelectedItem.ToString();
                string grupesName = comboBox5.SelectedItem.ToString();
                var context = new DuomenuContext();
                var grupe = context.Grupes.FirstOrDefault(u => u.Name == grupesName);
                var kursas = context.Kursai.FirstOrDefault(k => k.Name == kursoName);

                if (kursas != null && grupe != null)
                {
                    grupe.Kursai.Add(kursas);
                    context.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox7.SelectedItem != null && comboBox8.SelectedItem != null)
            {
                string kursoName = comboBox7.SelectedItem.ToString();
                string[] parts = comboBox8.SelectedItem.ToString().Split(' ');
                string vardas = parts[0];
                string pavarde = parts[1];

                var context = new DuomenuContext();
                var kursas = context.Kursai
                    .Include(item => item.Naudotojai)
                    .FirstOrDefault(u => u.Name == kursoName);
                var naudotojas = context.Naudotojai.FirstOrDefault(n => n.FirstName == vardas && n.LastName == pavarde);

                if (naudotojas != null && kursas != null)
                {
                    kursas.Naudotojai.Remove(naudotojas);
                    context.SaveChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null && comboBox5.SelectedItem != null)
            {
                string kursoName = comboBox4.SelectedItem.ToString();
                string grupesName = comboBox5.SelectedItem.ToString();
                var context = new DuomenuContext();
                var grupe = context.Grupes
                    .Include(item => item.Kursai)
                    .FirstOrDefault(u => u.Name == grupesName);
                var kursas = context.Kursai.FirstOrDefault(k => k.Name == kursoName);

                if (kursas != null && grupe != null)
                {
                    grupe.Kursai.Remove(kursas);
                    context.SaveChanges();
                }
            }
        }
    }



}