
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class ClerkKitchen : People , IPrepare, IPrepare {

        public ClerkKitchen() {
        }

        public List<Dish> Dish = new List<Dish>();


        /// <summary>
        /// @return
        /// </summary>
        public void RecoverStock() {
            // TODO implement here
       
        }

        /// <summary>
        /// @return
        /// </summary>
        public void BringBar() {
            // TODO implement here
          
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddDish() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveDish() {
            // TODO implement here
            
        }

    }
}