using System;

namespace DDW.PatternPrototype
{
    public abstract class Transport : Person, ICloneable
    {
        protected string Model;
        protected int HashModel;
        internal bool IsMove { get; set; }
       
        protected Transport(string model)
        {
            Model = model;         
        }
        /// <summary>
        /// Имя водителя
        /// </summary>
        public override string Name { get => base.Name; set => base.Name = value; }
        
        public abstract void Move();

        public abstract object Clone();

        public abstract object MyClone();

        public override string ToString()
        {
            return $"{Model} : {HashModel}\nВодитель {Name}\nТранспорт уехал = {(IsMove ? "Да" : "Нет")}\n";
        }

        
    }

}
