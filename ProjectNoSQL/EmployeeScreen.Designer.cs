namespace ProjectNoSQL
{
    partial class EmployeeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_incidentManagement = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.lbl_Title2 = new System.Windows.Forms.Label();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_NumberDeadline = new System.Windows.Forms.Label();
            this.lbl_NumberUnresolved = new System.Windows.Forms.Label();
            this.lbl_Deadline2 = new System.Windows.Forms.Label();
            this.lbl_Deadline1 = new System.Windows.Forms.Label();
            this.lbl_Unresolved2 = new System.Windows.Forms.Label();
            this.lbl_Unresolved1 = new System.Windows.Forms.Label();
            this.btn_ShowList = new System.Windows.Forms.Button();
            this.ch_Deadline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_Resolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_CurrentIncidents = new System.Windows.Forms.Label();
            this.pnl_TicketAdd = new System.Windows.Forms.Panel();
            this.lbl_TicketAdded = new System.Windows.Forms.Label();
            this.lbl_IsEmptyTicket = new System.Windows.Forms.Label();
            this.btn_CancelTicket = new System.Windows.Forms.Button();
            this.btn_AddTicket = new System.Windows.Forms.Button();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.cb_Priority = new System.Windows.Forms.ComboBox();
            this.lbl_Priority = new System.Windows.Forms.Label();
            this.cb_TypeOfIncident = new System.Windows.Forms.ComboBox();
            this.lbl_TypeIncident = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_AddTicet = new System.Windows.Forms.Label();
            this.pnl_TicketOverview = new System.Windows.Forms.Panel();
            this.dgv_Tickets = new System.Windows.Forms.DataGridView();
            this.btn_CreateIncident = new System.Windows.Forms.Button();
            this.lbl_OverviewTickets = new System.Windows.Forms.Label();
            this.pnl_Nav.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Deadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Resolved)).BeginInit();
            this.pnl_TicketAdd.SuspendLayout();
            this.pnl_TicketOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Nav.Controls.Add(this.btn_incidentManagement);
            this.pnl_Nav.Controls.Add(this.btn_Dashboard);
            this.pnl_Nav.Controls.Add(this.lbl_Title2);
            this.pnl_Nav.Controls.Add(this.lbl_Title1);
            this.pnl_Nav.Location = new System.Drawing.Point(476, 12);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(952, 101);
            this.pnl_Nav.TabIndex = 0;
            // 
            // btn_incidentManagement
            // 
            this.btn_incidentManagement.AutoSize = true;
            this.btn_incidentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incidentManagement.Location = new System.Drawing.Point(479, 66);
            this.btn_incidentManagement.Name = "btn_incidentManagement";
            this.btn_incidentManagement.Size = new System.Drawing.Size(470, 32);
            this.btn_incidentManagement.TabIndex = 5;
            this.btn_incidentManagement.Text = "Incident Management";
            this.btn_incidentManagement.UseVisualStyleBackColor = true;
            this.btn_incidentManagement.Click += new System.EventHandler(this.btn_incidentManagement_Click_1);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.AutoSize = true;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Location = new System.Drawing.Point(3, 66);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(470, 32);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click_1);
            // 
            // lbl_Title2
            // 
            this.lbl_Title2.AutoSize = true;
            this.lbl_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Title2.Location = new System.Drawing.Point(675, 34);
            this.lbl_Title2.Name = "lbl_Title2";
            this.lbl_Title2.Size = new System.Drawing.Size(274, 20);
            this.lbl_Title2.TabIndex = 3;
            this.lbl_Title2.Text = "Licensed to: The Garden Group";
            this.lbl_Title2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.AutoSize = true;
            this.lbl_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title1.Location = new System.Drawing.Point(752, 3);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(197, 31);
            this.lbl_Title1.TabIndex = 2;
            this.lbl_Title1.Text = "NoDesk: TGG";
            this.lbl_Title1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Dashboard.Controls.Add(this.lbl_NumberDeadline);
            this.pnl_Dashboard.Controls.Add(this.lbl_NumberUnresolved);
            this.pnl_Dashboard.Controls.Add(this.lbl_Deadline2);
            this.pnl_Dashboard.Controls.Add(this.lbl_Deadline1);
            this.pnl_Dashboard.Controls.Add(this.lbl_Unresolved2);
            this.pnl_Dashboard.Controls.Add(this.lbl_Unresolved1);
            this.pnl_Dashboard.Controls.Add(this.btn_ShowList);
            this.pnl_Dashboard.Controls.Add(this.ch_Deadline);
            this.pnl_Dashboard.Controls.Add(this.ch_Resolved);
            this.pnl_Dashboard.Controls.Add(this.lbl_CurrentIncidents);
            this.pnl_Dashboard.Location = new System.Drawing.Point(476, 119);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(952, 870);
            this.pnl_Dashboard.TabIndex = 3;
            // 
            // lbl_NumberDeadline
            // 
            this.lbl_NumberDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberDeadline.Location = new System.Drawing.Point(516, 575);
            this.lbl_NumberDeadline.Name = "lbl_NumberDeadline";
            this.lbl_NumberDeadline.Size = new System.Drawing.Size(396, 20);
            this.lbl_NumberDeadline.TabIndex = 19;
            this.lbl_NumberDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NumberUnresolved
            // 
            this.lbl_NumberUnresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberUnresolved.Location = new System.Drawing.Point(40, 575);
            this.lbl_NumberUnresolved.Name = "lbl_NumberUnresolved";
            this.lbl_NumberUnresolved.Size = new System.Drawing.Size(396, 20);
            this.lbl_NumberUnresolved.TabIndex = 18;
            this.lbl_NumberUnresolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Deadline2
            // 
            this.lbl_Deadline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deadline2.Location = new System.Drawing.Point(516, 130);
            this.lbl_Deadline2.Name = "lbl_Deadline2";
            this.lbl_Deadline2.Size = new System.Drawing.Size(396, 20);
            this.lbl_Deadline2.TabIndex = 17;
            this.lbl_Deadline2.Text = "All of your tickets past the deadline";
            this.lbl_Deadline2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Deadline1
            // 
            this.lbl_Deadline1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deadline1.Location = new System.Drawing.Point(516, 100);
            this.lbl_Deadline1.Name = "lbl_Deadline1";
            this.lbl_Deadline1.Size = new System.Drawing.Size(396, 20);
            this.lbl_Deadline1.TabIndex = 16;
            this.lbl_Deadline1.Text = "Incidents past deadline";
            this.lbl_Deadline1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Unresolved2
            // 
            this.lbl_Unresolved2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved2.Location = new System.Drawing.Point(40, 130);
            this.lbl_Unresolved2.Name = "lbl_Unresolved2";
            this.lbl_Unresolved2.Size = new System.Drawing.Size(396, 20);
            this.lbl_Unresolved2.TabIndex = 14;
            this.lbl_Unresolved2.Text = "All of your tickets that are currently open";
            this.lbl_Unresolved2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Unresolved1
            // 
            this.lbl_Unresolved1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved1.Location = new System.Drawing.Point(40, 100);
            this.lbl_Unresolved1.Name = "lbl_Unresolved1";
            this.lbl_Unresolved1.Size = new System.Drawing.Size(396, 20);
            this.lbl_Unresolved1.TabIndex = 13;
            this.lbl_Unresolved1.Text = "Unresolved Incidents";
            this.lbl_Unresolved1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ShowList
            // 
            this.btn_ShowList.AutoSize = true;
            this.btn_ShowList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ShowList.Location = new System.Drawing.Point(792, 44);
            this.btn_ShowList.Name = "btn_ShowList";
            this.btn_ShowList.Size = new System.Drawing.Size(120, 32);
            this.btn_ShowList.TabIndex = 9;
            this.btn_ShowList.Text = "Show List";
            this.btn_ShowList.UseVisualStyleBackColor = false;
            this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click_1);
            // 
            // ch_Deadline
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Deadline.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_Deadline.Legends.Add(legend1);
            this.ch_Deadline.Location = new System.Drawing.Point(516, 160);
            this.ch_Deadline.Name = "ch_Deadline";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_Deadline.Series.Add(series1);
            this.ch_Deadline.Size = new System.Drawing.Size(396, 396);
            this.ch_Deadline.TabIndex = 8;
            this.ch_Deadline.Text = "chart1";
            // 
            // ch_Resolved
            // 
            chartArea2.Name = "ChartArea1";
            this.ch_Resolved.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ch_Resolved.Legends.Add(legend2);
            this.ch_Resolved.Location = new System.Drawing.Point(40, 160);
            this.ch_Resolved.Name = "ch_Resolved";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ch_Resolved.Series.Add(series2);
            this.ch_Resolved.Size = new System.Drawing.Size(396, 396);
            this.ch_Resolved.TabIndex = 7;
            this.ch_Resolved.Text = "chart1";
            // 
            // lbl_CurrentIncidents
            // 
            this.lbl_CurrentIncidents.AutoSize = true;
            this.lbl_CurrentIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentIncidents.Location = new System.Drawing.Point(40, 40);
            this.lbl_CurrentIncidents.Name = "lbl_CurrentIncidents";
            this.lbl_CurrentIncidents.Size = new System.Drawing.Size(239, 31);
            this.lbl_CurrentIncidents.TabIndex = 6;
            this.lbl_CurrentIncidents.Text = "Current Incidents";
            this.lbl_CurrentIncidents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_TicketAdd
            // 
            this.pnl_TicketAdd.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_TicketAdd.Controls.Add(this.lbl_TicketAdded);
            this.pnl_TicketAdd.Controls.Add(this.lbl_IsEmptyTicket);
            this.pnl_TicketAdd.Controls.Add(this.btn_CancelTicket);
            this.pnl_TicketAdd.Controls.Add(this.btn_AddTicket);
            this.pnl_TicketAdd.Controls.Add(this.tb_Description);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Description);
            this.pnl_TicketAdd.Controls.Add(this.cb_Priority);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Priority);
            this.pnl_TicketAdd.Controls.Add(this.cb_TypeOfIncident);
            this.pnl_TicketAdd.Controls.Add(this.lbl_TypeIncident);
            this.pnl_TicketAdd.Controls.Add(this.tb_Subject);
            this.pnl_TicketAdd.Controls.Add(this.lbl_Subject);
            this.pnl_TicketAdd.Controls.Add(this.lbl_AddTicet);
            this.pnl_TicketAdd.Location = new System.Drawing.Point(476, 119);
            this.pnl_TicketAdd.Name = "pnl_TicketAdd";
            this.pnl_TicketAdd.Size = new System.Drawing.Size(952, 870);
            this.pnl_TicketAdd.TabIndex = 5;
            // 
            // lbl_TicketAdded
            // 
            this.lbl_TicketAdded.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_TicketAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TicketAdded.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_TicketAdded.Location = new System.Drawing.Point(396, 595);
            this.lbl_TicketAdded.Name = "lbl_TicketAdded";
            this.lbl_TicketAdded.Size = new System.Drawing.Size(401, 26);
            this.lbl_TicketAdded.TabIndex = 39;
            this.lbl_TicketAdded.Text = "Ticket has been added";
            this.lbl_TicketAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TicketAdded.Visible = false;
            // 
            // lbl_IsEmptyTicket
            // 
            this.lbl_IsEmptyTicket.BackColor = System.Drawing.Color.LightPink;
            this.lbl_IsEmptyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IsEmptyTicket.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_IsEmptyTicket.Location = new System.Drawing.Point(396, 595);
            this.lbl_IsEmptyTicket.Name = "lbl_IsEmptyTicket";
            this.lbl_IsEmptyTicket.Size = new System.Drawing.Size(401, 26);
            this.lbl_IsEmptyTicket.TabIndex = 38;
            this.lbl_IsEmptyTicket.Text = "Please fill out every field";
            this.lbl_IsEmptyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_IsEmptyTicket.Visible = false;
            // 
            // btn_CancelTicket
            // 
            this.btn_CancelTicket.AutoSize = true;
            this.btn_CancelTicket.BackColor = System.Drawing.SystemColors.Window;
            this.btn_CancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CancelTicket.Location = new System.Drawing.Point(396, 522);
            this.btn_CancelTicket.Name = "btn_CancelTicket";
            this.btn_CancelTicket.Size = new System.Drawing.Size(140, 36);
            this.btn_CancelTicket.TabIndex = 35;
            this.btn_CancelTicket.Text = "Cancel";
            this.btn_CancelTicket.UseVisualStyleBackColor = false;
            this.btn_CancelTicket.Click += new System.EventHandler(this.btn_CancelTicket_Click_1);
            // 
            // btn_AddTicket
            // 
            this.btn_AddTicket.AutoSize = true;
            this.btn_AddTicket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddTicket.Location = new System.Drawing.Point(657, 522);
            this.btn_AddTicket.Name = "btn_AddTicket";
            this.btn_AddTicket.Size = new System.Drawing.Size(140, 36);
            this.btn_AddTicket.TabIndex = 34;
            this.btn_AddTicket.Text = "Add Ticket";
            this.btn_AddTicket.UseVisualStyleBackColor = false;
            this.btn_AddTicket.Click += new System.EventHandler(this.btn_AddTicket_Click_1);
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(396, 328);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(401, 156);
            this.tb_Description.TabIndex = 17;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(158, 331);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(89, 20);
            this.lbl_Description.TabIndex = 16;
            this.lbl_Description.Text = "Description";
            // 
            // cb_Priority
            // 
            this.cb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Priority.FormattingEnabled = true;
            this.cb_Priority.Location = new System.Drawing.Point(396, 262);
            this.cb_Priority.Name = "cb_Priority";
            this.cb_Priority.Size = new System.Drawing.Size(401, 28);
            this.cb_Priority.TabIndex = 15;
            // 
            // lbl_Priority
            // 
            this.lbl_Priority.AutoSize = true;
            this.lbl_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority.Location = new System.Drawing.Point(158, 265);
            this.lbl_Priority.Name = "lbl_Priority";
            this.lbl_Priority.Size = new System.Drawing.Size(56, 20);
            this.lbl_Priority.TabIndex = 14;
            this.lbl_Priority.Text = "Priority";
            // 
            // cb_TypeOfIncident
            // 
            this.cb_TypeOfIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TypeOfIncident.FormattingEnabled = true;
            this.cb_TypeOfIncident.Location = new System.Drawing.Point(396, 196);
            this.cb_TypeOfIncident.Name = "cb_TypeOfIncident";
            this.cb_TypeOfIncident.Size = new System.Drawing.Size(401, 28);
            this.cb_TypeOfIncident.TabIndex = 13;
            // 
            // lbl_TypeIncident
            // 
            this.lbl_TypeIncident.AutoSize = true;
            this.lbl_TypeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TypeIncident.Location = new System.Drawing.Point(158, 199);
            this.lbl_TypeIncident.Name = "lbl_TypeIncident";
            this.lbl_TypeIncident.Size = new System.Drawing.Size(120, 20);
            this.lbl_TypeIncident.TabIndex = 12;
            this.lbl_TypeIncident.Text = "Type of incident";
            // 
            // tb_Subject
            // 
            this.tb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Subject.Location = new System.Drawing.Point(396, 132);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(401, 26);
            this.tb_Subject.TabIndex = 10;
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(158, 135);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(140, 20);
            this.lbl_Subject.TabIndex = 9;
            this.lbl_Subject.Text = "Subject of incident";
            // 
            // lbl_AddTicet
            // 
            this.lbl_AddTicet.AutoSize = true;
            this.lbl_AddTicet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddTicet.Location = new System.Drawing.Point(40, 40);
            this.lbl_AddTicet.Name = "lbl_AddTicet";
            this.lbl_AddTicet.Size = new System.Drawing.Size(376, 31);
            this.lbl_AddTicet.TabIndex = 4;
            this.lbl_AddTicet.Text = "Create a new incident ticket";
            // 
            // pnl_TicketOverview
            // 
            this.pnl_TicketOverview.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_TicketOverview.Controls.Add(this.dgv_Tickets);
            this.pnl_TicketOverview.Controls.Add(this.btn_CreateIncident);
            this.pnl_TicketOverview.Controls.Add(this.lbl_OverviewTickets);
            this.pnl_TicketOverview.Location = new System.Drawing.Point(476, 119);
            this.pnl_TicketOverview.Name = "pnl_TicketOverview";
            this.pnl_TicketOverview.Size = new System.Drawing.Size(952, 870);
            this.pnl_TicketOverview.TabIndex = 6;
            // 
            // dgv_Tickets
            // 
            this.dgv_Tickets.AllowUserToAddRows = false;
            this.dgv_Tickets.AllowUserToDeleteRows = false;
            this.dgv_Tickets.AllowUserToOrderColumns = true;
            this.dgv_Tickets.AllowUserToResizeRows = false;
            this.dgv_Tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_Tickets.Location = new System.Drawing.Point(40, 145);
            this.dgv_Tickets.Name = "dgv_Tickets";
            this.dgv_Tickets.ReadOnly = true;
            this.dgv_Tickets.RowHeadersVisible = false;
            this.dgv_Tickets.Size = new System.Drawing.Size(872, 712);
            this.dgv_Tickets.TabIndex = 8;
            // 
            // btn_CreateIncident
            // 
            this.btn_CreateIncident.AutoSize = true;
            this.btn_CreateIncident.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateIncident.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CreateIncident.Location = new System.Drawing.Point(772, 88);
            this.btn_CreateIncident.Name = "btn_CreateIncident";
            this.btn_CreateIncident.Size = new System.Drawing.Size(140, 36);
            this.btn_CreateIncident.TabIndex = 7;
            this.btn_CreateIncident.Text = "Create Incident";
            this.btn_CreateIncident.UseVisualStyleBackColor = false;
            this.btn_CreateIncident.Click += new System.EventHandler(this.btn_CreateIncident_Click_1);
            // 
            // lbl_OverviewTickets
            // 
            this.lbl_OverviewTickets.AutoSize = true;
            this.lbl_OverviewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OverviewTickets.Location = new System.Drawing.Point(40, 40);
            this.lbl_OverviewTickets.Name = "lbl_OverviewTickets";
            this.lbl_OverviewTickets.Size = new System.Drawing.Size(239, 31);
            this.lbl_OverviewTickets.TabIndex = 3;
            this.lbl_OverviewTickets.Text = "Overview Tickets";
            this.lbl_OverviewTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1001);
            this.Controls.Add(this.pnl_Nav);
            this.Controls.Add(this.pnl_TicketOverview);
            this.Controls.Add(this.pnl_TicketAdd);
            this.Controls.Add(this.pnl_Dashboard);
            this.Name = "EmployeeScreen";
            this.Text = "EmployeeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Nav.ResumeLayout(false);
            this.pnl_Nav.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Deadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Resolved)).EndInit();
            this.pnl_TicketAdd.ResumeLayout(false);
            this.pnl_TicketAdd.PerformLayout();
            this.pnl_TicketOverview.ResumeLayout(false);
            this.pnl_TicketOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label lbl_Title2;
        private System.Windows.Forms.Button btn_incidentManagement;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Button btn_ShowList;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Deadline;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Resolved;
        private System.Windows.Forms.Label lbl_CurrentIncidents;
        private System.Windows.Forms.Panel pnl_TicketAdd;
        private System.Windows.Forms.Button btn_CancelTicket;
        private System.Windows.Forms.Button btn_AddTicket;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.ComboBox cb_Priority;
        private System.Windows.Forms.Label lbl_Priority;
        private System.Windows.Forms.ComboBox cb_TypeOfIncident;
        private System.Windows.Forms.Label lbl_TypeIncident;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_AddTicet;
        private System.Windows.Forms.Panel pnl_TicketOverview;
        private System.Windows.Forms.DataGridView dgv_Tickets;
        private System.Windows.Forms.Button btn_CreateIncident;
        private System.Windows.Forms.Label lbl_OverviewTickets;
        private System.Windows.Forms.Label lbl_TicketAdded;
        private System.Windows.Forms.Label lbl_IsEmptyTicket;
        private System.Windows.Forms.Label lbl_Unresolved2;
        private System.Windows.Forms.Label lbl_Unresolved1;
        private System.Windows.Forms.Label lbl_Deadline2;
        private System.Windows.Forms.Label lbl_Deadline1;
        private System.Windows.Forms.Label lbl_NumberDeadline;
        private System.Windows.Forms.Label lbl_NumberUnresolved;
    }
}