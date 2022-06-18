using E_Ticketing.CoreLayer.Entity;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace E_Ticketing.Test.Entity.VehicleTest
{
    public class VehicleEntityTest
    {
        public readonly Vehicle vehicle;
        public readonly Vehicle_Category category;
        public VehicleEntityTest()
        {
            category = new("Mini Bus");
            vehicle = new("Ba 1 Kha 1911",category,"Sakira");
        }
        [Fact]
        public void Test_Create_new_instance_with_default_value()
        {
            Assert.Equals("Ba 1 Kha 1911",vehicle.Vehicle_Number);
            Assert.Equals(category, vehicle.Vehicle_Category);
            Assert.Equals("Sakira", vehicle.Vehicle_Name);
        }

    }
}
