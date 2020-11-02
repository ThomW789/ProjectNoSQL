using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using LoginRegister;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectNoSQL
{
    public partial class EmployeeScreen : Form
    {
        DataTable dataTableTickets;
        string email;

        public EmployeeScreen(string email)
        {
            InitializeComponent();
            this.email = email;
            ShowDashboard();
        }

        // Nav Buttons
        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btn_incidentManagement_Click_1(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_CancelTicket_Click_1(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_ShowList_Click_1(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_CreateIncident_Click_1(object sender, EventArgs e)
        {
            ShowTicketAdd();
        }

        // Show Panels
        private void ShowDashboard()
        {
            pnl_Dashboard.Show();
            pnl_TicketAdd.Hide();
            pnl_TicketOverview.Hide();

            FillResolvedChart();
            FillDeadlineChart();
        }

        private void ShowTicketOverview()
        {
            pnl_TicketOverview.Show();
            pnl_Dashboard.Hide();
            pnl_TicketAdd.Hide();

            FillTicketList();
        }

        private void ShowTicketAdd()
        {
            pnl_TicketAdd.Show();
            pnl_TicketOverview.Hide();
            pnl_Dashboard.Hide();

            cb_TypeOfIncident.DataSource = Enum.GetValues(typeof(TypeOfIncident));
            cb_Priority.DataSource = Enum.GetValues(typeof(Priority));
        }

        // Dashboard
        private void FillResolvedChart()
        {
            ch_Resolved.Series.Clear();
            ch_Resolved.Legends.Clear();

            int tickets = AmountOfTickets();
            int resolved = AmountOfTicketsResolved();
            int unresolved = tickets - resolved;

            ch_Resolved.Legends.Add("Resolved Legend");
            ch_Resolved.Legends[0].Docking = Docking.Bottom;
            ch_Resolved.Legends[0].Alignment = StringAlignment.Center;
            ch_Resolved.Legends[0].BorderColor = Color.Black;

            string seriesName = "Resolved";
            ch_Resolved.Series.Add(seriesName);
            ch_Resolved.Series[seriesName].ChartType = SeriesChartType.Pie;
            ch_Resolved.Series[seriesName]["PieLabelStyle"] = "Disabled";

            ch_Resolved.Series[seriesName].Points.AddXY("Unresolved", unresolved);
            ch_Resolved.Series[seriesName].Points.AddXY("Resolved", resolved);

            lbl_NumberUnresolved.Text = $"{unresolved} / {tickets}";

        }

        private void FillDeadlineChart()
        {
            ch_Deadline.Series.Clear();
            ch_Deadline.Legends.Clear();

            int tickets = AmountOfTickets();
            int pastDeadline = AmountTicketsPastDeadline();
            int preDeadline = tickets - pastDeadline;

            ch_Deadline.Legends.Add("Deadline Legend");
            ch_Deadline.Legends[0].Docking = Docking.Bottom;
            ch_Deadline.Legends[0].Alignment = StringAlignment.Center;
            ch_Deadline.Legends[0].BorderColor = Color.Black;

            string seriesName = "Deadline";
            ch_Deadline.Series.Add(seriesName);
            ch_Deadline.Series[seriesName].ChartType = SeriesChartType.Pie;
            ch_Deadline.Series[seriesName]["PieLabelStyle"] = "Disabled";

            ch_Deadline.Series[seriesName].Points.AddXY("Past Deadline", pastDeadline);
            ch_Deadline.Series[seriesName].Points.AddXY("Before Deadline", preDeadline);

            lbl_NumberDeadline.Text = $"{pastDeadline} / {tickets}";
        }

        public int AmountOfTickets()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.ReadTicketEmail(email);
            return tickets.Count();
        }

        private int AmountTicketsPastDeadline()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.ReadTicketEmail(email);

            int count = 0;

            foreach (Ticket ticket in tickets)
            {
                if (DateTime.Now > ticket.deadline)
                {
                    count++;
                }
            }
            return count;
        }

        public int AmountOfTicketsResolved()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.ReadTicketEmail(email);

            int count = 0;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.finished)
                {
                    count++;
                }
            }
            return count;
        }

        // Tickets
        private void FillTicketList()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.ReadTicketEmail(email);

            dataTableTickets = new DataTable();

            dataTableTickets.Columns.Add("Time Reported", typeof(DateTime));
            dataTableTickets.Columns.Add("Subject", typeof(string));
            dataTableTickets.Columns.Add("Type of Incident", typeof(TypeOfIncident));
            dataTableTickets.Columns.Add("Priority", typeof(Priority));
            dataTableTickets.Columns.Add("Deadline", typeof(DateTime));
            dataTableTickets.Columns.Add("Description", typeof(string));
            dataTableTickets.Columns.Add("Resolved", typeof(bool));


            foreach (Ticket ticket in tickets)
            {
                dataTableTickets.Rows.Add(ticket.timeReported, ticket.subject, ticket.typeOfIncident, ticket.priority, ticket.deadline, ticket.description, ticket.finished);
            }

            dgv_Tickets.DataSource = dataTableTickets;
        }

        private void btn_AddTicket_Click_1(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();

            DateTime timeReported = DateTime.Now;
            string subject = tb_Subject.Text;
            TypeOfIncident typeOfIncident = (TypeOfIncident)cb_TypeOfIncident.SelectedIndex;
            Priority priority = (Priority)cb_Priority.SelectedIndex;
            DateTime deadline;
            bool finished = false;

            if (priority == Priority.High)
            {
                deadline = timeReported.AddDays(1);
            }
            else if (priority == Priority.Normal)
            {
                deadline = timeReported.AddDays(3);
            }
            else
            {
                deadline = timeReported.AddDays(7);
            }

            string description = tb_Description.Text;

            if (TextboxTicketEmpty())
            {
                lbl_IsEmptyTicket.Show();
            }
            else
            {
                ticketService.CreateTicket(timeReported, subject, typeOfIncident, email, priority, deadline, description, finished);
                lbl_TicketAdded.Show();
                tb_Subject.Text = string.Empty;
                tb_Description.Text = string.Empty;
            }
        }

        private bool TextboxTicketEmpty()
        {
            if (string.IsNullOrEmpty(tb_Subject.Text) ||
                string.IsNullOrEmpty(tb_Description.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
