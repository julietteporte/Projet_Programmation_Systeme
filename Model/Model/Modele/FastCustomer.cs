
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class FastCustomer : ICustomer {

        public FastCustomer() {
        }

        public string Taste { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PresenceTimeMinute { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Solicitation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsReserved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}