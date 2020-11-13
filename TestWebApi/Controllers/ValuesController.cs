using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        /// <summary>
        /// 获取文本
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World!";
        }
        /// <summary>
        /// 两数相加
        /// </summary>
        /// <param name="num1">第一个数1111</param>
        /// <param name="num2">第二个数2222</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<int> Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// 两数相减
        /// </summary>
        /// <param name="param">参数</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<int> Subtract(Param param)
        {
            int result = param.num1 - param.num2;
            return result;
        }
    }


    /// <summary>
    /// 参数
    /// </summary>
    public class Param
    {
        /// <summary>
        /// 第一个数
        /// </summary>
        public int num1 { get; set; }
        /// <summary>
        /// 第二个数
        /// </summary>
        public int num2 { get; set; }
    }
}
