
using Practice1.Builder_Enemies;
using Practice1.Factory;
using Practice1.Factory_Figures;
using Practice1.Factory_Videogame;
using Practice1.FactoryAnimals;


//FACTORY METHOD IMPLEMENTATION

//ITransportCreator creator = new ShipCreator();
//ITransport ship = creator.CreateTransport();
//ship.Deliver();

//creator = new AireplaneCreator();
//ITransport airplane = creator.CreateTransport();
//airplane.Deliver();

//creator = new TruckCreator();
//ITransport truck = creator.CreateTransport();
//truck.Deliver();

//Console.WriteLine("Example with enemies ");
//IEnemyCreator enemyCreator = new BossCreator();
//IEnemy boss = enemyCreator.CreateEnemy();
//boss.DealDamage(100);

//enemyCreator = new StrongEnemyCreator();
//IEnemy strongEnemy = enemyCreator.CreateEnemy();
//strongEnemy.DealDamage(50);

//enemyCreator = new WeakEnemyCreator();
//IEnemy weakEnemy = enemyCreator.CreateEnemy();
//weakEnemy.DealDamage(20);

//Console.WriteLine(Environment.NewLine);
//Console.WriteLine("Example with animals");
//IAnimalCreator animalCreator = new GatoCreator();
//Animal cat = animalCreator.CreateAnimal();
//cat.MakeSound();

//animalCreator = new PerroCreator();
//Animal dog = animalCreator.CreateAnimal();
//dog.MakeSound();

//animalCreator = new VacaCreator();
//Animal cow = animalCreator.CreateAnimal();
//cow.MakeSound();

//Console.WriteLine(Environment.NewLine);
//Console.WriteLine("Example with figures");
//IFigure square = new Square(10, 20);
//Console.WriteLine($"Square area is: {square.CalculateArea()}");

//IFigure circle = new Circle(10);
//Console.WriteLine($"Circle area is: {circle.CalculateArea()}");

//IFigure triangle = new Triangle(10, 20);
//Console.WriteLine($"Triangle area is: {triangle.CalculateArea()}");

Console.WriteLine("Builder pattern - Enemy builder");
EnemyBuilder enemyBuilder = new EnemyBuilder();
EnemyDirector enemyDirector = new EnemyDirector();
Enemy boss = enemyDirector.BuildBoss(enemyBuilder);
Console.WriteLine("Enemy description - Boss");
Console.WriteLine($"Health: {boss.Health} {Environment.NewLine}" + $"Speed: {boss.Speed} {Environment.NewLine}" + $"Can move: {boss.IsMoving} {Environment.NewLine}" + $"Can shoot: {boss.CanShoot} {Environment.NewLine}" + $"");

Enemy walkingEnemy = enemyDirector.BuildWalkingEnemy(enemyBuilder);
Console.WriteLine("Enemy description - Walking enemy");
Console.WriteLine($"Health: {walkingEnemy.Health} {Environment.NewLine}" +
    $"Speed: {walkingEnemy.Speed} {Environment.NewLine}" +
    $"Can move: {walkingEnemy.IsMoving} {Environment.NewLine}" +
    $"Can shoot: {walkingEnemy.CanShoot} {Environment.NewLine}");