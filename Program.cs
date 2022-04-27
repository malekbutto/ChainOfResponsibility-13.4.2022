class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Garage Primer = new PrimerCheck();
        Garage Elec = new Electricity();
        Garage OverAll = new OverAllCheck();
        Garage Diagnostic = new Diagnostics();

        Primer.SetNext(Elec);
        Elec.SetNext(OverAll);
        OverAll.SetNext(Diagnostic);
        Diagnostic.SetNext(null); // emphasis that this is the last handler

        Primer.Handle(car);
        if (!car.Carfixed)
            Console.WriteLine("Car failed at " + car.Department + " department with Mark: " + car.Mark);
        else
            Console.WriteLine("Car has no problems");
    }
}