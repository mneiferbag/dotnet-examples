using NUnit.Framework;

[TestFixture] 
class SimpleTest {
    [Test]
    public void testSimpleClass() {
        SimpleClass s = new SimpleClass();
        Assert.AreEqual("hello, world", s.getGreeting());
    }
}
class SimpleClass {
    internal string getGreeting() {
        return "hello, world";
    }
}
