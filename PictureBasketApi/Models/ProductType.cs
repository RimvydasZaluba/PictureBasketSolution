﻿namespace PictureBasketApi.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Width { get; set; }
        public int StackLimit { get; set; }
    }
}
