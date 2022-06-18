using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Entity
{
    public class City
    {
        public readonly string Active = "Active";
        public readonly string Inactive = "Inactive";

        protected City()
        {

        }

        public City(string name)
        {
            Name = name;
            Status = Active;
        }

        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Status { get; protected set; }

        public void Activate()
        {
            Status = Active;
        }

        public Boolean IsActive()
        {
            return Status == Active;
        }
    }
}
