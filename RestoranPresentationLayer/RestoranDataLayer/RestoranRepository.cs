using RestoranDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranDataLayer
{
    public class RestoranRepository
    {
        public List<Restoran> GetAllRestorans()
        {
            List<Restoran> restorans = new List<Restoran>();
            using(SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Restorani";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    Restoran r = new Restoran();
                    r.Id = sqlDataReader.GetInt32(0);
                    r.Naziv = sqlDataReader.GetString(1);
                    r.Opis = sqlDataReader.GetString(2);
                    r.Cena = sqlDataReader.GetDecimal(3);
                    restorans.Add(r);
                }
            }
            return restorans;
        }

        public int InsertRestoran(Restoran r)
        {
            List<Restoran> restorans = new List<Restoran>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;
                
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Restorani VALUES ('{0}','{1}',{2})",
                    r.Naziv, r.Opis, r.Cena
                    );

                return sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }

