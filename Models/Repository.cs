using System.Collections.Generic;

namespace WebServer.Models {
    public class Repository {
        public static IDictionary<int, Product> Products { get; private set; }

        static Repository() {
            Products = new Dictionary<int, Product>();
           Products[0] = new Product { ID = 0, Name = "Khánh", age = 20 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" };
            Products[1] = new Product { ID = 1, Name = "Khánh Phạm", age = 20 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" };
            Products[2] = new Product { ID = 2, Name = "Thành", age = 19 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" };
            Products[3] = new Product { ID = 3, Name = "Nam", age = 18 , gender = "Nam" , mobile ="0123456", email= "khanhpvth1808010@fpt.edu.vn" };
        }
    }
}