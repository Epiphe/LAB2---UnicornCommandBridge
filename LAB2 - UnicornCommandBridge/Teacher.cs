﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Teacher : Användare, ITeacher
    {

        int sallery = 0;

        public Teacher(string användarId, string namn) : base(användarId, namn)
        {

        }
        // Vet inte riktitgt hur vi ska göra denhär just nu tbh, behöver tänka lite
        public int UppdateSalery ()
        {
            int ansv = 150;
            int other = 100;

            foreach (Kurs kurs in Form1.kurser)
            {
                foreach (Teacher teach in kurs.larare)
                {

                }
                if (this.användarId == kurs.AnsvLarare.användarId)
                {
                    sallery = sallery + ansv;
                }

                foreach (Teacher teach in kurs.larare)
                {

                    if (this.användarId == teach.användarId)
                    {
                        sallery = sallery + other;
                    }

                }

            }

            return sallery;
        }

        public override string ToString()
        {
            return användarId + " " + namn;
        }
    }
}
