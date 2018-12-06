
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public interface IPrepare {

        /// <summary>
        /// @return
        /// </summary>
        void Peel();

        /// <summary>
        /// @return
        /// </summary>
        void Trim();

        /// <summary>
        /// @return
        /// </summary>
        void Cut();

    }
}