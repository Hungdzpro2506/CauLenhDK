using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số nguyên không âm (tối đa 3 chữ số): ");
        string input = Console.ReadLine();
        int number;

        // Kiểm tra định dạng input
        if (int.TryParse(input, out number) && number >= 0 && number <= 999)
        {
            string words = "";

            // Xử lý hàng trăm
            if (number >= 100)
            {
                switch (number / 100)
                {
                    case 1: words += "one hundred"; break;
                    case 2: words += "two hundred"; break;
                    case 3: words += "three hundred"; break;
                    case 4: words += "four hundred"; break;
                    case 5: words += "five hundred"; break;
                    case 6: words += "six hundred"; break;
                    case 7: words += "seven hundred"; break;
                    case 8: words += "eight hundred"; break;
                    case 9: words += "nine hundred"; break;
                }
                number %= 100;

                if (number > 0)
                    words += " and ";
            }

            // Xử lý hàng chục và đơn vị
            if (number >= 20)
            {
                switch (number / 10)
                {
                    case 2: words += "twenty"; break;
                    case 3: words += "thirty"; break;
                    case 4: words += "forty"; break;
                    case 5: words += "fifty"; break;
                    case 6: words += "sixty"; break;
                    case 7: words += "seventy"; break;
                    case 8: words += "eighty"; break;
                    case 9: words += "ninety"; break;
                }
                number %= 10;

                if (number > 0)
                    words += " ";
            }
            else if (number >= 10)
            {
                switch (number)
                {
                    case 10: words += "ten"; break;
                    case 11: words += "eleven"; break;
                    case 12: words += "twelve"; break;
                    case 13: words += "thirteen"; break;
                    case 14: words += "fourteen"; break;
                    case 15: words += "fifteen"; break;
                    case 16: words += "sixteen"; break;
                    case 17: words += "seventeen"; break;
                    case 18: words += "eighteen"; break;
                    case 19: words += "nineteen"; break;
                }
                number = 0; // Đặt về 0 vì đã xử lý xong
            }

            // Xử lý đơn vị
            if (number > 0)
            {
                switch (number)
                {
                    case 1: words += "one"; break;
                    case 2: words += "two"; break;
                    case 3: words += "three"; break;
                    case 4: words += "four"; break;
                    case 5: words += "five"; break;
                    case 6: words += "six"; break;
                    case 7: words += "seven"; break;
                    case 8: words += "eight"; break;
                    case 9: words += "nine"; break;
                }
            }

            Console.WriteLine($"{input} in English: {words}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên không âm có tối đa 3 chữ số.");
        }
    }
}