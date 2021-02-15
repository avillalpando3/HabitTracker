using HabitTracker.DAL;
using HabitTracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void TestInsertToDB()
        {
            var group = new Group()
            {
                Group_ID = 0,
                Name = "Test1",
                SortPrecedence = 1,
                Color = "Red"
            };
            var group_Controller = new Group_DAL();
            
            var id = group_Controller.Create(group);

            Assert.AreNotEqual(0, id);
        }

        //[TestMethod]
        //public void TestUpdateToDB()
        //{
        //    var group = new Group()
        //    {
        //        Group_ID = 0,
        //        Name = "Test1",
        //        SortPrecedence = 1,
        //        Color = "Red"
        //    };
        //    var group_Controller = new Group_DAL();

        //    var id = group_Controller.Create(group);

        //    Assert.AreNotEqual(0, id);
        //}

        //[TestMethod]
        //public void TestDeleteToDB()
        //{
        //    var group = new Group()
        //    {
        //        Group_ID = 0,
        //        Name = "Test1",
        //        SortPrecedence = 1,
        //        Color = "Red"
        //    };
        //    var group_Controller = new Group_DAL();

        //    var id = group_Controller.Create(group);

        //    Assert.AreNotEqual(0, id);
        //}
    }
}
