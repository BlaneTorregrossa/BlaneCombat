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
        /// News the PartyMemebers list so that it is no longer null
        /// Sets a default value for PartyCapacity
        /// </summary>
        public Party()
        {

        }

        /// <summary>
        /// News up the PartyMembers list and then assigns the value of PartyCapacity
        /// the value of the passed argument
        /// </summary>
        /// <param name="partyCapacity">PartyCapacity = partyCapacity</param>
        public Party(int partyCapacity)
        {

        }
        #endregion

        /// <summary>
        /// Tries to add a new character to the party if the character is
        /// alive and the Party is not at max capacity
        /// </summary>
        /// <param name="partyMember"></param>
        public void AddPartyMember(Character partyMember)
        {

        }
    }
}
