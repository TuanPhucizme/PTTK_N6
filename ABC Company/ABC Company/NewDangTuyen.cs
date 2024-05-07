using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ABC_Company
{
    public partial class NewDangTuyen : Form
    {
        private AutoCompleteStringCollection companySuggestions;

        public NewDangTuyen()
        {
            InitializeComponent();

            // Initialize suggestions collection
            companySuggestions = new AutoCompleteStringCollection();

            // Set up companyCode TextBox AutoComplete
            companyCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            companyCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            companyCode.AutoCompleteCustomSource = companySuggestions;
        }

        private void NewDangTuyen_Load(object sender, EventArgs e)
        {
            companySuggestions.Clear();
            var db = new database(); // Assuming 'database' is your database access class
            List<string> suggestionsList = db.companySuggestion();

            // Add suggestions to the AutoCompleteStringCollection
            foreach (string suggestion in suggestionsList)
            {
                companySuggestions.Add(suggestion);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DateTime dateTimeValue = Convert.ToDateTime(UploadDate.Text);
            new database().createDangTuyen(dateTimeValue, position.Text, int.Parse(number.Text), description.Text, companyCode.Text);
            this.Close();
        }
    }
}