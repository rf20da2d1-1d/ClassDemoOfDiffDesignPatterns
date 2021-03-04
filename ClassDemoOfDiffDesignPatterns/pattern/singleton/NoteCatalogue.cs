using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.singleton
{
    class NoteCatalogue
    {
        /*
         * Singleton
         */
        // trin 1 private constructor  
        private NoteCatalogue()
        {
            this.notes = new List<string>()
            {
                "note1", "note2", "and note3"
            };
        }
        // trin 2
        private static NoteCatalogue _instance = new NoteCatalogue();

        // trin 3
        public static NoteCatalogue Instance => _instance;

        /*
         * Singleton slut
         */



        private List<String> notes;

        public List<string> Notes => new List<string>(notes);



        public void Add(string item)
        {
            notes.Add(item);
        }

        public void Clear()
        {
            notes.Clear();
        }


        public override string ToString()
        {
            String strNotes = String.Join("\n", notes);
            return $"Notes are :\n{strNotes}";
        }
    }
}
