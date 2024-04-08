// See https://aka.ms/new-console-template for more information
using NewHomeWork;
using System.Security.Cryptography;

//Класс Phone.
//Создайте класс Phone, который содержит переменные number, model и weight.
//Создайте три экземпляра этого класса. Выведите на консоль значения их переменных.
//Добавить в класс Phone методы: receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит {name}”.
//getNumber – возвращает номер телефона. Вызвать эти методы для каждого из объектов.
//Добавить конструктор в класс Phone, который принимает на вход три параметра
//для инициализации переменных класса - number, model и weight.
//Добавить конструктор, который принимает на вход два параметра для инициализации переменных класса - number, model.
//Добавить конструктор без параметров.
//Вызвать из конструктора с тремя параметрами конструктор с двумя. Добавьте перегруженный метод receiveCall, который принимает два параметра - имя
//звонящего и номер телефона звонящего. Вызвать этот метод.
//Создать метод sendMessage с аргументами переменной длины. Данный метод принимает на вход номера телефонов, которым будет отправлено сообщение.
//Метод выводит на консоль номера этих телефонов.

var ph1 = new Phone(4957223,"test1",100.5);
var ph2 = new Phone(20208,"test2");
var ph3 = new Phone(8347);

ph1.ReceiveCall("Matew");
ph2.ReceiveCall("Somebody");
ph3.ReceiveCall("Not defined");

ph1.GetNumber();
ph2.GetNumber();
ph3.GetNumber();

ph1.SendMessage(ph1.number);
ph2.SendMessage(ph2.number);
ph3.SendMessage(ph3.number);

Console.WriteLine();

//Создать класс CreditCard c полями номер счета, текущая сумма на счету.
//Добавьте метод, который позволяет начислять сумму на кредитную карточку.
//Добавьте метод, который позволяет снимать с карточки некоторую сумму.
//Добавьте метод, который выводит текущую информацию о карточке.
//Напишите программу, которая создает три объекта класса CreditCard у
//которых заданы номер счета и начальная сумма
//Тестовый сценарий для проверки:
//Положите деньги на первые две карточки и снимите с третьей.
//Выведите на экран текущее состояние всех трех карточек.

var customer1 = new CreditCard(123456,20000);
var customer2 = new CreditCard(123457,123000.523);
var customer3 = new CreditCard(123458,9245.0200);

customer1.CreditCardGetInfo();
customer2.CreditCardGetInfo();
customer3.CreditCardGetInfo();

customer1.CreditCardCharge(customer1.BillNumber, 100);
customer1.CreditCardGetInfo();

customer2.CreditCardCharge(customer1.BillNumber, 12.500);
customer2.CreditCardGetInfo();

customer3.CreditCardTakeOff(customer3.BillNumber, 10000);
customer3.CreditCardGetInfo();

customer3.CreditCardTakeOff(customer3.BillNumber, 5000);
customer3.CreditCardGetInfo();

