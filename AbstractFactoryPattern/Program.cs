namespace AbstractFactoryPattern
{
    interface ICustomer
    {
        void Purchase();
    }

    interface IOrder
    {
        void Process();
    }

    interface IFactory
    {
        ICustomer GetCustomer();
        IOrder GetOrder();
    }

     
    class RegularCustomer : ICustomer
    {
        public void Purchase()
        {
            Console.WriteLine("Regular customer made a purchase");
        }
    }


    class PremiumCustomer : ICustomer
    {
        public void Purchase()
        {
            Console.WriteLine("Premium customer made a purchase");
        }
    }

    class RegularOrder : IOrder
    {
        public void Process()
        {
            Console.WriteLine("Regular order is processed");
        }
    }


    class PremiumOrder : IOrder
    {
        public void Process()
        {
            Console.WriteLine("Premium order is processed");
        }
    }


    class RegularFactory : IFactory
    {
        public ICustomer GetCustomer()
        {
            return new RegularCustomer();
        }

        public IOrder GetOrder()
        {
            return new RegularOrder();
        }
    }

    class PremiumFactory : IFactory
    {
        public ICustomer GetCustomer()
        {
            return new PremiumCustomer();
        }

        public IOrder GetOrder()
        {
            return new PremiumOrder();
        }
    }


    class ECommerce
    {
        static void Main(string[] args)
        {
            IFactory factory = new RegularFactory();
            ICustomer customer = factory.GetCustomer();
            IOrder order = factory.GetOrder();

            customer.Purchase();
            order.Process();


            Console.WriteLine();


            factory = new PremiumFactory();
            customer = factory.GetCustomer();
            order = factory.GetOrder();

            customer.Purchase();
            order.Process();
        }
    }

}

