using System;

namespace Simple_Web_Browser
{
    public class ResponseInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
