using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public void GenerateNames()
        {
            var random = new Random();
            int indexfirst = random.Next(0, FirstNameListBox.Items.Count);
            firstNameTextBox.Text = FirstNameListBox.Items[indexfirst].ToString();

            int indexlast = random.Next(0, lastNameListBox.Items.Count);
            LastNameTextBox.Text = lastNameListBox.Items[indexlast].ToString();
        }
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.character.FirstName = firstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            Program.generatenameform.Hide();
        }
    }
}
