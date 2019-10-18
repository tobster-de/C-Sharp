using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ReadonlyMembers
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public readonly double Distance => Math.Sqrt(X * X + Y * Y);

            public readonly override string ToString() =>
                $"({X}, {Y}) is {Distance} from the origin";

            public readonly void Invalid()
            {
                //X = 5; //   ReadonlyMembers.cs(22, 17): [CS1604] "X" ist schreibgeschützt. Eine Zuweisung ist daher nicht möglich.
            }
        }

        public void UseReadonlyMember()
        {
            Point x = new Point { X = 3, Y = 4 };

            Console.WriteLine(x.ToString());
        }
    }
}
