using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Diaspora_service.Models;

namespace Diaspora_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRetrieveService" in both code and config file together.
    [ServiceContract]
    public interface IRetrieveService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "search/nm={nama}")]
        List<pengurus> search(string nama);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getdatabyid/id={id}")]
        pengurus GetDatabyID(string id);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalldata")]
        List<pengurus> GetAllData();

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
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "getalldatadm")]
        List<admin> GetAllDataAdmin();
    }
}
