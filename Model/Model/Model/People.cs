
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public abstract class People : PartChief, IModel {

        public People() {
        }

        public int Id;

        /// <summary>
        /// @return
        /// </summary>
        public void Wait() {
            // TODO implement here
            return null;
        }

    }
}