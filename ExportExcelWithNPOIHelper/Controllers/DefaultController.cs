using ExportExcelWithNPOIHelper.Models;
using NPOIExcel.WEB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExportExcelWithNPOIHelper.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExportStore()
        {
            var list = new List<StoreVM>
            {
                new StoreVM("S0001", "台北站前"),
                new StoreVM("S0002", "台北京站"),
                new StoreVM("S0003", "台北西門"),
            };

            NPOIExportExcelHelper<StoreVM> helper = new NPOIExportExcelHelper<StoreVM>();
            var fileBytes = helper.ExportToExcel(list);

            return File(fileBytes, "application/vnd.ms-excel", "StoreFile.xls");
        }

        public ActionResult ExportSpot()
        {
            var list = new List<SpotVM>
            {
                new SpotVM { SpotId = "10000001", SpotName = "國父紀念館", SpotType = "歷史建築" },
                new SpotVM { SpotId = "10000002", SpotName = "士林夜市", SpotType = "美食購物" },
                new SpotVM { SpotId = "10000003", SpotName = "陽明山國家公園", SpotType = "自然風景" },
            };

            NPOIExportExcelHelper<SpotVM> helper = new NPOIExportExcelHelper<SpotVM>(false);
            var fileBytes = helper.ExportToExcel(list);

            return File(fileBytes, "application/vnd.ms-excel", "SpotFile.xls");
        }
    }
}