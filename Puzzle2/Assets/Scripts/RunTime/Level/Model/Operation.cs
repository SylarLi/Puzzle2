using System.IO;

public class Operation : IOperation
{
    private OpType _type;

    public Operation() : base()
    {

    }

    public Operation(OpType type)
    {
        _type = type;
    }

    public void WriteIn(BinaryWriter writer)
    {
        writer.Write((int)_type);
    }

    public void ReadOut(BinaryReader reader)
    {
        _type = (OpType)reader.ReadInt32();
    }

    public OpType type
    {
        get
        {
            return _type;
        }
    }
}
