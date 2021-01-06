using DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DataLibrary.DataAccess;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        List<Person> results = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            ViewPeople();
        }

        #region buttons
        private void SortByBtn_Click(object sender, EventArgs e) => Sort();
        private void SearchBtn_Click(object sender, EventArgs e) => Search();
        private void ResetBtn_Click(object sender, EventArgs e) => ViewPeople();
        #endregion

        #region CheckBoxesAndRadios
        private void LastNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (LastNameRadio.Checked == true)
                AgeRadio.Checked = false;
        }

        private void AgeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (AgeRadio.Checked == true)
                LastNameRadio.Checked = false;
        }

        private void LastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LastNameCheckBox.Checked == true)
                EmailCheckBox.Checked = false;
        }

        private void EmailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmailCheckBox.Checked == true)
                LastNameCheckBox.Checked = false;
        }
        #endregion

        #region Methods
        private void Search()
        {
            if(!String.IsNullOrEmpty(SearchTxtBox.Text))
            {
                if(LastNameCheckBox.Checked==true)
                PeopleTable.DataSource = results.Where(p => p.LastName.Equals(SearchTxtBox.Text)).ToList();

                if (EmailCheckBox.Checked == true)
                    PeopleTable.DataSource = results.Where(p => p.Email.Equals(SearchTxtBox.Text)).ToList();
            }
        }

        private void Sort()
        {
            if (LastNameRadio.Checked == true)
                PeopleTable.DataSource = results.OrderBy(p => p.LastName).ToList();

            if (AgeRadio.Checked == true)
                PeopleTable.DataSource = results.OrderBy(p => p.Age).ToList();
        }

        private void ViewPeople()
        {
            results = Read();
            PeopleTable.DataSource = results;
        }
        #endregion

        private void PeopleTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void SearchTxtBox_TextChanged(object sender, EventArgs e) { }
    }
}
