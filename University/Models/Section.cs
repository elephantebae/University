using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMVC.Models
{
    public class Section : University
    {
        public string sectionName { get; set; }
        public int sectiondID { get; set; }

        public Section() : base() { }

        public Section(string UniversityName, int UniversityID, string SectionName, int sectID) : base(UniversityID, UniversityName)
        {
            this.sectiondID = sectID;
            if (SectionName != null) this.sectionName = SectionName;
        }
    }
}
