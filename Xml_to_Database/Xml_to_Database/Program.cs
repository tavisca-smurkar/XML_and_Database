using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextClassLibrary;
using System.Data;
using System.Data.SqlClient;
using Xml_to_Database;

namespace Xml_to_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            DataSet dataset = new DataSet();
            dataset.ReadXml(@"D:\XML_Project\Xml_to_Database\Xml_to_Database\Database\Employee-Company.xml");
            DataTable company = dataset.Tables["Company"];
            DataTable employees = dataset.Tables["Employees"];
            DataTable departments = dataset.Tables["Departments"];
            DataTable department = dataset.Tables["Department"];
            DataTable employee = dataset.Tables["Employee"];



            //Storint data of xml into database table
            using (SqlBulkCopy bulkcopy = new SqlBulkCopy(datacontext.Connection.ConnectionString))
            {

                try
                {
                    //Adding data in Company
                    bulkcopy.DestinationTableName = "Company";
                    bool validcompanyid = false;
                    bool validcompanyname = false;
                    foreach (DataRow companyrow in company.Rows)
                    {
                        List<Object> ls = companyrow.ItemArray.ToList();

                        // Validating Company Id
                        validcompanyid = ValidationClass.ValidateCompanyId(ls[1].ToString());


                        //Validating Company Name
                        validcompanyname = ValidationClass.ValidCompanyName(ls[0].ToString());

                    }
                    if (validcompanyid == true && validcompanyname == true)
                    {
                        bulkcopy.ColumnMappings.Add("Company_Id", "Company_Id");
                        bulkcopy.ColumnMappings.Add("CompanyName", "CompanyName");
                        bulkcopy.WriteToServer(company);
                    }

                }

                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }




                using (SqlBulkCopy bulkcopy_1 = new SqlBulkCopy(datacontext.Connection.ConnectionString))
                {

                    try
                    {

                        //Adding data in Empployees
                        bulkcopy_1.DestinationTableName = "Employees";
                        bool valid_emps_id = false;
                        bool valid_companyid = false;
                        foreach (DataRow emps in employees.Rows)
                        {
                            List<Object> employees_list = emps.ItemArray.ToList();

                            // Validating Employees Id
                            valid_emps_id = ValidationClass.ValidateEmployeesID(employees_list[0].ToString());

                            // Validating Company Id
                            valid_companyid = ValidationClass.ValidateFKCompanyId(employees_list[1].ToString());

                        }

                        if (valid_emps_id == true && valid_companyid == true)
                        {
                            bulkcopy_1.ColumnMappings.Add("Employees_Id", "Employees_Id");
                            bulkcopy_1.ColumnMappings.Add("Company_Id", "Company_Id");
                            bulkcopy_1.WriteToServer(employees);
                        }

                    }

                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }


                using (SqlBulkCopy bulkcopy_2 = new SqlBulkCopy(datacontext.Connection.ConnectionString))
                {

                    try
                    {

                        //Adding data in Departments
                        bulkcopy_2.DestinationTableName = "Departments";
                        bool valid_depts_id = false;
                        bool validcompany_id = false;
                        foreach (DataRow depts in departments.Rows)
                        {
                            List<Object> departments_list = depts.ItemArray.ToList();

                            // Validating Departments Id
                            valid_depts_id = ValidationClass.ValidateDepartmentsID(departments_list[0].ToString());

                            // Validating Company Id
                            validcompany_id = ValidationClass.ValidateFKCompanyId(departments_list[1].ToString());




                        }

                        if (valid_depts_id == true && validcompany_id == true)
                        {
                            bulkcopy_2.ColumnMappings.Add("Departments_Id", "Departments_Id");
                            bulkcopy_2.ColumnMappings.Add("Company_Id", "Company_Id");
                            bulkcopy_2.WriteToServer(departments);
                        }

                    }

                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                using (SqlBulkCopy bulkcopy_3 = new SqlBulkCopy(datacontext.Connection.ConnectionString))
                {

                    try
                    {
                        //Adding data in Department
                        bulkcopy_3.DestinationTableName = "Department";
                        bool valid_id_dept = false;
                        bool valid_name_dept = false;
                        bool valid_id_depts = false;
                        foreach (DataRow dept in department.Rows)
                        {
                            List<Object> department_list = dept.ItemArray.ToList();

                            // Validating Department Id
                            valid_id_dept = ValidationClass.ValidateDepartment_ID(department_list[0].ToString());

                            // Validating Department Name
                            valid_name_dept = ValidationClass.ValidDepartmentName(department_list[1].ToString());

                            // Validating Departments id
                            valid_id_depts = ValidationClass.ValidateFKDepartmentsID(department_list[2].ToString());



                        }

                        if (valid_id_dept == true && valid_name_dept == true && valid_id_depts == true)
                        {
                            bulkcopy_3.ColumnMappings.Add("ID", "ID");
                            bulkcopy_3.ColumnMappings.Add("DepartmentName", "DepartmentName");
                            bulkcopy_3.WriteToServer(department);
                        }

                    }

                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                using (SqlBulkCopy bulkcopy_4 = new SqlBulkCopy(datacontext.Connection.ConnectionString))
                {

                    try
                    {
                        //Adding data in Employee
                        bulkcopy_4.DestinationTableName = "Employee";
                        bool valid_id_emp = false;
                        bool valid_emp_dept_id = false;
                        bool valid_firstName = false;
                        bool valid_LastName = false;
                        bool valid_salary = false;
                        bool valid_emps_id_2 = false;
                        foreach (DataRow emp in employee.Rows)
                        {
                            List<Object> employee_list = emp.ItemArray.ToList();

                            // Validating Employee Id
                            valid_id_emp = ValidationClass.ValidateEmployee_ID(employee_list[0].ToString());


                            //Validating Department id
                            valid_emp_dept_id = ValidationClass.ValidateFKDepartment_ID(employee_list[1].ToString());


                            // Validating First Name
                            valid_firstName = ValidationClass.ValidFirstName(employee_list[2].ToString());


                            // Validating Last Name
                            valid_LastName = ValidationClass.ValidLastName(employee_list[3].ToString());



                            // Validating Salary
                            valid_salary = ValidationClass.ValidSalary(employee_list[4].ToString());


                            // Validating employees id
                            valid_emps_id_2 = ValidationClass.ValidateFKEmployeesID(employee_list[5].ToString());


                        }

                        if (valid_id_emp == true && valid_emp_dept_id == true && valid_firstName == true && valid_LastName == true && valid_salary == true && valid_emps_id_2 == true)
                        {
                            bulkcopy_4.ColumnMappings.Add("ID", "ID");
                            bulkcopy_4.ColumnMappings.Add("DepartmentId", "DepartmentId");
                            bulkcopy_4.ColumnMappings.Add("FirstName", "FirstName");
                            bulkcopy_4.ColumnMappings.Add("LastName", "LastName");
                            bulkcopy_4.ColumnMappings.Add("Salary", "Salary");
                            bulkcopy_4.ColumnMappings.Add("Employees_Id", "Employees_Id");
                            bulkcopy_4.WriteToServer(employee);
                        }



                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }

                }






            }
        }
    }
}
