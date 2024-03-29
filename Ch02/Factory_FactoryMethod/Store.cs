﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02.Factory_FactoryMethod
{
    /// <summary>
    /// 使用抽象類別 讓父, 子類別 依賴鬆綁
    /// </summary>
    public abstract class PizzaStore
    {
        public abstract string createPizza(Pizza pizza);
        public string orderPizza(Pizza pizza)
        {
            var msg = createPizza(pizza);
            pizza.cook();
            return msg;
        }
 
    }

    class NYStore : PizzaStore
    {
        public override string createPizza(Pizza pizza)
        {   
         return ("NYStore 開始製作~" );      
        }
    }

    class LAStore : PizzaStore
    {
        public override string createPizza(Pizza pizza)
        {
            return ("LAStore 開始製作~");
        }
    }
}
