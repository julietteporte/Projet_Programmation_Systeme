
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IObject {

    string Color { get; set; }

    string Form { get; set; }

    Position pos(int;int) ;

    int Height { get; set; }

    int Length { get; set; }

    int Index { get; set; }

}