public abstract class Garage
{
    protected Garage next;
    public void SetNext(Garage next)
    {
        this.next = next;
    }
    public abstract void Handle(Car car);
}