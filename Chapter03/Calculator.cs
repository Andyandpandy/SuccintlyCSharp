using System;

namespace Calculation
{
    public class Calculator
    {
        private double[] numbers;

        public Calculator()
        {
            numbers = new double[2];

        }

        //Properies
        /**
         * Gets the First value of data 
        */
        public double First{
            get{
                return numbers[0];
            }
        }
        /**
         * Gets the Second value of data 
        */
        public double Second{
            get{
                return numbers[1];
            }
        }

        //Shorthand property
        /**
         * Gets or Sets the Addition of First and Second
        */
        public double Result { get; set; }

        /**
         * If command is First or Second this method attempts to get input from user.
        */
        public void GetNumber(string command){
            if (command == "First"){
                numbers[0] = GetInputFromUser();
            }else if(command == "Second"){
                numbers[1] = GetInputFromUser();
            }else{
                throw new ArgumentException();
            }
        }

        private double GetInputFromUser(){
            Console.WriteLine("Enter number: ");
            double input = 0;
            try{
                input = double.Parse(Console.ReadLine());
            }catch (ArgumentException){
                Console.WriteLine("ArgumentException");
            }catch (SystemException){
                Console.WriteLine("SystemException");
            }catch (Exception){
                Console.WriteLine("Exception");
            }finally{
                Console.WriteLine("Final: " + input);
            }
            return input;
        }

        public void PrintResult(){
            Result = First + Second;
            Console.WriteLine("{0} + {1} = {2}", First, Second, Result);
        }
    }
}
