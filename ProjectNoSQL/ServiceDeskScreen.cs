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
    public partial class ServiceDeskScreen : Form
    {
        DataTable dataTableUser;
        DataTable dataTableTickets;

        string email;

        public ServiceDeskScreen(string email)
        {
            InitializeComponent();
            this.email = email;
            ShowDashboard();
        }

        // Nav Buttons
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void btn_incidentManagement_Click(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            ShowUserOverview();
        }

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_CreateIncident_Click(object sender, EventArgs e)
        {
            ShowTicketAdd();
        }

        private void btn_CancelTicket_Click(object sender, EventArgs e)
        {
            ShowTicketOverview();
        }

        private void btn_CancelUser_Click(object sender, EventArgs e)
        {
            ShowUserOverview();
        }

        private void btn_AddUserNav_Click(object sender, EventArgs e)
        {
            ShowUserAdd();
        }

        // Show Panels
        private void ShowDashboard()
        {
            pnl_Dashboard.Show();
            pnl_TicketAdd.Hide();
            pnl_TicketOverview.Hide();
            pnl_UserAdd.Hide();
            pnl_UserOverview.Hide();

            FillResolvedChart();
            FillDeadlineChart();
        }

        private void ShowTicketOverview()
        {
            pnl_TicketOverview.Show();
            pnl_Dashboard.Hide();
            pnl_TicketAdd.Hide();
            pnl_UserAdd.Hide();
            pnl_UserOverview.Hide();

            FillTicketList();
        }

        private void ShowTicketAdd()
        {
            pnl_TicketAdd.Show();
            pnl_TicketOverview.Hide();
            pnl_Dashboard.Hide();
            pnl_UserAdd.Hide();
            pnl_UserOverview.Hide();

            cb_TypeOfIncident.DataSource = Enum.GetValues(typeof(TypeOfIncident));
            cb_Priority.DataSource = Enum.GetValues(typeof(Priority));
        }

        private void ShowUserOverview()
        {
            pnl_UserOverview.Show();
            pnl_TicketAdd.Hide();
            pnl_TicketOverview.Hide();
            pnl_Dashboard.Hide();
            pnl_UserAdd.Hide();

            FillUserList();
        }

        private void ShowUserAdd()
        {
            pnl_UserAdd.Show();
            pnl_UserOverview.Hide();
            pnl_TicketAdd.Hide();
            pnl_TicketOverview.Hide();
            pnl_Dashboard.Hide();

            cb_Location.DataSource = Enum.GetValues(typeof(Location));
            cb_TypeOfUser.DataSource = Enum.GetValues(typeof(TypeOfUser));
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
            List<Ticket> tickets = ticketService.ReadTicketAll();
            return tickets.Count();
        }

        private int AmountTicketsPastDeadline()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.ReadTicketAll();

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
            List<Ticket> tickets = ticketService.ReadTicketAll();

            int count = 0;

            foreach(Ticket ticket in tickets)
            {
                if(ticket.finished)
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
            List<Ticket> tickets = ticketService.ReadTicketAll();

            dataTableTickets = new DataTable();

            dataTableTickets.Columns.Add("Time Reported", typeof(DateTime));
            dataTableTickets.Columns.Add("Subject", typeof(string));
            dataTableTickets.Columns.Add("Type of Incident", typeof(TypeOfIncident));
            dataTableTickets.Columns.Add("Email", typeof(string));
            dataTableTickets.Columns.Add("Priority", typeof(Priority));
            dataTableTickets.Columns.Add("Deadline", typeof(DateTime));
            dataTableTickets.Columns.Add("Description", typeof(string));

            foreach (Ticket ticket in tickets)
            {
                dataTableTickets.Rows.Add(ticket.timeReported, ticket.subject, ticket.typeOfIncident, ticket.email, ticket.priority, ticket.deadline, ticket.description);
            }

            dgv_Tickets.DataSource = dataTableTickets;
        }

        private void tb_SearchTicket_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTableTickets.DefaultView;
            dataView.RowFilter = "Email LIKE '%" + tb_SearchTicket.Text + "%'";
            dgv_Tickets.DataSource = dataView;
        }

        private void btn_AddTicket_Click(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();

            DateTime timeReported = DateTime.Now;
            string subject = tb_Subject.Text;
            TypeOfIncident typeOfIncident = (TypeOfIncident) cb_TypeOfIncident.SelectedIndex;
            Priority priority = (Priority)cb_Priority.SelectedIndex;
            DateTime deadline;
            bool finished = false;

            if (priority == Priority.High)
            {
                deadline = timeReported.AddDays(1);
            }
            else if(priority == Priority.Normal)
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
                ticketService.CreateTicket(timeReported , subject, typeOfIncident, email, priority, deadline, description, finished);
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

        // Users
        private void FillUserList()
        {
            UserService userService = new UserService();
            List<User> users = userService.ReadUserAll();

            dataTableUser = new DataTable();

            dataTableUser.Columns.Add("First Name", typeof(string));
            dataTableUser.Columns.Add("Last Name", typeof(string));
            dataTableUser.Columns.Add("Type", typeof(TypeOfUser));
            dataTableUser.Columns.Add("Email", typeof(string));
            dataTableUser.Columns.Add("Phone", typeof(string));
            dataTableUser.Columns.Add("Location", typeof(Location));

            foreach (User user in users)
            {
                dataTableUser.Rows.Add(user.firstName, user.lastName, user.typeOfUser, user.email, user.phone, user.location);
            }

            dgv_Users.DataSource = dataTableUser;
        }

        private void tb_SearchUser_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = dataTableUser.DefaultView;
            dataView.RowFilter = "Email LIKE '%" + tb_SearchUser.Text + "%'";
            dgv_Users.DataSource = dataView;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            Register register = new Register();

            string firstName = tb_FirstName.Text;
            string lastName = tb_LastName.Text;
            TypeOfUser typeOfUser = (TypeOfUser) cb_TypeOfUser.SelectedItem;
            string email = tb_Email.Text;
            string phone = tb_Phone.Text;
            Location location = (Location)cb_Location.SelectedItem;
            string password = register.GeneratePassword();

            if (TexboxUserEmpty())
            {
                lbl_IsEmptyUser.Show();
            }
            else
            {
                userService.CreateUser(firstName, lastName, typeOfUser, email, phone, location, password);

                if (cb_Password.Checked)
                {
                    register.SendMail(email, password, firstName);
                }
                lbl_UserAdded.Show();
                tb_FirstName.Text = string.Empty;
                tb_LastName.Text = string.Empty;
                tb_Email.Text = string.Empty;
                tb_Phone.Text = string.Empty;
            }
        }

        private bool TexboxUserEmpty()
        {
            if (string.IsNullOrEmpty(tb_FirstName.Text) ||
                string.IsNullOrEmpty(tb_LastName.Text) ||
                string.IsNullOrEmpty(tb_Email.Text) ||
                string.IsNullOrEmpty(tb_Phone.Text))
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
