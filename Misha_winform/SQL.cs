using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Misha_winform
{
    class SQL
    {
        public static string Conect()
        {
            string startupPath = Environment.CurrentDirectory;
            return @"Data Source=DESKTOP-IBAEO8B\SQLEXPRESS;Initial Catalog=Trade;Integrated Security=True";
        }

        public static string Query(string Query)
        {
            try
            {

                String query;
                SqlConnection con;
                SqlCommand cmd;
                SqlDataAdapter a;
                DataSet ds;
                query = Query;
                con = new SqlConnection(SQL.Conect());
                cmd = new SqlCommand(query, con);
                con.Open();
                a = new SqlDataAdapter(query, con);
                ds = new DataSet();
                a.Fill(ds);
                return "true";
            }
            catch (InvalidCastException e)
            {
                return "" + e;
            }
        }
  
        public static DataSet table(string Query)
        {


            String query;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter a;
            DataSet ds;
            query = Query;
            con = new SqlConnection(SQL.Conect());
            cmd = new SqlCommand(query, con);
            con.Open();
            a = new SqlDataAdapter(query, con);
            ds = new DataSet();
            a.Fill(ds);
            return ds;

        }


    }
}
