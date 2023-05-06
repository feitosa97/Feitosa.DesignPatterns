using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns2.Notes
{
    internal class Piano
    {
        public void Beep(IList<INote> music)
        {
            foreach(var note in music)
            {
                Console.Beep(note.Frequence, 300);
            }
        }
    }
}
