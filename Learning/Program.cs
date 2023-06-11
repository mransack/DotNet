// See https://aka.ms/new-console-template for more information
using Learning;
using Microsoft.Extensions.Logging;

Console.WriteLine("Welcome to Positivity!");

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddFilter("Microsoft", LogLevel.Warning)
        .AddFilter("System", LogLevel.Warning)
        .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug);
        //.AddConsole();
});
ILogger logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Example log message");

//1. Test Delegates
//new Delegates().TestMethod();

//2. Test WeakReference
//new WeakReferenceUnderstand().test();

//3. DotEvents
//DotEvents.DemoCustomEvents();

//4. Async Await
//await AsyncAwait.TestAsyncAwait();

//5. Inheritence //Hiding
//Parent parent = new Parent();
//parent.Print();

//Child child = new Child();
//child.Print();

//Parent child1 = new Child();
//child1.Print();

//6. IDisposable
//FileHandler handler = new FileHandler("Testing new File");
//handler.GetFileDetails();
//handler.Dispose();

//using (FileHandler handler1 = new FileHandler("File 2"))
//{ 
//    handler1.GetFileDetails();
//}

//7. Task.all / Task.waitany

//TasksTest test= new TasksTest();
//test.DemoTasks();
//test.DemoTaskWhenAll();

//8. Prime
//new PrimeClass().IsPrime(9);

//9. HashSet Example
HashSetExample.CountUniqueCharatersWithDictionary("aaabbcc");
//HashSetExample.CountUniqueCharactersPresence("Masud");
HashSetExample.CountUniqueCharatersWithDictionary("Masud");