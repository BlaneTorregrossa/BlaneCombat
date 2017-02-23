using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaneCombat
{    
    class FiniteStateMachine<T>
    {
        public Dictionary<string, List<T>> TransitionTable;

        public T CurrentState;

        /// <summary>
        /// News up the TransitonTable dictionary and invokes the
        /// AddStates function;
        /// </summary>
        public FiniteStateMachine()
        {
            TransitionTable = new Dictionary<string, List<T>>();
            AddStates();
        }

        /// <summary>
        /// Loops through an enum that is stored in the value T
        /// and assigns its values in a string format to a key inside
        /// of the TransitionTable dictionary.
        /// </summary>
        private void AddStates()
        {
            //Loops through each value returned bu the Enum.GetValues
            //function. These values are stored in the enum inside T
            foreach(var value in Enum.GetValues(typeof(T))) 
            {
                //Creates a new key inside of the TransitionTable dicitionary
                TransitionTable.Add(value.ToString(), new List<T>());
            }
        }

        /// <summary>
        /// Trys to add a new transition to the TransitionTable only if
        /// the dictionary contains the value of start as a key.        
        /// </summary>
        /// <param name="start">Dictionary key we are looking for</param>
        /// <param name="end">Value we are adding to the value of the key</param>
        public void AddTransiton(string start, T end)
        {

        }

        /// <summary>
        /// Will try to transition to the state passed in as an argument
        /// If the CurrentStates is a valid key in the Dictionary then check
        /// to see if the goal is contained in its list value.
        /// If the transtion to goal is a valid one
        /// CurrentState now equal goal
        /// </summary>
        /// <param name="goal"></param>
        public void TryTransition(T goal)
        {

        }
    }
}
