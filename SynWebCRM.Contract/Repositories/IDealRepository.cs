﻿using System;
using System.Collections.Generic;
using System.Text;
using SynWebCRM.Contract.Models;

namespace SynWebCRM.Contract.Repositories
{
    public interface IDealRepository: IRepository<Deal, int>
    {
        IEnumerable<Deal> GetLatestCompletedDeals(DateTime startDate);
    }
}