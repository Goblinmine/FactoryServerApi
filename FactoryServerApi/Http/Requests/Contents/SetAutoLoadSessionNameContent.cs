﻿namespace FactoryServerApi.Http.Requests.Contents;

internal class SetAutoLoadSessionNameContent : FactoryServerContent
{
    public SetAutoLoadSessionNameContent(string sessionName) : base("SetAutoLoadSessionName")
    {
        Data = new SinglePropertyFactoryServerContentData("SessionName", sessionName);
    }
}
