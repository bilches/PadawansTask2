using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException();
            }
                int sum = 0;
                // put your code here
                //throw new NotImplementedException();
                for (int x = 0; x < count; x++)
                {
                    sum = sum + number + add * x;

                }
                return sum;
            
        }
    }
}
