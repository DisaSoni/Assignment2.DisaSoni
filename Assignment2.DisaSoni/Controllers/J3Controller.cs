using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.DisaSoni.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        /// The minimal number of seconds needed to type in the word
        /// </summary>
        /// <param string = "input">All inputs in a single line seperated by one space " "</param>
        /// <return>A string with time taken for each input</return>
        /// GET api/J2/DiceGame/a aaa aabc -> "Time taken to type the message a is 1" +
        ///									  "Time Taken to type the message aaa is 3" +
        ///									  "Time Taken to type the message aabc is 7"
        [Route("api/J3/Keypad/{inputString}")]
        [HttpGet]
        public string Keypad(string inputString)
        {
            string[] inputs = inputString.Split(' ');
            int inputLen = inputs.Length;
            string res = "";
            for (int i = 0; i < inputLen - 1; i++)
            {
                string input = inputs[i];
                int len = input.Length;
                int ans = 0;
                for (int j = 0; j < len; j++)
                {
                    if (input[j] == 'a' || input[j] == 'd' || input[j] == 'g' || input[j] == 'j' || input[j] == 'm' || input[j] == 'p' || input[j] == 't' || input[j] == 'w')
                    {
                        ans += 1;
                    }
                    if (input[j] == 'b' || input[j] == 'e' || input[j] == 'h' || input[j] == 'k' || input[j] == 'n' || input[j] == 'q' || input[j] == 'u' || input[j] == 'x')
                    {
                        ans += 2;
                    }
                    if (input[j] == 'c' || input[j] == 'f' || input[j] == 'i' || input[j] == 'l' || input[j] == 'o' || input[j] == 'r' || input[j] == 'v' || input[j] == 'y')
                    {
                        ans += 3;
                    }
                    if (input[j] == 's' || input[j] == 'z')
                    {
                        ans += 4;
                    }
                }
                res += "Time taken to type the message " + input + " is " + ans + "\n";
            }
            return res;
        }
    }
}

