
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Server : IPersonne , IMobile, Observable, Observer {

        public Server() {
        }

        public int NbrDishMax;

        public list<Dish> ActualDishes;




        /// <summary>
        /// @return
        /// </summary>
        public void Serve() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void ClearTable() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddDish() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveDish() {
            // TODO implement here
            return null;
        }

    }
}