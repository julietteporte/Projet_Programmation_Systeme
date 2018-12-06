
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class HotelMaster : Personne {

        public HotelMaster() {
        }

        private static HotelMaster uniqueInstance;

        public list<Rank_chief> RankChieves;

        public list<Customer> WaitingCustomers;

        public list<Customer> BuyingCustomers;

        public float Wallet;






        private void HotelMaster() {
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
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void Welcome() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AssignTable() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddRankChief() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveRankChief() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddWaitingCustomer() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveWaitingCustomer() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddBuyingCustomer() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveBuyingCustomer() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void CollectMoney() {
            // TODO implement here
            return null;
        }

    }
}