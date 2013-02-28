using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace data_link
{
    public class d_trade
    {
        public bool add(data_define.trade model)
        {
            string sql = "";
            if (model.type_id > 0)
            {
                sql = string.Format("select max(trade_id) as trade_id from t_trade where type_id=" + model.type_id);
                DataTable dt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
                if (dt.Rows[0]["trade_id"].ToString()!=string.Empty)
                {
                    model.trade_id = int.Parse(dt.Rows[0]["trade_id"].ToString()) + 1;
                }
                else
                {
                    model.trade_id = int.Parse(model.type_id.ToString() + "01");
                }
                sql = string.Format("insert into t_trade(trade_id,type_id,trade_name) values ({0},{1},'{2}')", model.trade_id,model.type_id,model.trade_name); 
            }
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public bool update(data_define.trade model)
        {
            string sql = "";
            if (model.trade_id > 0)
            {
                int tradeid = model.trade_id;
                sql = string.Format("select max(trade_id) from t_trade where type_id=" + model.type_id);
                DataTable dt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    model.trade_id = int.Parse(dt.Rows[0]["trade_id"].ToString()) + 1;
                }
                sql = string.Format("update t_trade set trade_id={0},type_id={1},trade_name='{2}' where trade_id={3})", model.trade_id, model.type_id, model.trade_name, tradeid);
            }
            
            return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        }
        public List<data_define.trade> trade_listdt(data_define.trade model)
        {
            string str1 = "";
            List<data_define.trade> _listtrade = new List<data_define.trade>();
            if (model.trade_id > 0)
            { str1 = "where t_trade.trade_id=" + model.trade_id + ""; }
            else if (model.type_id> 0)
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and t_trade.type_id='" + model.type_id + "'";
                }
                else
                {
                    str1 = "where t_trade.type_id=" + model.type_id + "";
                }
            }
            string sql = string.Format("SELECT t_trade.*, t_type.type_name AS type_name FROM t_type INNER JOIN t_trade ON t_type.type_id = t_trade.type_id " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (ddt.Rows.Count > 0)
            {
                for (int i = 0; i < ddt.Rows.Count; i++)
                {
                    data_define.trade _model = new data_define.trade();
                    _model.trade_id = int.Parse(ddt.Rows[i]["trade_id"].ToString());
                    _model.type_id = int.Parse(ddt.Rows[i]["type_id"].ToString());
                    _model.trade_name = ddt.Rows[i]["trade_name"].ToString();
                    _model.type_name = ddt.Rows[i]["type_name"].ToString();
                    _listtrade.Add(_model);
                }
            }
            return _listtrade;
        }
        public DataTable tradedt(int type_id)
        {
            string str = "";
            if (type_id > 0)
            {
                str = "where t_trade.type_id=" + type_id + "";
            }
            string sql = string.Format("select * from t_trade " + str);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            return ddt;
        }
    }
}
