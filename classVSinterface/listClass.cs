using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classVSinterface
{
    class listClass
    {
        private int indexFrom;
        public int _indexFrom
        {
            get
            {
                return indexFrom;
            }
            set
            {
                indexFrom = value;
            }
        }

        private int indexTo;
        public int _indexTo
        { 
            get
            {
                return indexTo;
            }
            set
            {
                indexTo = value;
            }
        }

        public IList<int> testList = new List<int>();

        //public void listInit(IList<int> testList)
        public void listInit(int indexFrom, int indexTo)
        {
            IList<int> returnList = new List<int>();

            testList.Add(0);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);


            for (int index = indexFrom; index <= indexTo; index++)
            {
                //returnList.Add(testList);
                //Console.WriteLine(index);
                Console.WriteLine(testList[index]);
            }
            //var t = testList[8];
            //Console.WriteLine(t);

            //string stringList = returnList.ToString();
            //Console.WriteLine(stringList);


            return;
        }


    }
}
