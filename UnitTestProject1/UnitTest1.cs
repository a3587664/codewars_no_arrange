using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 
    {
        //private Tribonacci_Sequence_Test Tribonacci_Sequence_Test; 

        //[SetUp]
        //public void SetUp()
        //{
        //    Tribonacci_Sequence_Test = new Tribonacci_Sequence_Test();
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    Tribonacci_Sequence_Test = null;
        //}
        [TestMethod]
        public void Tribonacci_Sequence()
        {
            var test = new Tribonacci_Sequence_Test();
            double[] A = {6, 0, 14, 20, 34};
            double[] B = test.Test2(new double[] {6, 0, 14}, 5);
            CollectionAssert.AreEqual(A, B);
        }

        [TestMethod]
        public void Alan_Partridge_II_Apple_Turnover()
        {
            Kata kata = new Kata();
            Assert.AreEqual("It's hotter than the sun!!", kata.Apple(40));
            Assert.AreEqual("Help yourself to a honeycomb Yorkie for the glovebox.", kata.Apple(4));
        }

        [TestMethod]
        public void L1_Bartender_drinks()
        {
            Kata2 kata = new Kata2();
            Assert.AreEqual("Patron Tequila", kata.GetDrinkByProfession2("jabrOni"),
                "'Jabroni' should map to 'Patron Tequila'");
            Assert.AreEqual("Anything with Alcohol", kata.GetDrinkByProfession2("scHOOl counselor"),
                "'School Counselor' should map to 'Anything with alcohol'");
            Assert.AreEqual("Hipster Craft Beer", kata.GetDrinkByProfession2("prOgramMer"),
                "'Programmer' should map to 'Hipster Craft Beer'");
            Assert.AreEqual("Moonshine", kata.GetDrinkByProfession2("bike ganG member"),
                "'Bike Gang Member' should map to 'Moonshine'");
            Assert.AreEqual("Your tax dollars", kata.GetDrinkByProfession2("poLiTiCian"),
                "'Politician' should map to 'Your tax dollars'");
            Assert.AreEqual("Cristal", kata.GetDrinkByProfession2("rapper"), "'Rapper' should map to 'Cristal'");
            Assert.AreEqual("Beer", kata.GetDrinkByProfession2("pundit"), "'Pundit' should map to 'Beer'");
            Assert.AreEqual("Beer", kata.GetDrinkByProfession2("Pug"), "'Pug' should map to 'Beer'");
        }

        [TestMethod]
        public void SampleTests()
        {
            Kata3 kata = new Kata3();
            Assert.AreEqual("Mine's a Pint!", kata.Part(new String[] {"Grouse", "Partridge", "Pheasant"}));
            Assert.AreEqual("Mine's a Pint!!!!!!!!",
                kata.Part(new String[]
                {
                    "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree",
                    "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad",
                    "Finger", "Hamster"
                }));
            Assert.AreEqual("Lynn, I've pierced my foot on a spike!!",
                kata.Part(new string[] {"Pheasant", "Goose", "Starling", "Robin"}));
        }

        [TestMethod]
        public void Persistent_Bugger()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(1, Persist.Persistence(100));
        }

        [TestMethod]
        public void Calculate_BMI()
        {
            Kata4 kata = new Kata4();
            Assert.AreEqual("Normal", kata.Bmi(80, 1.80));
        }

        [TestMethod]
        public void Band_name_generator()
        {
            Kata5 kata = new Kata5();
            Assert.AreEqual("The Knife", kata.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", kata.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", kata.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", kata.BandNameGenerator("bed"));
        }

        [TestMethod]
        public void Product_of_Array_Items()
        {
            ArrayMath arrayMath =new ArrayMath();
            Assert.AreEqual(540, arrayMath.Product(new int[] { 5, 4, 1, 3, 9 }));
            //Assert.AreEqual(-672, arrayMath.Product(new int[] { -2, 6, 7, 8 }));
            //Assert.AreEqual(10, arrayMath.Product(new int[] { 10 }));
            //Assert.AreEqual(0, arrayMath.Product(new int[] { 0, 2, 9, 7 }));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullTest()
        {
            ArrayMath arrayMath = new ArrayMath();
            arrayMath.Product(null);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidOperationTest()
        {
            ArrayMath arrayMath = new ArrayMath();
            arrayMath.Product(new int[] { });
        }

        [TestMethod]
        public void String_average()
        {
            Kata6 kata = new Kata6();
            Assert.AreEqual("four", kata.AverageString("zero nine five two"));
            Assert.AreEqual("three", kata.AverageString("four six two three"));
            Assert.AreEqual("three", kata.AverageString("one two three four five"));
            Assert.AreEqual("four", kata.AverageString("five four"));
            Assert.AreEqual("zero", kata.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", kata.AverageString("one one eight one"));
            Assert.AreEqual("n/a", kata.AverageString(""));
        }

        [TestMethod]
        public void Build_Palindrome()
        {
            var kata = new Kata7();
            Assert.AreEqual("aaccbabccaa", kata.BuildPalindrome("aaccbabc"));
            Assert.AreEqual("abababa", kata.BuildPalindrome("ababab"));
        }

        [TestMethod]
        public void IQTest()
        {
            var iq = new IQ();
            Assert.AreEqual(3, iq.Test("2 4 7 8 10"));
        }

        [TestMethod]
        public void Clocky_Mc_Clock_Face()
        {
            var time = new Time();
            Assert.AreEqual("12:49", time.WhatTimeIsIt(24.78d));
            //Assert.AreEqual("12:00", time.WhatTimeIsIt(360));
            //Assert.AreEqual("03:00", time.WhatTimeIsIt(95));
            //Assert.AreEqual("06:00", time.WhatTimeIsIt(180));
            //Assert.AreEqual("09:00", time.WhatTimeIsIt(270));
        }

    }

    public class Time
    {
        public string WhatTimeIsIt(double angle)
        {
            double H = angle == 0 ? 12 : angle / 30;            
            double M2 = angle % 30;
            int M = 0;
            while (M2 >= 0.5)
            {
                M2 -= 0.5;
                M++;
            }
            H = H < 1 ? 12 : H;
            DateTime a = Convert.ToDateTime((int)H + ":" + M);
            return a.ToString("HH:mm");
        }
    }

    public class IQ
    {
        public int Test(string numbers)
        {
            //string[] array = numbers.Split(' ');
            //var n = array.Where(x => Int32.Parse(x.ToString()) % 2 == 0).ToArray();
            //int FalseNum = n.Length > 1 ? Array.FindIndex(array, x => Int32.Parse(x) % 2 != 0) : Int32.Parse(n[0]);

            return numbers.Split(' ').Where(x => Int32.Parse(x.ToString()) % 2 == 0).Count() > 1
                ? Array.FindIndex(numbers.Split(' '), x => Int32.Parse(x) % 2 != 0) + 1
                : Array.FindIndex(numbers.Split(' '), x => Int32.Parse(x) % 2 == 0) + 1;
        }
    }

    public class Kata7
    {
        public string BuildPalindrome(string str)
        {

            char[] _reverse = str.ToCharArray();

            Array.Reverse(_reverse);

            string _reverseValue = new string(_reverse);
            string _value = str + _reverseValue;
            string _palindrome = _value;

            while (_value.Length > str.Length)
            {
                _value = _value.Remove(str.Length, 1);

                if (isPalindrome(_value))
                    _palindrome = _value;
            }

            return _palindrome;
        }
        public bool isPalindrome(string str)
        {
            int min = 0;
            int max = str.Length - 1;

            while (true)
            {
                if (min > max)
                    return true;

                char a = str[min];
                char b = str[max];

                if (char.ToLower(a) != char.ToLower(b))
                    return false;

                min++;
                max--;
            }
        }
    }

    public class Kata6
    {
        public string AverageString(string str) 
        {
            try
            {
                string[] Denominator = str.Split(' ');
                for (int i = 0; i < Denominator.Length; i++)
                    Denominator[i] = change(Denominator[i]);
                string avr = (Denominator.Aggregate(0, (a, b) => a + Int32.Parse(b.ToString())) / Denominator.Length).ToString();
                return change(avr);
            }
            catch (Exception e)
            {
                return "n/a";
            }
            //var a = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //return !str.Split(' ').All(x => a.Contains(x)) ? "n/a" : a[(int)str.Split(' ').Average(x => Array.IndexOf(a, x))];
        }

        public string change(string tmp)
        {
            switch (tmp)
            {
                case "0":
                    return "zero";
                case "1":
                    return "one";
                case "2":
                    return "two";
                case "3":
                    return "three";
                case "4":
                    return "four";
                case "5":
                    return "five";
                case "6":
                    return "six";
                case "7":
                    return "seven";
                case "8":
                    return "eight";
                case "9":
                    return "nine";
                case "zero":
                    return "0";
                case "one":
                    return "1";
                case "two":
                    return "2";
                case "three":
                    return "3";
                case "four":
                    return "4";
                case "five":
                    return "5";
                case "six":
                    return "6";
                case "seven":
                    return "7";
                case "eight":
                    return "8";
                case "nine":
                    return "9";
                default: return "";
            }
        }
    }

    public class ArrayMath
    {
        public int Product(int[] values)
        {
            return values == null
                ? throw new ArgumentNullException(null)
                : !values.Any()
                    ? throw new InvalidOperationException()
                    : values.Aggregate(1, (a, b) => a * b);
        }
    }

    public class Kata5
        {
            public string BandNameGenerator(string str)
            {
                string FirstUpper = str.ToUpper().Substring(0, 1);
                string rest = str.Substring(1, str.Length - 1);
                return str.Substring(0,1)==str.Substring(str.Length-1,1) ? FirstUpper + rest + rest : "The " + FirstUpper + rest;
            }
        }

        public class Kata4
        {
            public string Bmi(double weight, double height)
            {
                double bmi = weight / Math.Pow(height, 2);
                return bmi <= 18.5 ? "Underweight" : bmi <= 25d ? "Normal" : bmi <= 30d ? "Overweight" : "Obese";
            }
        }

        public class Persist
        {
            public static int Persistence(long n)
            {
                //var Narray = n.ToString().ToArray();
                //int num = 0;
                //while (n >= 10)
                //{
                //    n = 1;
                //    for (int i = 0; i < Narray.Length; i++)
                //        n = n * Int32.Parse(Narray[i].ToString());
                //    Narray = n.ToString().ToArray();
                //    num++;
                //}

                //ask help people
                return n < 10 ? 0 : 1 + Persistence(n.ToString().Select(c => c - 48).Aggregate(1, (a, b) => a * b));
                // return num;


            }
        }

        public class Kata3
        {
            public string Part(string[] x)
            {
                //string[] EX = { "Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad" };
                //string T = "Mine's a Pint";
                //string F = "Lynn, I've pierced my foot on a spike!!";
                //string TT = "";
                //for (int i = 0; i < x.Length; i++)
                //{
                //    for (int j = 0; j < EX.Length; j++)
                //    {
                //        if (x[i].Contains(EX[j]))
                //        {
                //            TT += "!";
                //        }
                //    }
                //}
                //if (TT == "")
                //{               
                //    return F ;
                //}
                //return T+TT;

                int arrayCount = x
                    .Where(a => Array.Exists(
                        new string[]
                            {"Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"},
                        b => b == a)).Count();
                return arrayCount > 0
                    ? "Mine's a Pint" + new string('!', arrayCount)
                    : "Lynn, I've pierced my foot on a spike!!";
            }
        }

        public class Kata2
        {
            public string GetDrinkByProfession2(string p)
            {
                switch (p.ToUpper())
                {
                    case "JABRONI":
                        return "Patron Tequila";
                    case "SCHOOL COUNSELOR":
                        return "Anything with Alcohol";
                    case "PROGRAMMER":
                        return "Hipster Craft Beer";
                    case "BIKE GANG MEMBER":
                        return "Moonshine";
                    case "POLITICIAN":
                        return "Your tax dollars";
                    case "RAPPER":
                        return "Cristal";
                    default:
                        return "Beer";
                }
            }
        }


        public class Kata
        {
            public string Apple(object n)
            {
                //string a = "It's hotter than the sun!!";
                //string b = "Help yourself to a honeycomb Yorkie for the glovebox.";
                //if (Math.Pow(Int32.Parse(n.ToString()), 2) > 1000)
                //{
                //    return a;
                //}
                //    return b;

                int value = (n is string) ? int.Parse(n.ToString()) : (int) n;
                return Math.Pow(value, 2) > 1369
                    ? "It's hotter than the sun!!"
                    : "Help yourself to a honeycomb Yorkie for the glovebox.";
            }
        }

        public class Tribonacci_Sequence_Test
        {
            public double[] Test2(double[] args, int n)
            {
                if (n == 0)
                {
                    double[] clone2 = new double[n];
                    return clone2;
                }
                double[] clone = new double[n];
                Array.Copy(args, 0, clone, 0, 3);
                double sum = 0;
                for (int i = 3; i < n; i++)
                {
                    for (int j = i - 3; j < i; j++)
                    {
                        sum += clone[j];
                    }
                    clone[i] = sum;
                    sum = 0;
                }

                return clone;
            }
        }



    }
