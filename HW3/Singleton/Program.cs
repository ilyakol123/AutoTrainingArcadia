using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerForSingle containerForSingle = new ContainerForSingle();
            Single item1 = containerForSingle.GetSingleItem();
            Single item2 = containerForSingle.GetSingleItem();
            Single item3 = containerForSingle.GetSingleItem();

            Console.WriteLine(item1.GetHashCode());
            Console.WriteLine(item2.GetHashCode());
            Console.WriteLine(item3.GetHashCode());

        }
    }
    class ContainerForSingle
    {
        public Single Single { get; set; }
        public Single GetSingleItem()
        {
            Single = Single.getItem();
            return Single;
        }

    }
    
    class Single
    {
        private static Single singleItem;
        private static int itemCounter;

        private Single()
        {
            itemCounter++;
        }
        public static Single getItem()
        {
            if (itemCounter < 1)
            {
                singleItem = new Single();
                return singleItem;
            }
            else
            {
                return singleItem;
            }
        }
        /*public static Single getItem()
        {
            if (singleItem == null)
            {
                singleItem = new Single();
                return singleItem;
            }
            else
            {
                return singleItem;
            }
        }*/

        
    }
}
