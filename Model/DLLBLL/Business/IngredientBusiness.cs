
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business{
    public class IngredientBusiness {

        public IngredientBusiness() {
        }

        public int Id;

        public string Name;

        public int TimeLifeMinutes;

        public IngredientTypeDAO IngredientTypeId;

    }
}