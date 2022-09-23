using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopryzhenokApp.Model
{
    public partial class AgentCard : UserControl
    {
        public AgentCard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// AgentCard generation method (variables to labels bindi
        /// </summary>
        /// <param name="agent">Database object variable</param>
        public void GenerateAgentCard(Agent agent)
        {
            AgentPicBox.ImageLocation = agent.Logo;
            TypeTitleLbl.Text = agent.AgentType.Title + " | " + agent.Title;
            PhoneLbl.Text = agent.Phone;
            PriorityValueLbl.Text = agent.Priority.ToString();
            int qty = 0;
            foreach (var sale in agent.ProductSale)
            {
                if (sale.SaleDate.Year ==2019) // if condition for last year sales quantity 
                {
                    qty += sale.ProductCount;
                }
                
            }
            YearSalesLbl.Text = qty + " Продаж за год";
            DiscountLbl.Text = agent.Discount + "%";
            if (agent.Discount > 25) // if condition for 25% discount cards coloring
            {
                DiscountLbl.ForeColor = Color.LightGreen;
                TypeTitleLbl.ForeColor = Color.LightGreen;
            }
            IdLbl.Text = agent.ID.ToString();
        }
    }
}
