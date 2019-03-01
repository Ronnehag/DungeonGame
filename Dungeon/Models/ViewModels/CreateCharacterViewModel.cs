using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameLogic.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dungeon.Models.ViewModels
{
    public class CreateCharacterViewModel
    {
        public string Name { get; set; }
        public SelectList Races { get; set; }
        public Enums.Race Race { get; set; }
        public Enums.Gender Gender { get; set; }

        public void FillRaceList()
        {
            var races = from Enums.Race r in Enum.GetValues(typeof(Enums.Race))
                select new
                {
                    ID = (int) r,
                    Name = r.ToString()
                };
            Races = new SelectList(races, "ID", "Name");
        }
    }
}
