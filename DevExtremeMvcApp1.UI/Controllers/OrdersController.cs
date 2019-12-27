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

namespace DevExtremeMvcApp1_UI.Controllers {
    public class OrdersController : ApiController {

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            List<invoiceheader> invoiceheaders = new List<invoiceheader>();

            using (TMW_LiveEntities tmw = new TMW_LiveEntities())
            {
                var query = (from ih in tmw.invoiceheaders
                            select new
                            {
                                ih.ivh_hdrnumber,
                                ih.ivh_invoicestatus,
                                ih.ivh_shipper,
                                ih.ivh_shipdate,
                                ih.ivh_consignee
                            }).Take(20);

                foreach (var i in query)
                {
                    invoiceheaders.Add(new invoiceheader
                    {
                        ivh_hdrnumber = i.ivh_hdrnumber,
                        ivh_invoicestatus = i.ivh_invoicestatus,
                        ivh_shipper = i.ivh_shipper,
                        ivh_shipdate = i.ivh_shipdate,
                        ivh_consignee = i.ivh_consignee
                    });
                }
            }

            return Request.CreateResponse(DataSourceLoader.Load(invoiceheaders, loadOptions));
            //return Request.CreateResponse(DataSourceLoader.Load(SampleData.Orders, loadOptions));
        }

    }
}