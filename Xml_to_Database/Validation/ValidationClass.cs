using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextClassLibrary;

namespace Xml_to_Database
{
    public class ValidationClass
    {
        public static bool ValidateCompany(string companyid)
        {
            XmlDataContextDataContext datacontext = new XmlDataContextDataContext();
            if (IsNumber(companyid))
            {
                Int64 company_id = Int64.Parse(companyid);

                if (company_id >= 0)
                {
                    //Checking whether the number is already present in database or not.
                    var comp_id = from id in datacontext.Companies where id.Company_Id == company_id select id.Company_Id;
                   // Console.WriteLine(comp_id);
                    if (comp_id.Count()==0)
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

        public static bool IsNumber(string companyid)
        {
            Int64 number = 0;
            return Int64.TryParse(companyid, out number);


        }
    }
}
