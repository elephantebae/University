using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMVC.Models
{
    public class University
    {
        public int UniversityId { get; set; }

        public string UniversityName { get; set; }
        public University(int universityId, string universityName)
        {
            if (universityName != null) UniversityName = universityName;
            UniversityId = universityId;
        }

        public University()
        {
        }
    }
}
