﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Models
{
    [Serializable]

    public class Podcast
    {
        public int id;

        public string? Url { get; set; }
        public string? Titel { get; set; }
        public Kategori? PodcastKategori { get; set; }
        public List<Avsnitt>? Avsnitt { get; set; }
        public string? Beskrivning { get; set; }
        // Andra relevanta egenskaper...

        public Podcast()
        {
            Avsnitt = new List<Avsnitt>();
        }

    }
}