using System.Linq.Expressions;
using System;

namespace projet_Enums
{
    public enum ShippingMethod
    {
        RegualarAirMail = 1,
        RegistredAirMail = 2,
        Express = 3
    }

            class Program
            {
                static void Main(string[] args)
                {
                    var method = ShippingMethod.Express;
                    Console.WriteLine((int)method);
                    Console.WriteLine(method.ToString());
                    
                    var methodId = 3;
                    Console.WriteLine((ShippingMethod)methodId);

                    var methodName = "Express";
                    var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
                }
            }
        
    
}