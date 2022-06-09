using System;
using System.Collections;
using entity;

namespace services
{
    public class AddDirectServices{

        
        public static void Demo()
        {
            ArrayList direct = new ArrayList();
            Directionary directionary = new Directionary();
            direct.AddRange((ICollection)directionary);
        }

            public ArrayList AddDirect(object direction)
        {
            ArrayList arrayList = new ArrayList();
            Directionary directionary = new Directionary();
            arrayList.AddRange((ICollection)directionary);

            
             arrayList.Add(direction);
            return arrayList;
        }
    }
}