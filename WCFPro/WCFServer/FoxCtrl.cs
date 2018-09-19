using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WCFServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“FoxCtrl”。
    public class FoxCtrl : IFoxCtrl
    {
        public void DoWork()
        {
        }

        public DataTable GetFoxData()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=192.168.2.112;Initial Catalog=Fox;User ID=sa;Password=123456;Persist Security Info=False;Max Pool Size=100");
            string sql = "select top 30 * from Users";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
            }
            return ds.Tables[0];
        }
    }
}
