using System;
using System.Collections.Generic;

namespace Day4GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing MyStack<T> ===");

            // Create a stack of integers
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Count after 3 pushes: " + stack.Count());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Count after pop: " + stack.Count());

            Console.WriteLine();

            Console.WriteLine("=== Testing MyList<T> ===");

            // Create a list of strings
            MyList<string> myList = new MyList<string>();
            myList.Add("Apple");
            myList.Add("Banana");
            myList.Add("Cherry");
            Console.WriteLine("Find(1): " + myList.Find(1));
            Console.WriteLine("Contains 'Banana': " + myList.Contains("Banana"));
            myList.InsertAt("Orange", 1);
            Console.WriteLine("Find(1) after InsertAt: " + myList.Find(1));
            myList.DeleteAt(2);
            Console.WriteLine("Contains 'Cherry' after DeleteAt: " + myList.Contains("Cherry"));
            myList.Clear();
            Console.WriteLine("List cleared.");

            Console.WriteLine();

            Console.WriteLine("=== Testing GenericRepository<T> ===");

            // Define a simple class that inherits from Entity
            var repo = new GenericRepository<Customer>();

            repo.Add(new Customer { Id = 1, Name = "Alice" });
            repo.Add(new Customer { Id = 2, Name = "Bob" });

            Console.WriteLine("All items in repository:");
            foreach (var c in repo.GetAll())
            {
                Console.WriteLine("Customer Id: " + c.Id + ", Name: " + c.Name);
            }

            var found = repo.GetById(2);
            Console.WriteLine("Found customer with Id 2: " + found.Name);

            repo.Save();
        }
    }

    // A simple class derived from Entity for testing repository
    public class Customer : Entity
    {
        public string Name { get; set; }
    }
}
