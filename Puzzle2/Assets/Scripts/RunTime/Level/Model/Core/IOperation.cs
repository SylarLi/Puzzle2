public interface IOperation : IStream
{
    /// <summary>
    /// 操作类型
    /// </summary>
    OpType type { get; }
}
