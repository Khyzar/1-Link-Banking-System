using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace WebServices.DAL
{
    public class myDAL
    {
        private static readonly string connString =
        System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        //public DataSet SelectItem() //to get the values of all the items from table Items and return the Dataset
        //{

        //    DataSet ds = new DataSet(); //declare and instantiate new dataset
        //    SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
        //    con.Open(); // open sql Connection
        //    SqlCommand cmd;
        //    try
        //    {
        //        cmd = new SqlCommand("Select * from Account", con);  //instantiate SQL command 
        //        cmd.CommandType = CommandType.Text; //set type of sqL Command
        //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //        {
        //            da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine("SQL Error" + ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    return ds; //return the dataset
        //}


        //public void User(int ID)
        //{
        //    SqlConnection con = new SqlConnection(connString);
        //    SqlCommand cmd = new SqlCommand("ViewUser", con); //name of your procedure
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ID", ID);

        //    try
        //    {
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (SqlException)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        //public DataSet ShowUser(int UserID)
        //{


        //    DataSet ds = new DataSet();
        //    SqlConnection con = new SqlConnection(connString);
        //    con.Open();
        //    SqlCommand cmd;
        //    try
        //    {
        //        cmd = new SqlCommand("ShowUser ", con); //name of your procedure
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add("@ID", SqlDbType.Int);

        //        // set parameter values
        //        cmd.Parameters["@ID"].Value = UserID;


        //        cmd.ExecuteNonQuery();

        //        // read output value 


        //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //        {
        //            da.Fill(ds);

        //        }





        //        con.Close();


        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine("SQL Error" + ex.Message.ToString());

        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //    return ds;

        //}

        public int BalanceCheack(int UserID)
        {

            int Balance = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("BalanceCheack", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@ID"].Value = UserID;


                cmd.Parameters.Add("@Balance", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Balance = Convert.ToInt32(cmd.Parameters["@Balance"].Value);
                // read output value 


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }





                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Balance;

        }

        public int LimitCheack(int UserID)
        {

            int Limit = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("LimitCheack", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@ID"].Value = UserID;


                cmd.Parameters.Add("@Limit", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Limit = Convert.ToInt32(cmd.Parameters["@Limit"].Value);
                // read output value 


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }





                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Limit;

        }

        public void SetBalance(int UserID, int Amount, int Limit)
        {

            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SetBalance", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = UserID;
                cmd.Parameters.Add("@Amount", SqlDbType.Int);
                cmd.Parameters["@Amount"].Value = Amount;
                cmd.Parameters.Add("@Limit", SqlDbType.Int);
                cmd.Parameters["@Limit"].Value = Limit;

                cmd.ExecuteNonQuery();
                // read output value 



                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }



        }
        public int signincheck2(int id, string Password_)
        {
            int found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signin2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@Password", Password_);
                cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@ID"].Value = id;
                //   cmd.Parameters["@Password"].Value = Password_;
                cmd.ExecuteNonQuery();
                found = Convert.ToInt32(cmd.Parameters["@Found"].Value);

                if (found > 0)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }

                }
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql error" + ex.Message.ToString());
            }
            finally
            {

                con.Close();
            }

            return found;
        }
        public int IDCheck(int id)
        {
            int found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("IDCheck", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@ID"].Value = id;
                cmd.ExecuteNonQuery();
                found = Convert.ToInt32(cmd.Parameters["@Found"].Value);

                if (found > 0)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }

                }
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql error" + ex.Message.ToString());
            }
            finally
            {

                con.Close();
            }

            return found;
        }
        public int GetBankBalance(int ID)
        {

            int Balance = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetBankBalance", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@ID"].Value = ID;


                cmd.Parameters.Add("@Balance", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Balance = Convert.ToInt32(cmd.Parameters["@Balance"].Value);
                // read output value 


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }





                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Balance;

        }
        public void SetBankBalance(int ID, Int64 Amount)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SetBankBalance", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters.Add("@Amount", SqlDbType.Int);
                cmd.Parameters["@Amount"].Value = Amount;

                cmd.ExecuteNonQuery();
                // read output value 



                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
        }
        public int GetGive(int ID)
        {

            int Balance = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetGive", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@ID"].Value = ID;


                cmd.Parameters.Add("@Give", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Balance = Convert.ToInt32(cmd.Parameters["@Give"].Value);
                // read output value 


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }





                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Balance;

        }
        public int GetTake(int ID)
        {

            int Balance = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("GetTake", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@ID"].Value = ID;


                cmd.Parameters.Add("@Take", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                Balance = Convert.ToInt32(cmd.Parameters["@Take"].Value);
                // read output value 


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);

                }

                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Balance;

        }
        public void SetGive(int ID, Int64 Amount)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SetGive", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters.Add("@Give", SqlDbType.Int);
                cmd.Parameters["@Give"].Value = Amount;

                cmd.ExecuteNonQuery();
                // read output value 



                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
        }
        public void SetTake(int ID, Int64 Amount)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("SetTake", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters.Add("@Take", SqlDbType.Int);
                cmd.Parameters["@Take"].Value = Amount;

                cmd.ExecuteNonQuery();
                // read output value 



                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }
        }
    }
}