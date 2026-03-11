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
            //=============================================================
            #region Q3:
            /*
        * Explain the difference between a shallow copy and a deep copy.
        * When would you use each one? 
        * What is the risk of using a shallow copy when the object has reference - type fields ?
        
        - Shallow Copy: Copies the object’s bitwise values. 
          For Value Types, it copies the data. 
          For Reference Types, it only copies the memory address (reference).
          Both objects will point to the same internal object in memory.

        - Deep Copy: Creates a completely new copy of the object and 
             all objects referenced by it.
            It duplicates the entire object tree.

        ----------------------------------------------------

        * Shallow Copy:

         Use it when the object contains only Value Types (int, bool, etc.)
          or Immutable types (string).

         Use it when you specifically want multiple objects to share
         the same underlying data to save memory.

        * Deep Copy:

         Use it when you need a totally independent copy.
         If you modify the copy, the original must remain unchanged.

         Necessary for complex objects with nested lists or other classes.

        ------------------------------------------------------
        * What is the risk of using a shallow copy when the object has reference-type fields?
        * 
          The Risk: The main risk is Data Corruption or unintended side effects. 
          Since both objects share the same memory address for reference types,
          changing a property in the "copy" will automatically change it in the 
          "original." This leads to bugs that are very hard to track.
            
        ========================================= */
            #endregion

            #region Q4 :
            /*
          Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");  Dev - Testing
          Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");  QA - Testing
        -------------------------------

         Title (string): It is a reference type, 
          but strings are immutable. When you assign "QA" to e2.Title,
          it creates a new string for e2 without affecting e1.

          Dept (Class): This is a reference type.
          MemberwiseClone() creates a Shallow Copy,
         meaning it only copies the memory address (pointer) of the Dept object.

        Result: Both e1 and e2 point to the same Department object in memory.
         Therefore, when you change e2.Dept.Name, it updates the shared object, 
        reflecting the change for both e1 and e2



                    
            */
            #endregion






            #endregion




        }
    }
}
