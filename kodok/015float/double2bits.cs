using System;

class Program
{
    static void Main()
    {
       double d = Math.PI;
       
       string eredm="";
      
	   if (double.IsPositiveInfinity(d))
            eredm = "+Infinity";
        if (double.IsNegativeInfinity(d))
            eredm =  "-Infinity";
        if (double.IsNaN(d))
            eredm =  "NaN";

        // Translate the double into sign, exponent and mantissa.
        long bits = BitConverter.DoubleToInt64Bits(d);
        // Note that the shift is sign-extended, hence the test against -1 not 1
        bool negative = (bits < 0);
        int exponent = (int) ((bits >> 52) & 0x7ffL);
        long mantissa = bits & 0xfffffffffffffL;

        /*
		The Convert.ToString does the conversion to a binary string.
        The PadLeft adds zeroes to fill it up to 16 digits.
		string binexp = Convert.ToString(exponent, 2).PadLeft(16, '0');
		*/
		
		string binexp = Convert.ToString(exponent, 2).PadLeft(11, '0');;
		string binmant = Convert.ToString(mantissa, 2);
	   Console.WriteLine("negative = "+negative);
	   Console.WriteLine("mantissza = "+binmant);
	   Console.WriteLine("kitevő = "+binexp);
       
    }
}
