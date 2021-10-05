﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecepieBackOffice.UI.Web.Features.Common
{
    public abstract class BaseRequest
    {
        public BaseRequest(string requestUrl)
        {
            RequestUrl = requestUrl;
        }
        public string RequestUrl { get; set; }
    }
}
