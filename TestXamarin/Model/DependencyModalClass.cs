using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestXamarin.Model
{
    public class DependencyModalClass
    {
        public ObservableCollection<employeeClass> EmployeeList { get; set; }

        public DependencyModalClass()
        {
            EmployeeList = new ObservableCollection<employeeClass> {
            new employeeClass() { EmployeeName = "Rakesh Kumar", DependencyType = "Father", DOB = "09 Feb 1961", Gender = "Male", MaritalStatus = "Married" },
            new employeeClass() { EmployeeName = "Chaaya", DependencyType = "Spouse", DOB = "21 Mar 1992", Gender = "Female", MaritalStatus = "Married" },
            new employeeClass() { EmployeeName = "Kapil", DependencyType = "Son", DOB = "09 Dec 2017", Gender = "Male", MaritalStatus = "N/A" }
            };
        }
    }
    


    public class employeeClass
    {
        public string EmployeeName { get; set; }
        public string DependencyType { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string MaritalStatus { get; set; }
    }
}
