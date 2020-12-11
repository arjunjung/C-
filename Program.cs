using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace c_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            // PlayingWithMySQL playingWithMySQL = new PlayingWithMySQL();
            // // playingWithMySQL.Play();

            // PlayingWithDelegates playingWithDelegates = new PlayingWithDelegates();
            // playingWithDelegates.Play();
            // TestSingleInstanceClass testSingleInstanceClass = new TestSingleInstanceClass();

            //Testing Func delegate
            // PlayingWithDelegates playingWithDelegates2 = new PlayingWithDelegates();
            // playingWithDelegates2.PlayPredicateLamdaExpression
            // ();

            // //Testing Callback Delegates
            // PlayingWithDelegates playingWithDelegates3 = new PlayingWithDelegates();
            // playingWithDelegates3.DoWork(playingWithDelegates3.Work, playingWithDelegates3.OnSuccess, playingWithDelegates3.OnFailure);

            // //Testing Simple Try-Catch
            // TryCatchFinallyThrow tryCatchFinallyThrow = new TryCatchFinallyThrow();
            // tryCatchFinallyThrow.SimpleTryCatchThrow();

            // //Testing Playing With LINQ
            // PlayingWithLINQ playingWithLINQ = new PlayingWithLINQ();
            // playingWithLINQ.SimpleLINQQuery();

            //Testing Extra
            // Extra<int> extras = new Extra<int>();
            // List<int> result = extras.PlayingWithGenerics(11,1);

            // Console.Write("[ ");
            // foreach( int eachData in result) {
            //     Console.Write(""+eachData + ", ");
            // }
            // Console.Write("]");


            // //Testing MyOwnDataStructure
            // MYOwnDataStructure<int> mYOwnDataStructure = new MYOwnDataStructure<int>();

            // for (int i = 0; i < 100; i++) {
            //     Random rand = new Random();
            //     mYOwnDataStructure.AddData(rand.Next(87364783));

            // }

            // // mYOwnDataStructure.DeleteData(0);

            // int[] dataReturned = mYOwnDataStructure.GetFullData();
            // int indexCounter = 0;
            // Console.WriteLine("\nSize of datareturned: " + dataReturned.Length);
            // foreach(int eachData in dataReturned) {
            //     Console.WriteLine($"\nEachData[{indexCounter}]: "+eachData);
            //     indexCounter++;

            // }

            // //Tesing Differnt types of Constructors  Class
            // Miscellaneous miscellaneous = new Miscellaneous();

            // //Testing Deconstructor in c#
            // Deconstructors deconstructors = new Deconstructors(10,"Baby AB");
            // (int age, string name) = deconstructors;

            // Console.WriteLine($"My name is {name}. I am {age} years old");

            // //Testing Properties in  c#
            // MyProperties properties = new MyProperties();
            // Console.WriteLine($"Myage before change : {properties.MyAge}.\n");
            // properties.MyAge = 15;
            // Console.WriteLine($"Myage after change : {properties.MyAge}.\n");

            // //Testing Indexer in c#
            // Indexers indexers = new Indexers();
            // indexers[0] = "First Value";            
            // indexers[1] = "Second Value";            
            // indexers[2] = "Third Value";            
            // indexers[3] = "Fourth Value";            
            // indexers[4] = "Fifth Value";            
            // indexers[5] = "Sixth Value";            
            // indexers[6] = "Seventh Value";            
            // indexers[7] = "Eighth Value";            
            // indexers[8] = "Ninth Value";            
            // indexers[9] = "Tenth Value";

            // for (int i = 0; i < 10;i++) {
            //     Console.WriteLine($"Print No. {i + 1} : {indexers[i]}");
            // }


            // //Testing Dynamic Binding in c#
            // DynamicBinding dynamicBinding = new DynamicBinding();
            // // dynamicBinding.TestDynamicBinding1();
            // dynamic returnedMessage = dynamicBinding.ShowMessage("Do the Karma, Don't opt for result");
            // Console.WriteLine("Returned dynamic message: " + returnedMessage);


            // //Testing Binary Operator '+' OperatorOverloading
            // OperatorOverloading_Plus op1 = new OperatorOverloading_Plus(10, 20);
            // OperatorOverloading_Plus op2 = new OperatorOverloading_Plus(100, 200);
            // OperatorOverloading_Plus op3 = new OperatorOverloading_Plus();

            // op3 = op1 + op2;

            // Console.WriteLine("\nGetting Sum of two objects ob1 + ob2: "+ op3.GetSum());

            // //Testing Relational Operator < // > 
            // OperatorOverloading_GT_LT chitwan = new OperatorOverloading_GT_LT(25.0);
            // OperatorOverloading_GT_LT bara = new OperatorOverloading_GT_LT(20.0);

            // bool isColder = chitwan > bara;
            // if (isColder) Console.WriteLine("\nChitwan is colder than Bara.");
            // else  Console.WriteLine("\nBara is colder than Chitwan.");

            //Testing Console Color
            // StringBuilder myStringBuilder = new StringBuilder("Hello");
            // // myStringBuilder.Remove(2, 2);
            // myStringBuilder.Insert(4,"ZZ");
            // Console.WriteLine(myStringBuilder);

            //Testing Color Class.
            Color color = null;
            try
            {
                color = new Color("MeroColor", 255, 0, 0);
            }catch(ColorException e) {
                Console.WriteLine(e);
            }

            if (color != null)
            {
                Console.WriteLine("\nColor hex test: " + color.GetHexValue());
                Console.WriteLine("\nColor rgb test: " + color.GetRGBvalue());
                Console.WriteLine("\nColor isPrimary test: " + color.IsPrimary());
            }

            //Signifies, 'internal' struct is in the different assembly so can't be accessed.
            // PixelPoint pixel = new PixelPoint(10.0, 11.2);
            /*
                Identifiers: That we give name for classes, methods , delegates, public fields, parameters, local variables, private fields
                PascalCase: classes, methods , delegates, public fields
                camelCase:  parameters, local variables, private fields

            */

        }
    }
}

