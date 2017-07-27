using NPOIExcel.WEB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportExcelWithNPOIHelper.Models
{
    public class StoreVM
    {
            public StoreVM(string BC_CDE, string BC_NAME)
            {
                this.BC_CDE = BC_CDE;
                this.BC_NAME = BC_NAME;
            }
            /// <summary>
            /// 營業點代碼
            /// </summary>
            [ExcelExport(Title = "營業點代碼", Column = 1)]
            public string BC_CDE { get; set; }
            /// <summary>
            /// 營業店點
            /// </summary>
            [ExcelExport(Title = "營業店點", Column = 2)]
            public string BC_NAME { get; set; }
    }
}