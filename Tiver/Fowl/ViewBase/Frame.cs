﻿namespace Tiver.Fowl.ViewBase
{
    using System;
    using Core.Context;

    public class Frame : View, IDisposable
    {
        public Frame(string frameLocator)
        {
            TestExecutionContext.BrowserActions.SwitchToFrame(frameLocator);
        }

        public void Dispose()
        {
            TestExecutionContext.BrowserActions.SwitchToMainFrame();
        }
    }
}