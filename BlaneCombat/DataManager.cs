using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlaneCombat
{
    public static class DataManager<T>
    {
        /// <summary>
        /// Creates or finds a file with the name passed in to the value
        /// of fileName and once the file has been created or found we will
        /// take data stored the value of data and write to the file.
        /// </summary>
        /// <param name="fileName">File we are looking for</param>
        /// <param name="data">Data we are trying to save</param>
        public static void Serialize(string fileName, T data)
        {
            
        }        

        /// <summary>
        /// Will return a new object of the Type of T that it will
        /// create from data it gets in the file it finds based on the value of
        /// the arument passed in.
        /// </summary>
        /// <param name="fileName">File we are looking for our data in</param>
        /// <returns></returns>
        //public static T Deserialize(string fileName)
        //{
        //                 
        //}        
    }
}
