using System;

namespace AkronWeb.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool CanDownload { get; set; }
        public bool CanDelete { get; set; }
        public bool CanModify { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
    }
}