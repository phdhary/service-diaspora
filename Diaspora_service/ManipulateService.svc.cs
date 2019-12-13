using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Diaspora_service.Models;


namespace Diaspora_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ManipulateService : IManipulateService
    {

        //---Koneksi ke database
        SqlConnection conn = new SqlConnection(
            "Data Source= DESKTOP-SN9NTRV;" +
            "Initial Catalog=diaspora;" +
            "User ID=sa;" +
            "password=123");
        //---Method untuk tambah data pengurus

        public string AddData(pengurus p)
        {
            string query = string.Format("insert into pengurus values('{0}','{1}','{2}','{3}','{4}','{5}',{6})", p.nama, p.kontak, p.asal, p.jabatan, p.angkatan, p.periode, p.id_organisasi);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Disimpan";
            }
            catch (Exception ex)
            {
                return "Data gagal disimpan : " + ex.ToString();
            }
        }

        //---Method untuk ubah data pengurus
        public string UpdateData(pengurus p)
        {
            string query = string.Format("Update pengurus set nama='{0}',kontak='{1}',asal='{2}',jabatan='{3}',angkatan='{4}',periode='{5}',id_organisasi={6} where no_anggota={7}", p.nama, p.kontak, p.asal, p.jabatan, p.angkatan, p.periode, p.id_organisasi, p.no_anggota);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data Berhasil Diupdate";
            }
            catch (Exception ex)
            {
                return "Data gagal Diupdate : " + ex.ToString();
            }
        }
        //---Method untuk hapus data pengurus
        public string DeleteData(pengurus dp)
        {
            string query = string.Format("delete from dbo.pengurus where no_anggota = {0}", dp.no_anggota);
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Data berhasil dihapus";
            }
            catch (Exception e)
            {
                return "Data gagal dihapus : " + e.Message;
            }
        }
    }
}
