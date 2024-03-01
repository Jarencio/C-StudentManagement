using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{

    class GradeClass
    {
        DBConnect connect = new DBConnect();

        public bool insertC(int StudID, string FN, string LN, string course, float G, int SC, int Y, int S, string Sec)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `grades`(`Student_ID`, `FirstName`, `LastName`, `Course`, `GWA`, `SubjCount`, `Year`, `Sem`, `Section`) VALUES (@SI,@FN,@LN,@C,@G,@SC,@Y,@S,@SEC)", connect.getconnection);
            //@GI,@SI,@FN,@LN,@C,@G,@SC,@Y,@S,@SEC
            command.Parameters.Add("@SI", MySqlDbType.Int32).Value = StudID;
            command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = FN;
            command.Parameters.Add("@LN", MySqlDbType.VarChar).Value = LN;
            command.Parameters.Add("@C", MySqlDbType.VarChar).Value = course;
            command.Parameters.Add("@G", MySqlDbType.Float).Value = G;
            command.Parameters.Add("@SC", MySqlDbType.Int32).Value = SC;
            command.Parameters.Add("@Y", MySqlDbType.Int32).Value = Y;
            command.Parameters.Add("@S", MySqlDbType.Int32).Value = S;
            command.Parameters.Add("@SEC", MySqlDbType.VarChar).Value = Sec;

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
