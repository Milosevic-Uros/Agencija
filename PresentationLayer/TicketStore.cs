using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{

    public partial class TicketStore : Form

    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IClientBusiness clientBusiness;
        public TicketStore(IAdminBusiness _adminBusiness, IClientBusiness _clientBusiness)
        {
            adminBusiness = _adminBusiness;
            clientBusiness = _clientBusiness;
            InitializeComponent();
        }

        private void TicketStore_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = adminBusiness.GetAllTickets();
            dataGridViewTickets.DataSource = tickets;
        }


        private void dataGridViewTickets_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTickets.Rows[e.RowIndex];

            }
        }
    }
}
