Student mariya = new Student("Евстифеева Мария Николаевна", 2020, "ул. Ладожская 170 12", 89347658777, 1, "Менеджемт");//создание объекта
//класс             //конструктор
Student serega = new Student("Максимов Сергей Викторович", 2023, "ул. Лядова 43 2", 89127864583, 3, "Медицина");
Student lesha = new Student("Сюзюмов Алексей Сегреевич", 2022, "ул. Лермонтова 23 111", 89647365626, 2, "Компьюьерные технологии");
Student[] mass = new Student[3] { mariya, serega, lesha };//создание массива
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"фио студента - {mass[i].fio}");
}
Console.WriteLine("введите факультет - Менеджмент/Медицина/Компьютерные технологии");
string facyltet = Console.ReadLine();
for (int i = 0; i < mass.Length; i++)//вывод фио каждого студента
{
    if (mass[i].faculty == facyltet)
    {
        Console.WriteLine($"Студент данного факультета - {mass[i].fio}");
    }
}
Console.WriteLine("Введите год постуления студента (2020/2022/2023)");
int dAtA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Студент, поступивший в данном году - ");
for (int i = 0; i < mass.Length; i++)//поиск студента по введенному году
{
    if (mass[i].data > dAtA)
    {
        Console.WriteLine($"{mass[i].fio}");
    }
}
class Student // объявление класса
{
    private string FIO;
    private int Data;
    private string Address;
    private long Tel;
    private int Kurs;
    private string Faculty;
    public Student(string FIO, int Data, string Address, long Tel, int Course, string Faculty)//конструктор класса
    {
        this.FIO = FIO;
        this.Data = Data;
        this.Address = Address;
        this.Tel = Tel;
        this.Kurs = Kurs;
        this.Faculty = Faculty;
    }
    public string fio //свойства 
    {
        get//получение значения
        {
            return FIO; // чтение 
        }
        set //установка значения
        {
            FIO = value; // Запись
        }
    }
    public int data//свойство
    {
        get
        {
            return Data; // Чтение
        }
        set
        {
            Data = value; // Запись даты 
        }
    }
    public string address//свойство
    {
        get
        {
            return Address; // Чтение 
        }
    }
    public long phonenumber//свойство
    {
        get
        {
            return Tel;  // Чтение 
        }
        set
        {
            Tel = value; // Запись 
        }
    }
    public int course//свойство
    {
        set
        {
            Kurs = value;  // Запись 
        }
    }
    public string faculty//свойство
    {
        get
        {
            return Faculty;  // Чтение  
        }
    }
}
