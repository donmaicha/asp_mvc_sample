﻿using System;
namespace sample.Models
{
    public class Product
    {
        // ID は自動で主キー
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
