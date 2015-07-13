using Core;

/// <summary>
/// 关卡
/// </summary>
public interface ILevel : IEventDispatcher
{
    /// <summary>
    /// 玩家操作记录
    /// </summary>
    IRecord record { get; }

    /// <summary>
    /// 解析器：描述操作对关卡的影响，以及过关的判断
    /// </summary>
    IResolver resolver { get; }
}
