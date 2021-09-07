namespace DDW.PatternPrototype
{
    public class TruckMini : Truck
    {
        public TruckMini(string model) : base(model)
        {

        }

        public override object MyClone()
        {
            return new TruckMini(this.Model)
            {
                HashModel = this.HashModel,
                IsMove = this.IsMove,
                Model = this.Model
            };
        }

    }

}
