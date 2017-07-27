using NPOIExcel.WEB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExportExcelWithNPOIHelper.Models
{
    public class SpotVM
    {
        /// <summary>
        /// 景點編號
        /// </summary>
        [ExcelExport(Title = "景點編號")]
        public string SpotId { get; set; }
        /// <summary>
        /// 景點名稱
        /// </summary>
        [ExcelExport(Title = "景點名稱")]
        public string SpotName { get; set; }
        /// <summary>
        /// 景點類型
        /// </summary>
        [ExcelExport(Title = "景點類型")]
        public string SpotType { get; set; }
    }
}