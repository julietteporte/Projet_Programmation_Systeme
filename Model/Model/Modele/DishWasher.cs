
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class DishWasher : Observable {

        public DishWasher() {
        }

        public int WashingTime;

        public List<Dish> Dishes = new List<Dish>();

        public int CapacityMax;

        public int DishCount;



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