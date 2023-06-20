using MyLibrary;

namespace TestApp
{
    public class JsonUtilsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSerialize()
        {
            string sampleJson = "{\"Name\":\"Manoj V\", \"Experience\":20}";
            Employee actualEmployee = new();
            actualEmployee.Name = "Manoj V";
            actualEmployee.Experience = 20;
            Employee resultEmployee = JsonUtils.GetObject<Employee>(sampleJson);
            Assert.That(resultEmployee, Is.EqualTo(actualEmployee));
        }

        [Test]
        public void TestDerialize()
        {
            Assert.Pass();
        }
    }
}