﻿namespace APIVentas.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }

    }
}
