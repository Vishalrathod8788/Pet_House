﻿using System;
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
        String Conn;

        public String connection()
        {
            Conn = @"Data Source=VISHAL\SQLHPSERVER;Initial Catalog=pet_house;Integrated Security=True";
            return Conn;

        }
    }
}
