using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class boxManager
    {
        //Naming convention
        public void AddtoPackage(product Product)

        {
            Console.WriteLine("Product added on your package: " + Product.Name);
        }

        public void addAlternative(string productName, string information, double Price, double amountOfStock)
        {
            // We can add one more methods on same class
            Console.WriteLine("Added: " + productName);

        }


        
}

    }

