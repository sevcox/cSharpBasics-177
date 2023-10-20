namespace _05_Properties.Entities
{
    public class Donut
    {
        #region Private Backing Field
        private string _donutType;
        private string _filling;
        #endregion

        #region Properties...Attributes
        // public string Filling
        // {
        //     get
        //     {
        //read-only
        //we can also do computations if needed...
        //         return _filling.ToUpper();
        //     }
        //     set
        //     {
        //write (assign value to Filling)
        //         _filling = value;
        //     }
        // }

        //prop,tab,tab -> auto create a property (template)
        public string Filling { get; set; }
        public string Topping { get; set; }
        public decimal Price { get; set; } = .25m;
        public bool IsSpecial { get; set; } = false;
        #endregion

        #region Constructors. what we use to create an instance of an object (Class) on the fly!
        //lets create a 'default' constructor!
        public Donut()
        {
            _donutType = "Plain Jane";
        }

        //overload(s)
        public Donut(string donutType)
        {
            _donutType = donutType;
        }

        //full-constructor:
        public Donut(string donutType, string filling, string topping, bool isSpecial)
        {
            _donutType = donutType;
            Filling = filling;
            Topping = topping;
            IsSpecial = isSpecial;
        }

        #endregion

        #region Get/Set Methods that return private data via the private backing field
        public string GetDonutFilling()
        {
            return _filling.ToUpper();
        }

        public void SetDonutFilling(string filling)
        {
            _filling = filling;
        }

        public string GetDonutType()
        {
            return _donutType;
        }

        public void SetDonutType(string typeName)
        {
            _donutType = typeName;
        }
        #endregion

        #region Special Price Calculation
        private decimal CalculateSpecialPrice(bool isSpecial)
        {
            //ternary expression
            return isSpecial ? Price *= 2 : Price;

            // if (isSpecial) return Price *= 2;
            // else return Price;
            
            // if (isSpecial)
            // {
            //     return Price *= 2;
            // }
            // else
            // {
            //     return Price;
            // }
        }
        #endregion

        #region override ToString()
        public override string ToString()
        {
            return $"This donut is {this.GetDonutType()}\n full of {this.Filling}\n and topped with {Topping}\n for {CalculateSpecialPrice(this.IsSpecial)}";
        }
        #endregion
    }
}