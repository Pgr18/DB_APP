﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeCard.Models
{
    public class EmployeeToXml
    {
        [XmlElement(nameof(LastName))]
        public string LastName { get; set; }

        [XmlElement(nameof(FirstName))]
        public string FirstName { get; set; }

        [XmlElement(nameof(MiddleName))]
        public string MiddleName { get; set; }

        [XmlElement(nameof(Age))]
        public string Age { get; set; }

        [XmlElement(nameof(BirthDate))]
        public string BirthDate { get; set; }

        [XmlElement(nameof(Citizenship))]
        public string Citizenship { get; set; }

        [XmlElement(nameof(Address))]
        public string Address { get; set; }

        [XmlElement(nameof(Post))]
        public string Post { get; set; }

        [XmlElement(nameof(Education))]
        public string Education { get; set; }

        [XmlElement(nameof(WorkExperience))]
        public string WorkExperience { get; set; }




    }


    [XmlRoot("Items")]
    public class EmployeeToXmlList
    {
        [XmlElement("Item")]
        public List<EmployeeToXml> Items { get; set; }
    }
}
