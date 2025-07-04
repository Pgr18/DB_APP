﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCard
{
    public static class Constants
    {

        public static class TableNames
        {
            public const string DepartmentsTableName = "Departments";
            public const string EmployeesTableName = "Employeess";
            public const string EmplPersonalDataTableName = "EmplPersonalData";
            public const string EmplWorkDataTableName = "EmplWorkData";
        }

        public static class FieldsName
        {
            public const string Id = "Id";

            public static class DepartmentsTable
            {
                public const string Title = "Title";
            }

            public static class EmployeesTable
            {
                public const string DepartmentId = "DepartmentId";
                public const string LastName = "LastName";
                public const string FirstName = "FirstName";
                public const string MiddleName = "MiddleName";
            }

            public static class EmplPersonalDataTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Age = "Age";
                public const string BirthDate = "BirthDate";
                public const string Citizenship = "Citizenship";
                public const string Address = "Address";
                public const string PhotoFileName = "PhotoFileName";
            }

            public static class EmplWorkDataTable
            {
                public const string EmployeeId = "EmployeeId";
                public const string Post = "Post";
                public const string Education = "Education";
                public const string WorkExperience = "WorkExperience";
                public const string WorkCard = "WorkCard";
            }

            public static class ExcelCells
            {
                public const int A = 0;
                public const int B = 1;
                public const int C = 2;
                public const int D = 3;
                public const int E = 4;
                public const int F = 5;
                public const int G = 6; 
                public const int H = 7;
                public const int I = 8;
                public const int J = 9;
            }


        }

    }
}
