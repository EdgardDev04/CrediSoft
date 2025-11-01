using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Domain.Enums
{
    public enum LoanStatus
    {
        Active = 1,
        Requested = 2,      
        Approved = 3,      
        Rejected = 4,       
        Disbursed = 5,      
        Current = 6,        
        Delinquent = 7,     
        Defaulted = 8,      
        WrittenOff = 9,     
        PaidOff = 10
    }
}
