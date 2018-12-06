
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public abstract class PartChief : People {

        public PartChief() {
        }

        public ClerkKitchen Clerk;

        public list<Orders> Orders;




        /// <summary>
        /// @return
        /// </summary>
        public void OrderClerk() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public Dish Cook() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddOrder() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveOrder() {
            // TODO implement here
            return null;
        }

    }
}