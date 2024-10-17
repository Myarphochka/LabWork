namespace Lection2
{
    class User
    {
        public int Id { get; set; }

        //перегрузка инкремента
        public static User operator ++(User user)
        => new User() { Id = user.Id + 1 };

        //перегрузка +
        public static User operator +(User user1, User user2) => new User() { Id = user1.Id + user2.Id };

        //перегрузка > и <
        public static bool operator >(User user1, User user2)
            => user1.Id > user2.Id;

        public static bool operator <(User user1, User user2)
            => user1.Id > user2.Id;

        //перегрузка true
        public static bool operator true(User user)
            => user.Id > 0;
        public static bool operator false(User user)
            => user.Id <= 0;
    }
}