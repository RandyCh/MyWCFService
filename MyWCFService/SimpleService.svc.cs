using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    //這邊是實作ISimpleService的類別
    //要在這邊執行 叫用出WCF測試用戶端

    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "SimpleService"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 SimpleService.svc 或 SimpleService.svc.cs，然後開始偵錯。
    public class SimpleService : ISimpleService
    {


        public double GetStockPrice(int CompanyID)
        {
            Random r = new Random();
            return r.NextDouble() * r.Next(1, 101);
        }
    }
}
