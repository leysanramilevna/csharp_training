using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            SelectGroup(1);
            RemoveGroups();
            ReturnToGroupsPage();
        }
    }
}
