using FinancialControlSystem.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialControlSystem.Logic.Models
{ 
        public class ClientFinancialModel
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string Comment { get; set; }
        public ClientFinancialType Type { get; set; }
    }
}
