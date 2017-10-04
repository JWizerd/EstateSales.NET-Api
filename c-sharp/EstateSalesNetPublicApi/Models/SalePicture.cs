﻿using System.Diagnostics.CodeAnalysis;

namespace EstateSalesNetPublicApi.Models
{
    public class SalePicture
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "This is a data array. Collection object not really useful here.")]
        public byte[] ImageData { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string ThumbnailUrl { get; set; }

        public bool IsSold { get; set; }
    }
}
