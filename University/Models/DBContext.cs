using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMVC.Models
{

    public class DBContext
    {
        public IList<Student> students = new List<Student>();
        public DBContext() { }

        public IList<Student> allStuds(string uniName, int uniId, string secName, int secID)
        {
            IList<Student> tempStuds = new List<Student>();
            foreach(var stu in students)
            {
                if (stu.UniversityName == uniName &&
                    stu.UniversityId == uniId &&
                    stu.sectionName == secName &&
                    stu.sectiondID == secID)
                {
                    tempStuds.Add(stu);
                }
            }
            return tempStuds;
        }
        public IList<Student> getAllStudentsOver17()
        {
            IList<Student> tempStuds = new List<Student>();
            foreach (var stud in students)
            {
                if (stud.StudentAge > 17)
                {
                    tempStuds.Add(stud);
                }
            }
            return tempStuds;

        }

        public Dictionary<int, string> uniDetail()
        {
            IList<int> uniId = new List<int>();
            IList<string> uniName = new List<string>();
            IList<Student> allStudents = new List<Student>();
            foreach(var x in students)
            {
                if(uniId.Contains(x.UniversityId) && uniName.Contains(x.UniversityName))
                {
                    uniId.Add(x.UniversityId);
                    uniName.Add(x.UniversityName);
                }
            }
            Dictionary<int, string> uniDetail = new Dictionary<int, string>();
            for(var i = 0; i < uniId.Count; i++)
            {
                uniDetail.Add(uniId[i], uniName[i]);
            }
            return uniDetail;
        }

        public string uniDetail(int id)
        {
            foreach (Student x in students)
            {
                if(x.UniversityId == id)
                {
                    return x.UniversityName;
                }
            }
            return new string("none available");
        }

    }
}
