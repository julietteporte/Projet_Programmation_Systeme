
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Bar : Observable, Observer {

        private static Bar uniqueInstance;

        public int DirtyDishCount;

        public int ReadyDishCount;

        public int DirtyCapacityMax;

        public int ReadyCapacityMax;

        public List<Dish> DirtyDishes = new List<Dish>();

        public List<Dish> ReadyDishes = new List<Dish>();

        private Bar()
        {
            // TODO implement here
        }


        /// <summary>
        /// @return
        /// </summary>
        public static Bar getInstance() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddReady() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveReady() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddDirty()
        {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveDirty() {
            // TODO implement here
            
        }

    }
}