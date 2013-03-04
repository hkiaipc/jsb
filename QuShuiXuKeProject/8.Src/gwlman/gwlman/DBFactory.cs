using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gwlDB;
namespace gwlman
{
    public class DBFactory
    {
        private DBFactory()
        {
        }

        static public DB GetDB()
        {
            if (_db == null)
            {
                _db = new DB();
            }
            return _db;
        } static private DB _db = null;
    }
}
