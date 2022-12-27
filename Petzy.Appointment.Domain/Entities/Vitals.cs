using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Entities
{
    public class Vitals
    {
        public int AppointmentID { get; set; }
        public int VitalsID { get; set; }
        public int BPM { get; set; }
        public int Temp { get; set; }
    }
}
