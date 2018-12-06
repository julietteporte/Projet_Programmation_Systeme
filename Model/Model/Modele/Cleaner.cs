
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Cleaner : People , IPrepare, IPrepare, Observer, Observer {

        public Cleaner() {
        }


        /// <summary>
        /// @return
        /// </summary>
        public void CleanKitchen() {
            // TODO implement here
          
        }

        /// <summary>
        /// @return
        /// </summary>
        public void CleanMaterial() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void FillDishWasher() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void FillLaundryWasher() {
            // TODO implement here
          
        }

        /// <summary>
        /// @return
        /// </summary>
        public void EmptyDishWasher() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void EmptyLaundryWasher() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public Material StoreMaterial() {
            // TODO implement here
           
        }

    }
}