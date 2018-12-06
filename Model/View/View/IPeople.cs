
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View{
    public interface IPeople {

        string Color { get; set; }

        string Form { get; set; }

        List<int> position;

    }
}