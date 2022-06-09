using System;
using System.Collections;
using entity;

namespace services
{
    public class AddDirect{

            public string AddDirect(ArrayList<directionary> direction)
        {
             ArrayList<directionary> arrayList = new ArrayList();  
             arrayList.Add(direction);
            return arrayList;
        }
    }
}