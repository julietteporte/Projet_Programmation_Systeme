
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class HotelMaster : People {

      
        private static HotelMaster uniqueInstance;

        public List<RankChief> RankChieves = new List<RankChief>();

        public List<Customer> WaitingCustomers = new List<Customer>();

        public List<Customer> BuyingCustomers = new List<Customer>();

        public float Wallet;






        private  HotelMaster() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public static HotelMaster getInstance() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void Call() {
            // TODO implement here
          
        }

        /// <summary>
        /// @return
        /// </summary>
        public void Welcome() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AssignTable() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddRankChief() {
            // TODO implement here
          
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveRankChief() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddWaitingCustomer() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveWaitingCustomer() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddBuyingCustomer() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveBuyingCustomer() {
            // TODO implement here
           
        }

        /// <summary>
        /// @return
        /// </summary>
        public void CollectMoney() {
            // TODO implement here
            
        }

    }
}