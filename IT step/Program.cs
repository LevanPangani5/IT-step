
PartyOrginiser orginiser = new();
Guest guest = new();
guest.Subscribe(orginiser);
orginiser.CutCake(DateTime.Now);

public class MyEventArgs : EventArgs
{
    public string Message { get; }
    public MyEventArgs(string message)
    {
        Message = message;
    }
}

public class PartyOrginiser
{
    public event EventHandler<MyEventArgs>? CakeCutEventEvent;

    protected virtual void OnCakeCutEvent(string message)
    {
        MyEventArgs args = new MyEventArgs(message);
        CakeCutEventEvent?.Invoke(this, args);
    }

    public void CutCake(DateTime date)
    {
        OnCakeCutEvent($"Cake cutting starts at: {date}");
    }
}

//Subscriber
public class Guest
{
    private void VideoUploadEventHandler(object sender, MyEventArgs e)
    {
        Console.WriteLine($"Alert! new notification from Party organisers:\n{e.Message}");
    }

    public void Subscribe(PartyOrginiser orginiser)
    {
        orginiser.CakeCutEventEvent += VideoUploadEventHandler;
    }

    public void UnSubscribe(PartyOrginiser orginiser)
    {
        orginiser.CakeCutEventEvent -= VideoUploadEventHandler;
    }
}