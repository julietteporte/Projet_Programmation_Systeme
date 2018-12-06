
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public interface Observable {







        /// <summary>
        /// @param observer
        /// </summary>
        void Attach(void observer);

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