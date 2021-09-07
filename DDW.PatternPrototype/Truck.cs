using System;

namespace DDW.PatternPrototype
{
    public class Truck : Transport
    {        

        public Truck(string model) : base(model)
        {           
            this.HashModel = this.GetHashCode();
        }                    
       
        public override void Move()
        {           
            IsMove = true;
        }            

        public override object MyClone()
        {
            return new Truck(this.Model)
            {
                HashModel = this.HashModel,
                IsMove = this.IsMove,
                Model = this.Model
            };
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }



}
