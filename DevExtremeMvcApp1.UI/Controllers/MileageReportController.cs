using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevExtremeMvcApp1_UI.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeMvcApp1_UI.Data;

namespace DevExtremeMvcApp1_UI.Controllers
{
    public class MileageReportController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Mileage(DataSourceLoadOptions loadOptions)
        {
            List<mileagetable_Reporting> MileageList = new List<mileagetable_Reporting>();

            using (TMW_LiveEntities tmw = new TMW_LiveEntities())
            {
                var query = (from mr in tmw.mileagetable_Reporting
                             orderby mr.mt_updatedon descending
                             select new
                             {
                                 mr.mt_updatedon,
                                 mr.mt_updatedby,
                                 mr.mt_miles,
                                 mr.mt_destinationtype,
                                 mr.mt_origintype,
                                 mr.mt_type
                             }).Take(100);

                foreach (var i in query)
                {
                    MileageList.Add(new mileagetable_Reporting
                    {
                        mt_updatedon = i.mt_updatedon,
                        mt_updatedby = i.mt_updatedby,
                        mt_miles = i.mt_miles,
                        mt_destinationtype = i.mt_destinationtype,
                        mt_origintype = i.mt_origintype,
                        mt_type = i.mt_type
                    });
                }
            }

            return Request.CreateResponse(DataSourceLoader.Load(MileageList, loadOptions));
        }
    }
}
