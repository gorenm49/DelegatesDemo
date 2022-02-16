using System;

namespace DelegatesDemo
{
    public class DelegatesMulti
    {
        delegate void DelegatesOperations(int x, int y) ;

        public void DelegatesMul()
        {
            DelegatesOperations obj =Operations.Add;
            obj += Operations.Multiplication;

            obj(2,6);
            obj(4,5);
        }
    }
}