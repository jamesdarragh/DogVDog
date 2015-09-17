using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Configuration;
using DogVDog.Web.Models.RequestModels;
using DogVDog.Web.Domains;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using DogVDog.Web.Services.Interfaces;

namespace DogVDog.Web.Services
{
    public class BreedService : IBreedService
    {
        public void InsertBreed(BreedRequestModel model)
        {
            Configuration rootConfig = WebConfigurationManager.OpenWebConfiguration("/DogVDog");
            ConnectionStringSettings connString = rootConfig.ConnectionStrings.ConnectionStrings["DefaultConnection"];

            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Breeds_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Breed", model.Breed);
            if(model.Region != null)            
                cmd.Parameters.AddWithValue("@Region", model.Region);           
            else
                cmd.Parameters.AddWithValue("@Region", DBNull.Value);
            cmd.Parameters.AddWithValue("@IsCute", model.IsCute);
            cmd.Parameters.AddWithValue("@MedicalIssues", model.MedicalIssues);

            cmd.ExecuteNonQuery();

            conn.Close();
            
        }

        public List<Dog> GetAll()
        {
            Configuration rootConfig = WebConfigurationManager.OpenWebConfiguration("/DogVDog");
            ConnectionStringSettings connString = rootConfig.ConnectionStrings.ConnectionStrings["DefaultConnection"];

            SqlConnection conn = new SqlConnection(connString.ConnectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Breeds_SelectAll";
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Dog> breedList = new List<Dog>();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    int startingIndex = 0;

                    Dog item = new Dog();
                    if (reader[startingIndex] != null && reader[startingIndex] != DBNull.Value)
                        item.Breed = reader.GetString(startingIndex++);
                    else
                    {
                        item.Breed = null;
                        startingIndex++;
                    }

                    if (reader[startingIndex] != null && reader[startingIndex] != DBNull.Value)
                        item.Region = reader.GetString(startingIndex++);
                    else
                    {
                        item.Region = null;
                        startingIndex++;
                    }

                    if (reader[startingIndex] != null && reader[startingIndex] != DBNull.Value)
                        item.IsCute = reader.GetBoolean(startingIndex++);
                    else
                    {
                        item.IsCute = false;
                        startingIndex++;
                    }

                    if (reader[startingIndex] != null && reader[startingIndex] != DBNull.Value)
                        item.MedicalIssues = reader.GetString(startingIndex++);
                    else
                    {
                        item.MedicalIssues = null;
                        startingIndex++;
                    }

                    breedList.Add(item);
                }
            }

            reader.Close();
            return breedList;
        }
    }
}