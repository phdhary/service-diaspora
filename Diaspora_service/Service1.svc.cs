using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Diaspora_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection conn = new SqlConnection(
            "Data Source= DESKTOP-SN9NTRV;" +
            "Initial Catalog=diaspora;" +
            "User ID=sa;" +
            "password=123");

        public pengurus GetData(string id)
        {
            pengurus p = new pengurus();
            SqlCommand cmd = new SqlCommand("select from pengurus where no_anggota=" + id, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pengurus pengurus = new pengurus();
                pengurus.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                pengurus.nama = reader["nama"].ToString();
                pengurus.kontak = reader["kontak"].ToString();
                pengurus.asal = reader["asal"].ToString();
                pengurus.jabatan = reader["jabatan"].ToString();
                pengurus.angkatan = reader["angkatan"].ToString();
                pengurus.periode = reader["periode"].ToString();
                pengurus.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
            }
            conn.Close();
            return p;
        }


        public List<pengurus> GetAllData()
        {
            List<pengurus> p = new List<pengurus>();
            SqlCommand cmd = new SqlCommand ("select * from pengurus", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                pengurus pengurus = new pengurus();
                pengurus.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                pengurus.nama = reader["nama"].ToString();
                pengurus.kontak = reader["kontak"].ToString();
                pengurus.asal = reader["asal"].ToString();
                pengurus.jabatan = reader["jabatan"].ToString();
                pengurus.angkatan = reader["angkatan"].ToString();
                pengurus.periode = reader["periode"].ToString();
                pengurus.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
                p.Add(pengurus);
            }
            conn.Close();
            return p;
        }
        public string AddData(pengurus p)
        {
            string query = string.Format("insert into pengurus value('{0}','{1}','{2}','{3}','{4}','{5}',{6})", p.nama, p.kontak, p.asal, p.jabatan, p.angkatan, p.periode, p.id_organisasi);
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
        public string UpdateData(pengurus p)
        {
            string query = string.Format("insert into pengurus value('{0}','{1}','{2}','{3}','{4}','{5}',{6})", p.nama, p.kontak, p.asal, p.jabatan, p.angkatan, p.periode, p.id_organisasi);
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
        public List<pengurus> GetAllDataIMM()
        {
            List<pengurus> p = new List<pengurus>();
            SqlCommand cmd = new SqlCommand("select * from pengurus where id_organisasi = 1", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pengurus pengurus = new pengurus();
                pengurus.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                pengurus.nama = reader["nama"].ToString();
                pengurus.kontak = reader["kontak"].ToString();
                pengurus.asal = reader["asal"].ToString();
                pengurus.jabatan = reader["jabatan"].ToString();
                pengurus.angkatan = reader["angkatan"].ToString();
                pengurus.periode = reader["periode"].ToString();
                pengurus.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
                p.Add(pengurus);
            }
            conn.Close();
            return p;
        }
        public List<pengurus> GetAllDataBEM()
        {
            List<pengurus> p = new List<pengurus>();
            SqlCommand cmd = new SqlCommand("select * from pengurus where id_organisasi = 2", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pengurus pengurus = new pengurus();
                pengurus.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                pengurus.nama = reader["nama"].ToString();
                pengurus.kontak = reader["kontak"].ToString();
                pengurus.asal = reader["asal"].ToString();
                pengurus.jabatan = reader["jabatan"].ToString();
                pengurus.angkatan = reader["angkatan"].ToString();
                pengurus.periode = reader["periode"].ToString();
                pengurus.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
                p.Add(pengurus);
            }
            conn.Close();
            return p;
        }
        public List<pengurus> GetAllDataDPM()
        {
            List<pengurus> p = new List<pengurus>();
            SqlCommand cmd = new SqlCommand("select * from pengurus where id_organisasi = 3", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pengurus pengurus = new pengurus();
                pengurus.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                pengurus.nama = reader["nama"].ToString();
                pengurus.kontak = reader["kontak"].ToString();
                pengurus.asal = reader["asal"].ToString();
                pengurus.jabatan = reader["jabatan"].ToString();
                pengurus.angkatan = reader["angkatan"].ToString();
                pengurus.periode = reader["periode"].ToString();
                pengurus.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
                p.Add(pengurus);
            }
            conn.Close();
            return p;
        }
        public string DeleteData(pengurus dp)
        {
            string query = string.Format("delete from dbo.pengurus where id = {0}", dp.no_anggota);
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
    public class pengurus
    {
        public int no_anggota { get; set; }
        public string nama { get; set; }
        public string kontak { get; set; }
        public string asal { get; set; }
        public string jabatan { get; set; }
        public string angkatan { get; set; }
        public string periode { get; set; }
        public int id_organisasi { get; set; }
    }

}
