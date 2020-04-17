using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.ENTITY; // Entity Access
using System.Data.SqlClient; // DB Access

namespace ABC.Data
{
    public class ABCDateAccess
    {
        string datasource = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
        
        // method-insert Client into DB
        public void InsertClient(Clients clients)
        {
            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Clients_InsertClient", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", clients.ClientID));
            cmd.Parameters.Add(new SqlParameter("@Name", clients.ClientName));
            cmd.Parameters.Add(new SqlParameter("@Phone", clients.ClientPhone));

            // execute the command
            cmd.ExecuteNonQuery();
            // close DB connection
            conn.Close();
        }



        public void UpdateClient(Clients clients)
        {
            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Clients_UdateClientById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", clients.ClientID));
            cmd.Parameters.Add(new SqlParameter("@Name", clients.ClientName));
            cmd.Parameters.Add(new SqlParameter("@Phone", clients.ClientPhone));

            // execute the command
            cmd.ExecuteNonQuery();
            // close DB connection
            conn.Close();
        }

        public void RemoveClient(Clients clients)
        {
           
            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Clients_DeleteById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", clients.ClientID));
                                             
            // execute the command
            cmd.ExecuteNonQuery();
            //SqlDataReader reader = cmd.ExecuteReader();

            // handle the result

            
            // close DB connection
            conn.Close();
        }

        public List<Clients> SelectAllClients()
        {
            List<Clients> clients = new List<Clients>();

            // create setup and open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = datasource;
            conn.Open();

            // create command type
            SqlCommand cmd = new SqlCommand("sp_Clients_DisplayAll", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            // handle the result
            while (reader.Read()) // until true keep returning the record
            {
                Clients clients1 = new Clients();
                clients1.ClientID = Convert.ToInt32(reader["ClientID"]);
                clients1.ClientName = Convert.ToString(reader["ClientName"]);
                clients1.ClientPhone = Convert.ToString(reader["ClientPhone"]);
                
                clients.Add(clients1);

            }
            //close the connection 
            conn.Close();
            return clients;

        }

        public Clients FindClientByID(int id)
        {
            Clients clients = null;
            // create connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = datasource;
            connection.Open();

            // Create a command Object
            SqlCommand command = new SqlCommand("sp_Clients_SearchById", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ID", id));

            //Execute the command
            SqlDataReader reader = command.ExecuteReader();

            // Handle the result
            while (reader.Read())
            {
                clients = new Clients();
                clients.ClientID = Convert.ToInt32(reader["ClientID"]);
                clients.ClientName = Convert.ToString(reader["ClientName"]);
                clients.ClientPhone = Convert.ToString(reader["ClientPhone"]);
            }
            // Close the Connection
            connection.Close();
            // return the clients List
            return clients;
        }


        public List<Brands> FindBrandByClientID(int bid)
        {
            
            List<Brands> brands = new List<Brands>();
            // create connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = datasource;
            connection.Open();

            // Create a command Object
            SqlCommand command = new SqlCommand("sp_Brands_SearchBrandByClientID", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@Id", bid));

            //Execute the command
            SqlDataReader reader = command.ExecuteReader();

            // Handle the result
            while (reader.Read())
            {
                Brands brands1 = new Brands();
                 
                brands1.BrandID = Convert.ToInt32(reader["BrandID"]);
                brands1.BrandName = Convert.ToString(reader["BrandName"]);
                brands1.ClientID = Convert.ToInt32(reader["ClientID"]);
                brands1.ManagerID = Convert.ToInt32(reader["ManagerID"]);
                brands.Add(brands1);
            }
            // Close the Connection
            connection.Close();
            // return the clients List
            return brands;
        }


        //      -------------------------BRANDS------------------------------------


        public void InsertBrand(Brands brands)
        {
            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Brands_InsertBrand", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@iD", brands.BrandID));
            cmd.Parameters.Add(new SqlParameter("@bName", brands.BrandName));
            cmd.Parameters.Add(new SqlParameter("@clientId", brands.ClientID));
            cmd.Parameters.Add(new SqlParameter("@mId", brands.ManagerID));

            // execute the command
            cmd.ExecuteNonQuery();
            // close DB connection
            conn.Close();
        }

        public List<Brands> SelectAllBrands()
        {
            List<Brands> brands = new List<Brands>();

            // create setup and open connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = datasource;
            conn.Open();

            // create command type
            SqlCommand cmd = new SqlCommand("sp_Brands_SelectAll", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // execute the command
            SqlDataReader reader = cmd.ExecuteReader();

            // handle the result
            while (reader.Read()) // until true keep returning the record
            {
                Brands brands1 = new Brands();
                brands1.BrandID = Convert.ToInt32(reader["BrandID"]);
                brands1.BrandName = Convert.ToString(reader["BrandName"]);
                brands1.ClientID = Convert.ToInt32(reader["ClientID"]);
                brands1.ManagerID = Convert.ToInt32(reader["ManagerID"]);

                brands.Add(brands1);

            }
            //close the connection 
            conn.Close();
            return brands;

        }

        public Brands FindBrandByID(int id)
        {
            Brands brands = null;
            // create connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = datasource;
            connection.Open();

            // Create a command Object
            SqlCommand command = new SqlCommand("sp_Brands_SearchByID", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ID", id));

            //Execute the command
            SqlDataReader reader = command.ExecuteReader();

            // Handle the result
            while (reader.Read())
            {
                brands = new Brands();
                brands.BrandID = Convert.ToInt32(reader["BrandID"]);
                brands.BrandName = Convert.ToString(reader["BrandName"]);
                brands.ClientID = Convert.ToInt32(reader["ClientID"]);
                brands.ManagerID = Convert.ToInt32(reader["ManagerID"]);
            }
            // Close the Connection
            connection.Close();
            // return the clients List
            return brands;
        }

        public void UpdateBrand(Brands brands)
        {
            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Brands_UpdateById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", brands.BrandID));
            cmd.Parameters.Add(new SqlParameter("@Name", brands.BrandName));
            cmd.Parameters.Add(new SqlParameter("@CID", brands.ClientID));
            cmd.Parameters.Add(new SqlParameter("@MID", brands.ManagerID));

            // execute the command
            cmd.ExecuteNonQuery();
            // close DB connection
            conn.Close();
        }

        public void RemoveBrand(Brands brands)
        {

            // set up and open connection with DB
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QV2D04T\SQLEXPRESS;Initial Catalog=ABCDatabase;Integrated Security=True";
            conn.Open();
            // create command objects and read SP
            SqlCommand cmd = new SqlCommand("sp_Brand_DeleteById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", brands.BrandID));

            // execute the command
            cmd.ExecuteNonQuery();
            

            // handle the result


            // close DB connection
            conn.Close();
        }

        public List<Adverts> FinAdvertByBrandID(int aid)
        {

            List<Adverts> adverts = new List<Adverts>();
            // create connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = datasource;
            connection.Open();

            // Create a command Object
            SqlCommand command = new SqlCommand("sp_Advert_FindAdvByBrandID", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@id", aid));

            //Execute the command
            SqlDataReader reader = command.ExecuteReader();

            // Handle the result
            while (reader.Read())
            {
                Adverts adverts1 = new Adverts();

                adverts1.AdID = Convert.ToInt32(reader["AdID"]);
                adverts1.AdTitle = Convert.ToString(reader["AdTitle"]);
                adverts1.AdCost = Convert.ToInt32(reader["AdCost"]);
                adverts1.StartDate = Convert.ToDateTime(reader["Ad_Start_Date"]);
                adverts1.EndDate = Convert.ToDateTime(reader["Ad_End_Date"]);
                adverts1.Frequency = Convert.ToInt32(reader["Ad_Frequency"]);
                adverts1.BrandID = Convert.ToInt32(reader["BrandID"]);
                adverts.Add(adverts1);
            }
            // Close the Connection
            connection.Close();
            // return the clients List
            return adverts;
        }

        //--------------------------Adverts-----------------------------------

    }
}
