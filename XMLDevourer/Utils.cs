using System;

namespace XMLDevourer.Utils
{
    public class Utils
    {
        /*
            Incorrectly implemented method for prime checks.
        */
        public static bool IsPrime(int candidate)
        {
            if (candidate <= 0) {
                throw new NotImplementedException("IsPrime is not defined for numbers <= 0.");
            } else if (candidate % 2 == 0 || candidate == 1) {
                return false;
            } else {
                return true;
            }
        }
    }
}