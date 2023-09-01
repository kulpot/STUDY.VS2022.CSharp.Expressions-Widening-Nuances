using System;

//ref link:https://www.youtube.com/watch?v=fLuduc3PbF4&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=29
//  explicit means cast

class MainClass
{       // requires binary knowledge -- sign or unsign
    static void Main()
    {
        int i = 5;
        //Console.WriteLine(int.MinValue);    // -2147483648
        //Console.WriteLine(int.MaxValue);    //  2147483647
        //long l = (long)i;   // explicit convertion(cast)
        long l = i;     //implicit convertion
        //Console.WriteLine(long.MinValue);   // -9223372036854775808
        //Console.WriteLine(long.MaxValue);   // 9223372036854775807

        //i = l;  //error converting long to int --requires safetyoff by casting
        //i = (int)l;     // safetyoff (explicit casting)

        //i = (int)unchecked(int.MaxValue + 10);

        l = long.MaxValue;
        i = (int)l;
        Console.WriteLine(i);   // -1



        ////- Human (TypeName)         - Compiler(UsingTypeName)
        //byte b = 0;                 // System.Byte  -- 8bits -- unsigned type  -- efficient maximum needed for 255 values
        //Console.WriteLine(byte.MaxValue);   // 255
        //Console.WriteLine(byte.MinValue);   // 0
        //
        //
        ////------------------ casting between signed and unsigned -------------------
        //byte numPeopleInFamily = 200;
        //// signedVersion = numPeopleInFamily;  // error cant convert byte to sbyte
        //sbyte signedVersion = (sbyte)numPeopleInFamily; // cast (sbyte) 
        //Console.WriteLine(signedVersion);   // -56    // loss data
        ////-----------------------------------------------


        //sbyte sb = 0;               // System.SByte   -- signed -- 255/2
        //Console.WriteLine(sbyte.MaxValue);   // 127
        //Console.WriteLine(sbyte.MinValue);   // -128
        //
        //short s = 0;                // System.Int16    -- short interpret as signed
        //Console.WriteLine(short.MaxValue);   // 32767
        //Console.WriteLine(short.MinValue);   // -32768
        //
        //
        //ushort us = 0;              // System.UInt16 -- unsign version or unshort
        //int i = 0;                  // System.Int32     -- 4 bytes -- 32bits    
        //uint ui = 0;                // System.UInt32
        //long l = 0;                 // System.Int64
        //ulong ul = 0;               // System.UInt64
        //float f = 0;                // System.Single
        //double d = 0;               // System.Double
        //char c = '\0';              // System.Char
        //bool bl = false;            // System.Boolean
        //string st = "";             // System.String
        //decimal dc = 0;             // System.Decimal

        ///////



        //Console.WriteLine(short.MaxValue);   // 32767
        //Console.WriteLine(ushort.MaxValue);   // 65535
        //Console.WriteLine(int.MaxValue);   // 2147483647
        //Console.WriteLine(uint.MaxValue);   // 4294967295
        //Console.WriteLine(long.MaxValue);   // 9223372036854775807
        //Console.WriteLine(ulong.MaxValue);   // 18446744073709551615
        //Console.WriteLine(float.MaxValue);   // 3.4028235E+38
        //Console.WriteLine(double.MaxValue);   // 1.7976931348623157E+308
        //Console.WriteLine(char.MaxValue);   // ?
        //
        //Console.WriteLine(decimal.MaxValue);   // 79228162514264337593543950335
    }
}