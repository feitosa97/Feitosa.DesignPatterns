using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Notes
{
    class MusicalNote
    {
        private static IDictionary<string, INote> notes = new Dictionary<string, INote>()
        {
            {"do", new Do() },
            {"re", new Re() },
            {"mi", new Mi() },
            {"fa", new Fa() },
            {"sol", new Sol() },
            {"la", new La() },
            {"si", new Si() },
        };

        public INote Get(string note)
        {
            return notes[note];
        }
    }
}
