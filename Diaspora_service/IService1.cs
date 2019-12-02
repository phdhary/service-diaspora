using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Diaspora_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [WebInvoke(
    Method = "GET",
    RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json,
    UriTemplate = "getdata/id = {id}")]
        pengurus GetData(string id);




        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalldata")]
        List<pengurus> GetAllData();

        [WebInvoke(
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "adddata")]
        string AddData(pengurus p);

        [WebInvoke(
          Method = "POST",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "updatedata")]
        string UpdateData(pengurus p);


        [OperationContract]
        [WebInvoke(
          Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "getalldataimm")]
        List<pengurus> GetAllDataIMM();

        [OperationContract]
        [WebInvoke(
        Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "getalldatabem")]
        List<pengurus> GetAllDataBEM();

        [OperationContract]
        [WebInvoke(
      Method = "GET",
      RequestFormat = WebMessageFormat.Json,
      ResponseFormat = WebMessageFormat.Json,
      UriTemplate = "getalldatadpm")]
        List<pengurus> GetAllDataDPM();


        [OperationContract]
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "deletedata")]
        string DeleteData(pengurus dp);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
}
