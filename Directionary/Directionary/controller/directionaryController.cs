using services;
using System;
using System.Collections;
 namespace controller
{
    public class directionaryController
    {
        public ArrayList AddDirect(Object direction)
        {
            AddDirectServices addDirect = new AddDirectServices();
            return addDirect.AddDirect(direction);
        }
    }
}