namespace DDW.PatternPrototype
{
    public class TruckMini : Truck, IMyCloneable<TruckMini>
    {
        public TruckMini(string model) : base(model)
        {

        }

        public override object MyClone()
        {
            Goods goods2 = new Goods(this.goods.Type);

            return new TruckMini(this.Model)
            {
                HashModel = this.HashModel,
                IsMove = this.IsMove,
                Model = this.Model,
                goods = goods2
            };
        }

        TruckMini IMyCloneable<TruckMini>.MyClone2()
        {
            return (TruckMini)MyClone();
        }

        public override Goods goods { get => base.goods; set => base.goods = value; }
    }

}
