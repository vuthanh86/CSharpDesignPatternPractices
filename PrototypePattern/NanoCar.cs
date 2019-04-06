using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class NanoCar : BasicCar
    {
        public NanoCar(string m)
        {
            ModelName = m;
        }

        #region Overrides of BasicCar

        public override BasicCar Clone()
        {
            return (BasicCar) this.MemberwiseClone();
        }

        #endregion
    }
}
