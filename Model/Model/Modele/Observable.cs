
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public interface Observable {


        /// <summary>
        /// @param observer
        /// </summary>
        void Attach(Observer);

        /// <summary>
        /// @return
        /// </summary>
        void Detach();

        /// <summary>
        /// @return
        /// </summary>
        void Notify();

    }
}