﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; }
        //Alternative way for initialisation
        //public List<Person> TeamMembers { get; set; } = new List<Person>();


        public string TeamName { get; set; }

        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();

        }
    }
}
