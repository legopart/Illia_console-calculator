using GoogleSearch.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace GoogleSearch
{
    public partial class frmGoogleSearch : Form
    {
        #region Private members
        List<Label> _resultNumberLabels = new List<Label>();
        List<Label> _resultLabels = new List<Label>();
        #endregion

        #region Public methods
        public frmGoogleSearch()
        {
            InitializeComponent();
        }
        #endregion

        #region Private methods
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Click works", "Hello world!");

            string searchValue = txtSearchBy.Text.Trim();
            if (searchValue == "")
            {
                MessageBox.Show($"Search input is empty. Please fix!");
            }
            else
            {
                // MessageBox.Show($"Search input is <{searchValue}>.");

                ClearPreviousResults();

                ResultJson result = GetSearchResults();

                ShoResultsInLabels(result);

                ShowResultsInDataGrid(result);

                //MessageBox.Show(textResult);
            }
        }

        private ResultJson GetSearchResults()
        {
            string uri = $"https://www.googleapis.com/customsearch/v1?key=AIzaSyCPA8j4Kovr2refBanYiyLSeq5HPFcpqus&cx=017576662512468239146:omuauf_lfve&q={txtSearchBy.Text}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";

            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            string textResult = sr.ReadToEnd();

            ResultJson result = JsonConvert.DeserializeObject<ResultJson>(textResult);
            return result;
        }

        private void ShowResultsInDataGrid(ResultJson result)
        {
            var numberedResults = (from item in result.items.Select((value, index) => new { index, value })
                                   select new { Number = item.index + 1, Title = item.value.title }).ToArray();

            dgvResults.DataSource = numberedResults;
        }

        private void ShoResultsInLabels(ResultJson result)
        {
            for (int i = 1; i <= result.items.Length; i++)
            {
                Label lblNewResultNumber = new Label();
                lblNewResultNumber.Name = $"lblResultNumber{i}";
                lblNewResultNumber.Text = i.ToString();
                lblNewResultNumber.Parent = pnlResults;
                lblNewResultNumber.Top = lblResultNumber.Top + (20 * (i - 1));
                lblNewResultNumber.Left = lblResultNumber.Left;
                lblNewResultNumber.AutoSize = true;
                _resultNumberLabels.Add(lblNewResultNumber);

                Label lblNewResultTitle = new Label();
                lblNewResultTitle.Name = $"lblResultNumber{i}";
                lblNewResultTitle.Text = result.items[i - 1].title;
                lblNewResultTitle.Parent = pnlResults;
                lblNewResultTitle.Top = lblResultTitle.Top + (20 * (i - 1));
                lblNewResultTitle.Left = lblResultTitle.Left;
                lblNewResultTitle.AutoSize = true;
                _resultLabels.Add(lblNewResultTitle);
            }
        }

        private void ClearPreviousResults()
        {
            foreach (Label label in _resultNumberLabels)
            {
                pnlResults.Controls.Remove(label);
            }

            foreach (Label label in _resultLabels)
            {
                pnlResults.Controls.Remove(label);
            }
        }
        #endregion
    }
}
