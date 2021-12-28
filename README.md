# Содержание

[Введение](#введение)

1)[Описание предметной области](#предметная_область)

1.1 [Проблематика](#проблематика)

1.2 [Цели и задачи](#цели_и_задачи)

1.3 [Варианты решения проблемы](#решение_проблемы)

2)[Разработка](#разработка)

2.1 [Этап проектирования](#проектирование)

2.2 [Этап реализации](#реализация)

3)[Тестирование информационной системы](#тестирование)

[Заключение](#заключение)

[Список использованных источников](#ссылки)

***

## Введение <a name="введение"></a>

Темой данного проекта является "Сервис по подбору автомобилей на вторичном рынке", на данный момент большое количество людей нуждаются в приобретении автомобиля, но по каким-то причинам у них не хватает времени на его поиски, данный сервис помогает найти понравившееся клиенту авто в хорошем состоянии, не тратя на это время. Услуга автоподбора, собственно, и создана для того, чтобы уберечь покупателя от дальнейших трат нервов, времени и денег. Плата за эти услуги должна многократно окупиться. Ведь выбор доверяется специалисту, который отсеет хлам на стадии поиска, и уж тем более не допустит, чтобы в руки клиента попал проблемный экземпляр. 


***

## 1 Описание предметной области <a name="предметная_область"></a>

Человеку, заходящему на сайт, будет сразу предложено либо зарегистрироваться, либо войти в свой личный кабинет, если он был уже зарегистрирован. Далее он может выбрать марку автомобиля, которая ему интересена. Выбрав марку авто, человеку будет предложен список моделей авто. Нажав на понравившийся автомобиль, он сможешь добавить его в избранное.
Автоподборщик принимает заказы о понравившемся авто, далее делает его офлайн проверку и высылает отчет об автомобиле заказчику(1).

***

## 1.1 Проблематика <a name="проблематика"></a>

  В наше время широко развиты информационные системы, связанные с сервисом подбора автомобилей. У большинства людей из-за работы не хватает времени на поиски авто, но данный сервис помогает решить им данную проблему.Клиенты не будут тратить время на сравнение автомобилей, автоподборщик будет сам просматривать понравившиеся клиенту авто и присылать отчеты.
  
***
  
## 1.2 Цели и задачи <a name="цели_и_задачи"></a>

Целью данного проекта является превлечения внимания окружающих к чтению книг "не выходя из дома" . 
Задачи проекта. 
1) Расширение возможностей сайта.
2) Популизирование сервиса по подбору автомобилей на вторичном рынке.
3) Привлечение аудитории на сайт.

***

## 1.3 Варианты решения проблемы <a name="решение_проблемы"></a>

1) Создать практичный сайт по подбору автомобилей.
2) Улучшать его на основе отзывов клиентов.

***
## 2 Разработка <a name="разработка"></a>

Разработка информационной системы состоит из двух этапов: проектирования и реализации. В проектировании информационной системы разрабатываем USE-CASE, DFD и ER диаграммы. Данные диаграммы необходимы для графического описания лиц, описания действий участников процесса и описания их связей между собой внутри системы. Реализация информационной системы представляет собой готовый программный продукт с описанием его составляющих и текстом программного кода.

## 2.1 Этап проектирования <a name="проектирование"></a>

Этап проектирования начинаеться с описания главных лиц, учавствовавших в бизнес-процессе (рисунок 1).

<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/USE%20CASE.png?raw=true"></p>
<p align="center">Рисунок 1 - UseCase диаграмма</p>

Далее на основе UseCase диаграммы описываются действия участников процесса, с помощью DFD диаграммы (рисунок 2).

<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/DFD.png?raw=true"></p>
<p align="center">Рисунок 2 - DFD диаграмма</p>
Затем на основе DFD диаграммы создается ER диаграмма, на которой описываются связи участников между собой внутри системы (рисунок 3).

<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/ER.png?raw=true"></p>
<p align="center">Рисунок 3 - ER диаграмма</p>                     

## 2.2 Этап реализации <a name="реализация"></a>

На основе ER-диаграммы создали класс с указанием полей, параметров и типов данных для каждой сущности. 
Привели пример создания класса для сущности Client (листинг 1):

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

Таким же создали классы для автоподборщика, машины, оплаты и заказа .

Далее для каждой сущности создали контроллеры с методами Create, Read, Update, Delite.
Привели пример создания контроллера для сущности Client (листинг 2):

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
Таким же образом создали контроллеры для оставшихся классов.

Затем создали хранилище для каждого класса. Пример создания хранилища для класса Client (листинг 3):

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

Таким же образом создали хранилища для оставшихся классов, после чего создали общее хранилище (листинг 4):

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
## 4 Тестирование информационной системы <a name="тестирование"></a>

После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними (рисунок 4).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/4.png?raw=true"></p>
<p align="center">Рисунок 4 - Cтраница Swagger UI</p> 

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в сущности Autopicker (рисунок 5).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/5.png?raw=true"></p>
<p align="center">Рисунок 5 - Проверка работы методов CRUD</p> 

1. Create позволяет добавлять новые строки в вашу таблицу (рисунок 6).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/6.png?raw=true"></p>
<p align="center">Рисунок 6 - Окно метода создания</p> 

Ввод необходимых данных об автоподборщике в соответствующие поля (рисунок 7).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/7.png?raw=true"></p>
<p align="center">Рисунок 7 - Работа с методом создания</p> 

После успешного выполнения операции сервер выдаёт ответ (рисунок 8).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/8.png?raw=true"></p>
<p align="center">Рисунок 8 - Результат выполнения операции создания</p> 

2. Функция чтения Read похожа на функцию поиска, так как позволяет извлекать определенные записи и считывать их значения (рисунок 9).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/9.png?raw=true"></p>
<p align="center">Рисунок 9 - Окно функции чтения</p> 

Считывание информации об уже созданном автоподборщике по его Id (рисунок 10).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/10.png?raw=true"></p>
<p align="center">Рисунок 10 - Работа с методом чтения</p> 

После выполнения операции сервер выдаёт о автоподборщике информацию, которая была создана в Create (рисунок 11).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/11.png?raw=true"></p>
<p align="center">Рисунок 11 - Результат выполнения операции чтения</p> 

3. Функция редактирования записи Update используется для изменения существующих записей в базе данных (рисунок 12).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/12.png?raw=true"></p>
<p align="center">Рисунок 12 - Окно метода обновления</p> 

Измениение информации об автоподборщике, для этого сначала нужно ввести его номер и затем новые данные (рисунок 13).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/13.png?raw=true"></p>
<p align="center">Рисунок 13 - Работа с методом обновления</p> 

После выполнения операции сервер выдаёт новую информацию о том же автоподборщике (рисунок 14).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/14.png?raw=true"></p>
<p align="center">Рисунок 14 - Результат выполнения операции обновления</p> 

Функцией Read проверяется вышеуказанная операция. После срабатывания сервер выдает новую информацию об автоподборщике (рисунок 15).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/15.png?raw=true"></p>
<p align="center">Рисунок 15 - Результат выполнения операции чтения после обновления данных</p> 

4. Функция Delete используется для удаления записи по Id. Если операция удаления сработает успешно, то ответ сервера будет "true", в противном случае "false" (рисунок 16).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/16.png?raw=true"></p>
<p align="center">Рисунок 16 - Окно метода удаления</p> 

Удаление автоподборщика по его Id (рисунок 17).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/17.png?raw=true"></p>
<p align="center">Рисунок 17 - Работа с методом удаления</p> 

После выполнения операции ответ сервера (рисунок 18).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/18.png?raw=true"></p>
<p align="center">Рисунок 18 - Результат выполнения метода удаления</p> 

Проверка вышеописанного действия с помощью Read, считывание информацию об удалённом автоподборщике (рисунок 19).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/19.png?raw=true"></p>
<p align="center">Рисунок 19 - Работа с операцией чтения</p> 

После срабатывания программа не выдаёт информации об этом автоподборщике (рисунок 20).
<p align="center">
<img src="https://github.com/maksaev62/repr1/blob/main/Фото/20.png?raw=true"></p>
<p align="center">Рисунок 20 - Результат выполнения операции чтения после удаления данных</p>

***
## Заключение <a name="заключение"></a>

По окончании работы была создана информационная система: "Сервис по подбору автомобилей на вторичном рынке", которая позволяет вести учёт клиентской базы, подобрать согласно требованиям клиента авто и позволяет производить оплату за оказанные услуги.

***
## Список использованных источников <a name="ссылки"></a>

Для разработке данной информационной системы использовались эти ресурсы:

1. Шаблон автомобильного сайта - uWeb [Электронный ресурс]. / - Сайт – Режим доступа: https://www.uweb.ru/cars / свободный доступ – Дата доступа: 16.09.2021.

2. Draw.io [Электронный ресурс]. / - Сайт – Режим доступа: https://app.diagrams.net/. - Режим доступа: https://it.wikireading.ru/57101 / свободный доступ – Дата доступа: 17.09.2021.

3. C# и .NET | Классы и объекты [Электронный ресурс]. / - Сайт – Режим доступа: https://metanit.com/sharp/tutorial/3.1.php / свободный доступ – Дата доступа: 18.10.2021.

4. C# и .NET | Свойства [Электронный ресурс]. / - Сайт – Режим доступа: https://metanit.com/sharp/tutorial/3.4.php / свободный доступ – Дата доступа: 19.10.2021.

