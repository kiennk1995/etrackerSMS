using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtrackerSMS
{
    public class SendSMSModel
    {
        public string AccountID { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public string ContractName { get; set; }
        public string Content { get; set; }
        public string TitleMess { get; set; }
    }
}
