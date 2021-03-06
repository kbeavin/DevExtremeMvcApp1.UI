﻿using System;
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
    public class OrdersController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage Orders(DataSourceLoadOptions loadOptions)
        {
            List<orderheader> orderheaders = new List<orderheader>();

            using (TMW_LiveEntities tmw = new TMW_LiveEntities())
            {
                var query = (from oh in tmw.orderheaders
                             orderby oh.ord_hdrnumber descending
                             select new
                             {
                                 oh.ord_number,
                                 oh.ord_bookedby,
                                 oh.ord_hdrnumber,
                                 oh.ord_refnum,
                                 oh.ord_route
                             }).Take(20);

                foreach (var o in query)
                {
                    orderheaders.Add(new orderheader
                    {
                        ord_number = o.ord_number,
                        ord_bookedby = o.ord_bookedby,
                        ord_hdrnumber = o.ord_hdrnumber,
                        ord_refnum = o.ord_refnum,
                        ord_route = o.ord_route
                    });
                }
            }

            return Request.CreateResponse(DataSourceLoader.Load(orderheaders, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage OrderDetails(int id, DataSourceLoadOptions loadOptions)
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