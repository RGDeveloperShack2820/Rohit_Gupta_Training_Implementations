// See https://aka.ms/new-console-template for more information

using Design_Patterns.Factory_Method_pattern;
using Design_Patterns.Abstract_Factory_Method_Pattern;
using Design_Patterns.Memento_pattern;
using Design_Patterns.Singleton_Pattern;
using Design_Patterns.State_Pattern;
using Design_Patterns.Builder_Pattern;
using Design_Patterns.Prototype_Pattern;
using Design_Patterns.Adapter_Pattern;
using Design_Patterns.Facade_Pattern;
using Design_Patterns.Proxy_Pattern;
using Design_Patterns.Decorator_Pattern;
using Design_Patterns.Bridge_Pattern;
using Design_Patterns.Flyweight_Pattern;
using Design_Patterns.Composite_Pattern;
using Design_Patterns.Chain_Of_Responsibility_Pattern;
using System.Reflection.Metadata;
using Design_Patterns.Command_Pattern;
using Design_Patterns.Interpreter_Pattern;
using Design_Patterns.Template_Pattern;
using Design_Patterns.SOLID_Principles.Single_Responsibility_Principle;
using SOLID_Principles.Open_Close_Principle;
using SOLID_Principles.Liskov_s_Substitution_Principle;
using SOLID_Principles.Interface_Segregation_Princliple;
using SOLID_Principles.Dependency_Inversion_Principle;
using OOPS_Concepts.Inheritance;
using OOPS_Concepts.Abstraction;
using OOPS_Concepts.Encapsulation;
using OOPS_Concepts.Aggregation;
using OOPS_Concepts.Composition;
using Design_Patterns.OOPS_Concepts.Polymorphism;
using Design_Patterns.OOPS_Concepts.Constructors;
using static Design_Patterns.OOPS_Concepts.Constructors.MyClass;
using Design_Patterns.Design_Patterns_Implementation.Strategy_Pattern;
using Design_Patterns_Implementation.Visitor_Pattern;
using Design_Patterns_Implementation.Observer_Pattern;
using Design_Patterns_Implementation.Iterator_Pattern;
using Design_Patterns_Implementation.Mediator_Pattern;
using Design_Patterns.SOLID_Principles.K.I.S.S_principle;
using Design_Patterns.SOLID_KISS_DRY_YAGNI_Principles.YAGNI_principle;
using Design_Patterns.SOLID_KISS_DRY_YAGNI_Principles.DRY_Principle;

void executeBuilderPattern()
{
    Console.WriteLine("5. Builder Pattern\n");
    BuilderA bA = new BuilderA();

    Director d = new Director(bA);

    d.buildProduct();

    ProductA pA=d.getProduct();


}

void executeFacadePattern()
{

    Console.WriteLine("10. Facade Pattern\n");
    Shopkeeper shopkeeper = new Shopkeeper();

    shopkeeper.getSamsung();
    shopkeeper.getApple();
}

void executeStatePattern()
{
    Console.WriteLine("20. State Pattern\n");
    Canvas c = new Canvas();
    c.setTool(new Pen());
    c.mouseClicked();
    c.mouseReleased();

    Console.WriteLine();

    c.setTool(new Brush());
    c.mouseClicked();
    c.mouseReleased();
}

void executeMementoPattern()
{
    Console.WriteLine("18. Memento Pattern\n");
    Editor editor = new Editor();
    StateManager stateManager = new StateManager();

    editor.setContent("a");
    editor.setTitle("A");
    stateManager.push(editor.createState());

    editor.setContent("b");
    editor.setTitle("B");
    stateManager.push(editor.createState());

    editor.setContent("c");
    editor.setTitle("C");

    editor.restore(stateManager.pop());
    editor.restore(stateManager.pop());

    Console.WriteLine("Content: " + editor.getContent());
    Console.WriteLine("Title: " + editor.getTitle());
}

void executeAbstractFactoryMethodPattern()
{
    Console.WriteLine("3. Abstract Factory Method Pattern\n");
    AbstractAnimalFactory f1 = AnimalFactoryMaker.getAbstractFactory("Land");
    Animal a1 = f1.getAnimal("Dog");
    Animal a2 = f1.getAnimal("Cat");

    AbstractAnimalFactory f2 = AnimalFactoryMaker.getAbstractFactory("Water");
    Animal a3 = f2.getAnimal("Shark");
    Animal a4 = f2.getAnimal("Whale");

    Console.Write("Dog: ");
    a1.makeSound();
    Console.Write("Cat: ");
    a2.makeSound();
    Console.Write("Shark: ");
    a3.makeSound();
    Console.Write("Whale: ");
    a4.makeSound();
}

void executePrototypePattern()
{
    Console.WriteLine("4. Prototype Pattern\n");

    BookShop b1 = new BookShop("Shop 1", 100, "New York");
    BookShop b2=(BookShop)b1.getClone();

    b1.show();
    b2.show();
}

void executeFactoryMethodPattern()
{
    Console.WriteLine("2. Factory Method Pattern\n");
    ShapeFactory S = new ShapeFactory();
    Shape s1 = S.getShape("Circle");
    Shape s2 = S.getShape("Rectangle");
    Shape s3 = S.getShape("Triangle");

    Console.Write("Circle : ");
    s1.draw();
    Console.Write("Rectangle : ");
    s2.draw();
    Console.Write("Triangle : ");
    s3.draw();
}

void executeSingletonPattern()
{
    Console.WriteLine("1. Singleton Pattern\n");
    Singleton s = Singleton.getInstance();
    Singleton p = Singleton.getInstance();

    Console.WriteLine("Object Count: " + p.getCount());
}

void executeAdapterPattern()
{
    Console.WriteLine("6. Adapter Pattern\n");
    Adaptee adaptee = new Adaptee();
    Target target = new Adapter(adaptee);

    target.getRequest();
}

void executeProxyPattern()
{
    Console.WriteLine("12. Proxy Pattern\n");
    Console.Write("Enter Name : ");
    string name = Console.ReadLine();
    LockerAccessInterface lockerAccess = new ProxyLockerAccess(name);

    lockerAccess.grantAccess();
}

void executeDecoratorPattern()
{
    Console.WriteLine("9. Decorater Pattern\n");

    AbstractPizza p=new Pizza();
    Console.WriteLine(p.getDescription() + " : Rs." + p.getCost());

    AbstractPizza p1 = new VegToppings(new Pizza());
    Console.WriteLine(p1.getDescription()+" : Rs."+p1.getCost());

    AbstractPizza p2 = new NonVegToppings(new Pizza());
    Console.WriteLine(p2.getDescription() + " : Rs." + p2.getCost());
}

void executeBridgePattern()
{
    Console.WriteLine("8. Bridge Pattern\n");

    Remote tvRemote = new TVRemote(new TVDevice());
    Remote dvdRemote = new DVDRemote(new DVDPlayer());

    tvRemote.fwdButtonPressed();
    tvRemote.bwdButtonPressed();

    dvdRemote.fwdButtonPressed();
    dvdRemote.bwdButtonPressed();

}

void executeFlyweightPattern()
{
    Console.WriteLine("11. Flyweight Pattern\n");

    VehicleFactory f1=new VehicleFactory();

    Vehicle v1 = f1.getVehicle("Car");
    Vehicle v2 = f1.getVehicle("Bike");
    Vehicle v3 = f1.getVehicle("Rikshaw");
    Vehicle v4 = f1.getVehicle("Car");

    v1.setPaint("Black");
    v2.setPaint("Red");
    v3.setPaint("Yellow");
    v4.setPaint("Grey");
}

void executeCompositePattern()
{
    Console.WriteLine("7. Composite  Pattern\n");

    Employee bankManager = new Manager("Rohit", 50000);
    Employee cashier = new Cashier("Mohan", 35000);
    Employee guard = new Guard("Raj", 15000);

    cashier.addEmployee(bankManager);
    cashier.removeEmployee(bankManager);

    cashier.printDetails();
    guard.printDetails();

    Console.WriteLine();
    bankManager.addEmployee(cashier);
    bankManager.addEmployee(guard);
    Console.WriteLine();

    bankManager.printDetails();

    Console.WriteLine();
    bankManager.removeEmployee(cashier);
    Console.WriteLine();

    bankManager.printDetails();

}

void executeChainOfResponsibilityPattern()
{
    Console.WriteLine("13. Chain Of Responsibility Pattern\n");

    Chain first = new Addition();
    Chain second = new Subtract();
    Chain third = new Multiply();

    first.setNextChain(second);
    second.setNextChain(third);

    Calculate c1 = new Calculate(5,7,"add");
    Calculate c2 = new Calculate(5,7,"sub");
    Calculate c3 = new Calculate(5,7,"mult");
    Calculate c4 = new Calculate(5,7,"divide");

    first.performCalculation(c1);
    first.performCalculation(c2);
    first.performCalculation(c3);
    first.performCalculation(c4);
}

void executeCommandPattern()
{
    Console.WriteLine("14. Command  Pattern\n");

    DOC document = new DOC();

    Command open=new OpenCommand(document);
    Command save=new SaveCommand(document);

    DocHandler handler1 = new DocHandler(open);
    DocHandler handler2=new DocHandler(save);

    handler1.execute();
    handler2.execute();
}

void executeInterpreterPattern()
{
    Console.WriteLine("15. Interpreter Pattern\n");

    int data = 5;

    Pattern decimalToBinary = new DecimalToBinary(data);

    Console.WriteLine( $"Decimal : {data} \nBinary : { decimalToBinary.getConversion()}" );


}

void executeTemplatePattern()
{
    Console.WriteLine("22. Template Pattern\n");

    Game templeRun=new TempleRun();
    Game roadRash=new RoadRash();

    templeRun.play();
    Console.WriteLine();
    roadRash.play();
}

void printDesignPatternMenu() {


    Console.WriteLine("--------------------DESIGN PATTERNS---------------------\n");
    Console.WriteLine("Choose From The Given Patterns Below :\n");
    Console.WriteLine("A). Creational Design Patterns :\n");
    Console.WriteLine("1. Singleton Pattern");
    Console.WriteLine("2. Factory Method Pattern");
    Console.WriteLine("3. Abstract Factory Method Pattern");
    Console.WriteLine("4. Prototype Pattern");
    Console.WriteLine("5. Builder Pattern");

    Console.WriteLine("\n\nB). Structural Design Patterns :\n");
    Console.WriteLine("6. Adapter Pattern");
    Console.WriteLine("7. Composite  Pattern");
    Console.WriteLine("8. Bridge Pattern");
    Console.WriteLine("9. Decorater Pattern");
    Console.WriteLine("10. Facade Pattern");
    Console.WriteLine("11. Flyweight Pattern");
    Console.WriteLine("12. Proxy Pattern");

    Console.WriteLine("\n\nC). Behaviour Design Patterns :\n");
    Console.WriteLine("13. Chain Of Responsibility Pattern");
    Console.WriteLine("14. Command  Pattern");
    Console.WriteLine("15. Interpreter Pattern");
    Console.WriteLine("16. Iterator Pattern");
    Console.WriteLine("17. Mediator Pattern");
    Console.WriteLine("18. Memento Pattern");
    Console.WriteLine("19. Observer Pattern");
    Console.WriteLine("20. State Pattern");
    Console.WriteLine("21. Strategy Pattern");
    Console.WriteLine("22. Template Pattern");
    Console.WriteLine("23. Visitor Pattern");


    Console.Write("\n\nEnter Choice : ");

}

void printSolidMenu()
{

    Console.WriteLine("--------------------SOLID DESIGN PRINCIPLES---------------------\n");
    Console.WriteLine("Choose From The Given Patterns Below :\n");

    Console.WriteLine("1. Single Responsibility Principle");
    Console.WriteLine("2. Open/Closed Principle");
    Console.WriteLine("3. Liskov’s Substitution Principle (LSP)");
    Console.WriteLine("4. Interface Segregation Principle (ISP)");
    Console.WriteLine("5. Dependency Inversion Principle (DIP)");
    Console.WriteLine("6. Keep It Simple Stupid Principle (K.I.S.S)");
    Console.WriteLine("7. You Ain't Gonna Need It Principle (YAGNI)");
    Console.WriteLine("8. Don't Repeat Yourself Principle (DRY)");



    Console.Write("\n\nEnter Choice : ");
}

void executeDesignPatterns()
{
    printDesignPatternMenu();

    String input = Console.ReadLine();

    Console.Clear();

    switch (input)
    {

        case "1":
            {
                executeSingletonPattern();
                break;
            }

        case "2":
            {
                executeFactoryMethodPattern();
                break;
            }
        case "3":
            {
                executeAbstractFactoryMethodPattern();
                break;
            }

        case "4":
            {
                executePrototypePattern();
                break;
            }

        case "5":
            {
                executeBuilderPattern();
                break;
            }

        case "6":
            {
                executeAdapterPattern();
                break;
            }

        case "7":
            {
                executeCompositePattern();
                break;
            }

        case "8":
            {
                executeBridgePattern();
                break;
            }


        case "9":
            {
                executeDecoratorPattern();
                break;
            }

        case "10":
            {
                executeFacadePattern();
                break;
            }

        case "11":
            {
                executeFlyweightPattern();
                break;
            }

        case "12":
            {
                executeProxyPattern();
                break;
            }

        case "13":
            {
                executeChainOfResponsibilityPattern();
                break;
            }

        case "14":
            {
                executeCommandPattern();
                break;
            }

        case "15":
            {
                executeInterpreterPattern();
                break;
            }

        case "16":
            {
                executeIteratorPattern();
                break;
            }

        case "17":
            {
                executeMediatorPattern();
                break;
            }

        case "18":
            {
                executeMementoPattern();
                break;
            }


        case "19":
            {
                executeObserverPattern();
                break;
            }

        case "20":
            {

                executeStatePattern();
                break;
            }

        case "21":
            {

                executeStrategyPattern();
                break;
            }

        case "22":
            {

                executeTemplatePattern();
                break;
            }

        case "23":
            {

                executeVisitorPattern();
                break;
            }


        default:
            {

                Console.WriteLine("Invalid Input");
                break;

            }

    }

}

void printOopsMenu()
{
    Console.WriteLine("--------------------OOPS Concepts---------------------\n");
    Console.WriteLine("Choose From The Given Concepts Below :\n");
    Console.WriteLine("1. Inheritance");
    Console.WriteLine("2. Abstraction");
    Console.WriteLine("3. Encapsulation");
    Console.WriteLine("4. Aggregation");
    Console.WriteLine("5. Compostion");
    Console.WriteLine("6. Polymorphism");
    Console.WriteLine("7. Constructors");

    Console.Write("\n\nEnter Choice : ");
}

void executeOopsConcepts()
{
    printOopsMenu();

    String input = Console.ReadLine();

    Console.Clear();

    switch (input)
    {

        case "1":
            {
                executeInheritance();
                break;
            }

        case "2":
            {
                executeAbstraction();
                break;
            }
        case "3":
            {
                executeEncapsulation();
                break;
            }

        case "4":
            {
               executeAggregation();
                break;
            }

        case "5":
            {
                executeComposition();
                break;
            }

        case "6":
            {
                executePolymorphism();
                break;
            }

        case "7":
            {
                executeConstructors();
                break;
            }


        default:
            {

                Console.WriteLine("Invalid Input");
                break;

            }

    }
}

void printMainMenu()
{
    Console.WriteLine("--------------------Training Implementations---------------------\n");
    Console.WriteLine("Choose From The Given Implementations Below :\n");

    Console.WriteLine("1. OOPS Concepts");
    Console.WriteLine("2. Design Principles");
    Console.WriteLine("3. Design Patterns");

    Console.Write("\n\nEnter Choice : ");
}

void executeMain()
{
    printMainMenu();

    String input = Console.ReadLine();

    Console.Clear();

    switch (input)
    {

        case "1":
            {
                executeOopsConcepts();
                break;
            }

        case "2":
            {
                executeSolidPrinciples();
                break;
            }
        case "3":
            {
                executeDesignPatterns();
                break;
            }

        default :
            {

                Console.WriteLine("Invalid Input");
                break;

            }
    }

}

void executeSolidPrinciples()
{
    printSolidMenu();

    String input = Console.ReadLine();

    Console.Clear();

    switch (input)
    {

        case "1":
            {
                executeSRP();
                break;
            }

        case "2":
            {
                executeOpenCLose();
                break;
            }
        case "3":
            {
                executeLSP();
                break;
            }

        case "4":
            {
                executeISP();
                break;
            }

        case "5":
            {
                executeDIP();
                break;
            }

        case "6":
            {
                executeKISS();
                break;
            }

        case "7":
            {
                executenYAGNI();
                break;
            }

        case "8":
            {
                executenDRY();
                break;
            }

        default:
            {

                Console.WriteLine("Invalid Input");
                break;

            }
    }
}

void executeSRP()
{
    Console.WriteLine("1. Single Responsibility Principle\n");
    Calculator calculator = new Add(5,5);
    Calculator calculator1 = new Sub(5,5);

    Console.WriteLine(calculator.calculate());
    Console.WriteLine(calculator1.calculate());
}

void executeOpenCLose()
{
    Console.WriteLine("2. Open/Closed Principle\n");
    Calci calculator = new Adding(5, 5);
    Calci calculator1 = new Subtracting(5, 5);
    Calci calculator2 = new Multiplying(5 , 5);

    Console.WriteLine(calculator.calculate());
    Console.WriteLine(calculator1.calculate());
    Console.WriteLine(calculator2.calculate());
}

void executeLSP()
{
    Console.WriteLine("3. Liskov’s Substitution Principle (LSP)\n");

    Cars cars = new PoliceCar();
    cars.drive();

}

void executeISP()
{
    Console.WriteLine("4. Interface Segregation Principle (ISP)\n");

    AutoPilotCar car = new BMW();
    AutoPilotTrain train = new BulletTrain();

    car.moveForward();
    car.moveBackward();
    car.moveLeft();
    car.moveRight();

    train.moveBackward();
    train.moveForward();
}

void executeDIP()
{
    Console.WriteLine("5. Dependency Inversion Principle (DIP)\n");

    SalaryInterface salary = new SalaryCalculator();

    EmployeeDetails empDetails = new EmployeeDetails(25,500,salary);
    empDetails.getSalary();
}

void executeInheritance()
{
    Console.WriteLine("1. Inheritance\n");
    Console.WriteLine("Single Level Inheritance\n");

    Single_Level_Inheritance single_Level_Inheritance = new Single_Level_Inheritance();
    single_Level_Inheritance.execute();

    Console.WriteLine("\nMultilevel Inheritance\n");

    Multilevel multilevel = new Multilevel();
    multilevel.execute();

    Console.WriteLine("\nMultiple Inheritance\n");

    Multiple multiple = new Multiple(); 
    multiple.execute();

    Console.WriteLine("\nHybrid Inheritance\n");

    Hybrid hybrid = new Hybrid();
    hybrid.execute();

    Console.WriteLine("\nHierarichal Inheritance\n");

    Heirarichal heirarichal = new Heirarichal();
    heirarichal.execute();

}

void executeAbstraction()
{ 
    Console.WriteLine("2. Abstraction\n");
    Computer c1=new WindowsMachine();
    c1.compute();

}

void executeEncapsulation()
{
    Console.WriteLine("3. Encapsulation\n");
    Account sbi =new SBIAccount();
    sbi.setBalance(20000);
    Console.WriteLine("Balance : "+sbi.getBalance());
}

void executeAggregation()
{
    Console.WriteLine("4. Aggregation\n");
    Teacher teacher = new Teacher("Rohan", 50000);
    Students s1 = new Students("Rohit", 22, 75);
    Students s2 = new Students("Mohit", 21, 80);

    teacher.addStudent(s1);
    teacher.addStudent(s2);

    Console.WriteLine($"Student : {s1.getName()} | Age : {s1.getAge()} | Marks : {s1.getMarks()}");
    Console.WriteLine($"Student : {s2.getName()} | Age : {s2.getAge()} | Marks : {s2.getMarks()}");

    Console.WriteLine($"Teacher : {teacher.getName()} | Salary : {teacher.getSalary()}");
    teacher.getStudents();


}

void executeComposition()
{
    Console.WriteLine("5. Compostion\n");
    University u1 = new University("MDU");
    Departments science = new Departments("Science");
    Departments maths = new Departments("Maths");

    u1.addDepartment(science);
    u1.addDepartment(maths);

    Console.WriteLine("Department : "+science.getName());
    Console.WriteLine("Department : "+maths.getName());

    Console.WriteLine("University : "+u1.getName());
    u1.getDepartments();


}

void executePolymorphism()
{
    Console.WriteLine("6. Polymorphism\n");
    Console.WriteLine("\nRuntime Polymorphism : Overriding\n");

    Overriding overriding = new Overriding();
    overriding.execute();

    Console.WriteLine("\nCompile Time Polymorphism : Overloading\n");

    Overloading overloading = new Overloading();
    overloading.execute();
}

void executeConstructors()
{
    Console.WriteLine("7. Constructors\n");
    
    Console.WriteLine("\nDefault Constructor\n");

    DefaultConstructor defaultConstructor = new DefaultConstructor();
    defaultConstructor.execute();

    Console.WriteLine("\nParameterized Constructor\n");

    ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor();
    parameterizedConstructor.execute();

    Console.WriteLine("\nCopy Constructor\n");

    CopyConstructor copyConstructor = new CopyConstructor();
    copyConstructor.execute();

    Console.WriteLine("\nPrivate Constructor\n");

    PrivateConstructor privateConstructor = new PrivateConstructor();
    privateConstructor.execute();

    Console.WriteLine("\nStatic Constructor\n");

    StaticConstructor staticConstructor = new StaticConstructor();
    staticConstructor.execute();
}

void executeStrategyPattern()
{
    Console.WriteLine("21. Strategy Pattern\n");
    Scooter scooter = new Scooter("Black",7);

    Console.WriteLine($"Before Repair Scooter : Color = {scooter.getPaint()} | Dents = {scooter.getNoOfDents()}");

    Garage garage = new Garage(new Painting());
    Garage garage1 = new Garage(new Denting());

    garage.start(scooter);
    garage1.start(scooter);

    Console.WriteLine($"After Repair Scooter : Color = {scooter.getPaint()} | Dents = {scooter.getNoOfDents()}");


}

void executeVisitorPattern()
{
    Console.WriteLine("23. Visitor Pattern\n");
    ComputerPart computerPart = new KeyBoard();
    ComputerPart computerPart1 = new Mouse();

    Visitor visitor = new ComputerPartVisitor();

    computerPart.accept(visitor);
    computerPart1.accept(visitor);

}

void executeObserverPattern()
{
    Console.WriteLine("19. Observer Pattern\n");
    Subjects subject = new Subjects();

    Observer observer = new BinaryObserver(subject);
    Observer observer1 = new HexadecimalObserver(subject);
    
    subject.setState(10);
    Console.WriteLine("Decimal : " + subject.getState());
}

void executeIteratorPattern()
{
    Console.WriteLine("16. Iterator Pattern\n");
    CollectionOfNames collectionOfNames = new CollectionOfNames();

    for (Iterator itr = collectionOfNames; itr.hasNext();)
    {
        Console.WriteLine(itr.next());
    }
}

void executeMediatorPattern()
{
    Console.WriteLine("17. Mediator Pattern\n");
    User rohit = new User("Rohit");
    User mohit = new User("Mohit");

    rohit.sendMessage("Hi! Mohit!");
    mohit.sendMessage("Hello! Rohit!");
}

void executeKISS()
{
    Console.WriteLine("6. Keep It Simple Stupid Principle (K.I.S.S)\n");
    KISSPrinciple kISSPrinciple = new KISSPrinciple();

    Console.Write("Complex Implementation : ");
    Console.WriteLine(kISSPrinciple.getweekday1(6));

    Console.Write("Simple Implementation : ");
    Console.WriteLine(kISSPrinciple.getweekday1(6));


}

void executenYAGNI()
{
    Console.WriteLine("7. You Ain't Gonna Need It Principle (YAGNI)\n");
    Stapler  stapler= new Stapler();
    Console.Write(  "Required Functionality For Stapler : " );
    stapler.staple();
    Console.Write("Not Required Functionality For Stapler : ");
    stapler.flash();
}

void executenDRY()
{
    Console.WriteLine("8. Don't Repeat Yourself Principle (DRY)\n");
    DepartmentInfo.execute(); 
}

executeMain();
