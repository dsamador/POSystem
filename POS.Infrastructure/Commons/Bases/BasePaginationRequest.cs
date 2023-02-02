﻿namespace POS.Infrastructure.Commons.Bases
{
    public class BasePaginationRequest
    {
        public int NumPage { get; set; } = 1;
        public int NumRecordPage { get; set; } = 10;

        private readonly int NumMaxRecordsPage = 50;
        public string Order { get; set; } = "asc";
        public string? Sort { get; set; } = null;

        public int Records
        {
            get => NumRecordPage;
            set
            {
                NumRecordPage = (value > NumMaxRecordsPage) ? NumMaxRecordsPage : value;
            }
        }
    }
}
