
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Customer : ICustomer , IMobile {

        public Customer() {
        }

        public Order Orders;

        public ICustomer Strategy;

        /// <summary>
        /// @return
        /// </summary>
        public int Pay() {
            // TODO implement here
            return 0;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void Eat() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void CallChiefRank() {
            // TODO implement here
            
        }

    }
}