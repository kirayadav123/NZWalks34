﻿namespace NZWalks.API.Models.DTO
{
    public class UpdateRegionRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public Double Lat { get; set; }
        public Double Long { get; set; }
        public double Population { get; set; }
    }
}
