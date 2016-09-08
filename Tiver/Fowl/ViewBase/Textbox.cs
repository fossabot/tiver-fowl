﻿namespace Tiver.Fowl.ViewBase
{
    using Core.Context;
    using OpenQA.Selenium;

    public class Textbox : Element
    {
        public Textbox(string locator)
            : base(locator)
        {
        }

        public Textbox(string locator, string name) : base(locator, name)
        {
        }

        public void Type(string value)
        {
            LogAction($"Type value '{value}'");
            this.Process(e => e.SendKeys(value));
        }

        public void SetValue(string value)
        {
            this.Process(
                e => TestExecutionContext.Browser.BrowserActions.ExecuteScript($"arguments[0].setAttribute('value', '{value}')", e));
        }

        public void PressEnter()
        {
            LogAction($"Press key 'Enter'");
            this.Process(e => e.SendKeys(Keys.Enter));
        }
    }
}
