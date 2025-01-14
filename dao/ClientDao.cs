using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.models;

namespace UserManagement.dao
{
    internal class ClientDao
    {
        public MySqlConnection Connect()
        {
            string server = "localhost"; //ip si se despliega
            string user = "root";
            string password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
            string db = "user_management";

            string conectionString = "Database=" + db
                + "; Data Source=" + server
                + "; User Id=" + user
                + "; Password=" + password;

            MySqlConnection conectionDb = new MySqlConnection(conectionString);
            conectionDb.Open();

            return conectionDb;
        }


        public List<Customer> GetAllCustomers() {
            List<Customer> list = new List<Customer>();

            string request = "SELECT * FROM user_management.clients;";
            /*METODOS DE CONEXION A DB*/

            //separa la creación del MySqlCommand de la configuración de su conexión.
            /*
            MySqlCommand cmd = new MySqlCommand(request);
            cmd.Connection = conectionDb;
            */

            /*ALT 2 MUY DIFERENTE*/
            //            MySqlCommand cmd = conectionDb.CreateCommand(); //utiliza el método CreateCommand para asegurarse de que el comando esté asociado con la conexión, pero requiere que se establezca CommandText por separado

            /*ALT 3 MAS CORTA*/
            MySqlCommand cmd = new MySqlCommand(request, Connect());

            MySqlDataReader reader = cmd.ExecuteReader();

            string result = "";
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.Id = reader.GetInt32("id_clients").ToString();
                customer.Name = reader.GetString("name_clients");
                customer.LastName = reader.GetString("lastname_clients");
                customer.Celphone = reader.GetString("cel_clients");
                customer.CreditCard = reader.GetString("card_clients"); //tambien se puede con posicion de colum (numerico) ej: este seria 4

                list.Add(customer);
            }
            cmd.Connection.Close();

            return list;
        }

        public void Save(Customer customer)
        {
            if (customer.Id == null)
            {
                insert(customer);
            }
            else
            {
                update(customer);
            }
        }

        private void insert(Customer customer)
        {
            string request = "INSERT INTO clients(id_clients, name_clients, lastname_clients, cel_clients, card_clients) " +
                "VALUES(NULL, '" + customer.Name + "', " +
                "'" + customer.LastName + "', " +
                "'" + customer.Celphone + "', " +
                "'" + customer.CreditCard + "')";

            MySqlCommand cmd = new MySqlCommand(request, Connect());
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }


        private void update(Customer customer)
        {
            string request = "UPDATE clients SET " +
                "name_clients = '" + customer.Name + "', " +
                "lastname_clients = '" + customer.LastName + "', " +
                "cel_clients = '" + customer.Celphone + "', " +
                "card_clients = '" + customer.CreditCard + "' " +
                "WHERE id_clients = " + customer.Id;

            MySqlCommand cmd = new MySqlCommand(request, Connect());
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }


        public void Delete(Customer selectedCustomer)
        {
            string request = "DELETE FROM clientes where id_clients = " + selectedCustomer.Id + ";";
            MySqlCommand cmd = new MySqlCommand(request, Connect());
            cmd.ExecuteNonQuery();


            cmd.Connection.Close();
        }
    }
}
