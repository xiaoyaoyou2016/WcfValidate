﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace WCFServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserCtrl”。
    [ServiceContract]
    public interface IUserCtrl
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        DataTable GetUserData();
    }
}
