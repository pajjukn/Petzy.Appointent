﻿using Microsoft.EntityFrameworkCore;
using Petzy.Appointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzy.Appointment.Domain.Repository
{
    public class AppointmentDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        public DbSet<Appointments> Appointments { get; set; }

    }
}
