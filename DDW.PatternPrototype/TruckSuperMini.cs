namespace DDW.PatternPrototype
{
    public class TruckSuperMini : TruckMini, IMyCloneable<TruckSuperMini>
    {
        public TruckSuperMini(string model) : base(model)
        {
            this.IsMove = true;
        }

        TruckSuperMini IMyCloneable<TruckSuperMini>.MyClone2()
        {
            return (TruckSuperMini)MyClone();
        }

        public override object MyClone()
        {
            Goods goods2 = new Goods(this.goods.Type);

            return new TruckSuperMini(this.Model)
            {
                HashModel = this.HashModel,
                IsMove = this.IsMove,
                Model = this.Model,
                goods = goods2
            };
        }

        public override Goods goods { get => base.goods; set => base.goods = value; }
    }

}
