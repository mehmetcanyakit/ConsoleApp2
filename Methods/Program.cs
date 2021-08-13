using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            product computer = new product();
            computer.Name = "Computer";
            computer.Price = 500;
            computer.Information = "Super";
            computer.Id = 54400;

            product phone = new product();
            phone.Name = "Phone";
            phone.Price = 850;
            phone.Id = 888754;
            phone.Information = "High Level";

            //In real life we will get this array members which is below from datasets
            product[] newProducts = new product[] { phone, computer };

            //To press for every data from an array
            foreach (product product_ in newProducts)
            {

                Console.WriteLine(product_.Price);
            }

            Console.WriteLine("---------Methods----------");
                boxManager voxManager = new boxManager();
                voxManager.AddtoPackage(phone);


            //This is the different technique to add something on your particular array.
            //But this usage which is below is very risky because if you add new property about your product you must add for every line of codes
            voxManager.addAlternative("Armut", "Yeşil", 12, 50);


        }
    }
}
// Do not repeat yourself.