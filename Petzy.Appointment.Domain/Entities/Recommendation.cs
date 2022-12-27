using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Entities
{
    public class Recommendation
    {
        public int AppointmentID { get; set; }
        public int RecommendationID { get; set; }
        public List<String> RecommendedClinic { get; set; }
        public List<String> RecommendedDocor { get; set; }
        public string Comments { get; set; }
    }
}
