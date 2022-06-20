using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Entity
{
    public class Vehicle_Category
    {
        public static readonly string Active = "Active";
        public static readonly string Inactive = "Inactive";

        protected Vehicle_Category()
        {

        }
        public Vehicle_Category(string name) {
            Category_Name = name;
            Status = Active;
        }   
        public virtual int Id { get; protected set; }
        public virtual string Category_Name { get; protected set; }
        public virtual string Status { get; protected set; }

        public virtual ICollection<Vehicle> Vehicles { get; protected set; } = new List<Vehicle>();

        public void Activate()
        {
            Status = Active;
        }
        public void Deactivate()
        {
            Status = Inactive;
        }

        public Boolean IsActive()
        {
            return Status == Active;
        }

    }
}
