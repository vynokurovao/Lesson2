using System;

namespace HW_loops
{
    public class RoutesNumberCounter
    {
        public static uint CountRoutesNumber(uint numberOfClients)
        {
            if (numberOfClients == 0)
            {
                return 1;
            }
            else
            {
                uint result = 1;
                do
                {
                    result *= numberOfClients;
                    numberOfClients--;
                }
                while (numberOfClients > 1);
                return result;
            }
        }
    }
}
