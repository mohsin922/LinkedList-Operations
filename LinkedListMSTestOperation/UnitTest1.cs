using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListOperations;

namespace LinkedListMSTestOperation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindNode()
        {
            //Arrange
            LinkedList n = new LinkedList();
            int node =  30;
            //Act
            int actual = n.Search(30);
            //Assert
            Assert.AreEqual(node, actual);
        }
    }
}
