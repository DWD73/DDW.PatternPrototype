using System;

namespace DDW.PatternPrototype
{
    public class Truck : Transport, IMyCloneable<Truck>
    {

        public virtual Goods goods { get; set; }

        public Truck(string model) : base(model)
        {           
            this.HashModel = this.GetHashCode();
            Name = "Boris";

            goods = new Goods("Fish");
        }                    
       
        public override void Move()
        {           
            IsMove = true;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public override object MyClone()
        {
            Goods goods2 = new Goods(this.goods.Type);

            return new Truck(this.Model)
            {
                HashModel = this.HashModel,
                IsMove = this.IsMove,
                Model = this.Model,
                goods = goods
            };
        }

        public Truck MyClone2()
        {
            return (Truck)MyClone();
        }       

        public override string ToString()
        {
            //string k = base.ToString();

            return $"{base.ToString()}\tГруз {goods.Type}\n";
        }
    }

}
