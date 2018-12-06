
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public interface ICustomer {

        string Taste { get; set; }

        int PresenceTimeMinute { get; set; }

        int Solicitation { get; set; }

        bool IsReserved { get; set; }

        /// <summary>
        /// @return
        /// </summary>
        void Eat();

    }
}