﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace ClassLibrary
{
    public class Page : TableEntity
    {
        public Page(string title, string url, DateTime date, string urlHash)
        {
            this.PartitionKey = urlHash;
            this.RowKey = Guid.NewGuid().ToString();
            this.title = title;
            this.url = url;
            this.date = date;
        }

        public Page() { }

        public DateTime date { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
