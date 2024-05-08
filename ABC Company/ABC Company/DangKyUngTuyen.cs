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
    public partial class DangKyUngTuyen : Form
    {
        private AutoCompleteStringCollection paperSuggestions;
        private AutoCompleteStringCollection applierSuggestions;
        private string MaCTDT;

        public DangKyUngTuyen(string maCTDT)
        {
            this.MaCTDT = maCTDT;
            InitializeComponent();

            paperSuggestions = new AutoCompleteStringCollection();
            applierSuggestions = new AutoCompleteStringCollection();

            paper.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            paper.AutoCompleteSource = AutoCompleteSource.CustomSource;
            paper.AutoCompleteCustomSource = paperSuggestions;

            applier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            applier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            applier.AutoCompleteCustomSource = applierSuggestions;
        }

        private void DangKyUngTuyen_Load(object sender, EventArgs e)
        {
            detail.Text = MaCTDT;

            paperSuggestions.Clear();
            var db = new database();
            List<string> paperSuggestionsList = db.paperSuggestion();

            // Add suggestions to the AutoCompleteStringCollection
            foreach (string suggestion in paperSuggestionsList)
            {
                paperSuggestions.Add(suggestion);
            }

            applierSuggestions.Clear();
            List<string> applierSuggestionsList = db.applierSuggestion();

            // Add suggestions to the AutoCompleteStringCollection
            foreach (string suggestion in applierSuggestionsList)
            {
                applierSuggestions.Add(suggestion);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            var db = new database();
            if (db.applyCheck(applier.Text, paper.Text))
            {
                db.registerDangTuyen(MaCTDT, applier.Text);
            }
            this.Close();
        }

        private void applier_TextChanged(object sender, EventArgs e)
        {
            var db = new database().getApllierName(applier.Text);
            name.Text = db;
        }
    }
}
