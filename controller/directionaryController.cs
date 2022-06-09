using services;
using System;
using System.Collections;
 namespace controller
{
    public class directionaryController
    {
        public void AddDirect(ArrayList<directionary> direction)
        {
            AddDirectServices addDirect = new AddDirectServices();
            return addDirect.AddDirect(direction);
        }
    }
}