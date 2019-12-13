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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IManipulateService
    {
        //---Interface Untuk Tambah Data Pengurus
        [OperationContract]
        [WebInvoke(
           Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "adddata")]
        string AddData(pengurus p);
        //---Interface Untuk Ubah Data Pengurus
        [OperationContract]
        [WebInvoke(
          Method = "POST",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "updatedata")]
        string UpdateData(pengurus p);
        //---Interface Untuk Hapus Data Pengurus
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "deletedata")]
        string DeleteData(pengurus dp);
    }
}
