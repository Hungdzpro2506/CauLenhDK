using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can doc: ");
            int SoCanDoc = Convert.ToInt32(Console.ReadLine());
            if (SoCanDoc < 10 && SoCanDoc >= 0)
            {
                string DocHangdonVi = string.Empty;// Đảm bảo biến được khởi tạo
                switch (SoCanDoc)
                {
                    case 0:

                        DocHangdonVi = "zero";
                        break;
                    case 1:
                        DocHangdonVi = "one";
                        break;
                    case 2:
                        DocHangdonVi = "two";
                        break;
                    case 3:
                        DocHangdonVi = "three";
                        break;
                    case 4:
                        DocHangdonVi = "four";
                        break;
                    case 5:
                        DocHangdonVi = "five";
                        break;
                    case 6:
                        DocHangdonVi = "six";
                        break;
                    case 7:
                        DocHangdonVi = "seven";
                        break;
                    case 8:
                        DocHangdonVi = "eight";
                        break;
                    case 9:
                        DocHangdonVi = "nine";

                        break;
                }
                Console.WriteLine(DocHangdonVi);


            }
            else if (SoCanDoc >= 11 && SoCanDoc < 20)
            {
                int Hangdonvi = SoCanDoc - 10;
                switch (Hangdonvi)
                {
                    case 0:
                        Console.WriteLine("ten");
                        break;
                    case 1:
                        Console.WriteLine("eleven");
                        break;
                    case 2:
                        Console.WriteLine("twelve");
                        break;
                    case 3:
                        Console.WriteLine("thirteen");
                        break;
                    case 4:
                        Console.WriteLine("four teen");
                        break;
                    case 5:
                        Console.WriteLine("five teen");
                        break;
                    case 6:
                        Console.WriteLine("six teen");
                        break;
                    case 7:
                        Console.WriteLine("seven teen");
                        break;
                    case 8:
                        Console.WriteLine("eight teen");
                        break;
                    case 9:
                        Console.WriteLine("nine teen");
                        break;

                }

            }
            else if (SoCanDoc >= 20 && SoCanDoc < 100)
            {
                int hangChuc = SoCanDoc / 10;
                int Hangdonvi = SoCanDoc % 10;
                string DocHangChuc = "";
                string DocHangdonVi = "";
                switch (hangChuc)
                {

                    case 2:
                        DocHangChuc = "twenty";
                        break;
                    case 3:
                        DocHangChuc = "thirty";
                        break;
                    case 4:
                        DocHangChuc = "thirty";
                        break;
                    case 5:
                        DocHangChuc = "fifty";
                        break;
                    case 6:
                        DocHangChuc = "sixty";
                        break;
                    case 7:
                        DocHangChuc = "seventy";
                        break;
                    case 8:
                        DocHangChuc = "eighty";

                        break;
                    case 9:
                        DocHangChuc = "ninety";

                        break;
                    default:
                        DocHangChuc = "";
                        break;
                }

                if (Hangdonvi != 0)
                {
                    switch (Hangdonvi)
                    {

                        case 1:
                            DocHangdonVi = "one";
                            break;
                        case 2:
                            DocHangdonVi = "two";
                            break;
                        case 3:
                            DocHangdonVi = "three";
                            break;
                        case 4:
                            DocHangdonVi = "four";
                            break;
                        case 5:
                            DocHangdonVi = "five";
                            break;
                        case 6:
                            DocHangdonVi = "six";
                            break;
                        case 7:
                            DocHangdonVi = "seven";
                            break;
                        case 8:
                            DocHangdonVi = "eight";
                            break;
                        case 9:
                            DocHangdonVi = "nine";
                            break;
                    }
                }

                if (Hangdonvi != 0)
                {
                    Console.WriteLine(DocHangChuc + " " + DocHangdonVi);
                }
                else
                {
                    Console.WriteLine(DocHangChuc);
                }

            }
            else if (SoCanDoc >= 100 && SoCanDoc < 999)
            {
                int hangTram = SoCanDoc / 100;
                int hangChuc = SoCanDoc / 10;
                int Hangdonvi = SoCanDoc % 10;
                string DocHangTram = "";
                string DocHangChuc = "";
                string DocHangdonVi = "";
                switch (hangTram)
                {
                    case 1:
                        DocHangTram = "one";
                        break;
                    case 2:
                        DocHangTram = "two";
                        break;
                    case 3:
                        DocHangTram = "three";
                        break;
                    case 4:
                        DocHangTram = "four";
                        break;
                    case 5:
                        DocHangTram = "five";
                        break;
                    case 6:
                        DocHangTram = "six";
                        break;
                    case 7:
                        DocHangTram = "seven";
                        break;
                    case 8:
                        DocHangTram = "eight";
                        break;
                    case 9:
                        DocHangTram = "nine";
                        break;
                }
                if (hangChuc != 0)
                {
                    switch (hangChuc)
                    {

                        case 1:
                            DocHangChuc = "evelen";//sai nhung chua nghĩ ra
                            break;
                        case 2:
                            DocHangChuc = "twenty";
                            break;
                        case 3:
                            DocHangChuc = "thirty";
                            break;
                        case 4:
                            DocHangChuc = "fourty";
                            break;
                        case 5:
                            DocHangChuc = "fivety";
                            break;
                        case 6:
                            DocHangChuc = "sixty";
                            break;
                        case 7:
                            DocHangChuc = "seventy";
                            break;
                        case 8:
                            DocHangChuc = "eightty";
                            break;
                        case 9:
                            DocHangChuc = "ninety";
                            break;
                    }

                }

                if (Hangdonvi != 0)
                {
                    switch (Hangdonvi)
                    {

                        case 1:
                            DocHangdonVi = "one";
                            break;
                        case 2:
                            DocHangdonVi = "two";
                            break;
                        case 3:
                            DocHangdonVi = "three";
                            break;
                        case 4:
                            DocHangdonVi = "four";
                            break;
                        case 5:
                            DocHangdonVi = "five";
                            break;
                        case 6:
                            DocHangdonVi = "six";
                            break;
                        case 7:
                            DocHangdonVi = "seven";
                            break;
                        case 8:
                            DocHangdonVi = "eight";
                            break;
                        case 9:
                            DocHangdonVi = "nine";
                            break;
                    }
                }
                if (hangChuc != 0)
                {
                    if (Hangdonvi != 0)
                    {
                        Console.WriteLine(DocHangTram + " hundred  and" + DocHangChuc + " " + DocHangdonVi);
                    }
                    else
                    {
                        Console.WriteLine(DocHangTram + " hundred  and" + " " + DocHangChuc);
                    }

                }
                else
                {
                    if (Hangdonvi != 0)
                    {
                        Console.WriteLine(DocHangTram + " hundred  and" + " " + DocHangdonVi);
                    }
                    else
                    {
                        Console.WriteLine(DocHangTram);
                    }
                }
            }
        }
    }
}
