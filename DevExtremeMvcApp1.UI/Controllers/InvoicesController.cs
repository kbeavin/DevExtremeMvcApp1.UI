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
    public class InvoicesController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage Invoices(DataSourceLoadOptions loadOptions)
        {
            List<invoiceheader> invoiceheaders = new List<invoiceheader>();

            using (TMW_LiveEntities tmw = new TMW_LiveEntities())
            {
                var query = (from ih in tmw.invoiceheaders
                             orderby ih.ivh_hdrnumber descending
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
        }

        [HttpGet]
        public HttpResponseMessage InvoiceDetails(int id, DataSourceLoadOptions loadOptions)
        {
            List<invoicedetail> invoicedetails = new List<invoicedetail>();

            using (TMW_LiveEntities tmw = new TMW_LiveEntities())
            {
                var query = (from ivd in tmw.invoicedetails
                             where ivd.ivh_hdrnumber == id
                             select new
                             {
                                 ivd.ivd_number,
                                 ivd.fgt_number,
                                 ivd.fgt_supplier,
                                 ivd.ivd_bolid,
                                 ivd.ivd_ord_number
                             }).Take(5);

                foreach (var i in query)
                {
                    invoicedetails.Add(new invoicedetail
                    {
                        ivd_number = i.ivd_number,
                        fgt_number = i.fgt_number,
                        fgt_supplier = i.fgt_supplier,
                        ivd_bolid = i.ivd_bolid,
                        ivd_ord_number = i.ivd_ord_number
                    });
                }
            }

            return Request.CreateResponse(DataSourceLoader.Load(invoicedetails, loadOptions));
        }
    }
}