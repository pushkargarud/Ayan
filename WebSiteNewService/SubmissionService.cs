using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteNewService
{
    public class SubmissionService :Service    
    {
        public object Post(Submission sub)
        {
            return new SubmissiomResponse() { Id = 1 };
        }
    }
}