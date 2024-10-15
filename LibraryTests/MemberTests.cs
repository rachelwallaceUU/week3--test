using Library;

namespace LibraryTests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange - give info to test
            int memberId = 1;
            string name = "John Doe";
            string address = "123 High Street";
            int phone = 123456789;

            // Act - running the code that we are testing
            Member member = new Member(memberId, name, address, phone); // a constructor

            // Assert - test things that are inside the class
            Assert.AreEqual(memberId, member.MemberId);
            Assert.AreEqual(name, member.Name);
            Assert.AreEqual(address, member.Address);
            Assert.AreEqual(phone, member.Phone);
        }

        [TestMethod]
        public void NameProperty_ShouldGetAndSet()
        {
            // Arrange
            Member member = new Member(1, "John Doe", "123 High Street", 123456789);
            string newName = "Jane Doe";

            // Act - changing john doe to jane doe
            member.Name = newName;

            // Assert
            Assert.AreEqual(newName, member.Name);

        }
    }
}