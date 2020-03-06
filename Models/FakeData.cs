using System.Collections.Generic;

namespace WebServer.Models {
    public class FakeData {
        public static IList<Rocket> Rockets { get; set; }

        static FakeData() {
            Rockets = new List<Rocket>();
            Rockets.Add(new Rocket { ID = 0, Name = "Khánh", age = 20 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" });
            Rockets.Add(new Rocket { ID = 1, Name = "Khánh Phạm", age = 20 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" });
            Rockets.Add(new Rocket { ID = 2, Name = "Thành", age = 19 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" });
            Rockets.Add(new Rocket { ID = 3, Name = "Nam", age = 18 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" });
            
        }
    }
}