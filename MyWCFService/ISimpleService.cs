using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    //這個cs檔案是wcf的介面
    //請在svc.cs執行測試


    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "ISimpleService"。
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]//公開在網路上
        double GetStockPrice(int CompanyID);
    }
}
