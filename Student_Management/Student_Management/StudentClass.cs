using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.MobileControls;

namespace Student_Management
{
    class StudentClass
    {
        DBConnect connect = new DBConnect();

        public bool insertSTD(string Fname, String Lname, String MI, DateTime Bday, string sex, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`FirstName`, `LastName`, `MI`, `DOB`, `Sex`, `Address`, `Phone`, `Photo`) VALUES (@fn,@ln,@MIn,@BD,@S,@ADD,@PH,@img)", connect.getconnection);
            //@fn,@ln,@MIn,@BD,@S,@ADD,@PH,@img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = Fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname;
            command.Parameters.Add("@MIn", MySqlDbType.VarChar).Value = MI;
            command.Parameters.Add("@BD", MySqlDbType.Date).Value = Bday;
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("ADD", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@PH", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        public DataTable Names(MySqlCommand com, int id)
        {
            com.Parameters.AddWithValue("@id", id); // Set the value of the parameter
            com.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getstudentlist()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `student`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        //To get the Counts
        public string execount(string Query)
        {
            MySqlCommand command = new MySqlCommand(Query, connect.getconnection);
            connect.openconnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeconnect();
            return count;
        }

        //To get the Total
        public string TotalStudent()
        {
            return execount("SELECT COUNT(*) FROM `student`");
        }

        //To get the Male
        public string MaleStd()
        {
            return execount("SELECT COUNT(*) FROM `student` WHERE Sex = 'male'");
        }

        //To get the Female
        public string FemaleStd()
        {
            return execount("SELECT COUNT(*) FROM `student` WHERE Sex = 'female'");
        }

        public DataTable SearchStudent(String searchdata)
        { 
            MySqlCommand com = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`FirstName`,`LastName`,`MI`,`Address`) LIKE '%"+ searchdata + "%' ", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //For Editing
        public bool updateSTD(int id,string Fname, String Lname, String MI, DateTime Bday, string sex, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `FirstName`= @fn, `LastName`= @ln, `MI`= @MIn, `DOB`= @BD, `Sex`= @S, `Phone`= @PH, `Address`= @ADD, `Photo`= @img WHERE `StudentID`= @id", connect.getconnection);
            //@fn,@ln,@MIn,@BD,@S,@ADD,@PH,@img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = Fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname;
            command.Parameters.Add("@MIn", MySqlDbType.VarChar).Value = MI;
            command.Parameters.Add("@BD", MySqlDbType.Date).Value = Bday;
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = sex;
            command.Parameters.Add("ADD", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@PH", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        public DataTable Getlist(MySqlCommand com)
        {
            com.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            return table;
        }
    
    }
}
