using MySql.Data.MySqlClient;
using ShoeStoreApp.Data.DataAccess.Exceptions;
using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public class MySqlEmployee : IEmployee
    {
        private static readonly string SELECT = "SELECT * FROM `Employee` ORDER BY name";
        private static readonly string SELECT_ID = "SELECT * FROM `Employee` WHERE id=@id";
        private static readonly string UPDATE_ACTIVE = "UPDATE `Employee` SET active=@a WHERE id=@idEmployee";
        private static readonly string INSERT = "INSERT INTO `Employee`(name, lastname, username, password, email, phoneNumber, role, active, language, theme) VALUES (@name, @lastname, @username, @password, @email, @phoneNumber, @role, @active, 1, 1)";
        private static readonly string UPDATE = "UPDATE `Employee` SET name=@name, lastname=@lname, username=@username, password=@newPassword, email=@email, phoneNumber=@phone, language=@l, theme=@t WHERE id=@idEmployee";

        public bool addEmployee(Employee employee)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@lastname", employee.lastname);
                cmd.Parameters.AddWithValue("@username", employee.username);
                cmd.Parameters.AddWithValue("@password", employee.password);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@phoneNumber", employee.phoneNumber);
                cmd.Parameters.AddWithValue("@role", employee.role);
                cmd.Parameters.AddWithValue("@active", employee.active);
                res = cmd.ExecuteNonQuery() == 1;
                employee.id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public bool deActivateEmployee(int employeeId, int active)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_ACTIVE;
                cmd.Parameters.AddWithValue("@idEmployee", employeeId);
                cmd.Parameters.AddWithValue("@a", active);
                res = cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public Employee getById(int id)
        {
            Employee employee = null;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    employee = new Employee()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        lastname = reader.GetString(2),
                        username = reader.GetString(3),
                        password = reader.GetString(4),
                        email = reader.GetString(5),
                        phoneNumber = reader.GetString(6),
                        role = reader.GetString(7),
                        active = reader.GetBoolean(8),
                        language = reader.GetInt32(9),
                        theme = reader.GetInt32(10)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        lastname = reader.GetString(2),
                        username = reader.GetString(3),
                        password = reader.GetString(4),
                        email = reader.GetString(5),
                        phoneNumber = reader.GetString(6),
                        role = reader.GetString(7),
                        active = reader.GetBoolean(8),
                        language = reader.GetInt32(9),
                        theme = reader.GetInt32(10)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return employees;
        }

        public bool updateEmployee(Employee employee)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@idEmployee", employee.id);
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@lname", employee.lastname);
                cmd.Parameters.AddWithValue("@username", employee.username);
                cmd.Parameters.AddWithValue("@newPassword", employee.password);
                cmd.Parameters.AddWithValue("@email", employee.email);
                cmd.Parameters.AddWithValue("@phone", employee.phoneNumber);
                cmd.Parameters.AddWithValue("@l", employee.language);
                cmd.Parameters.AddWithValue("@t", employee.theme);
                res = cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlEmployee", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }
    }
}
