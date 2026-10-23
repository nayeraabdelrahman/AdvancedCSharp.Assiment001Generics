using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedCSharp.Assiment001Generics
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 - Generic Classes

            #region Q1 -  What is a generic class? Why use generics?

            // What is a generic class?
            //answer: a generic class is a class that uses a type parameter <T> to work with different data types without rewriting the code.
            // Why use generics?
            //answer:
            //Code Reusability: Reuse the same code with different types.
            //Type Safety: Detect type errors at compile time.
            //Performance: Avoid unnecessary boxing and unboxing for value types.
            #endregion

            #region Q2 - Test Container<T>

            // Create and test Container<T>.
            GenericBox<int> genericBox = new GenericBox<int>(20);
            #endregion

            #region Q3 - Test Pair<TKey, TValue>
            //What are multiple type parameters?
            //Answer: Multiple Type Parameters allow a generic class or method to use more than one type parameter.
            // Create and test Pair<TKey, TValue>.
            Pair<int, string> pair = new Pair<int, string>(10, "SH001");
            #endregion

            #endregion


            #region Part 02 - Generic Methods

            #region Q4 - Swap<T>

            // What is a generic method?
            //A Generic Method is a method that uses a type parameter <T> to work with different data types without rewriting the method.

            // Write and test Swap<T>.
            int a=10; int b=20;
            Console.Write($"orginal numbers:{a} , {b} ");

           Swap<int>(ref a, ref b);
            Console.WriteLine($"after swap: {a},{b}");
            #endregion

            #region Q5 - FindMax<T>

            // Write and test a generic method
            // that finds the maximum value.
            decimal[] arr = { 10, 15, 20,100,80 };
            Console.WriteLine($"maximum value is:{FindMax<decimal>(arr)}");
            #endregion

            #endregion


            #region Part 03 - Generic Interfaces

            #region Q6 - IRepository<T>

            // What is a generic interface?
            //A generic interface is an interface that uses type parameters <T> to define a reusable, type-safe contract for different data types.
            // Write IRepository<T>.
            GenericRepository<Car> repository = new GenericRepository<Car>();
            repository.additem(new Car("Toyota Corolla", 1280000));
            repository.additem(new Car("BMW", 2500000));
            foreach(var car in repository.GetAll())
            {
                Console.WriteLine(car.ToString());
            }
            #endregion

            #endregion


            #region Part 04 - Generic Constraints

            #region Q7 - Struct Constraint

            // What is the struct constraint?
            // Write an example.

            #endregion

            #region Q8 - Class Constraint

            // What is the class constraint?
            // Write an example.

            #endregion

            #region Q9 - New Constraint

            // What is the new() constraint?
            // Write an example.

            #endregion

            #region Q10 - Interface Constraint

            // What is the interface constraint?
            // Write an example.

            #endregion

            #region Q11 - Base Class Constraint

            // What is the base class constraint?
            // Write an example.

            #endregion

            #region Q12 - Multiple Constraints

            // How do you apply multiple constraints?
            // Write an example.

            #endregion

            #endregion


            #region Part 05 - Default Keyword

            #region Q13 - Default Keyword Theory

            // What does the default keyword
            // do in generics?

            #endregion

            #region Q14 - Test SafeList<T>

            // Test SafeList<T> with valid
            // and invalid indexes.

            #endregion

            #endregion


            #region Part 06 - Variance

            #region Q15 - Covariance

            // What is covariance?
            // Explain the out keyword.

            #endregion

            #region Q16 - Contravariance

            // What is contravariance?
            // Explain the in keyword.

            #endregion

            #region Q17 - Covariance vs Contravariance

            // What is the difference between
            // covariance and contravariance?

            #endregion

            #endregion


            #region Part 07 - Static and Inheritance

            #region Q18 - Static Members

            // How do static members work
            // in generic types?

            #endregion

            #region Q19 - Generic Inheritance

            // How can you inherit
            // from a generic class?

            #endregion

            #endregion


            #region Part 08 - Complete Exercise

            #region Q20 - Test Cache<TKey, TValue>

            #region A - Create Cache

            #endregion

            #region B - Test Add

            #endregion

            #region C - Test Get

            #endregion

            #region D - Test Remove

            #endregion

            #region E - Test Contains

            #endregion

            #region F - Test Expiration

            #endregion

            #endregion

            #endregion
        }


        #region Q4 - Generic Swap<T> Method

        // Write Swap<T> here.
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion


        #region Q5 - Generic FindMax<T> Method

        // Write FindMax<T> here.
        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max= arr[i];
                }
            }
            return max;
        }
        #endregion
    }
}
