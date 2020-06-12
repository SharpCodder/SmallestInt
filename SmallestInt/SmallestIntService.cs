using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SmallestInt
{
    public class SmallestIntService
    {
        public int Get(ArrayList arrayList)
        {
            if (arrayList == null)
                throw new NullReferenceException("No array list passed");

            int minimumInt = int.MaxValue;
            bool intFound = false;
            foreach (var item in arrayList)
            {
                switch (item)
                {
                    case int val:
                        if (val < minimumInt)
                        {
                            minimumInt = val;
                            intFound = true;
                        }
                        break;
                    case object _:
                        break;

                }
            }
            
            return intFound ? minimumInt : throw new Exception("ArrayList contained no ints");
        }
    }
}
