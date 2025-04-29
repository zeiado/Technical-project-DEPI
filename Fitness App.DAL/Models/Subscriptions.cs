using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitness_App.DAL.Models
{
    public class Subscription
    {

        public int subscriptionID { get; set; }
        public int ClientId { get; set; }
        public int CoachID { get; set; }
        public Date startDate { get; set; }
        public Date endDate { get; set; }
        public double price { get; set; }
        public SubscriptionStatus subscriptionStatus { get; set; }
        public PaymentStatus paymentStatus { get; set; }
        public Client client { get; set; }
        public Coach coach { get; set; }
    }
    public enum SubscriptionStatus
    {
        ACTIVE,
        EXPIRED,
        CANCELLED
    }
    public enum PaymentStatus
    {
        PAID,
        PENDING,
        FAILED
    }
}
