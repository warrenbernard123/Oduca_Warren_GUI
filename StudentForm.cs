using Oduca_Warren_Bernard_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oduca_Warren_Bernard_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Warren Bernard Oduca";
            StudentAgeLabel.Text = "21";
            StudentAddressLabel.Text = "121 Zone 2";
            StudentContactLabel.Text = "09913290935";
            StudentEmailLabel.Text = "rain@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Bernalyn Oduca";
            ParentContactLabel.Text = "09123456780";
            HobbiesLabel.Text = "Graphic Designer";
            NicknameLabel.Text = "Rain";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}