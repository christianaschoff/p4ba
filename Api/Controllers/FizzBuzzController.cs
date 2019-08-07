using System;
using System.Collections.Generic;
using Contract;
using Contract.Api;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzCalculator fizzBuzzCalculator;

        public FizzBuzzController(IFizzBuzzCalculator fizzBuzzCalculator)
        {
            this.fizzBuzzCalculator = fizzBuzzCalculator;
        }

        [HttpGet("{number}")]
        public ActionResult<FizzBuzzResponse> Get(int number)
        {
            return new ActionResult<FizzBuzzResponse>( new FizzBuzzResponse { Result = new List<string>(){fizzBuzzCalculator.FizzBuzz(number)}});
        }

        [HttpPost]
        public ActionResult<FizzBuzzResponse> Post([FromBody] FizzBuzzRequest value)
        {
            List<string> result = new List<string>();
            for(int i = value.From; i<= value.Until; i++)
            {
                result.Add(fizzBuzzCalculator.FizzBuzz(i));
            }
            return new ActionResult<FizzBuzzResponse>(new FizzBuzzResponse(){ Result = result});
        }
    }
}
