using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTNLatin
{
    class Verbs
    {
        private int conjugationNumber;
        private int principalPart;
        private string infinitive;
        private string infinitiveCut;           // The infinitive w/out the last three letters
        private string inputString;
        private string verbEnding;
        private bool isInputInfinitive;
        private string[] personEndings = new string[6] { "o", "s", "t", "mus", "tis", "nt" };         // Array 'personEndings' of size 7
        
        private string[,] conjEndings = new string[5,4]
            {
                {"o", "are","avi", "atum"},
                {"eo", "ere", "ui", "itum"},
                {"o", "ere", "i", "tum"},
                {"io", "ere", "i", "tum"},
                {"io", "ire", "ivi", "itum"}
            };          // Two-Dimensional array 'conjEndings' (5 by 4)

        enum infinitiveEndings { are, ere, ire };
        public Verbs()
        {
            //TODO
        }

        public void initialize(int conjNum, string verbEnded, string verb, string infin, int principalP)
        {
            conjugationNumber = conjNum;
            verbEnding = verbEnded;
            inputString = verb;
            infinitive = infin;
            principalPart = principalP;
            isInputInfinitive = true;    // As of now, it will only accept the infinitive as an input
            //detectVerbType();          // Implement later, only regular is supported now
            infinitiveCut = infin.Substring(0, infin.Length - 3);
        }
        public string conjugate(string personAdd, string principalVals)
        {
            //TODO
            switch (infinitiveCut)
            {
                case "are":
                    if (principalPart == 0)
                    {
                        infinitiveCut += personAdd + principalVals;
                    }
                    else
                    {
                        infinitiveCut += "a" + personAdd + principalVals;
                    }
                    break;
                default:
                    infinitiveCut += personAdd + principalVals;
                    break;
            }
            return infinitiveCut;
        }

        public string searchMultiArray(int arrayIndexOne, int arrayIndexTwo)
        {
            return conjEndings[arrayIndexOne, arrayIndexTwo];
        }

        public string searchArray(int arrayIndexOne)
        {
            return personEndings[arrayIndexOne];
        }
    }
}
