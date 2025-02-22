#include <locale>
#include <iostream>
using namespace std;

class Car {
protected:
    string brand;
    string model;
    int release_year;
    double max_speed;

public:
    Car() { // Конструктор по умолчанию
        brand = "";
        model = "";
        release_year = 0;
        max_speed = 0;
        printf("Вызвался конструктор по умолчанию Car\n");
    }

    // Конструктор с параметрами
    Car(string brand, string model, int release_year, double max_speed) {
        this->brand = brand;
        this->model = model;
        this->release_year = release_year;
        this->max_speed = max_speed;
        printf("Вызвался конструктор с параметрами Car\n");
    }

    // Конструктор копирования
    Car(const Car& x) {
        this->brand = x.brand;
        this->model = x.model;
        this->release_year = x.release_year;
        this->max_speed = x.max_speed;
        printf("Вызвался конструктор копирования Car\n");
    }

    void start() {
        cout << "Wroom!" << endl;
    }

    void speed_change(double speed) {
        this->max_speed += speed;
    }

    int get_release_year() {
        return release_year;
    }

    void set_release_year(int release_year) {
        this->release_year = release_year;
    }

    double get_max_speed() {
        return max_speed;
    }

    void set_max_speed(double max_speed) {
        this->max_speed = max_speed;
    }

    ~Car() {
        printf("Вызвался деструктор Car\n");
    }
};

class Sportcars : public Car {
public:
    int horse_power;
public:
    Sportcars() {
        horse_power = 0;
        printf("Вызвался конструктор по умолчанию Sportcars\n");
    }

    ~Sportcars() {
        printf("Вызвался деструктор Sportcars\n");
    }
};

class Electric_Car : public Car {
private:
    int battery_percentage;

public:
    Electric_Car() {
        battery_percentage = 0;
        printf("Вызвался конструктор по умолчанию Electric_Car\n");
    }

    void charge_battery(int percentage);

    void start() {
    cout << "Pip!" << endl;
     }

    ~Electric_Car() {
        printf("Вызвался деструктор Electic_Car\n");
    }
};

class Autopark {
public:
    Car Car1;
    Car* Car2;


    Autopark() { //по умолчанию
        Car2 = new Car;
        printf("Вызвался конструктор по умолчанию (композиция)\n");
    }

    Autopark(string brand1, string model1, int release_year1, double max_speed1, 
        string brand2, string model2, int release_year2, double max_speed2) 
    {
        Car1 = Car(brand1, model1, release_year1, max_speed1);
        Car2 = new Car(brand2, model2, release_year2, max_speed2);
        printf("Вызвался конструктор с параметрами (композиция)\n");
    }
        

    
    Autopark(const Autopark& copy)
        : Car1(copy.Car1), Car2(new Car(*copy.Car2)) { // Динамическое создание копии
        printf("Вызвался конструктор копирования (композиция)\n");
    }


    ~Autopark() { //деструктор
        delete Car2;
        printf("Вызвался деструктор (композиция)\n");
    }

};



// Реализация методов Electric_Car вне класса
void Electric_Car::charge_battery(int percentage) {
    this->battery_percentage += percentage;
}

int main()
{
    setlocale(LC_ALL, "Russian");

    printf("===================================\n");

    Car Mazda_cx7; // создание обьекта статически через конструктор по умолчанию
    Car Porshe_911("Porshe", "911", 2023, 320); // создание обьекта статически через конструктор с параметрами
    Car Mazda_cx5(Mazda_cx7); // созд обьекта через констр копирования 

    Car* BMW_5 = new Car(); // созд обьекта динамически
    delete BMW_5; // удаление динамическ обьекта

    Porshe_911.speed_change(22.5); // обращение к методу обьекта
    cout << Porshe_911.get_max_speed() << endl;

    printf("===================================\n");

    Electric_Car Voyah;
    Voyah.start(); //переопределенный метод потомка 
    Voyah.Car::start(); //метод предка

    printf("===================================\n");

    Autopark AutoPark("Toyota", "Prado", 2023, 220, "Kia", "K5", 2022, 220); // создание композируемого обьекта
    Autopark Autop(AutoPark);
    Autopark NewPark;

    printf("\n===================================\n\n");

    //Sportcars* sportcar = new Sportcars();
    //Electric_Car* electric_car = new Electric_Car();
    //Car* c1 = sportcar;
    //Car* c2 = electric_car;

    Car* obj = new Car();
    obj->start();

    Car* obj2 = new Electric_Car();
    obj2->start();


    delete obj;
    delete obj2;


    // ТЕСТЫ НА ОБЛАСТИ ВИДИМОСТИ

    // такое не скомпилируется, тк у полей класса Car область видимости 
    // protected и доступ к ним есть только у классов-наследников  
    // Porshe_911.brand = "Parshe";

    // такое скомпилируется тк у полей класса Sportcars область видимости
    // public и доступ к ним есть в любой части кода, что может быть небезопасно
    Sportcars* sportcar = new Sportcars();
    sportcar->horse_power = 1234;
    delete sportcar;

    // такое не скомпилируется, тк у полей класса ElectricCar область видимости 
    //  private и прямого доступа к ним нет. Только через Getter и  Setter
    //Voyah.battery_percentage = 110;

    return 0;
}