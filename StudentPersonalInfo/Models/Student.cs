using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPersonalInfo.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Phone { get; set; }
        
        public string Email { get; set; }
        
        public string FatherName { get; set; }
        
        public string MotherName { get; set; }
        
        public string Address { get; set; }
        
        public string ImageLocation { get; set; }

        public override string ToString()
        {
            return $"Student ID: {Id}\nName: {Name}\nPhone: {Phone}\nEmail: {Email}\nFather's Name: {FatherName}\nMother's Name: {MotherName}\nAddress: {Address}\nImage Location: {ImageLocation}";
        }
    }
}
