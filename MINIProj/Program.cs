using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

public class DatabaseHandler
{


    public static SqlConnection GetConnection()
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-K6ENR28R;Initial Catalog=test11;" +
                "Integrated Security=true;");
        con.Open();
        return con;
    }
    public class EmployeeHandler
    {



        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }


        public static void InsertEmp(decimal EMPNO, string ENAME, string JOB, decimal SAL)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("InsertEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", JOB);
                cmd.Parameters.AddWithValue("@Salary", SAL);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEmp(decimal EMPNO, string ENAME, string JOB, decimal SAL)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("UpdateEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", JOB);
                cmd.Parameters.AddWithValue("@Salary", SAL);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEmp(decimal EMPNO)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("DeleteEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllEmp()
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("GetAllEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Insert new employee");
                Console.WriteLine("2. Update employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. View all employees");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter employee no: ");
                        decimal EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        string ENAME = Console.ReadLine();
                        Console.Write("Enter employee job: ");
                        string JOB = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        decimal SAL = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.InsertEmp(EMPNO, ENAME, JOB, SAL);
                        Console.WriteLine("Employee added successfully");
                        break;

                    case "2":
                        Console.Write("Enter employee no: ");
                        EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter employee name: ");
                        ENAME = Console.ReadLine();
                        Console.Write("Enter employee job: ");
                        JOB = Console.ReadLine();
                        Console.Write("Enter employee salary: ");
                        SAL = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.UpdateEmp(EMPNO, ENAME, JOB, SAL);
                        Console.WriteLine("Employee updated successfully");
                        break;

                    case "3":
                        Console.Write("Enter employee no: ");
                        EMPNO = int.Parse(Console.ReadLine());
                        EmployeeHandler.DeleteEmp(EMPNO);
                        Console.WriteLine("Employee deleted successfully");
                        break;

                    case "4":
                        DataTable employees = EmployeeHandler.GetAllEmp();
                        foreach (DataRow row in employees.Rows)
                        {
                            Console.WriteLine($"ID: {row["EMPNO"]}, Name: {row["ENAME"]}, Job: {row["JOB"]}, Salary: {row["SAL"]}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}