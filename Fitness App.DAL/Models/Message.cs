using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App.DAL.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        //public int SenderId { get; set; }
        //public int ReceiverId { get; set; }
        
        
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public MessageType Type { get; set; }
        public MessageStatus Status { get; set; }
        public Sender sender { get; set; }
        public Receiver receiver { get; set; }

        [ForeignKey("coach")]
        public int CoachID { get; set; }
        public Coach coach { get; set; }

        [ForeignKey("client")]
        public int ClientId { get; set; }
        public Client client { get; set; }
    }
    public enum Sender
    {
        Coach,
        Client
    }
    public enum Receiver
    {
        Coach,
        Client
    }
    public enum MessageType
    {
        Text,
        Image,
        Video,
        Document
    }
    public enum MessageStatus
    {
        Sent,
        Delivered,
        Read,
        Failed
    }
}
