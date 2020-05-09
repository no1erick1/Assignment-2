using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Resources
{
   public class SupplyFood
    {
        public string Id { get; set; }
        public string FoodWater { get; set; }
            public string CategoryFood { get; set; }
            public string Patient { get; set; }          
            public List<SupplyFood> listSupplyFood { get; set; }


            public SupplyFood()
            {
            this.Id = "";
            this.FoodWater = "";
                this.CategoryFood = "";
                this.Patient = "";
               
                this.listSupplyFood = new List<SupplyFood>();
            }
        public SupplyFood(string id, string FoodWater, string CategoryFood, string Patient)
            {
            this.Id = id;
            this.FoodWater = FoodWater;
                this.CategoryFood = CategoryFood;
                this.Patient = Patient;
                
                this.listSupplyFood = new List<SupplyFood>();
            }

        public SupplyFood(SupplyFood a)
            {
                // vì từng property trong doctor là kiểu value type
                // nên là sẽ trả ra giá trị
                // nếu là reference type thì trả ra địa chỉ 
                this.FoodWater = a.FoodWater;
                this.CategoryFood = a.CategoryFood;
                this.Patient = a.Patient;
            this.Id = "";
            this.listSupplyFood = new List <SupplyFood > ();
            }



        
    }
}
