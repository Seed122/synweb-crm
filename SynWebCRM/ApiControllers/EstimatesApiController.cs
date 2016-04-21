﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using SynWebCRM.ApiControllers.Models;
using SynWebCRM.Data;
using SynWebCRM.Models;
using SynWebCRM.Security;

namespace SynWebCRM.ApiControllers
{
    [System.Web.Mvc.Authorize(Roles = Roles.Admin + "," + Roles.Sales)]
    public class EstimatesApiController : ApiController
    {

        Model db = new Model();
        public ResultModel GetEstimate(int id)
        {
            try
            {
                var rec = db.Estimates.Find(id);
                var res = Mapper.Map<EstimateModel>(rec);
                return new ResultModel(true, res);
            }
            catch (Exception e)
            {
                return new ResultModel(e);
            }

        }

        [System.Web.Http.HttpPost]
        public ResultModel UpdateEstimate(Estimate estimate)
        {

            try
            {
                foreach(var item in estimate.Items)
                {
                    if (item.EstimateId == 0)
                    {
                        item.EstimateId = estimate.EstimateId;
                        item.CreationDate = DateTime.Now;
                        db.EstimateItems.Add(item);
                    }
                    else
                    {
                        db.EstimateItems.Attach(item);
                        db.Entry(item).State = EntityState.Modified;
                    }
                }
                db.Estimates.Attach(estimate);
                db.Entry(estimate).State = EntityState.Modified;
                db.SaveChanges();
                return new ResultModel(true);
            }
            catch (Exception e)
            {
                return new ResultModel(e);
            }

        }
    }
}