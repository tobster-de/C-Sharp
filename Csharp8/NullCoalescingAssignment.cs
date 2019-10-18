using System;

namespace App
{
    public class NullCoalescingAssignment
    {
        public static void Assign()
        {
            int? age = null;
            
            age ??= 20;
            Console.WriteLine(age);
            
            age ??= 40;                 // bleibt 20, weil vorher nicht null
            Console.WriteLine(age);
        }
    }
}