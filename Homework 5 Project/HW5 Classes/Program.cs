using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    public class Program
    {
        //public static bool wasCalled = false;
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }


        public static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            toast.wasCalled = true;
            return toast;
        }



        public static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");

            Juice juice = new Juice();
            juice.wasCalled = true;

            return juice;
        }

        public static Toast ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");

            toast.wasCalled = true;
            return toast;
        }

        public static Toast ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");

            toast.wasCalled = true;
            return toast;
        }

        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(2000);
            await Task.Delay(1000);
            Console.WriteLine("Remove toast from toaster");


            Toast toast = new Toast();
            toast.wasCalled = true;

            return toast;
        }


        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            Bacon bacon = new Bacon();
            bacon.wasCalled = true;

            return bacon;
        }

        public static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            Egg egg = new Egg();
            egg.wasCalled = true;

            return egg;
        }

        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            
            Coffee coffee = new Coffee();
            coffee.wasCalled = true;

            return coffee;
        }
    }
}