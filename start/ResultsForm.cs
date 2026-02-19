using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace start
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var users = UserManager.GetAll();

            foreach (var user in users)
            {
                resultsDataGridView.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
