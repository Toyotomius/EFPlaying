using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFPlaying
{
    internal partial class Program
    {
        public class USPowerBallData
        {
            private DateTime _date;

            public int Bonus { get; set; }

            public string Date
            {
                get
                {
                    return _date.ToShortDateString();
                }
                set { _date = DateTime.Parse(value); }
            }

            public int Id { get; set; }

            public int Num1 { get { return Numbers[0]; } private set { } }

            public int Num2 { get { return Numbers[1]; } private set { } }

            public int Num3 { get { return Numbers[2]; } private set { } }

            public int Num4 { get { return Numbers[3]; } private set { } }

            public int Num5 { get { return Numbers[4]; } private set { } }

            [NotMapped]
            public List<int> Numbers { get; set; }
        }
    }
}
