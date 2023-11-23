using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrirGithub
{
    internal class AutomationWeb
    {
        private IWebDriver? driver;

        public AutomationWeb()
        {
            driver = new EdgeDriver();
        }

        public void TesteWeb()
        {
            driver!.Navigate().GoToUrl("https://github.com/login");
            TimeSpan.FromSeconds(5);
            driver!.FindElement(By.Name("login")).SendKeys("projetointegrador03gen@gmail.com");
            driver!.FindElement(By.Name("password")).SendKeys("amorTeRsIatE03");
            driver!.FindElement(By.Name("commit")).Click();
            driver!.Navigate().GoToUrl("https://github.com/Projeto-Integrador-Grupo03/BackEnd");
        }
    }
}
