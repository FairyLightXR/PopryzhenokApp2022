using PopryzhenokApp.Model;
using PopryzhenokApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopryzhenokApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = dbContext.Db.Agent.ToList();
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateAgentsCardsList(agents);
            
        }
        public void GenerateAgentsCardsList(List<Agent> agents)
        {
            foreach (var agentCard in agents)
            {
                AgentCard card = new AgentCard();
                card.GenerateAgentCard(agentCard);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
          
    }
}
