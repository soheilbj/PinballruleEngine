using PinballruleEngine.RuleEngine;
using PinballruleEngine.Test.Model;
using System;
using System.Collections.Generic;

namespace PinballruleEngine.Test
{

    class Program
    {
        static void Main(string[] args)
        {
            SimpleRuleLoaderProductTest();
            Console.ReadKey();
        }


        public static void SimpleRuleLoaderProductTest()
        {


            //Create two sample product
            ProductModel Product1 = new ProductModel
            {
                DateAdd = new DateTime(2020, 2, 2),
                Price = 125000,
                Title = "Mercedes Benz AMG GTC",
                discount = 0
            };
            ProductModel Product2 = new ProductModel
            {
                DateAdd = DateTime.Now.AddDays(-5), // diffrence from our target result
                Price = 600000,
                Title = "Ford F150 Raptor",
                discount = 0
            };

            List<ProductModel> productlist = new List<ProductModel>();
            productlist.Add(Product1);
            productlist.Add(Product2);


            //create sample rule            
            Rule rule = new Rule("( DateAdd = '" + new DateTime(2020, 2, 2) + "' && Price = " + 125000 + " ) set discount = 0.40 ");

            //evaluation on both list
            RuleValidator evaluator = new RuleValidator();
            foreach (ProductModel item in productlist)
            {
                evaluator.ValidateExpressionRules<ProductModel>(item, rule);
            }

            //display evaluated result
            foreach (var item in productlist)
            {

                Console.WriteLine("Title: " + item.Title);
                Console.WriteLine("discount: " + item.discount);
            }

            Console.WriteLine("Product after Rule Expression execution!");


        }
    }
}

