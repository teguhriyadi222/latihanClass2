class manusia {

    public string name;
    public int age;
    private int _salary;

    public manusia(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public manusia(string name, int age, int salary) {
        this.name = name;
        this.age = age;
        this._salary = salary;
    }

    public void SetSalary(int _salary) {
        this._salary = _salary * 1000;
    }

    public int GetSalary() {
        if (_salary < 10000 ) {
            Console.WriteLine("gajimu sitek");
        }
        else {
            Console.WriteLine("gajimu akeh");
        }
        return _salary;
    }
}

static class program {

    static void Main() {

        Console.WriteLine("Berapa jumlah manusia yang ingin diinput?");
        int n = int.Parse(Console.ReadLine());  
        manusia[] manusiaArray = new manusia[n];     
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Input data manusia ke-{i+1}");
            Console.WriteLine("Masukkan nama manusia: ");
            string name = Console.ReadLine();
            Console.WriteLine("Masukkan umur manusia: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan gaji manusia: ");
            int salary = int.Parse(Console.ReadLine());

            manusiaArray[i] = new manusia(name, age, salary);
            Console.WriteLine($"Nama manusia ke-{i+1} adalah " + manusiaArray[i].name + "\nUmur manusia ke-{i+1} adalah " + manusiaArray[i].age);
            Console.WriteLine($"Gaji manusia ke-{i+1} adalah :" + manusiaArray[i].GetSalary());
        }
    }
}
