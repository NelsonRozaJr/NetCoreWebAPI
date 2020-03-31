﻿using System;

namespace NetCoreWebAPI.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime? InitialDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int EventId { get; set; }

        public Event Event { get; }
    }
}
