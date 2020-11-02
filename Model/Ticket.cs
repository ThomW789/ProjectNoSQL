using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public ObjectId id;
        public DateTime timeReported;
        public string subject;
        public TypeOfIncident typeOfIncident;
        public string email;
        public Priority priority;
        public DateTime deadline;
        public string description;
        public bool finished;

        public Ticket(DateTime timeReported, string subject, TypeOfIncident typeOfIncident, string email, Priority priority, DateTime deadline, string description, bool finished)
        {
            this.timeReported = timeReported;
            this.subject = subject;
            this.typeOfIncident = typeOfIncident;
            this.email = email;
            this.priority = priority;
            this.deadline = deadline;
            this.description = description;
            this.finished = finished;
        }
    }
}
