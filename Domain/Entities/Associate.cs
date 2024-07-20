using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Associate : User
    {
        public DateTime LastPay {  get; set; }
        public ICollection<Class> ClassAttended { get; set; } = new List<Class>();
    }
}
