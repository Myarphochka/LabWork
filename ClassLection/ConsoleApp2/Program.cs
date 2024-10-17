using Lection2;

Sandwich sandwich = new Sandwich();
Bread bread = new() { Weight = 110 };
sandwich = sandwich + bread;
Cheese cheese = new() { Weight = 60 };
sandwich = sandwich + cheese;

User user1 = new User { Id = 12 };
User user2 = new User { Id = 28 };
User user3 = user1 + user2;
Console.WriteLine(user3.Id); // 40

if (user1 < user2)
    Console.WriteLine("1 меньше");
else
    Console.WriteLine("2 меньше");

if (user1)
    Console.WriteLine("id > 0");