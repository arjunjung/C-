using System;

namespace c_Programming{

    //Declaring 
    //Simple delegates requires method to declare.
    //For Custom Delegates: Func, Action, Predicate doesn't require declaration.
    public delegate void AnyName(String name);
    public delegate int Calculate(int a, int b);
    public class PlayingWithDelegates{
        public PlayingWithDelegates() {
        
        }

        //Delegate method 1
        public void YourCountry(String naam) {
            Console.WriteLine("\n Name of the country: " + naam);
        }

        //Delegate method 2
        public void YourFather(String naamHo) {
            Console.WriteLine("\n Name of your father: " + naamHo);
        }

        public void PlayMulticast() {
            AnyName delegateTest = YourCountry;

            //Delegate Multicasting
            delegateTest += YourFather;

            delegateTest("Nepal"); //This is printing 2 method simultaneosly 
        }

        public void PlayUnicast() {
            Calculate delegateAddition = Add;
            Console.WriteLine("\n Added data: " + delegateAddition(10, 20));
        }

        public int Add(int a, int b) {
            return (a + b);
        }

        public int[] CreateMultiplicationTable(int BaseNumber, int Upto) {
            int[] result = new int[Upto];

            for (int i = 0; i < Upto; i++) {
                result[i] = BaseNumber * (i + 1);
            }

            return result;
        }

        public void PlayFuncSimple() {
            Func<int, int, int[]> FuncTest = CreateMultiplicationTable;
            int[] MultiplicationResult = FuncTest(5, 10);
            for (int i = 0; i < MultiplicationResult.Length; i++) {
                Console.WriteLine(MultiplicationResult[i]);
            }

            /*
                Conslution: 
                Func<T in, T in, T out> , it's generic takes , parameters_types at first and return_type at last.

                Note: Func<T out> , which has no parameters but only returns something. 
                Note: Func must atleast have OUTPUT value, at that time it maynot take parameter

            */
        }

        public void PlayFuncLamdaExpression() {
            //Lambda Expression: Expression Lambda (i.e body is one liner expression)
            Func<string, string> Change_toUpperCase = (para1) => para1.ToUpper();
            Func<string, string, bool> Are_Same = (para1, para2) => para1 == para2;

            //Lambda Expression: Statement Lambda (i.e body has a statement block)
            Func<string, int> Statement_Lambda_Example = (str) => {
                int lengthOfString = str.Length;
                return lengthOfString;
            };

            // Console.WriteLine(Change_toUpperCase("gajako sahara"));
            // Console.WriteLine(Are_Same("Aalu", "Pyaaj"));
            // Console.WriteLine(Statement_Lambda_Example("Kale"));

        }

        public void PlayActionLamdaExpression()
        {
            Action<string, string> Action_Delegate_NoReturnType = (str1, str2) => Console.WriteLine($"This is str1: {str1}. This is str2: {str2}");
            Action_Delegate_NoReturnType("Kale", "Vale");

            /*
                Action<T para1, T para2> : Action delegates only works with void return type tasks and method.
                Note: For method with no parameters and no return value don't use generics symbol: Action methodSingature;
            */
        }

        public void PlayPredicateLamdaExpression()
        {
            Predicate<int> Predicate_BoolReturnType = (number) => number % 2 == 0;
            Console.WriteLine("Even result: " + Predicate_BoolReturnType(23));

            /*
                Predicate<T in> : Must  takes 1 parameter and always return 'boo'
            */
        }

        // Making callback with delegates

        public void DoWork(Func<bool> work, Action onSuccess, Action onFailure) {
            for (int i = 0; i < 10; i++) {
                if (work()) onSuccess();
                else onFailure();

            }
        }

        public bool Work() {
            try{
                Random rand = new Random();
                int randomNum = rand.Next(34);
                Console.WriteLine("Random number: " + randomNum);

                for (int i = 0; i < 10; i++)
                {
                    if(randomNum==i+1) {
                        return true;
                    }
                }
                throw new Exception();

            } catch(Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public void OnSuccess() {
            Console.WriteLine("Success");
        }

        public void OnFailure() {
            Console.WriteLine("Failed");
        }
 



    }

    /*
        A delegate is a reference type. But instead of referring to an object, a delegate refers to a method.

        Delegates are used in the following cases:

        Event handlers
        Callbacks
        LINQ
        Implementation of design patterns

        -> Predefined delegates

        Func<> : This delegate takes upto 16 parameters and 1 return value. And works on functions with 'return' type
        Action<>: This delegate takes parameters or not, but works on functions with 'void' type.
        Predicate<>: This delegate takes only one parameter, and only works on function with 'bool' return type. 

        Note: We can attach method to these delegates. Or We can use lambda expression.
    */

}