﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCompanion.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string UidUser { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Categorii { get; set; }
        public int NrPag { get; set; }
        public int Progres { get; set; }

        public Book(int id, string uiduser, string title, string autor, string categorii, int nrPag, int progres) 
        {
            Id = id;
            UidUser = uiduser;
            Title = title;
            Autor = autor;
            Categorii = categorii;
            NrPag = nrPag;
            Progres = progres;
        }
    }
}