using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Diaspora_service.Models;

namespace Diaspora_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RetrieveService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RetrieveService.svc or RetrieveService.svc.cs at the Solution Explorer and start debugging.
    public class RetrieveService : IRetrieveService
    {
        //---Koneksi ke database
        SqlConnection conn = new SqlConnection(
            "Data Source= DESKTOP-SN9NTRV;" +
            "Initial Catalog=diaspora;" +
            "User ID=sa;" +
            "password=123");
        //---Method untuk mengambil 1 data dari db lalu memasukkan ke dalam model
        public pengurus search(string nama)
        {
            pengurus p = new pengurus();
            SqlCommand cmd = new SqlCommand("select * from pengurus where nama like" + "'%" + nama + "%'", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                p.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                p.nama = reader["nama"].ToString();
                p.kontak = reader["kontak"].ToString();
                p.asal = reader["asal"].ToString();
                p.jabatan = reader["jabatan"].ToString();
                p.angkatan = reader["angkatan"].ToString();
                p.periode = reader["periode"].ToString();
                p.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
            }
            conn.Close();
            return p;
        }
        public pengurus GetDatabyID(string id)
        {
            pengurus p = new pengurus();
            SqlCommand cmd = new SqlCommand("select * from pengurus where no_anggota ="  + id , conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                p.no_anggota = Convert.ToInt32(reader["no_anggota"]);
                p.nama = reader["nama"].ToString();
                p.kontak = reader["kontak"].ToString();
                p.asal = reader["asal"].ToString();
                p.jabatan = reader["jabatan"].ToString();
                p.angkatan = reader["angkatan"].ToString();
                p.periode = reader["periode"].ToString();
                p.id_organisasi = Convert.ToInt32(reader["id_organisasi"]);
            }
            conn.Close();
            return p;
        }
        //get alldata pengurus
        //---Method untuk mengambil semua data pengurus dari db lalu memasukkan ke dalam model
        public List<pengurus> GetAllData()
        {
            List<pengurus> p = new List<pengurus>();
            SqlCommand cmd = new SqlCommand("select * from pengurus", conn);
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
        //get alldata admin
        //---Method untuk mengambil semua data admin dari db lalu memasukkan ke dalam model
        public List<admin> GetAllDataAdmin()
        {
            List<admin> p = new List<admin>();
            SqlCommand cmd = new SqlCommand("select * from admin", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin adm = new admin();
                adm.adminname = reader["adminname"].ToString();
                adm.password = reader["password"].ToString();

                p.Add(adm);
            }
            conn.Close();
            return p;
        }
        //---Method untuk mengambil semua data pengurus KMTI yg ikut IMM 
        //---dari db lalu memasukkan ke dalam model
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
        //---Method untuk mengambil semua data pengurus KMTI yg ikut BEM 
        //---dari db lalu memasukkan ke dalam model
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
        //---Method untuk mengambil semua data pengurus KMTI yg ikut DPM 
        //---dari db lalu memasukkan ke dalam model
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
    }
}
