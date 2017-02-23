using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaneCombat
{
    class Combat
    {
        public Party PlayerParty;
        public Party EnemyParty;
        public Character ActiveCharacter;
        public List<Character> Fighters;

        /// <summary>
        /// News up the Fighters list
        /// </summary>
        public Combat()
        {
            Fighters = new List<Character>();
        }

        /// <summary>
        /// Assigns the value of PlayerParty to value of the argument passed in.
        /// Then gets all the Characters in the party and adds them to the List
        /// of Fighters if they are not already in the list;
        /// Invokes the SortFighers function
        /// </summary>
        /// <param name="party">PlayerParty = party</param>
        public void SetPlayerParty(Party party)
        {
            if (EnemyParty != party)
            {
                PlayerParty = party;
                foreach (var c in PlayerParty.PartyMembers)
                {
                    if(!Fighters.Contains(c))
                        Fighters.Add(c);
                }
            }
            SortFighters();
        }

        /// <summary>
        /// Assigns the value of EnemyParty to value of the argument passed in.
        /// Then gets all the Characters in the party and adds them to the List
        /// of Fighters if they are not already in the list;
        /// Invokes the SortFighers function
        /// </summary>
        /// <param name="party">EnemyParty = party</param>
        public void SetEnemyParty(Party party)
        {
            if (PlayerParty != party)
            {
                EnemyParty = party;
                foreach (var c in EnemyParty.PartyMembers)
                {
                    if (!Fighters.Contains(c))
                        Fighters.Add(c);
                }
            }
            SortFighters();
        }

        /// <summary>
        /// Sorts the Fighters list by the character's speed.
        /// The Characters should be sorted by fastest speed to slowest speed.
        /// Then assigns the active character the value of the first Character in
        /// the Fighters list.
        /// </summary>
        private void SortFighters()
        {
            for(int i = 0; i < Fighters.Count(); i++)
            {
                for(int j = 0; j < Fighters.Count(); j++)
                {
                    if(Fighters[i] != Fighters[j])
                    {
                        if(Fighters[i].Speed < Fighters[j].Speed)
                        {
                            Character temp = Fighters[i];
                            Fighters[i] = Fighters[j];
                            Fighters[j] = temp;
                        }
                    }
                }
            }
            ActiveCharacter = Fighters.First();
        }

        /// <summary>
        /// Iterates through the list and sets the value of ActiveCharacter to the 
        /// value of the next Character in the list Fighters. If the current 
        /// Character is equal to the last index in the list CurrentFighter equals
        /// the first idex.
        /// If the fighter is dead go to the next alive Charcter.
        /// </summary>
        public void SetActiveCharacter()
        {
            ActiveCharacter = (ActiveCharacter != Fighters.Last()) ? 
                ActiveCharacter = Fighters[Fighters.IndexOf(ActiveCharacter) + 1] : 
                ActiveCharacter = Fighters.First();
        }
    }
}
