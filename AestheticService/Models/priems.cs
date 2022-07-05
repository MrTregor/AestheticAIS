using System;

namespace AestheticService.Models
{
    public class priems
    {
        public int id { get; set; }

        public string date { get; set; }

        public string time { get; set; }
        public string service { get; set; }
        public int was { get; set; }
        public string who_fname { get; set; }
        public string who_sname { get; set; }
        public string phone { get; set; }

        public string who
        {
            get
            {
                return $"{who_fname} {who_sname}";
            }
        }

        public override string ToString()
        {
            return $"{date} {time} {service} {who_fname} {who_sname}";
        }
    }
}