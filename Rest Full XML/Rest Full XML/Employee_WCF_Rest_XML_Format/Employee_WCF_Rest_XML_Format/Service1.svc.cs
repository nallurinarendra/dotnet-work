using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Employee_WCF_Rest_XML_Format
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void AddEmployee(EmployeeDataContract obj)
        {
            try
            {
              using(EmployeeDBEntities edb=new EmployeeDBEntities ())
              {
                  EmployeeTable et = new EmployeeTable()
                  {
                      EmpId=obj.EmpId,
                      EmpName=obj.EmpName,
                      EmpSalary=obj.EmpSalary
                  };

                  edb.EmployeeTables.Add(et);
                  edb.SaveChanges();

              }
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            
        }


        public void UpdateEmployee(EmployeeDataContract obj)
        {
            try
            {
                using (EmployeeDBEntities edb = new EmployeeDBEntities())
                {

                    EmployeeTable et = (from st in edb.EmployeeTables where st.EmpId == obj.EmpId select st).First();

                    et.EmpId = obj.EmpId;
                    et.EmpName = obj.EmpName;
                    et.EmpSalary = obj.EmpSalary;
                    edb.SaveChanges();
                    

                }
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }

        public void DeleteEmployee(EmployeeDataContract obj)
        {
            try
            {
                using (EmployeeDBEntities edb = new EmployeeDBEntities())
                {

                    EmployeeTable et = (from st in edb.EmployeeTables where st.EmpId == obj.EmpId select st).First();

                   edb.EmployeeTables.Remove(et);
                   edb.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }

        public EmployeeDataContract SearchEmployee(string EmpId)
        {

            EmployeeDataContract obj = new EmployeeDataContract();

            obj.EmpId = Int32.Parse(EmpId.ToString());

            try
            {
                using (EmployeeDBEntities edb = new EmployeeDBEntities())
                {

                    EmployeeTable et = (from st in edb.EmployeeTables where st.EmpId == obj.EmpId select st).First();

                    obj.EmpId = et.EmpId;
                    obj.EmpName = et.EmpName;
                    obj.EmpSalary = float.Parse(et.EmpSalary.ToString());

                    
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }


            return obj;


        }
    }
}
