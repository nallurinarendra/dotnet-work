using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Employee_WCF_Rest_JSON_Format
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddEmployee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        void AddEmployee(EmployeeDataContract obj);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateEmployee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT")]
        void UpdateEmployee(EmployeeDataContract obj);


        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteEmployee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        void DeleteEmployee(EmployeeDataContract obj);



        [OperationContract]
        [WebInvoke(UriTemplate = "/SearchEmployee/{EmpId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        EmployeeDataContract SearchEmployee(string EmpId);
              
    }


    [DataContract]
    public class EmployeeDataContract
    {
        [DataMember]
        public int EmpId { get; set; }

        [DataMember]
        public string EmpName { get; set; }

        [DataMember]
        public float EmpSalary { get; set; }


    }

}
