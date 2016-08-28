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
            DataTable employee = dataset.Tables["Employee"];
            DataTable departments = dataset.Tables["Departments"];
            DataTable department = dataset.Tables["Department"];

            //Storint data of xml into database table
            using (SqlBulkCopy bulkcopy = new SqlBulkCopy(datacontext.Connection.ConnectionString))
            {
                
                try
                {
                    bulkcopy.DestinationTableName = "Company";
                    foreach (DataRow a in company.Rows)
                    {
                        List<Object> ls = a.ItemArray.ToList();

                        //Validating Company Id
                        bool validcompanyid = ValidationClass.ValidateCompany(ls[0].ToString());
                        if(validcompanyid)
                        {
                            bulkcopy.ColumnMappings.Add("Company_Id", "Company_Id");
                        }

                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                
            }            
            { }





            }
    }
}
