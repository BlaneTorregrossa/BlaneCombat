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
        public Party EnemyPartty;
        public Character ActiveCharacter;
        public List<Character> Fighters;

        /// <summary>
        /// News up the Fighters list
        /// </summary>
        public Combat()
        {

        }

        /// <summary>
        /// Assigns the value of PlayerParty to value of the argument passed in.
        /// Then gets all the Characters in the party and adds them to the List
        /// of Fighters if they are not all ready in the list;
        /// Invokes the SortFighers function
        /// </summary>
        /// <param name="party">PlayerParty = party</param>
        public void SetPlayerParty(Party party)
        {

        }

        /// <summary>
        /// Assigns the value of EnemyParty to value of the argument passed in.
        /// Then gets all the Characters in the party and adds them to the List
        /// of Fighters if they are not all ready in the list;
        /// Invokes the SortFighers function
        /// </summary>
        /// <param name="party">EnemyParty = party</param>
        public void SetEnemyParty(Party party)
        {

        }

        /// <summary>
        /// Sorts the Fighters list by the character's speed.
        /// The Characters should be sorted by fastest speed to slowest speed.
        /// Then assigns the active character the value of the first Character in
        /// the Fighters list.
        /// </summary>
        private void SortFighters()
        {

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

        }
    }
}
