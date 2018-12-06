
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Order {

        public Order() {
        }

        public int Id;

        public Table Table;

        public float TotalPrice;

        public List<Recipe> Recipes = new List<Recipe>();

        public Customer Customer;


        /// <summary>
        /// @return
        /// </summary>
        public void AddRecipe() {
            // TODO implement here
            
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveRecipe() {
            // TODO implement here
            
        }

    }
}