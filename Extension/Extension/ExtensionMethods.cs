using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    internal static class ExtensionMethods
    {

        public static bool CustomContains(this string str,string contain)
        {
            StringBuilder sb = new StringBuilder();

            bool check=false;

            int tempI = 0;
            int tempJ = 0;

            for (int i = 0; i < contain.Length; i++)
            {
                
                for (int j = 0; j < str.Length; j++)
                {
                    Here:

                    if (contain[i] == str[j])
                    {
                        sb.Append(str[j]);
                        check = true;
                    }

                    if (check)
                    {
                        while (check)
                        {
                            tempI = i + 1;
                            tempJ = j + 1;

                            while(tempI<contain.Length && tempJ < str.Length)
                            {
                                if(contain[tempI] == str[tempJ])
                                {
                                    sb.Append(str[tempJ]);
                                    tempI++;
                                    tempJ++;
                                }
                                else
                                {
                                    sb = new StringBuilder("");
                                    check = false;
                                    j++;
                                    goto Here;
                                }
                            }

                            if(sb.ToString() == contain)
                            {
                                return true;
                            }
                            return false;
                        }
                        
                    }

                }
            }

            return false;
        }

        public static bool CustomContains(this string str,char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ch)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsPrime(this int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
            }

            if (count > 2)
            {
                return false;
            }
            return true;
        }
    }
}
