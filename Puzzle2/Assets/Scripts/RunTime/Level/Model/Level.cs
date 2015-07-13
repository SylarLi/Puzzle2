using Core;

public class Level : EventDispatcher, ILevel
{
    private IRecord _record;

    private IResolver _resolver;

    public Level()
    {
        _record = new Record();
        _resolver = new Resolver();
    }

    public IRecord record
    {
        get
        {
            return _record;
        }
    }

    public IResolver resolver
    {
        get
        {
            return _resolver;
        }
    }
}
