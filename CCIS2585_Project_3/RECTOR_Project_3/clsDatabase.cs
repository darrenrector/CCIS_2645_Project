using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;

namespace Project3_CS
{
    class clsDatabase
    {
        public static SqlConnection AcquireConnection()
        {
            SqlConnection cnSQL = null;

            if (ConfigurationManager.ConnectionStrings["Payroll"] != null)
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings["Payroll"].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    cnSQL.Dispose();
                    cnSQL = null;
                }
            }

            return cnSQL;
        }

        public static DataSet GetPayrollListingByEmployee(Int32 intEmpID)
        {
            DataSet dsSQL = null;
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayrollByEmployee";

                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsSQL.Dispose();
                    dsSQL = null;
                }
            }
            return dsSQL;
        }
        public static DataSet GetPayrollByEmployee(Int32 EmployeeID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayrollByEmployee";
                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = EmployeeID;

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsSQL.Dispose();
                    dsSQL = null;
                }
            }
            return dsSQL;
        }

        public static DataSet GetAllEmployees()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsData = null;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetAllEmployees";

                dsData = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsData);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsData.Dispose();
                    dsData = null;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }
            return dsData;
        }

        public static DataSet GetTotalPayrollByWeek()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetTotalPayrollByWeek";

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsSQL.Dispose();
                    dsSQL = null;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }
            return dsSQL;
        }

       public static DataSet GetEmployeeNames()
        {
            DataSet dsSQL = null;
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetEmployeeNames";

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsSQL.Dispose();
                    dsSQL = null;
                }
            }
            return dsSQL;
        }

       public static Int32 insertPayroll(Int32 intEmpID, String strWeekEnd, Decimal decHrs)
       {
           SqlConnection cnSQL;
           SqlCommand cmdSQL;

           cnSQL = AcquireConnection();
           if (cnSQL != null)
           {
               cmdSQL = new SqlCommand();
               cmdSQL.Connection = cnSQL;
               cmdSQL.CommandType = CommandType.StoredProcedure;
               cmdSQL.CommandText = "InsertPayroll";


               cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
               cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
               cmdSQL.Parameters["@EmpID"].Value = intEmpID;

               cmdSQL.Parameters.Add(new SqlParameter("@WeekEnding", SqlDbType.NChar, 8));
               cmdSQL.Parameters["@WeekEnding"].Direction = ParameterDirection.Input;
               cmdSQL.Parameters["@WeekEnding"].Value = strWeekEnd;

               cmdSQL.Parameters.Add(new SqlParameter("@HoursWorked", SqlDbType.Decimal));
               cmdSQL.Parameters["@HoursWorked"].Direction = ParameterDirection.Input;
               cmdSQL.Parameters["@HoursWorked"].Value = decHrs;

               //dsSQL = new DataSet();
               try
               {
                   cmdSQL.ExecuteNonQuery();
               }
               catch
               {

               }
           }
           return 0;
       }



        public static Decimal GetPayrateByEmployeeID(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Decimal decPay = -1;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetPayrateByID";



                cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                cmdSQL.Parameters.Add(new SqlParameter("@PayRate", SqlDbType.Money));
                cmdSQL.Parameters["@PayRate"].Direction = ParameterDirection.Output;

                try
                {
                    cmdSQL.ExecuteNonQuery();
                    decPay = Convert.ToDecimal(cmdSQL.Parameters["@PayRate"].Value);
                }
                catch (Exception ex)
                {
                    decPay = -1;
                }
            }
            return decPay;
        }
    }
}
    



