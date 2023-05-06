using Feitosa.DesignPatterns2.Factories;
using Feitosa.DesignPatterns2.Notes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Feitosa.DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notes = new MusicalNote();

            var music = new List<INote>()
            {
                notes.Get("do"),
                notes.Get("re"),
                notes.Get("mi"),
                notes.Get("fa"),
                notes.Get("fa"),
                notes.Get("fa")
            };

            var piano = new Piano();

            piano.Beep(music);

        }
    }
}
