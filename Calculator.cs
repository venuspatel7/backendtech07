
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        public decimal Add(decimal a=11, decimal b=8)
        {
            return a+b;
        }
        //GET Calculator
        
        public decimal Sub(decimal a=11, decimal b=8)
        {
            return a-b;
        }
        public decimal Mul(decimal a=11, decimal b=8)
        {
            return a*b;
        }
        public decimal Div(decimal a=11, decimal b=8)
        {
            return a/b;
        }
        public decimal Mod(decimal a=11, decimal b=8)
        {
            return a%b;
        }
    }

}
