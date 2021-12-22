# Сервис по подбору автомобилей на вторичном рынке


## Содержание

[Введение](#введение)

1. [Описание предметной области](#предметная_область)

1.1 [Проблематика](#проблематика)

1.2 [Цели и задачи](#цели_и_задачи)

1.3 [Варианты решения проблемы](#решение_проблемы)

2. [Разработка](#разработка)

2.1 [Этап проектирования](#проектирование)

2.2 [Этап реализации](#реализация)

[Заключение](#заключение)

[Список использованных источников](#ссылки)

***

## Введение <a name="введение"></a>

Темой моего проекта является "Сервис по подбору автомобилей на вторичном рынке", на данный момент большое количество людей нуждаются в приобретении автомобиля, но по каким-то причинам у них не хватает времени на его поиски, данный сервис помогает найти понравившееся клиенту авто в хорошем состоянии, не тратя на это время. Услуга автоподбора, собственно, и создана для того, чтобы уберечь покупателя от дальнейших трат нервов, времени и денег. Плата за эти услуги должна многократно окупиться. Ведь выбор доверяется специалисту, который отсеет хлам на стадии поиска, и уж тем более не допустит, чтобы в руки клиента попал проблемный экземпляр. 


***

## 1 Описание предметной области <a name="предметная_область"></a>

Человеку, заходящему на сайт, будет сразу предложено либо зарегистрироваться, либо войти в свой личный кабинет, если он был уже зарегистрирован. Далее он может выбрать марку автомобиля, которая ему интересена. Выбрав марку авто, человеку будет предложен список моделей авто. Нажав на понравившийся автомобиль, он сможешь добавить его в избранное.
Автоподборщик принимает заказы о понравившемся авто, далее делает его офлайн проверку и высылает отчет об автомобиле заказчику[1].

***

## 1.1 Проблематика <a name="проблематика"></a>

  В наше время широко развиты информационные системы, связанные с сервисом подбора автомобилей. У большинства людей из-за работы не хватает времени на поиски авто, но данный сервис помогает решить им данную проблему.Клиенты не будут тратить время на сравнение автомобилей, автоподборщик будет сам просматривать понравившиеся клиенту авто и присылать отчеты.
  
***
  
## 1.2 Цели и задачи <a name="цели_и_задачи"></a>

Целью данного проекта является превлечения внимания окружающих к чтению книг "не выходя из дома" . 
Задачи проекта: 
1) Расширение возможностей сайта
2) Популизирование сервиса по подбору автомобилей на вторичном рынке
3) Привлечение аудитории на сайт

***

## 1.3 Варианты решения проблемы <a name="решение_проблемы"></a>

1) Создать практичный сайт по подбору автомобилей
2) Улучшать его на основе отзывов клиентов

***
## 2 Разработка <a name="разработка"></a>

Разработка информационной системы состоит из двух этапов: проектирования и реализации. В проектировании информационной системы разрабатываем USE-CASE, DFD и ER диаграммы. Данные диаграммы необходимы для графического описания лиц, описания действий участников процесса и описания их связей между собой внутри системы. Реализация информационной системы представляет собой готовый программный продукт с описанием его составляющих и текстом программного кода.

## 2.1 Этап проектирования <a name="проектирование"></a>

Этап проектирования начинаеться с описания главных лиц, учавствовавших в бизнес-процессе (рисунок 1).

<p align="center">
![image](https://user-images.githubusercontent.com/92459148/147114362-5529ca1c-2a12-4fce-a706-0111982564ed.png)
<p align="center">Рисунок 1 - UseCase диаграмма</p>

Далее на основе UseCase диаграммы описываются действия участников процесса, с помощью DFD диаграммы (рисунок 2).

<p align="center">
![image](https://user-images.githubusercontent.com/92459148/147116051-db246c64-33af-4fd4-84ee-743aa48a99be.png)
<p align="center">Рисунок 2 - DFD диаграмма</p>
                                                
Затем на основе DFD диаграммы создается ER диаграмма, на которой описываются связи участников между собой внутри системы (рисунок 3).

<p align="center">
![image](https://user-images.githubusercontent.com/92459148/147117899-aff6faa2-b1ae-408c-96b0-09ccb88a3d1e.png)
<p align="center">Рисунок 3 - ER диаграмма</p>                      

## 2.2 Этап реализации <a name="реализация"></a>

На основе ER-диаграммы создадим класс с указанием полей, параметров и типов данных для каждой сущности. 
Приведём пример создания класса для сущности Client (листинг 1):

Листинг 1 - Класс "Клиент"
```C# 
    public class Client
    {

        public int ClientId { get; set; }

        public string FullName { get; set; }

        public DateTime BirthdayDate { get; set; }

        public string PhoneNumber { get; set; }
    }
```

Таким же создадим классы для автоподборщика, машины, оплаты и заказа .

Далее для каждой сущности создаём контроллеры с методами Create, Read, Update, Delite.
Приведём пример создания контроллера для сущности Client (листинг 2):

Листинг 2 - Контроллер класса "Клиент"
```csharp 
[ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPost]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId); ;
        }
    }
}
```
Таким же образом создаём контроллеры для оставшихся классов.

Затем создаём хранилище для каждого класса. Пример создания хранилища для класса Client (листинг 3):

Листинг 3 - Хранилище класса "Клиент"
```csharp
     public class ClientStorage
    {
        private Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public ClientStorage() => Connection.Open();

        public void Create(Client client)
        {
            Clients.Add(client.ClientId, client);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Client Read(int clientId)
        {
            return Clients[clientId];
        }

        public Client Update(int clientId, Client newClient)
        {
            Clients[clientId] = newClient;
            return Clients[clientId];
        }

        public bool Delete(int clientId)
        {
            return Clients.Remove(clientId);
        }
    }
}
```

Таким же образом создаём хранилища для оставшихся классов, после чего создаём общее хранилище (листинг 4):

Листинг 4 - Общее хранилище
```csharp
namespace repr1.Repository
{
    public static class Storage
    {
        public static readonly ClientStorage clientStorage = new();
        public static readonly CarStorage CarStorage = new();
        public static readonly RequestStorage RequestStorage = new();
        public static readonly PaymentStorage PaymentStorage = new();
        public static readonly AutopickerStorage AutopickerStorage = new();
    }
}
```


***
## Заключение <a name="заключение"></a>

Должно быть
***
## Список использованных источников <a name="ссылки"></a>

Для разработке данной информационной системы использовались эти ресурсы:

[1] Шаблон автомобильного сайта - uWeb [Электронный ресурс]. – Режим доступа: https://www.uweb.ru/cars – Дата доступа: 16.09.2021.

[2] Draw.io [Электронный ресурс]. – Режим доступа: https://app.diagrams.net/. - Режим доступа: https://it.wikireading.ru/57101 – Дата доступа: 17.09.2021.

[3] METANIT.COM [Электронный ресурс]. – Режим доступа: https://metanit.com/sharp/tutorial/3.1.php. – Дата доступа: 18.10.2021.

[4] METANIT.COM [Электронный ресурс]. – Режим доступа: https://metanit.com/sharp/tutorial/3.4.php. – Дата доступа: 19.10.2021.

