using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : Base
    {
        public void CreateTicket(Ticket ticket)
        {
            using (var session = client.StartSession())
            {
                session.StartTransaction();

                try
                {
                    BsonDocument bsonTicket = new BsonDocument
                    {
                        {"timeReported", ticket.timeReported },
                        {"subject", ticket.subject },
                        {"typeOfIncident", ticket.typeOfIncident},
                        {"email", ticket.email },
                        {"priority", ticket.priority },
                        {"deadline", ticket.deadline },
                        {"description", ticket.description },
                        {"finished", ticket.finished }
                    };
                    ticketCollection.InsertOne(bsonTicket);
                    session.CommitTransaction();
                }
                catch
                {
                    session.AbortTransaction();
                }
            }
        }

        public List<Ticket> ReadTicketAll()
        {
            List<BsonDocument> documents = ticketCollection.Find(new BsonDocument()).ToList();
            List<Ticket> ticketList = new List<Ticket>();

            foreach (BsonDocument document in documents)
            {
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                ticketList.Add(ticket);
            }
            return ticketList;
        }

        public List<Ticket> ReadTicketEmail(string email)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("email", email);
            List<BsonDocument> documents = ticketCollection.Find(filter).ToList();
            List<Ticket> ticketList = new List<Ticket>();

            foreach (BsonDocument document in documents)
            {
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(document);
                ticketList.Add(ticket);
            }
            return ticketList;
        }
    }
}
