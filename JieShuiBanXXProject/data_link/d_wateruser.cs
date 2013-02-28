using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace data_link
{
    public class d_wateruser
    {
        d_linkman linkman = new d_linkman();
        public bool add(data_define.wateruser model)
        {

            
            //commandparameter[1].
            //SqlParameter param = new SqlParameter();
            //param.ParameterName = "@wateruser";
            //param.Value = model.waterusername;
            ////commandparameter.add

            //SqlParameter param1 = new SqlParameter();
            //param1.ParameterName = "@wateruser_num";
            //param1.Value = model.wateruser_num;
            

            //SqlParameter param2 = new SqlParameter();
            //param2.ParameterName = "@corporate";
            //param2.Value = model.corporate;
            

            //SqlParameter param3 = new SqlParameter();
            //param3.ParameterName = "@watermeter_num";
            //param3.Value = model.watermeter_num;

            //SqlParameter param4 = new SqlParameter();
            //param4.ParameterName = "@address";
            //param4.Value = model.address;

            //SqlParameter param5 = new SqlParameter();
            //param5.ParameterName = "@post";
            //param5.Value = model.post;

            //SqlParameter param6 = new SqlParameter();
            //param6.ParameterName = "@fax";
            //param6.Value = model.fax;

            //SqlParameter param7 = new SqlParameter();
            //param7.ParameterName = "@email";
            //param7.Value = model.email;

            //SqlParameter param8 = new SqlParameter();
            //param8.ParameterName = "@trade_id";
            //param8.Value = model.trade_id;

            //SqlParameter param9 = new SqlParameter("@photo",SqlDbType.Image,photo.Length);
            //param9.ParameterName = "@photo";
            //param9.Value = model.photo;

            //SqlParameter param10 = new SqlParameter();
            //param10.ParameterName = "@product";
            //param10.Value = model.product;

            //SqlParameter param11 = new SqlParameter();
            //param11.ParameterName = "@is_economize";
            //param11.Value = model.is_economize;

            //SqlParameter param12 = new SqlParameter();
            //param12.ParameterName = "@test_year";
            //param12.Value = model.test_year;

            //SqlParameter param13 = new SqlParameter();
            //param13.ParameterName = "@getwater_kind_id";
            //param13.Value = model.getwater_kind_id;

            //SqlParameter param14 = new SqlParameter();
            //param14.ParameterName = "@getwater_num";
            //param14.Value = model.getwater_num;

            //SqlParameter param15 = new SqlParameter();
            //param15.ParameterName = "@waterbeed";
            //param15.Value = model.waterbeed;

            //SqlParameter param16 = new SqlParameter();
            //param16.ParameterName = "@waterpeople";
            //param16.Value = model.waterpeople;

            //SqlParameter param17 = new SqlParameter();
            //param17.ParameterName = "@waterpeople_unit";
            //param17.Value = model.waterpeople_unit;

            //SqlParameter param18 = new SqlParameter();
            //param18.ParameterName = "@year_output";
            //param18.Value = model.year_output;

            //SqlParameter param19 = new SqlParameter();
            //param19.ParameterName = "@unit";
            //param19.Value = model.unit;

            //SqlParameter param20 = new SqlParameter();
            //param20.ParameterName = "@remark";
            //param20.Value = model.remark;


            string sql = string.Format("insert into t_wateruser(wateruser,wateruser_num,corporate,address,post,fax,email,trade_id,photo,product,is_economize,test_year,getwater_kind_id,getwater_num,waterbeed,watermeter_num,waterpeople,waterpeople_unit,year_output,unit,remark)"
            + " values(@wateruser,@wateruser_num,@corporate,@address,@post,@fax,@email,@trade_id,@photo,@product,@is_economize,@test_year,@getwater_kind_id,@getwater_num,@waterbeed,@watermeter_num,@waterpeople,@waterpeople_unit,@year_output,@unit,@remark)");
            SqlCommand cmd = new SqlCommand(sql);

            SqlParameter[] commandparameter = new SqlParameter[21];
            string[] paraname = new string[21] { "@wateruser", "@wateruser_num", "@corporate", "@address", "@post", "@fax", "@email", "@trade_id", "@photo", "@product", "@is_economize", "@test_year", "@getwater_kind_id", "@getwater_num", "@waterbeed", "@watermeter_num", "@waterpeople", "@waterpeople_unit", "@year_output", "@unit", "@remark" };
            object[] values = new object[21] { model.waterusername, model.wateruser_num, model.corporate, model.address, model.post, model.fax, model.email, model.trade_id, model.photo, model.product, model.is_economize, model.test_year, model.getwater_kind_id, model.getwater_num, model.waterbeed, model.watermeter_num, model.waterpeople, model.waterpeople_unit, model.year_output, model.unit, model.remark };
            for (int i = 0; i < commandparameter.Length; i++)
            {
                if (i == 8)
                { commandparameter[i] = new SqlParameter("@photo", SqlDbType.Image, model.photo.Length); }
                else
                {
                    commandparameter[i] = new SqlParameter();
                }
                commandparameter[i].ParameterName = paraname[i];
                commandparameter[i].Value = values[i];
                cmd.Parameters.Add(commandparameter[i]);
            }
            //SqlCommand cmd = new SqlCommand(sql);
            //cmd.Parameters.Add()
            if (sqlconn.DBIBase.Instance.ExecuteNonQuery(cmd))
            {
                string sql1 = string.Format("select max(wateruser_id) as wateruser_id from t_wateruser");
                DataTable dt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql1);
                data_define.linkman _answerman = new data_define.linkman();
                _answerman.wateruser_id = int.Parse(dt.Rows[0]["wateruser_id"].ToString());
                _answerman.name = model.answername;
                _answerman.branch = model.answerbranch;
                _answerman.duty = model.answerduty;
                _answerman.phone = model.answerphone;
                _answerman.handphone = model.answerhandphone;
                _answerman.isnote = model.answerisnote;
                _answerman.is_check = "0";
                data_define.linkman _linkman = new data_define.linkman();
                _linkman.wateruser_id = int.Parse(dt.Rows[0]["wateruser_id"].ToString());
                _linkman.name = model.linkmanname;
                _linkman.branch = model.linkmanbranch;
                _linkman.duty = model.linkmanduty;
                _linkman.phone = model.linkmanphone;
                _linkman.handphone = model.linkmanhandphone;
                _linkman.isnote = model.linkmanisnote;
                _linkman.is_check = "1";
                if (linkman.add(_answerman) && linkman.add(_linkman))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        
        /// <summary>
        /// 检查是否有相同的单位微机编号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool is_wateruser(data_define.wateruser model)
        {
            
            string sql = string.Format("select * from t_wateruser where wateruser_num=" + model.wateruser_num);
            DataTable dt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)//不能有相同的微机编号
               {
                   return false;
               }
                return true;
        }
        //public bool update(data_define.trade model)
        //{
        //    string sql = "";
        //    if (model.trade_id > 0)
        //    {
        //        int tradeid = model.trade_id;
        //        sql = string.Format("select max(trade_id) from t_trade where type_id=" + model.type_id);
        //        DataTable dt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
        //        if (dt.Rows.Count > 0)
        //        {
        //            model.trade_id = int.Parse(dt.Rows[0]["trade_id"].ToString()) + 1;
        //        }
        //        sql = string.Format("update t_trade set trade_id={0},type_id={1},trade_name='{2}' where trade_id={3})", model.trade_id, model.type_id, model.trade_name, tradeid);
        //    }

        //    return sqlconn.DBIBase.Instance.ExecuteNonQuery(sql);
        //}
        public List<data_define.wateruser> wateruser_listdt(data_define.wateruser model)
        {
            string str1 = "";
            List<data_define.wateruser> _listwateruser = new List<data_define.wateruser>();
            if (model.wateruser_id > 0)
            { str1 = "where t_wateruser.wateruser_id=" + model.wateruser_id + ""; }
            else if (model.trade_id > 0)
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and t_wateruser.trade_id='" + model.trade_id + "'";
                }
                else
                {
                    str1 = "where t_wateruser.trade_id=" + model.trade_id + "";
                }
            }
            string sql = string.Format("SELECT * from v_wateruser " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            if (ddt.Rows.Count > 0)
            {
                for (int i = 0; i < ddt.Rows.Count; i++)
                {
                    data_define.wateruser _model = new data_define.wateruser();
                    _model.wateruser_id = int.Parse(ddt.Rows[i]["wateruser_id"].ToString());
                    _model.waterusername = ddt.Rows[i]["wateruser"].ToString();
                    _model.wateruser_num = ddt.Rows[i]["wateruser_num"].ToString();
                    _model.corporate = ddt.Rows[i]["corporate"].ToString();
                    _model.address = ddt.Rows[i]["address"].ToString();
                    _model.post = ddt.Rows[i]["post"].ToString();
                    _model.fax = ddt.Rows[i]["fax"].ToString();
                    _model.email = ddt.Rows[i]["email"].ToString();
                    _model.trade_id = int.Parse(ddt.Rows[i]["trade_id"].ToString());
                    //_model.photo=byte[]()
                    _model.is_economize = ddt.Rows[i]["is_economize"].ToString();
                    _model.test_year = int.Parse(ddt.Rows[i]["test_year"].ToString());
                    _model.getwater_kind_id = int.Parse(ddt.Rows[i]["getwater_kind_id"].ToString());
                    _model.getwater_num = ddt.Rows[i]["getwater_num"].ToString();
                    _model.waterbeed = ddt.Rows[i]["waterbeed"].ToString();
                    _model.watermeter_num = int.Parse(ddt.Rows[i]["watermeter_num"].ToString());
                    _model.waterpeople = int.Parse(ddt.Rows[i]["waterpeople"].ToString());
                    _model.waterpeople_unit = ddt.Rows[i]["waterpeople_unit"].ToString();
                    _model.year_output = int.Parse(ddt.Rows[i]["year_output"].ToString());
                    _model.unit = ddt.Rows[i]["unit"].ToString();
                    _model.remark = ddt.Rows[i]["remark"].ToString();
                    _model.trade_name = ddt.Rows[i]["tradename"].ToString();
                    _model.getwater_kindname = ddt.Rows[i]["getwater_kind_name"].ToString();
                    _listwateruser.Add(_model);
                    
                }
            }
            return _listwateruser;
        }
        public DataTable wateruserdt(data_define.wateruser model)
        {
            string str1 = "";
            if (model.waterusername.Length > 0)
            {
                str1= "where t_wateruser.wateruser like '%" +model.waterusername + "%'";
            }
            else if (model.address.Length > 0)
            {
                if (str1.Length > 0)
                {
                    str1 = str1 + " and t_wateruser.address like '%" + model.address + "%'";
                }
                else
                {
                    str1 = "where t_wateruser.address like'%" + model.address + "%'";
                }
            }
            string sql = string.Format("select * from t_wateruser " + str1);
            DataTable ddt = sqlconn.DBIBase.Instance.ExecuteDataTable(sql);
            return ddt;
        }
    }
}
