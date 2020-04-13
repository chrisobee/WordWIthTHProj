using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordWithTH
{
    class SubstringIsolater
    {
        public string SubstringToFind { get; set; }
        List<string> words;
        public SubstringIsolater(string substringToFind)
        {
            SubstringToFind = substringToFind.ToLower();
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }

        public List<string> ReturnStringsContainingSubstring()
        {
            var wordsContainingSubstring = words.Where(s => s.Contains(SubstringToFind)).ToList();
            return wordsContainingSubstring;
        }
    }
}
