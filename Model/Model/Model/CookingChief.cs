
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class CookingChief : People , Observer {

        public CookingChief() {
        }

        private static CookingChief uniqueInstance;

        public list<Order> Order;

        public list<Part_chief> PartChieves;






        private void CookingChief() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public static CookingChief getInstance() {
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

        /// <summary>
        /// @return
        /// </summary>
        public void RegroupOrder() {
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
        public void AddPartiChief() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemovePartChief() {
            // TODO implement here
            return null;
        }

    }
}