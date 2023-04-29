using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class CongThuc_Img
    {
        public int ID { get; set; }
        public string TenCongThuc { get; set; }
        public string MoTa { get; set; }
        public int ThoiGianNau { get; set; }
        public int IDUser { get; set; }
        public int IDCountry { get; set; }
        public string URL { get; set; }
    }
}
