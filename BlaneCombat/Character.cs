using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaneCombat
{
    class Character : iDamageable, iDamager
    {
        /// <summary>
        /// Region that houses all fields associated with this object
        /// </summary>
        #region Fields
        public string Name;
        public int Health;
        public int Strength;
        public int Speed;
        public iDamageable Target;
        #endregion

        /// <summary>
        /// Region that houses all the object constructors for this object
        /// </summary>
        #region Constructors

        ///<summary>
        ///Assigns defaulat values to all fields associated with the Character object
        ///except for the Target field
        ///</summary>       
        public Character()
        {
            
        }

        /// <summary>
        /// Assigns the values of the passed arguments to its assocaited field.
        /// Refrence the param tags below to see what arguments should be assigned 
        /// to each field.
        /// </summary>
        /// <param name="name">Name = name</param>
        /// <param name="health">Health = health</param>
        /// <param name="strength">Strength = strength</param>
        /// <param name="speed">Speed = speed</param>
        public Character(string name, float health, float strength, float speed)
        {

        }
        #endregion

        /// <summary>
        /// Assigns the value of Target the value of the argument passed in.
        /// The value of Target will only be assigned if the character passed in
        /// is alive and the current instance of the Character class is alive.
        /// </summary>
        /// <param name="target">Value we are trying to assign Target to</param>
        public void SetTarget(Character target)
        {

        }

        /// <summary>
        /// Returns true if the current instance of the class that invokes the
        /// function Health is less or equal to 0. Otherwist the character is still
        /// alive and the function should return false.
        /// </summary>
        public bool IsDead()
        {
            return false;
        }

        /// <summary>
        /// Modifies the current intances health by the amount paassed as an
        /// argument
        /// </summary>
        /// <param name="amount">Amount of damage the character has taken</param>
        public void TakeDamage(int amount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Invokes the TakeDamage function from the current target of the instance
        /// </summary>
        public void DoDamage()
        {
            throw new NotImplementedException();
        }
    }
}
