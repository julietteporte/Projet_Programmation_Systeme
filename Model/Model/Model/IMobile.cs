
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public interface IMobile {

        Square ActualSquare { get; set; }

        Table ActualTable { get; set; }



        /// <summary>
        /// @return
        /// </summary>
        void Move();

    }
}