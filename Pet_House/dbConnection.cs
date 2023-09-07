using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pet_house
{
    class dbConnection
    {
        String con;
        public String connection()
        {
            //Work at Home
            con = @"Data Source=VISHAL\SQLHPSERVER;Initial Catalog=pet_house;Integrated Security=True";

            //Work at Collage
            //con = @"Data Source=L3-178;Initial Catalog=pet_house;Integrated Security=True";
            return con;
        }
    }
}
