using OData_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OData_API.Services
{
    public class EmployeeService
    {
        public List<EmployeeModel> CreateData()
        {
            List<EmployeeModel> employeeModels = new(); // C# 9 Syntax

            employeeModels.Add(new EmployeeModel { Id = 1, Name = "Jay", Role = "Developer", City = "Hyderabad", Pincode = 500072 });
            employeeModels.Add(new EmployeeModel { Id = 2, Name = "Chaitanya ", Role = "Developer", City = "Bangalore", Pincode = 500073 });
            employeeModels.Add(new EmployeeModel { Id = 3, Name = "Bobby Kalyan", Role = "Developer", City = "Chennai", Pincode = 500074 });
            employeeModels.Add(new EmployeeModel { Id = 4, Name = "Praveen", Role = "Developer", City = "Vizag", Pincode = 500075 });
            employeeModels.Add(new EmployeeModel { Id = 5, Name = "Naidu", Role = "Developer", City = "Cochin", Pincode = 500076 });
            employeeModels.Add(new EmployeeModel { Id = 6, Name = "Yateesh", Role = "Developer", City = "Tirupati", Pincode = 500077 });
            employeeModels.Add(new EmployeeModel { Id = 7, Name = "Priyanka", Role = "Developer", City = "Khammam", Pincode = 500064 });
            employeeModels.Add(new EmployeeModel { Id = 8, Name = "Jisha", Role = "QA", City = "Kurnool", Pincode = 500078 });
            employeeModels.Add(new EmployeeModel { Id = 9, Name = "Aravind", Role = "QA", City = "Anakapalli", Pincode = 500214 });
            employeeModels.Add(new EmployeeModel { Id = 10, Name = "Manikanta", Role = "QA", City = "Tuni", Pincode = 500443 });
            employeeModels.Add(new EmployeeModel { Id = 11, Name = "Chinna", Role = "QA", City = "Srikakulam", Pincode = 500534 });
            employeeModels.Add(new EmployeeModel { Id = 12, Name = "Samuel", Role = "QA", City = "Bhimavaram", Pincode = 500654 });
            employeeModels.Add(new EmployeeModel { Id = 13, Name = "John", Role = "QA", City = "Kharagpur", Pincode = 5000765 });
            employeeModels.Add(new EmployeeModel { Id = 14, Name = "Edward", Role = "QA", City = "Mumbai", Pincode = 5000224 });
            employeeModels.Add(new EmployeeModel { Id = 15, Name = "Nihaan", Role = "QA", City = "Mangalore", Pincode = 500965 });
            return employeeModels;
        }

        public List<EmployeeModel> GetEmployees() => CreateData().ToList();
    }
}
