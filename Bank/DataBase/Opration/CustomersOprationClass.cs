using DataBase.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Opration
{
    public class CustomersOprationClass
    {
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-A2SMR1S;Initial Catalog=BankSystemDataBase;Integrated Security=True");

        public Object SearchForFirstname(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE First_Name = '" + ce.Username +"'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForLastname(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Last_Name = '" + ce.Username + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForEmailaddress(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Email_address = '" + ce.Username + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForGender(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Gender = '" + ce.Gender + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForOccupation(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Occupation = '" + ce.Occupation + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForStatus(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Status = '" + ce.Username + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForAccountType(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Account_Type = '" + ce.Username + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object SearchForNationality(CustomersEntityClass ce)
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal WHERE Country = '" + ce.Nationality + "'", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
        public Object Search()
        {
            Connection.Open();
            Object search;
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Parsonal", Connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            search = data;
            Connection.Close();

            return search;
        }
    }
}
