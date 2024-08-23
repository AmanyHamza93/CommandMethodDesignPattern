using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandMethodDesignPattern
{
    public class Invoker
    {
        private List<IExecute> arrayList = new List<IExecute>();
        public Invoker()
        {
            arrayList.Add(new ExitOrder());
            arrayList.Add(new FileOrder());
            arrayList.Add(new PrintOrder());
        }
        public string GetCommand(string order)
        {
            foreach (var item in arrayList)
            {
                if (item.Command() == order)
                {
                    return item.Command();
                }
            }
            return null;
        }
    }
}
