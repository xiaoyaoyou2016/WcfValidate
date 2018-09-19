using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SalesOpt”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SalesOpt.svc 或 SalesOpt.svc.cs，然后开始调试。
    public class SalesOpt : ISalesOpt
    {
        public void DoWork()
        {
        }

        public DataTable GetData()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=192.168.2.112;Initial Catalog=Fox;User ID=sa;Password=123456;Persist Security Info=False;Max Pool Size=100");
            string sql = "select top 30 * from Foxs";
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
