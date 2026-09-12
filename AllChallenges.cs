using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Challenges
{
    // CHALLENGE 1: Stop gninnipS My sdroW! 
    public class Challenge1
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }
            return string.Join(" ", words);
        }
    }

    // CHALLENGE 2: Validate a PIN code
    public class Challenge2
    {
        public static bool ValidatePin(string pin)
        {
            if (pin.Length != 4 && pin.Length != 6) return false;
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

    //CHALLENGE 3: Growth of a Population
    class Challenge3
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int year = 0;
            while (p0 < p)
            {
                p0 = (int)(p0 + p0 * percent / 100 + aug);
                year++;
            }
            return year;
        }
    }

    //CHALLENGE 4: Get the Middle Character
    public class Challenge4
    {
        public static string GetMiddle(string s)
        {
            int mid = s.Length / 2;
            if (s.Length % 2 == 0)
            {
                return s.Substring(mid - 1, 2);
            }
            else return s[mid].ToString();
        }
    }

    //CHALLENGE 5: Highest and Lowest
    public static class Challenge5
    {
        public static string HighAndLow(string numbers)
        {
            string[] arr = numbers.Split(' ');
            int max = int.Parse(arr[0]);
            int min = int.Parse(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                int num = int.Parse(arr[i]);
                if (num > max) max = num;
                if (num < min) min = num;
            }
            return max + " " + min;
        }
    }

    //CHALLENGE 6: Shortest Word
    public class Challenge6
    {
        public static int FindShort(string s)
        {
            string[] arr = s.Split();
            int min = arr[0].Length;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length < min) min = arr[i].Length;
            }
            return min;
        }
    }

    //CHALLENGE 7: Bouncing Balls
    public class Challenge7
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h < 0 || bounce < 0 || bounce >= 1 || window >= h) return -1;
            int count = 1;
            while (h * bounce > window)
            {
                h = h * bounce;
                count += 2;
            }
            return count;
        }
    }

    //CHALLENGE 8: Playing with digits
    public class Challenge8
    {
        public static long digPow(int n, int p)
        {
            string s = n.ToString();
            long sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                sum += (long)Math.Pow(digit, p + i);
            }
            if (sum % n == 0) return sum / n;
            return -1;
        }
    }

    //CHALLENGE 9: Highest Scoring Word
    public class Challenge9
    {
        public static string High(string s)
        {
            string[] arr = s.Split(' ');
            string result = arr[0];
            int maxScore = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int score = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    score += arr[i][j] - 'a' + 1;
                }
                if (score > maxScore)
                {
                    maxScore = score;
                    result = arr[i];
                }
            }
            return result;
        }
    }

    //CHALLENGE 10: Is a number prime?
    public static class Challenge10
    {
        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }

    //CHALLENGE 11: Equal Sides Of An Array
    public class Challenge11
    {
        public static int FindEvenIndex(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            int left = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int right = total - left - arr[i];
                if (left == right)
                {
                    return i;
                }
                left += arr[i];
            }
            return -1;
        }
    }

    //CHALLENGE 12: Product of consecutive Fib numbers
    public class Challenge12
    {
        public static ulong[] productFib(ulong prod)
        {
            ulong a = 0;
            ulong b = 1;
            while (a * b < prod)
            {
                ulong next = a + b;
                a = b;
                b = next;
            }
            if (a * b == prod)
            {
                return new ulong[] { a, b, 1 };
            }
            return new ulong[] { a, b, 0 };
        }
    }

    //CHALLENGE 13: Persistent Bugger
    public class Challenge13
    {
        public static int Persistence(long n)
        {
            int count = 0;
            while (n >= 10)
            {
                long product = 1;
                while (n > 0)
                {
                    product *= n % 10;
                    n /= 10;
                }
                n = product;
                count++;
            }
            return count;
        }
    }

    //CHALLENGE 14: Consecutive strings
    public class Challenge14
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
                return "";
            string result = "";
            int maxLength = 0;
            for (int i = 0; i <= strarr.Length - k; i++)
            {
                string current = "";
                for (int j = 0; j < k; j++)
                {
                    current += strarr[i + j];
                }
                if (current.Length > maxLength)
                {
                    maxLength = current.Length;
                    result = current;
                }
            }
            return result;
        }
    }

    //CHALLENGE 15: Build Tower
    public class Challenge15
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] result = new string[nFloors];
            for (int i = 0; i < nFloors; i++)
            {
                int spaces = nFloors - i - 1;
                int stars = 2 * i + 1;
                result[i] = new string(' ', spaces) + new string('*', stars) + new string(' ', spaces);
            }
            return result;
        }
    }

    //CHALLENGE 16: Twice linear
    public class Challenge16
    {
        public static int DblLinear(int n)
        {
            int[] u = new int[n + 1];
            u[0] = 1;
            int i = 0, j = 0;
            for (int k = 1; k <= n; k++)
            {
                int y = 2 * u[i] + 1;
                int z = 3 * u[j] + 1;
                u[k] = Math.Min(y, z);
                if (u[k] == y) i++;
                if (u[k] == z) j++;
            }
            return u[n];
        }
    }

    //CHALLENGE 17: Maximum subarray sum
    public static class Challenge17
    {
        public static int MaxSequence(int[] arr)
        {
            int current = 0, max = 0;
            foreach (int x in arr)
            {
                current = Math.Max(0, current + x);
                max = Math.Max(max, current);
            }
            return max;
        }
    }

    //CHALLENGE 18: What's a Perfect Power anyway?
    public class Challenge18
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            for (int k = 2; k <= 30; k++)
            {
                int m = (int)Math.Round(Math.Pow(n, 1.0 / k));
                if (m > 1 && Math.Pow(m, k) == n) return (m, k);
            }
            return null;
        }
    }

    //CHALLENGE 19: Perimeter of squares in a rectangle
    public class Challenge19
    {
        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger sum = 0;
            BigInteger a = 1, b = 1;
            for (BigInteger i = 0; i <= n; i++)
            {
                sum += a;
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }
            return sum * 4;
        }
    }

    //CHALLENGE 20: Sum Strings as Numbers
    public static class Challenge20
    {
        public static string sumStrings(string a, string b)
        {
            string result = "";
            int i = a.Length - 1, j = b.Length - 1, carry = 0;
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int c = 0, d = 0;
                if (i >= 0) c = a[i] - '0';
                if (j >= 0) d = b[j] - '0';
                int sum = c + d + carry;
                result = (sum % 10) + result;
                carry = sum / 10;
                i--;
                j--;
            }
            result = result.TrimStart('0');
            if (result == "") return "0";
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            // CHALLENGE 1: Stop gninnipS My sdroW!
            Console.WriteLine(Challenge1.SpinWords("Hey fellow warriors"));

            // CHALLENGE 2: Validate a PIN code
            Console.WriteLine(Challenge2.ValidatePin("1234"));

            // CHALLENGE 3: Growth of a Population
            Console.WriteLine(Challenge3.NbYear(1500, 5, 100, 5000));

            // CHALLENGE 4: Get the Middle Character
            Console.WriteLine(Challenge4.GetMiddle("testing"));

            // CHALLENGE 5: Highest and Lowest
            Console.WriteLine(Challenge5.HighAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6"));

            // CHALLENGE 6: Shortest Word
            Console.WriteLine(Challenge6.FindShort("bitcoin take over the world maybe who knows perhaps"));

            // CHALLENGE 7: Bouncing Balls
            Console.WriteLine(Challenge7.bouncingBall(3, 0.66, 1.5));

            // CHALLENGE 8: Playing with digits
            Console.WriteLine(Challenge8.digPow(89, 1));

            // CHALLENGE 9: Highest Scoring Word
            Console.WriteLine(Challenge9.High("man i need a taxi up to ubud"));

            // CHALLENGE 10: Is a number prime?
            Console.WriteLine(Challenge10.IsPrime(7));

            // CHALLENGE 11: Equal Sides Of An Array
            Console.WriteLine(Challenge11.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));

            // CHALLENGE 12: Product of consecutive Fib numbers
            ulong[] fib = Challenge12.productFib(4895);
            Console.WriteLine($"[{fib[0]}, {fib[1]}, {(fib[2] == 1 ? "True" : "False")}]");

            // CHALLENGE 13: Persistent Bugger
            Console.WriteLine(Challenge13.Persistence(39));

            // CHALLENGE 14: Consecutive strings
            Console.WriteLine(Challenge14.LongestConsec(
                new string[] { "zone", "abigail", "theta", "form", "libe", "zas" }, 2));

            // CHALLENGE 15: Build Tower
            string[] tower = Challenge15.TowerBuilder(3);
            Console.WriteLine(string.Join("\n", tower));

            // CHALLENGE 16: Twice linear
            Console.WriteLine(Challenge16.DblLinear(10));

            // CHALLENGE 17: Maximum subarray sum
            Console.WriteLine(Challenge17.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));

            // CHALLENGE 18: What's a Perfect Power anyway?
            var pp = Challenge18.IsPerfectPower(4);
            Console.WriteLine(pp.HasValue ? $"({pp.Value.Item1}, {pp.Value.Item2})" : "null");

            // CHALLENGE 19: Perimeter of squares in a rectangle
            Console.WriteLine(Challenge19.perimeter(5));

            // CHALLENGE 20: Sum Strings as Numbers
            Console.WriteLine(Challenge20.sumStrings("123", "456"));
        }
    }
}
