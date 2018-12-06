
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance{
    public class DatabaseContext {

        public DatabaseContext() {
        }

        public DbSet<Ingredient> Ingredient;


        /// <summary>
        /// @param optionBuilder 
        /// @return
        /// </summary>
        protected void OnConfiguring(DbContextOptionsBuilder optionBuilder) {
            // TODO implement here
            return null;
        }

        /// <summary>
        /// @param ModelBuilder 
        /// @return
        /// </summary>
        protected void OnModelCreating(ModelBuilder ModelBuilder) {
            // TODO implement here
            return null;
        }

    }
}