using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextClassLibrary;
using System.Text.RegularExpressions;

namespace Xml_to_Database
{
    public class ValidationClass
    {
        public static bool ValidateCompanyId(string companyid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(companyid))
            {
                Int64 company_id = Int64.Parse(companyid);

                if (company_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                     var comp_id = from id in datacontext.Companies where id.Company_Id == company_id select id.Company_Id;
                    Console.WriteLine(comp_id);
                    if (comp_id.Count() == 0)
                    {
                        return true;

                    }
                    else
                {
                    throw new Exception("Company ID is already present in Company.");
                }
            }
            else
            {
                throw new Exception("Not a valid Company ID. ID can't be nagative.");
            }
            }
            else
            {
                throw new Exception("Not a Valid Company ID");
            }

        }


        public static bool ValidateFKCompanyId(string companyid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(companyid))
            {
                Int64 company_id = Int64.Parse(companyid);

                if (company_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var comp_id = from id in datacontext.Companies where id.Company_Id == company_id select id.Company_Id;
                    Console.WriteLine(comp_id);
                    if (comp_id.Count() == 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Company ID is not present in Company.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Company ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Company ID");
            }

        }










        public static bool ValidateEmployeesID(string empsid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(empsid))
            {
                Int64 empsid_id = Int64.Parse(empsid);

                if (empsid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var emps_id = from id in datacontext.Employee1s where id.Employees_Id == empsid_id select id.Employees_Id;
                   
                    if (emps_id.Count() == 0)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Employees ID is already present in Employees.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Employees ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Employees ID");
            }

        }


        public static bool ValidateFKEmployeesID(string empsid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(empsid))
            {
                Int64 empsid_id = Int64.Parse(empsid);

                if (empsid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var emps_id = from id in datacontext.Employee1s where id.Employees_Id == empsid_id select id.Employees_Id;

                    if (emps_id.Count() == 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Employees ID is not present in Employees.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Employees ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Employees ID");
            }

        }





        public static bool ValidateDepartmentsID(string deptsid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(deptsid))
            {
                Int64 deptsid_id = Int64.Parse(deptsid);

                if (deptsid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var depts_id = from id in datacontext.Department1s where id.Departments_Id == deptsid_id select id.Departments_Id;

                    if (depts_id.Count() == 0)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Departments ID is already present in Departments.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Departments ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Departments ID");
            }

        }



        public static bool ValidateFKDepartmentsID(string deptsid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(deptsid))
            {
                Int64 deptsid_id = Int64.Parse(deptsid);

                if (deptsid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var depts_id = from id in datacontext.Department1s where id.Departments_Id == deptsid_id select id.Departments_Id;

                    if (depts_id.Count() == 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Departments ID is not present in Departments.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Departments ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Departments ID");
            }

        }




        public static bool ValidateDepartment_ID(string deptid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(deptid))
            {
                Int64 deptid_id = Int64.Parse(deptid);

                if (deptid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var dept_id = from id in datacontext.Departments where id.ID == deptid_id select id.ID;

                    if (dept_id.Count() == 0)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Department ID is already present in Department.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Department ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Department ID");
            }

        }


        public static bool ValidateFKDepartment_ID(string deptid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(deptid))
            {
                Int64 deptid_id = Int64.Parse(deptid);

                if (deptid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var dept_id = from id in datacontext.Departments where id.ID == deptid_id select id.ID;

                    if (dept_id.Count() == 1)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Department ID is not present in Department.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Department ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Department ID");
            }

        }




        public static bool ValidateEmployee_ID(string empid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(empid))
            {
                Int64 empid_id = Int64.Parse(empid);

                if (empid_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var emp_id = from id in datacontext.Employees where id.ID == empid_id select id.ID;

                    if (emp_id.Count() == 0)
                    {
                        return true;

                    }
                    else
                    {
                        throw new Exception("Employee ID is already present in Employee.");
                    }
                }
                else
                {
                    throw new Exception("Not a valid Employee ID. ID can't be nagative.");
                }
            }
            else
            {
                throw new Exception("Not a Valid Employee ID");
            }

        }






        public static bool ValidCompanyName(string companyname)
    {
            if (validname(companyname))
            {
                return true;
            }
            else throw new Exception("Not a valid Company name.");
    }

        public static bool ValidDepartmentName(string deptname)
        {
            if (validname(deptname))
            {
                return true;
            }
            else throw new Exception("Not a valid Department name.");
        }

        public static bool ValidFirstName (string firstname)
        {
            if (validname(firstname))
            {
                return true;
            }
            else throw new Exception("Not a valid Fisrt Name.");
        }

        public static bool ValidLastName(string lastname)
        {
            if (validname(lastname))
            {
                return true;
            }
            else throw new Exception("Not a valid Last Name.");
        }

        public static bool ValidSalary(string salary)
        {
            if (IsNumber(salary))
            {
                if (Int64.Parse(salary) > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Not a valid Salary. Salary can not be negative.");
                }

            }
            else
            {
                throw new Exception("Not a valid Salary.");
            }
        }


        public static bool IsNumber(string companyid)
    {
        Int64 number = 0;
        return Int64.TryParse(companyid, out number);
    }

    public static bool validname(string name)
    {
        Regex regex = new Regex(@"^[a-zA-Z]+$");
        Match match = regex.Match(name);
        return match.Success;
    }
}
}
