﻿using NUnit.Framework;
namespace WebAddressbookTests
{
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(new GroupData("test name", "text1", "text2"));
            SubmitGroupCreation();
            ReturnToGroupsPage();
        }
    }
}
