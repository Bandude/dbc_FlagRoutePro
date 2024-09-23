
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using dbc_FlagRoutePro.Interfaces;
namespace dbc_FlagRoutePro.Entities
{
    public class FlagSeason 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public int SubscriptionTypeId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; } // Ensure this property exists
       
    }
}
