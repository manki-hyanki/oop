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



c

int main()
{
    setlocale(LC_ALL, "Russian");
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