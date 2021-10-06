using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitCroupCreation();

            GroupData group = new GroupData("a");
            group.Header = "d";
            group.Footer = "f";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }
    }
}

