﻿using Anotar.Custom;
using Xunit;

public class CustomExplicitSample
{
    [Fact]
    public void Run()
    {
        MyMethod();

        Assert.Equal("Method: 'Void MyMethod()'. Line: ~16. TheMessage", Logger.LastMessage.Format);
    }

    static void MyMethod()
    {
        LogTo.Debug("TheMessage");
    }
}