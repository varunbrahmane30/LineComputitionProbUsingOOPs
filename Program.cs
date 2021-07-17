using System;

namespace LineComputitionProblemUsingOOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computition Problem Using OOPs");
            //LIneLength.getCartesianPoint();
            //LinesEqualOrNot.checkEquality();
            //CheckEqualGreterLesser.checkEqulGreatLess();

            #region UC4- using oops Operation

            // object creation of class 
            UsingOOPsOperation op = new UsingOOPsOperation();

            // calling methods of class (UsingOOPsOperation)
            op.getValue();
            op.cal();
            op.result();
            #endregion

            Console.ReadKey();
        }
    }
}
