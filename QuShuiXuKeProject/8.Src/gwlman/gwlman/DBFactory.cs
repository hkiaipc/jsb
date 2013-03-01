using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gwlDB;
namespace gwlman
{
    public class DBFactory
    {
        static public DB GetDB()
        {
            return new DB();
        }
    }
}
