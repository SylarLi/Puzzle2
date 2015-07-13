﻿using Core;

public class LevelInputEvent : Event
{
    public const string TouchStart = "TouchStart";
    public const string TouchEnd = "TouchEnd";
    public const string TouchClick = "TouchClick";
    public const string Key = "Key";

    public LevelInputEvent(string type, object data = null) : base(type, data)
    {

    }
}
