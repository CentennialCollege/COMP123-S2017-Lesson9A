using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 13, 2017
 * Description: This is an Interface that defines a Karam Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - Created IHasKarma interface
 */

namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is the IHasKarma Interface
    /// </summary>
    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}