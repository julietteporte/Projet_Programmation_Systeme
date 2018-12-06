
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Ingredient : Observer, Observable {

        public Ingredient() {
        }

        public int Id;

        public string Name;

        public int TimeLifeMinutes;


    }
}