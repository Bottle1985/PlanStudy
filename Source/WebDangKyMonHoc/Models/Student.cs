using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDangKyMonHoc.Models
{
    public class Student
    {
        private String rollNo;
        private String name;

        public String getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(String rollNo)
        {
            this.rollNo = rollNo;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idUser { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Lever { get; set; }


    }
}
