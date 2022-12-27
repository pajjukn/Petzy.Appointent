using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Entities
{
    public class Prescription
    {
        public int AppointmentID { get; set; }
        public List<Prescription> precriptions { get; set; }
    }
}
