using DesignPattern.AbstractFactory;
using DesignPattern.Builder;
using DesignPattern.ChainOfResponsibility;
using DesignPattern.Factory;
using DesignPattern.Iterator;
using DesignPattern.Mediator;
using DesignPattern.Memento;
using DesignPattern.Observer.WeatherStation;
using DesignPattern.Prototype;
using DesignPattern.Singleton;
using DesignPattern.Template;
using System.Diagnostics;

Parallel.For(0, 10000, (i) =>
{
    Singleton singleton = Singleton.Instance;
});

Debug.Assert(Singleton.count == 1);

Parallel.For(0, 10000, (i) =>
{
    SingletonThreadSafe singleton = SingletonThreadSafe.Instance;
});

Debug.Assert(SingletonThreadSafe.count == 1);

Parallel.For(0, 10000, (i) =>
{
    SingletonThreadsafeOptimized singleton = SingletonThreadsafeOptimized.Instance;
});

Debug.Assert(SingletonThreadsafeOptimized.count == 1);

{
    SingletonKindaLazy singleton1 = SingletonKindaLazy.Instance;
    SingletonKindaLazy singleton2 = SingletonKindaLazy.Instance;

    Debug.Assert(singleton1 == singleton2);
}

{
    SingletonWrapperLazy singleton1 = SingletonWrapperLazy.Instance;
    SingletonWrapperLazy singleton2 = SingletonWrapperLazy.Instance;

    Debug.Assert(singleton1 == singleton2);
}

{
    SingletonLazy singleton1 = SingletonLazy.Instance;
    SingletonLazy singleton2 = SingletonLazy.Instance;

    Debug.Assert(singleton1 == singleton2);
}


ComputerFactory computerFactory = new ComputerFactory();
computerFactory.GetComputer(ComputerType.DESKTOP).ShutDown();
computerFactory.GetComputer(ComputerType.LAPTOP).ShutDown();

/*
 *          Rap    Country
 * 90's     
 * Modern   
 */


SongFactory songFactory = new SongFactory();

var rapFactory = songFactory.GetSongFactory(SongType.RAP);

rapFactory.GetSong(SongTimePeriod._90S).Play();
rapFactory.GetSong(SongTimePeriod.Modern).Play();

var countryFactory = songFactory.GetSongFactory(SongType.COUNTRY);

countryFactory.GetSong(SongTimePeriod._90S).Play();
countryFactory.GetSong(SongTimePeriod.Modern).Play();

/*
 * 
 *   ISong -> 90Rap, 90Country, Rap, Country
 *   IFactory -> RapFact, CounytryFact
 *   SongFactory -> IFactory -> ISong
 */


Box box = new Box { Height = 10, Width = 11 };
Box clonedBox = (Box)box.CustomClone();

Debug.Assert(clonedBox.Height == box.Height && clonedBox.Width == box.Width);

Circle circle = new Circle { Radius = 100 };
Circle clonedCircle = (Circle)circle.CustomClone();

Debug.Assert(circle.Radius == clonedCircle.Radius);

Debug.Assert(ReferenceEquals(clonedCircle, circle) == false);

BoxMemberWise boxMemberWise = new BoxMemberWise { Height = 2, Width = 1, Circle = new Circle { Radius = 10 } };
BoxMemberWise clonedBoxMemberWise = (BoxMemberWise)boxMemberWise.Clone();

Debug.Assert(ReferenceEquals(boxMemberWise.Circle, clonedBoxMemberWise.Circle) == false);


BoxDeepCopy boxDeepCopy = new BoxDeepCopy { CircleDeepCopy = new CircleDeepCopy { Radius = 10 }, Width = 100, Height = 100 };
BoxDeepCopy clonedBoxDeepCopy = boxDeepCopy.DeepCopy();

Debug.Assert(ReferenceEquals(boxDeepCopy.CircleDeepCopy, clonedBoxDeepCopy.CircleDeepCopy) == false);

MealBuilder mealBuilder = new MealBuilder();

var vegMeal = mealBuilder.PrepareVegMeal();
vegMeal.ShowFoods();
Console.WriteLine(vegMeal.GetCost() + " Cost");

var nonVegMeal = mealBuilder.PrepareNonVegMeal();
nonVegMeal.ShowFoods();
Console.WriteLine(nonVegMeal.GetCost() + " Cost");

Logger.Log("Okay", LogType.CONSOLE);
Logger.Log("Not Okay", LogType.FILE);
Logger.Log("Not Not Okay", LogType.DB);

BaseGame archerGame = new ArcherGame();
archerGame.Play();

BaseGame footballGame = new FootballGame();
footballGame.Play();

WeatherDataProvider weatherData = new WeatherDataProvider();

CurrentConditionsDisplay currentDisp = new CurrentConditionsDisplay(weatherData);
ForecastDisplay forecastDisp = new ForecastDisplay(weatherData);

weatherData.SetMeasurements(40, 78, 3);
Console.WriteLine();
weatherData.SetMeasurements(45, 79, 4);
Console.WriteLine();
weatherData.SetMeasurements(46, 73, 6);

forecastDisp.Dispose();
Console.WriteLine();
Console.WriteLine("Forecast Display removed");
Console.WriteLine();
weatherData.SetMeasurements(36, 53, 8);

var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine();

TextEditor editor = new TextEditor("Hello world!");

UndoRedoHandler undoRedoHandler = new UndoRedoHandler(editor);
undoRedoHandler.Save();

editor.SetText("Hello worl");
undoRedoHandler.Save();

editor.SetText("Hello wo");
undoRedoHandler.Save();

editor.SetText("Hello");
undoRedoHandler.Save();

undoRedoHandler.ShowHistory();

undoRedoHandler.Undo();
Console.WriteLine($"{editor.Text} Current State");

undoRedoHandler.Undo();
Console.WriteLine($"{editor.Text} Current State");

undoRedoHandler.Redo();
Console.WriteLine($"{editor.Text} Current State");

undoRedoHandler.Undo();
Console.WriteLine($"{editor.Text} Current State");

undoRedoHandler.Redo();
Console.WriteLine($"{editor.Text} Current State");

undoRedoHandler.ShowHistory();


IChatRoom chatRoom = new ChatRoom();

IUser fbBotUser = new FBBotUser("Bot from fb");
IUser regularUser = new RegularUser("Bob");

chatRoom.Register(fbBotUser);
chatRoom.Register(regularUser);

fbBotUser.Send("Bob", "Hello click on link www.trackme.fb.com");
regularUser.Send("Bot from fb", "Okay wait!");


Console.WriteLine("Please enter to exit!");
Console.ReadLine();
