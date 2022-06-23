using System;
using System.Linq;
using System.Text;

namespace CoxAutomotiveNgozika
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var str = "Smooth Operator At Nightfall detention4Lift";
            var strDash = str.Replace(' ', '-');
            var strObj = strDash.Split('-');
            foreach (var item in strObj)
            {
                if (item.Length > 2)
                {
                    //TODO Split By Numeric
                    for (int i = 0; i < item.Length; i++)
                    {
                        char c = item[i];
                        switch (c)
                        {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                
                                break;
                           
                            default:
                           
                                break;
                        }
                    }
                    //END TODO

                    var itemArray = new char[item.Length - 2];

                    for (int i = 1; i <= item.Length - 2; i++)
                    {
                        itemArray[i-1] = item[i];
                    }

                    var distinctItemArray = itemArray.Distinct();

                    var newWord = item[0] + distinctItemArray.Count().ToString() + item[item.Length - 1] + " ";
                   
                    stringBuilder.Append(newWord);
                }
                else
                {
                    stringBuilder.Append(item + " ");
                }

            }

            Console.WriteLine(stringBuilder.ToString().TrimEnd().Replace(' ','-'));
        }
    }
}
