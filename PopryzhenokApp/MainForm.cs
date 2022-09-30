using PopryzhenokApp.Model;
using PopryzhenokApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopryzhenokApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = dbContext.Db.Agent.ToList();
        List<AgentCard> SelectedAgentCard = new List<AgentCard>();
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentsCardsList(agents);
            var allTypes = dbContext.Db.AgentType.Select(t => t.Title).ToList();
            allTypes.Insert(0, "Фильтрация");
            FilterCmb.DataSource = allTypes;
            FilterCmb.SelectedIndex = 0;
        }
       public void SearchFilterSorting()
        {
            var ListUpdate = dbContext.Db.Agent.ToList();

            #region Filtering
            if (FilterCmb.SelectedIndex != 0 )
            {
                ListUpdate = ListUpdate.Where(p => p.AgentType.Title == FilterCmb.SelectedItem.ToString()).ToList();
            }



            #endregion
            #region Searching
            if (SearchTxt.Text != "Введите для поиска" && SearchTxt.Text != "")
            {
                ListUpdate = ListUpdate.Where(search => search.Title.ToLower().Contains(SearchTxt.Text.ToLower())
                    || search.Phone.ToString().Contains(SearchTxt.Text)
                    || search.Email.ToString().Contains(SearchTxt.Text.ToLower())).ToList();
            }
            
            #endregion


            #region Sorting
            switch (SortCmb.SelectedIndex)
            {
                case 1:
                    if (DescChkBox.Checked)
                    {
                        ListUpdate = ListUpdate.OrderByDescending(s => s.Title).ToList();
                    }
                    else
                    {
                        ListUpdate = ListUpdate.OrderBy(s => s.Title).ToList();
                    }
                    break;
                case 2:
                    if (DescChkBox.Checked)
                    {
                        ListUpdate = ListUpdate.OrderByDescending(s => s.Priority).ToList();
                    }
                    else
                    {
                        ListUpdate = ListUpdate.OrderBy(s => s.Priority).ToList();
                    }
                    break;
                case 3:
                    if (DescChkBox.Checked)
                    {
                        ListUpdate = ListUpdate.OrderByDescending(s => s.Discount).ToList();
                    }
                    else
                    {
                        ListUpdate = ListUpdate.OrderBy(s => s.Discount).ToList();
                    }
                    break;
            }

            #endregion
            flowLayoutPanel1.Controls.Clear();
            GenerateAgentsCardsList(ListUpdate);
        }
        public void GenerateAgentsCardsList(List<Agent> agents)
        {
            foreach (var agentCard in agents)
            {
                AgentCard card = new AgentCard();
                card.GenerateAgentCard(agentCard);
                flowLayoutPanel1.Controls.Add(card);
                card.Click += Card_Click;
                card.DoubleClick += Card_DoubleClick;
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Card_Click(object sender, EventArgs e)
        {
            AgentCard agentCard = sender as AgentCard;
            if (agentCard.BackColor == Color.White)
            {
                agentCard.BackColor = Color.FromArgb(67, 220, 254);
                SelectedAgentCard.Add(agentCard);
            }
            else
            {
                SelectedAgentCard.Remove(agentCard);
                agentCard.BackColor = Color.White;
            }
        }

        private void FilterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFilterSorting();
        }

        private void DescChkBox_CheckedChanged(object sender, EventArgs e)
        {
            SearchFilterSorting();
        }

        private void SortCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SearchFilterSorting();
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchFilterSorting();
        }

        private void SearchTxt_MouseClick(object sender, MouseEventArgs e)
        {
            SearchTxt.Text = "";
        }

        //Unused
        private void SearchTxt_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchTxt_Leave(object sender, EventArgs e)
        {
            SearchTxt.Text = "Введите для поиска";
        }
    }
}
