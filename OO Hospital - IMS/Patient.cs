﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Patient : Person
    {
        public string Problem { get; set; }
        public string Treatment { get; set; }

        private Data _data = new Data();

        public Patient(DateOnly birth, string name, string problem) : base(birth,name)
        {
            this.Problem = problem;
            this.Treatment = String.Empty;
            // this.Name = name;
            // this.Birth = birth;
            // dit kan ook maar waarom zouden we dat doen? 
            // we hergebruiken de code die we reeds schreven
            // basis van OO!!

            ID = _data.InsertPatient(this);
        }

        public Patient(int id, DateOnly birth, string name, string problem, string treatment) : base(birth, name)
        {
            this.Problem = problem;
            this.Treatment = treatment;
            this.ID = id;
        }

        public bool SetTreatment(string treatment)
        {
            this.Treatment = treatment;
            return _data.UpdatePatient(this);
        }
        
        public override string ToString()
        {
            return $"Patient {Name} born on {Birth} has {Problem} and is treated with {Treatment}";
        }

    }
}
