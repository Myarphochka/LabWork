namespace ConsoleApp1
{
    internal class Person
    {
        #region Данные класса (поля и константы)
        //данные
        private string name;
        public byte age;
        public const byte MajorityAge = 18;
        #endregion

        #region Свойства
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = value.Trim();
                if (value != "")
                    name = value;
            }
        }

        public double Money { get; set; }
        #endregion

        #region Конструкторы
        public Person() : this("unknown", 18)
        {
        }

        public Person(string name, byte age)
        {
            Name = name;
            this.age = age;
        }
        #endregion

        #region Методы класса
        public void Print()
        {
            Console.WriteLine($"{Name}, {age} лет");
        }
        #endregion

        #region Индексаторы
        public object? this[int fieldNumber]
        {
            get
            {
                if (fieldNumber == 1)
                    return name;
                if (fieldNumber == 2)
                    return age;
                return null;
            }
        }
        #endregion
    }
}
