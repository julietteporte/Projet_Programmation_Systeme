
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Recipe : Observable, Observer {

        public Recipe() {
        }

        public int Id;

        public float Price;

        public list<Ingredient> List_ingredients;

        public list<Material> List_materials;

        public string RecipeName;

        public list<string> Categories;

        public bool IsAvailable;













        /// <summary>
        /// @return
        /// </summary>
        public void AddIngredient() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveIngredient() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void AddMaterial() {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void RemoveMaterial() {
            // TODO implement here
            return null;
        }

    }
}