using System;
using System.Data;
using System.Data.SqlClient;

namespace YearSummary
{

    /// <summary>
    /// 
    /// </summary>
    internal class DayWaterRecord
    {
        public string Name;
        public int AllAmount;
        public DateTime DT;

        public DayWaterRecord(string name, DateTime dt, int allAmount)
        {
            this.Name = name;
            this.AllAmount = allAmount;
            this.DT = dt;
        }
    }

    internal class WaterUseInfo
    {
        public DateTime Begin;
        public DateTime End;
        public string Name;
        public int UsedAmount;
        public WaterUseInfo(string name, DateTime begin, DateTime end, int usedAmount)
        {
            this.Name = name;
            this.Begin = begin;
            this.End = end;
            this.UsedAmount = usedAmount;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    internal class SaleRecord
    {
        public string Name;
        public int AllSaleAmount;
        public int AllSaleMoney;
        public float Price;
        public DateTime DT;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dt"></param>
        /// <param name="price"></param>
        /// <param name="allSaleMoney"></param>
        /// <param name="allSaleAmount"></param>
        public SaleRecord(string name, DateTime dt, float price, int allSaleMoney, int allSaleAmount)
        {
            this.Name = name;
            this.DT = dt;
            this.Price = price;
            this.AllSaleMoney = allSaleMoney;
            this.AllSaleAmount = allSaleAmount;
        }
    }

    internal class SaleInfo
    {
        public string Name;
        public DateTime Begin;
        public DateTime End;
//        public float Price;
        public int AllSaleMoney;
        public int AllSaleAmount;

        public SaleInfo(string name, DateTime begin, DateTime end, 
//            float price, 
            int allSaleMoney, int allSaleAmount)
        {
            this.Name = name;
            this.Begin = begin;
            this.End = end;
//            this.Price = price;
            this.AllSaleAmount = allSaleAmount;
            this.AllSaleMoney = allSaleMoney;
        }
    }

    /// <summary>
    /// SqlQuery 的摘要说明。
    /// </summary>
    public class SqlQuery
    {
        private DBcon con;

        //private DataTable dt;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public SqlQuery()
        {
            con = new DBcon();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public string GetWellNo(string Name)
        {
            string sql = string.Format("select wellNo from tbwell where wellName='{0}' ", Name);
            SqlCommand  cmd = new SqlCommand(sql, con.GetConnection());
            object obj = cmd.ExecuteScalar();
            if (obj != null)
                return obj.ToString();
            else
                return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wellName"></param>
        /// <returns></returns>
        public float  GetPrice(string wellName)
        {
            string wellNO = GetWellNo(wellName);
            return GetPriceByWellNO(wellNO);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public float GetPriceByWellNO(string wellNO)
        {
            float price = 0;
            string sql = string.Format("select price1 from tbwell where wellNo='{0}' ", wellNO);
            cmd = new SqlCommand(sql, con.GetConnection());
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                price = Convert.ToSingle(dr.GetValue(0));
            }
            dr.Close();
            cmd.Dispose();
            return price;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public DataTable GetSaleDatas(string wellName, DateTime begin, DateTime end)
        {
            string wellNO = GetWellNo ( wellName );

            string sql = string.Format(
                "select * from tbSal where wellNo='{0}' and time between '{1}' and '{2}' order by time desc",
                wellNO, begin, end);

            SqlDataAdapter  da = new SqlDataAdapter(sql, con.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            DataTable dt = ds.Tables[0];
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        public DataTable GetUseWaterDatas(string wellName, DateTime begin, DateTime end)
        {
            string sql = string.Format(
                "select * from waterDatasDay where Name='{0}' and time between '{1}' and '{2}' order by time desc", 
                wellName, begin, end);
            SqlDataAdapter da = new SqlDataAdapter(sql, con.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Dispose();
            DataTable dt = ds.Tables[0];
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        //public WatAllDatas GetAllDatas(string Name, string Year)
        public WatAllDatas GetAllDatas(string wellName, DateTime begin, DateTime end)
        {
            float price = this.GetPrice ( wellName );

            WaterUseInfo waterUseInfo = GetWatDatas(wellName, begin, end);
            
            SaleInfo saleInfo = GetSalDatas(wellName, begin, end);

            if (waterUseInfo == null || saleInfo == null)
            {
                return null;
            }

            WatAllDatas _watdatas = new WatAllDatas();

            
            _watdatas.wellID = 0;
            _watdatas.Name = wellName;
            int usedMoney = (int)(waterUseInfo.UsedAmount * price);

            _watdatas.RemainMoney = saleInfo.AllSaleMoney - usedMoney;


            _watdatas.RemainAmount = saleInfo.AllSaleAmount - waterUseInfo.UsedAmount;
            _watdatas.AllSaleMoney = saleInfo.AllSaleMoney;
            _watdatas.AllSaleAmount = saleInfo.AllSaleAmount;
            _watdatas.UsedMoney = usedMoney;
            _watdatas.UsedAmount = waterUseInfo.UsedAmount;
            _watdatas.BeginDT  = waterUseInfo.Begin;
            _watdatas.EndDT = waterUseInfo.End;
            _watdatas.Remark = "";

            return _watdatas;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private DayWaterRecord GetFirstDayWater(string name, DateTime begin, DateTime end)
        {
            string sql = string.Format(
                "select top 1 * from waterDatasDay where Name='{0}' and time between '{1}' and '{2}' order by time", 
                name, begin, end);
            return GetDayWaterRecord(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private DayWaterRecord GetLastDayWater(string name, DateTime begin, DateTime end)
        {
            string sql = string.Format(
                "select top 1 * from waterDatasDay where Name='{0}' and time between '{1}' and '{2}' order by time desc",
                name, begin, end);
            return GetDayWaterRecord(sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DayWaterRecord GetDayWaterRecord(string sql)
        {
            DayWaterRecord record = null;
            SqlCommand cmd = new SqlCommand(sql, this.con.GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string name = dr["name"].ToString();
                DateTime dt = Convert.ToDateTime(dr["time"]);
                int allAmount = Convert.ToInt32(dr["AllAmount"]);
                record = new DayWaterRecord(name, dt, allAmount);
            }
            dr.Close();

            return record;
        }


        /// <summary>
        /// 计算阶段用水量
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        private WaterUseInfo GetWatDatas(string wellName, DateTime begin, DateTime end)
        {

            DayWaterRecord first = this.GetFirstDayWater(wellName, begin, end);
            DayWaterRecord last = this.GetLastDayWater(wellName, begin, end);

            if (first == null || last == null)
            {
                return null;
            }
            else
            {
                WaterUseInfo info = new WaterUseInfo(wellName, first.DT, last.DT, last.AllAmount - first.AllAmount);
                return info;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private SaleRecord GetFirstSaleRecord(string name, DateTime begin, DateTime end)
        {
            string wellNO = GetWellNo(name);
            string sql = string.Format(
                "select top 1 * from tbSal where wellNo={0} and time between '{1}' and '{2}' order by time",
                wellNO, begin, end );
            return GetSaleRecord(name, sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private SaleRecord GetLastSaleRecord(string name, DateTime begin, DateTime end)
        {
            string wellNO = GetWellNo(name);
            string sql = string.Format(
                "select top 1 * from tbSal where wellNo={0} and time between '{1}' and '{2}' order by time desc",
                wellNO, begin, end );
            return GetSaleRecord(name, sql);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private SaleRecord GetSaleRecord(string name, string sql)
        {
            SaleRecord sr = null;
            SqlCommand cmd = new SqlCommand(sql, con.GetConnection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DateTime dt = Convert.ToDateTime(dr["time"]);
                float price = Convert.ToSingle(dr["price"]);
                int allSaleAmount = Convert.ToInt32(Convert.ToSingle(dr["allSalAmount"]));
                int allSaleMoney = (int)(allSaleAmount * price);
                sr = new SaleRecord(name, dt, price, allSaleMoney, allSaleAmount);
            }
            dr.Close();
            return sr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable ExecuteDataTable( string sql )
        {
            SqlCommand cmd = new SqlCommand( sql, this.con.GetConnection () );
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Year"></param>
        /// <returns></returns>
        private SaleInfo GetSalDatas(string wellName, DateTime begin, DateTime end)
        {
            string wellNO = this.GetWellNo ( wellName );

            string sql = string.Format(
                "select sum(salMony) as salMony, sum(salAmount) as salAmount from tbSal where wellNO = '{0}' and time between '{1}' and '{2}'",
                wellNO, begin, end);

            DataTable tbl = this.ExecuteDataTable ( sql );
            if( tbl.Rows.Count == 0 )
            {
                return null;
            }

            DataRow row = tbl.Rows[0];
            int sumSaleMoney = 0;
            int sumSaleAmount  = 0;

            object obj = row["salMony"];
            if( obj != DBNull.Value )
            {
                sumSaleMoney = Convert.ToInt32(obj);
            }

            obj = row["salAmount"];
            if( obj != DBNull.Value )
            {
                sumSaleAmount = Convert.ToInt32(obj);
            }

            SaleInfo info = new SaleInfo( wellName, begin, end, sumSaleMoney , sumSaleAmount );
            return info;
        }

        /// <summary>
        /// 获取区名称
        /// </summary>
        /// <returns></returns>
        public string[] GetQuName()
        {
            string sql = "select distinct CountryName from tbDep where CountryName is not null";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable  dt = ds.Tables[0];
            da.Dispose();
            string[] restr = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                restr[i] = dt.Rows[i][0].ToString();
            }
            return restr;
        }

        /// <summary>
        /// 获取单位名称
        /// </summary>
        /// <param name="qu">区名称</param>
        /// <returns></returns>
        public string[] GetUnitName(string qu)
        {
            string sql = "select depName from tbDep where CountryName='" + qu + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            da.Dispose();
            string[] restr = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                restr[i] = dt.Rows[i][0].ToString();
            }
            return restr;
        }

        /// <summary>
        /// 获取单位下属的水井名称
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public string[] GetWellName(string unit)
        {
            string sql = "select wellName from tbWell where depName='" + unit + "' order by wellName";
            SqlDataAdapter da = new SqlDataAdapter(sql, con.GetConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            da.Dispose();
            string[] restr = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                restr[i] = dt.Rows[i][0].ToString();
            }
            return restr;
        }
    }
}
