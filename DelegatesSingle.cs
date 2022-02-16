using System;

namespace DelegatesDemo
{
    public class DelegatesSingle
    {
        delegate void DelegatesOperations(int x, int y) ;

        public void Delegates()
        {
            DelegatesOperations[] obj ={
                new DelegatesOperations(Operations.Add),
                new DelegatesOperations(Operations.Multiplication)
            };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2,6);
                obj[i](4,5);
            }
        }
    }
}