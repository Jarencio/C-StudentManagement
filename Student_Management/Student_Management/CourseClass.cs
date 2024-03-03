using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.MobileControls;
using System.Threading.Tasks;

namespace Student_Management
{
    class CourseClass
    {
        DBConnect connect = new DBConnect();

        public bool insertC(string course,string code,int years)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`Course`, `Code`, `Years`) VALUES (@C,@CD,@Y)", connect.getconnection);
            //@fn,@ln,@MIn,@BD,@S,@ADD,@PH,@img
            command.Parameters.Add("@C", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@CD", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@Y", MySqlDbType.Int32).Value = years;
            
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

        public DataTable getcourselist()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `course`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool updateC(int ID,string course, string code, int years)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `Course`=@C,`Code`=@CD,`Years`=@Y WHERE `Course_ID`= @ID", connect.getconnection);
            //@ID,@C,@CD,@Y
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("@C", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@CD", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@Y", MySqlDbType.Int32).Value = years;

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

        public DataTable SearchCourse(String searchdata)
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`Course`,`Code`) LIKE '%" + searchdata + "%' ", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
           DataTable table = new DataTable();
           adapter.Fill(table);
            return table;
        }

        public bool deltcourse(int ID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `Course_ID` = @ID", connect.getconnection);
            //,@SI,@FN,@LN,@C,@G,@SC,@Y,@S,@SEC
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;

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



    }
}
