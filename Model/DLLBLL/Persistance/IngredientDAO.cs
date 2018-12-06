
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance{
    public class IngredientDAO {

        public IngredientDAO() {
        }

        public int Id;

        public string Name;

        public int TimeLifeMinutes;

        public IngredientTypeDAO IngredientTypeId;

    }
}