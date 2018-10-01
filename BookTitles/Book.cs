using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTitles
{
    public class Book
    {
        private string elefant;

        public string Title
        {
            get
            {
            return elefant;
            }
            set
            {
            elefant = value;
            char hmm;
            string rest;
            string newword = "";
            string numbers = "1234567890";
            string[] splitter = elefant.Split(' ');
             int i;
             for (i=0; i<splitter.Length; i++)
                {
                    if (char.IsLower(splitter[i][0]) || numbers.Contains(splitter[i][0]))
                    {   
                        if (splitter[i] == "the" || splitter[i] == "an" || splitter[i] == "a" ||  splitter[i] == "and" || splitter[i] == "in" || splitter[i] == "of")
                        {
                        hmm = char.ToLower(splitter[i][0]);
                        }
                        else
                        {
                        hmm = char.ToUpper(splitter[i][0]);
                        }
                        if (splitter[0] == "the")
                        {
                        hmm = char.ToUpper(splitter[0][0]);
                        }
                        rest = splitter[i].Substring(1);
                        splitter[i] = hmm + rest;
                        newword = newword + splitter[i] + " ";
                    }
                }
                elefant = newword.Trim();
            }
        }
    }
}
