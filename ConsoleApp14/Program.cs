using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseHelper;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;
using System.Transactions;
using WareHouse.Repository;

namespace WareHouseFinal
{
  class Program
  {
    static void Main(string[] args)
    {
      UserRepository userRepository = new UserRepository();

      if (userRepository.Login("User2", "Paswword2"))
        Console.WriteLine("Correct credential works");
      else
        Console.WriteLine("Correct credential doesnt work");

      if (!userRepository.Login("User1_", "Paswword1_"))
        Console.WriteLine("Incorrect credential works");
      else
        Console.WriteLine("Incorrect credential doesnt work");

      if (!userRepository.Login("User1_", "Paswword1"))
        Console.WriteLine("Incorrect username credential works");
      else
        Console.WriteLine("Incorrect username credential doesnt work");

      if (!userRepository.Login("User1", "Paswword1_"))
        Console.WriteLine("Incorrect password credential works");
      else
        Console.WriteLine("Incorrect password credential doesnt work");

      ////InsertCategory
      //Database db = new Database();
      //for (int i = 0; i < 100; i++)
      //{
      //    db.ExecuteNonQuery("InsertCategories", CommandType.StoredProcedure,
      //    new SqlParameter("Name", $"Category {i + 1}"),
      //    new SqlParameter("Description", $"Description{i + 1}")
      //    );
      //}

      ////InsertProduct
      //Database db = new Database();
      //for (int i = 0; i < 100; i++)
      //{
      //    db.ExecuteNonQuery("InsertProducts", CommandType.StoredProcedure,
      //    new SqlParameter("Name", $"Product{i + 1}"),
      //    new SqlParameter("Description", $"Description{i + 1}")
      //    );
      //}

      ////InsertProccessing
      //Database db = new Database();
      //for (int i = 10; i < 100; i++)
      //{
      //    db.ExecuteNonQuery("InsertProccessing", CommandType.StoredProcedure,
      //    new SqlParameter("UserID", i + 1),
      //    new SqlParameter("ProductID", i + 1),
      //    new SqlParameter("Price", 15 + 1) { SqlDbType = SqlDbType.Money },
      //    new SqlParameter("Quantity", 20 + i + 1),
      //    new SqlParameter("ProccessingType", "Input"),
      //    new SqlParameter("ProcessDate", DateTime.Today) { SqlDbType=SqlDbType.Date}
      //    );
      //}


      //Database db = new Database();
      //for (int i = 1; i < 100; i++)
      //{
      //    db.ExecuteNonQuery("AssignCategory", CommandType.StoredProcedure,
      //    new SqlParameter("ProductID", i+1) { SqlDbType = SqlDbType.Int },
      //    new SqlParameter("CategoryID", i+1) { SqlDbType = SqlDbType.Int },
      //    new SqlParameter("Assign", 1) { SqlDbType = SqlDbType.Bit }
      //    );
      //}

      ////InsertEmployee
      //byte[] photo = File.ReadAllBytes(@"E:\mypicture.jpg");
      //File.WriteAllBytes(@"E:\mypicture.jpg", photo);
      //Database db = new Database();
      //object data = db.ExecuteScalar("select photo from employees");
      //for (int i = 0; i < 100; i++)
      //{
      //    db.ExecuteNonQuery("InsertEmployees", CommandType.StoredProcedure,
      //    new SqlParameter("LastName", "LastName"),
      //    new SqlParameter("FirstName", "FirstName"),
      //    new SqlParameter("BirthDate", new DateTime(1998, 02, 05)) { SqlDbType = SqlDbType.Date },
      //    new SqlParameter("Photo", photo) { SqlDbType = SqlDbType.VarBinary },
      //    new SqlParameter("City", "Tbilisi"),
      //    new SqlParameter("Position", "Developer"),
      //    new SqlParameter("HireDate", DateTime.Today) { SqlDbType = SqlDbType.Date },
      //    new SqlParameter("Address", "Vake"),
      //    new SqlParameter("Country", "Georgia"),
      //    new SqlParameter("Phone", "+99557766112"),
      //    new SqlParameter("Email", "gchokor1@gmail.com")
      //    );
      //}

      ////InsertUser
      //Database db = new Database();
      //for (int i = 0; i < 254; i++)
      //{
      //    db.ExecuteNonQuery("InsertUsers", CommandType.StoredProcedure,
      //    new SqlParameter("ID", i + 10) { SqlDbType = SqlDbType.Int },
      //    new SqlParameter("Username", $"User{i + 1}") { SqlDbType = SqlDbType.NVarChar },
      //    new SqlParameter("Password", $"Paswword{i + 1}") { SqlDbType = SqlDbType.NVarChar }
      //    );
      //}

      ////UpdateCategories
      //Database db = new Database();
      //db.ExecuteNonQuery("UpdateCategories", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 1) { SqlDbType=SqlDbType.Int},
      //    new SqlParameter("Name", "NewCategory") { SqlDbType=SqlDbType.NVarChar},
      //    new SqlParameter("Description", "NewDescription") { SqlDbType=SqlDbType.NVarChar}
      //);

      ////UpdateProduct
      //Database db = new Database();
      //db.ExecuteNonQuery("UpdateProducts", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 1) { SqlDbType = SqlDbType.Int },
      //    new SqlParameter("Name", "NewProduct") { SqlDbType=SqlDbType.NVarChar},
      //    new SqlParameter("Description", "NewDescription") { SqlDbType=SqlDbType.NVarChar}
      // );

      ////UpdateEmployees
      //Database db = new Database();
      //byte[] photo = File.ReadAllBytes(@"E:\mypicture2.jpg");
      //File.WriteAllBytes(@"E:\mypicture2.jpg", photo);
      //object data = db.ExecuteScalar("select photo from employees");
      //db.ExecuteNonQuery("UpdateEmployees", CommandType.StoredProcedure,
      //   new SqlParameter("ID", 1) { SqlDbType = SqlDbType.Int },
      //   new SqlParameter("LastName", "NewLastName"),
      //   new SqlParameter("FirstName", "NewFirstName"),
      //   new SqlParameter("BirthDate", new DateTime(1969, 6, 9)) { SqlDbType = SqlDbType.Date },
      //   new SqlParameter("Photo", photo) { SqlDbType = SqlDbType.VarBinary },
      //   new SqlParameter("City", "Batumi"),
      //   new SqlParameter("Position", "WebDeveloper"),
      //   new SqlParameter("HireDate", DateTime.Today) { SqlDbType = SqlDbType.Date },
      //   new SqlParameter("Address", "Na more"),
      //   new SqlParameter("Country", "Georgia"),
      //   new SqlParameter("Phone", "577696969"),
      //   new SqlParameter("Email", "NewEmail@Gmail.com")
      //  );

      ////UpdateUsers
      //Database db = new Database();
      //db.ExecuteNonQuery("UpdateUsers", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 12) { SqlDbType = SqlDbType.Int },
      //    new SqlParameter("UserName", "NewUserName"),
      //    new SqlParameter("Password", "NewPassword")
      // );

      ////DeleteCategories
      //Database db = new Database();
      //db.ExecuteNonQuery("DeleteCategories", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 1)
      //    );

      ////DeleteProducts
      //Database db = new Database();
      //db.ExecuteNonQuery("DeleteProducts", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 1)
      //    );

      ////DeleteEmployees
      //Database db = new Database();
      //db.ExecuteNonQuery("DeleteEmployees", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 1)
      //    );

      ////DeleteUsers
      //Database db = new Database();
      //db.ExecuteNonQuery("DeleteUsers", CommandType.StoredProcedure,
      //    new SqlParameter("ID", 10)
      //    );

      Console.ReadKey();
    }
  }
}
