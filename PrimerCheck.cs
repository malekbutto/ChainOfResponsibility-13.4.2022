class PrimerCheck : Garage
{
    public override void Handle(Car car)
    {
        Random rnd = new Random();
        car.Mark = rnd.Next(1, 11);
        if (car.Mark >= 6)
        {
            car.Carfixed = true;
            car.Department = this.ToString();
            next.Handle(car);
        }
        else
        {
            car.Carfixed = false;
            car.Department = this.ToString();
        }
    }
}