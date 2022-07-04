using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Interface1
    {
        public static void Main()
        {
            Strawberry A = new Strawberry();
            A.bake();
            BlackForest B = new BlackForest();
            B.bake();
            
        }
        
    }
    public interface Icake
    {
        public abstract void bake();

    }
    class Strawberry : Icake
    {
        public void bake()
        {
            Console.WriteLine("straberry");
        }
    }
    class BlackForest : Icake
    {
        public void bake()
        {
            Console.WriteLine("blackforest ");
        }
    }
}
