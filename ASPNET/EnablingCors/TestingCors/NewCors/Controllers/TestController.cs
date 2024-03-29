﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NewCors.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var resp = new HttpResponseMessage()
            {
                Content = new StringContent("GET: Test message")
            };
            resp.Headers.Add("X-Custom-Header", "hello");
            return resp;
        }

        public HttpResponseMessage Post()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("POST: Test message")
            };
        }

        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent("PUT: Test message")
            };
        }
    }
}