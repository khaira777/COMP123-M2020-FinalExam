using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public void GenerateNames()
        {
            //generating random names in the textboxes from the list
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

        // when generate name form loads
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //generate name method is called
            GenerateNames();
        }

        // when generate name button is clicked
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //generate name method is called
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //the following sets the value of the properties to the value that was generated for the textfields
            Program.character.FirstName = firstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;

            // instantiated abilitygeneratorform object
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();

            //showing abilitygenerator form
            abilityGeneratorForm.Show();

            //hiding generate name form
            Program.generatenameform.Hide();
        }
    }
}
