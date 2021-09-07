using System;

namespace DDW.PatternPrototype
{
    public abstract class Transport : ICloneable
    {
        protected string Model;
        protected int HashModel;
        internal bool IsMove { get; set; }

        protected Transport(string model)
        {
            Model = model;         
        }     

        public abstract void Move();

        public abstract object Clone();

        public abstract object MyClone();

        public override string ToString()
        {
            return $"{Model} : {HashModel}\nТранспорт уехал = {(IsMove ? "Да" : "Нет")}\n";
        }

       
        
    }

}
