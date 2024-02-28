﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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

        public DataTable getstudentlist()
        {
            MySqlCommand com = new MySqlCommand("SELECT * FROM `student`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }





    }
}
