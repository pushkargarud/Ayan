using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteNewService
{
    [Route("/Submission")]
    public class Submission
    {
        public DateTime SubmissionTime { get; set; }
        public string HeadLine { get; set; }
        public string Body { get; set; }
    }
    public class SubmissiomResponse
    {
        public int Id { get; set; }
    }
}