using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaneCombat
{
    class Party
    {
        #region Fields
        public List<Character> PartyMembers;
        int PartyCapacity;
        #endregion

        #region Constructors
        /// <summary>
        /// News the PartyMembers list so that it is no longer null
        /// Sets a default value for PartyCapacity
        /// </summary>
        public Party()
        {
            PartyMembers = new List<Character>();
            PartyCapacity = 2;
        }

        /// <summary>
        /// News up the PartyMembers list and then assigns the value of PartyCapacity
        /// the value of the passed argument
        /// </summary>
        /// <param name="partyCapacity">PartyCapacity = partyCapacity</param>
        public Party(int partyCapacity)
        {
            PartyMembers = new List<Character>();
            PartyCapacity = partyCapacity; 
        }
        #endregion

        /// <summary>
        /// Tries to add a new character to the party if the character is
        /// alive and the Party is not at max capacity
        /// </summary>
        /// <param name="partyMember"></param>
        public void AddPartyMember(Character partyMember)
        {
            if (!partyMember.IsDead() && PartyMembers.Count() < PartyCapacity)
                PartyMembers.Add(partyMember);
        }
    }
}
