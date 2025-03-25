#include <clocale>
#include <iostream>
using namespace std;


class Animal {

private:

    string name;

public:
      // создание виртуального конструктора невозможно
      Animal() {};

      void speak() 
      {
         printf("Auau (animal)\n");
      }

      virtual void run() {printf("виртуальный метод класса Animal\n");} //виртуальный метод

      virtual ~Animal() { printf("виртуальный деструктор класса Animal\n"); }; //виртуальный деструктор

      void fly() { printf("fly Animal предка\n"); }
      void useFly() {
          fly();
      }

      virtual void sleep() { "sleep Animal потомка \n"; }
      void useSleep() {
          sleep();
      }

      virtual string classname() { return "Animal"; }

      virtual bool isA(const string & who) //спрашиваем у объекта кто он
      {
          return who == "Animal";
      }

};

class Dog : public Animal {
public:

    Dog(){}

    void speak()  
    {
        printf("Woof (dog)\n"); //переопределенный метод предка
    }

    void  run() override //перекрытый виртуальный метод предка
    {
        printf("Dog is running\n");
    }

    void fly() { printf("fly Dog потомка\n"); }

    void sleep() override { printf("sleep Dog потомка\n"); }

    ~Dog() { printf("деструктор класса Dog / "); }

    string classname() override { return "Dog"; }

    bool isA(const string& who) override
    {
        return (who == "Animal") || (who == "Dog");
    }
};

class Cat : public Animal {
public:
    string classname() override { return "Cat"; }
    void catchMouse() { printf("Meow catched!\n"); }
    ~Cat() { printf("деструктор класса Cat / "); }

    bool isA(const string& who) override
    {
        return (who == "Animal") || (who == "Cat");
    }
};

class Tiger : public Cat {
public:
    bool isA(const string& who) override //теперь вместо больших проверок добавляем метод 
    {
        return (who == "Manul") || (Cat :: isA(who)); 
    }
};



class Base {
    public:
        Base() { printf("Конструктор Base\n"); }

        Base(Base* obj) { printf("Конструктор через указатель Base\n"); }

        Base(const Base& obj) { printf("Конструктор копирования Base\n"); }

        virtual ~Base() { printf("Деструктор Base\n"); }
};

class Desc : public Base {
public:
    Desc() {printf("Конструктор Desc\n");}

    Desc(Desc* obj) { printf("Конструктор через указатель Desc\n"); }

    Desc(Desc& obj) { printf("Конструктор копирования Desc\n"); }

    void specificMethod() {
        cout << "Метод класса Desc\n";
    }

    ~Desc() { printf("Деструктор Desc\n"); }
};

void func1(Base obj) {

    printf("func1 передача по значению\n");
}

void func2(Base* obj) {
    printf("func2 передача по указателю\n");
}

void func3(Base& obj) {
    printf("func3 передача по ссылке\n");
}

Base func11() {
    Base obj;
    return obj; // возврат по значению
}

Base* func21() {
    static Base obj;
    return &obj; // возврат указателя на статический объект
}

Base& func31() {
    static Base obj;
    return obj; // возврат ссылки на статический объект
}

Base* func4() {
    Base* obj = new Base();
    return obj; // возврат указателя на динамический объект
}

Base* func5() {
    Base* obj = new Base();
    return obj; // возврат указателя на динамический объект
}

Base* func6() {
    Base* obj = new Base();
    return obj; // возврат указателя на динамический объект
}

// приведение типов в функциях
void func(Base* obj) {
    Desc* desc = dynamic_cast<Desc*>(obj);
    if (desc) {
        cout << "Приведение успешно. Вызов метода Desc.\n";
        desc->specificMethod();
    }
    else {
        cout << "Приведение не удалось. Объект не является Desc.\n";
    }
}
//приведение можно сделать, для этого добавляем полиморфиз, virtual деструктор Base

void pass_object(unique_ptr<Desc>d3) {
    d3->specificMethod();
}

shared_ptr<Desc>pass_object(shared_ptr<Desc>d) {
    d->specificMethod();
    return d;
}

int main()
{
    setlocale(LC_ALL, "Russian");
    
    printf("============Передача объектов как параметр=============\n");
    Base base;
    Desc desc;

    printf("============Передача Base=============\n");
    func1(base); // создается копия и удаляется
    func2(&base);
    func3(base); 

    printf("============Передача Desc=============\n");
    func1(desc);
    func2(&desc);
    func3(desc);// копируется только часть относящаяся к Base

    printf("============Возврат статических объектов=============\n");
    Base b1 = func11(); // временный объект передается в переменную вызываются конструкторы и деструкторы
    Base* b2 = func21(); // объект не копируется (нет конст деструк)
    Base& b3 = func31(); // необход самостоятельно удалять объект

    printf("============Возврат динамических объектов=============\n");
    Base* b4 = func4(); // возврат указателя на динамический объект
    Base* b5 = func5(); // возврат указателя на динамический объект
    Base* b6 = func6(); // возврат указателя на динамический объект

    delete b4;
    delete b5;
    delete b6;

    printf("============Приведение объекста в функции=============\n");
    Base* base1 = new Base();
    Desc* desc1 = new Desc();

    cout << "=== Передача Base ===\n";
    func(base1); // приведение не удастся

    cout << "=== Передача Desc ===\n";
    func(desc1); // приведение успешно

    delete base1;
    delete desc1;

    printf("============Умные указатели=============\n");

    unique_ptr<Desc>d1 = make_unique<Desc>(); //обычный локал объект
    pass_object(move(d1)); //теперь функция отвечает за жизнь объекта
    d1->specificMethod();                    //удалится после выхода из зоны видимости

   
    //если создать сначала пустой ум указатель - ничего не выйдет
    //unique_ptr<Desc>d2;
    //d2 = d; ошибка

    shared_ptr<Desc>d2 = make_shared<Desc>();
    d2 = pass_object(d2);
    shared_ptr<Desc>d3 = d2;
    d3->specificMethod();

    //unique_ptr декларирует: «Этот объект – мой, до тех пор, пока я
    //явно его кому - то не передам.Пользоваться – пользуйтесь на здоровье,
    //но отвечаю
    //за его время жизни – я, этот объект меня не переживёт»

   /* shared_ptr декларирует : 
   «Этот объект – нужен, как минимум, мне, но может быть и
   Rому - то ещё, я не против.Но пока он мне нужен – его никто
   не сможет удалить»*/
    


    Dog* d = new Dog();
    Animal* a = new Dog();
    Animal* an = new Animal();
    printf("================Перекрываемые методы================\n");
    d->speak();
    a->speak();
    printf("================Виртуальные методы================\n");
    d->run();
    a->run();
    an->run();
    printf("================Деструкторы================\n");
    delete d;
    delete a;
    delete an;
    // виртуальный деструктор нужен для корректного удаления
    // если виртуального нет, то при удалении объекта 
    // через указатель на базовый класс
    // деструктор производного класса не будет вызван  

    printf("================Работа с методами================\n");
    //•	в методе1 базового класса вызывается метод2,
    // который определен в этом же классе как невиртуальный,
    // у класса-потомка метод2 переопределен: что происходит
    // при вызове метода1 у класса-потомка?

    Dog doge;
    doge.useFly(); //метод useFly как бы привязан к fly предка

    //в методе1 базового класса вызывается метод2,
    //который определен в этом же классе как виртуальный,
    //у класса - потомка метод2 переопределен : 
    //что происходит при вызове метода1 у класса - потомка ?

    doge.useSleep(); //компилятор смотрит на фактический тип объекта

    //в базовом классе объявить метод невиртуальный,
    //а в классе-потомке объявить метод с таким же именем:
    //какой метод будет вызываться при обращении к объекту
    //через указатель на базовый класс, через указатель на класс-потомок?

    Dog* dogptr = new Dog();
    Animal* animalptr = new Dog();

    printf("================Невиртуальные методы================\n");
    dogptr->fly();
    animalptr->fly();

    printf("================Bиртуальные методы================\n");
    dogptr->sleep();
    animalptr->sleep();

    delete dogptr;
    delete animalptr;
    
    printf("================Приведения типов================\n");
    
    const int zooSize = 10;
    Animal* zoo[zooSize];

    for (int i = 0; i < zooSize; i++) {
        if (i % 2 == 0) {
            zoo[i] = new Dog(); // Создаем Dog
        }
        else {
            zoo[i] = new Cat(); // Создаем Cat
        }
    }

//небезопасное приведение с проверкой
    for (int i = 0; i < zooSize; i++) {
        if (zoo[i]->classname() == "Cat") {
            static_cast<Cat*>(zoo[i])->catchMouse();
        }
    }
    printf("================================\n");
    //проблема в том что при создании потомков проверка будет все больше
    //(zoo[i]->classname() == "Cat") || (zoo[i]->classname() == "Потомок")

//используем другую проверку методом
    for (int i = 0; i < zooSize; i++) {
        if (zoo[i]->isA("Cat")) {
            static_cast<Cat*>(zoo[i])->catchMouse();
        }
    }
    printf("================================\n");
    //потомок так же проверится тк есть метод

    //безопасное приведение
    for (int i = 0; i < zooSize; i++) {
        Cat* c = dynamic_cast<Cat*>(zoo[i]); //указатель анимал превратился в кет
        if (c != nullptr)
            c->catchMouse();
    }
    printf("================================\n");

    for (int i = 0; i < zooSize; i++) 
    {
        delete zoo[i];
    }



    //опасное приведение
    //((Cat*)zoo[i])->catchMouse();
    //static_cast<Cat*>(zoo[i])->catchMouse();
    //если в Cat* будет что-то другое программа скрашится


        //Зачем нужна проверка на принадлежность некоторому классу?
        //соблюдать правильную модель класса
        //понимать с кем работаешь
        //вызывать специфичные методы

        //Вызов метода потомка через переменную предка нужен для :
        //реализации полиморфизма.
        //расширения функциональности.
        //работы с коллекциями объектов разных типов

        return 0;
    }