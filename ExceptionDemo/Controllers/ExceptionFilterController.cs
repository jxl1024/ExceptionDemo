using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExceptionDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExceptionFilterController : ControllerBase
    {
        [HttpGet]
        public async Task<ResultModel<int>> Get()
        {
            int i = 0;
            int k = 10;
            // 这里会发生异常
            int j = await Task.Run<int>(() => 
            {
                return k / i;
            });


            return new ResultModel<int>()
            {
                ResultCode=1,
                ResultMsg="Success",
                ResultData=j
            };
        }
    }
}