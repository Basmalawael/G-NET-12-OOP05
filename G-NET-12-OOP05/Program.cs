namespace G_NET_12_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1 :
            /* 
            * What is an Interface?
            An Interface is a "contract" that defines a set of methods and properties without implementing them.
            It tells a class what to do, but not how to do it.

            * Why use it instead of Concrete Classes?
             We use interfaces to achieve Loose Coupling. 
             This means your code doesn't depend on a specific class,
             making it easier to change or swap parts of the system later.
            
             *Three Benefits of Interfaces : 
             Flexibility: Easily swap one implementation for another
             (e.g., changing database types).

             Multiple Inheritance: A class can implement many interfaces
                but can only inherit from one class.

            Testability: Allows you to create "Mock" (fake) objects for easier 
                unit testing.
             */
            #endregion


            // ============================================================================

            #region  Q2 :
            /* 
             a) What is the problem with this design?Both interfaces have a method called Greet() 
              — how does the class handle it currently?

           * The problem is Ambiguity (or shared implementation). Currently, 
            the class provides a single Greet() method that satisfies both interfaces.
             You cannot have different logic for English and Arabic separately.

           * How it is handled: Currently, the class uses Implicit Implementation.
            Since the method signature void Greet() is identical in both interfaces,
            the compiler maps both to the same single method in the class.

            b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? 
             What is this technique called?

             class Translator : IEnglishSpeaker, IArabicSpeaker
                {

                // Implementation for English
                void  IEnglishSpeaker .Greet(){Console.WriteLine("Hello");}

                // Implementation for Arabic
                void IArabicSpeaker.Greet(){Console.WriteLine("Ahlan");}

                 }

           *  What is this technique called?
             This technique is called Explicit Interface Implementation.


            c) After applying your fix, can you call Greet() directly on a Translator object 
            (e.g. translator.Greet())? Why or why not? How do you call each version?

                Can you call it directly?
                No. You cannot call translator.Greet() directly on the object.
                Why?
                Because when using Explicit Implementation, the methods become
                "private" to the class and are only visible when the object is 
                treated as the interface itself.

                How do you call each version?

                You must cast the object to the specific interface type first:

                Translator translator = new Translator();

                // Calling the English version

               ((IEnglishSpeaker)translator).Greet();

                // Calling the Arabic version

              ((IArabicSpeaker)translator).Greet();
        */
            #endregion

            #endregion
        }
    }
}
