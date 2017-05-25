using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EmployeeMan
{
    class EmployeeDAO
    {

        private String connectionString = "datasource=localhost;port=3306;username=root;password=";

        private MySqlConnection sqlConnection;

        private MySqlCommand sqlCommand;

        private MySqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public EmployeeDAO()
        {
            sqlConnection = new MySqlConnection(connectionString);
        }

        public DataSet getCustomers()
        {
            sqlConnection.Open();

            String query = "select * from employee.employee";

            sqlCommand = new MySqlCommand(query,sqlConnection);

            sqlAdapter = new MySqlDataAdapter();

            sqlAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;


        }

        public void createEmployee(EmployeeDTO employeeDto)
        {
            sqlConnection.Open();

            String query = "insert into employee.employee values('" + employeeDto.ID + "','"
                                                                    + employeeDto.NAME + "','"
                                                                    + employeeDto.AGE + "','" 
                                                                    + employeeDto.SALARY + "')";

            sqlCommand = new MySqlCommand(query, sqlConnection);

            

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void deleteEmployee(int id)
        {
            sqlConnection.Open();

            String query = "delete from employee.employee where id = '" + id+"'";

            sqlCommand = new MySqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void updateEmployee(int id,String name,int salary)
        {
            sqlConnection.Open();

            String query = "update employee.employee set name = '" + name + "' , age = '" + age + "' , salary = '" + salary + "'  where id = '" + id + "'";

            sqlCommand = new MySqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


    }
}
