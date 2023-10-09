using StudentPersonalInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPersonalInfo.Global
{
    public static class GlobalStaticClass
    {
        public static List<Student> StudentList { get; } = new List<Student>();
        public static string placeholder = "C:\\Users\\easin\\OneDrive\\Documents\\C#\\StudentPersonalInfo\\StudentPersonalInfo\\Resources\\person-placeholder.jpg";
        public static int counter = 0;
    }
}
