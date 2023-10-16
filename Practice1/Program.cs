
using Practice1.Factory;
using Practice1.Factory_Videogame;


//FACTORY METHOD IMPLEMENTATION

ITransportCreator creator = new ShipCreator();
ITransport ship = creator.CreateTransport();
ship.Deliver();

creator = new AireplaneCreator();
ITransport airplane = creator.CreateTransport();
airplane.Deliver();

creator = new TruckCreator();
ITransport truck = creator.CreateTransport();
truck.Deliver();

Console.WriteLine("Example with enemies ");
IEnemyCreator enemyCreator = new BossCreator();
IEnemy boss = enemyCreator.CreateEnemy();
boss.DealDamage(100);

enemyCreator = new StrongEnemyCreator();
IEnemy strongEnemy = enemyCreator.CreateEnemy();
strongEnemy.DealDamage(50);

enemyCreator= new WeakEnemyCreator();
IEnemy weakEnemy = enemyCreator.CreateEnemy();
weakEnemy.DealDamage(20);