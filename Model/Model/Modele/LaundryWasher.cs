
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class LaundryWasher : Observable {

        public LaundryWasher() {
        }

        public int WashingTime;

        public List<Material> LaundryCount = new List<Material>();

        public int CapacityMax;



        /// <summary>
        /// @return
        /// </summary>
        public Material Wash() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddLaundry() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveLaundry() {
            // TODO implement here
            
        }

    }
}