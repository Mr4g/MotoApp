using MotoApp;


namespace MotoAppTest 
{
    public class Tests
    {
        public class BasicStackTests 
        {
            [Test]
            public void NewStack_ShouldHaveZeroCount()
            {
                // Arrange
                var stack = new BasicStack();

                // Act & Assert
                Assert.AreEqual(0, stack.Count);
            }

            [Test]
            public void PushingElements_ShouldIncreaseCount()
            {
                // Arrange
                var stack = new BasicStack();

                // Act
                stack.Push(5);
                stack.Push(10);
                stack.Push(15);

                // Assert
                Assert.AreEqual(3, stack.Count);
            }

            [Test]
            public void PoppingElements_ShouldDecreaseCount()
            {
                // Arrange
                var stack = new BasicStack();

                stack.Push(5);
                stack.Push(10);
                stack.Push(15);

                // Act
                stack.Pop();
                stack.Pop();

                // Assert
                Assert.AreEqual(1, stack.Count);
            }

            [Test]

            public void PushingElemnt_ShouldPopSecondElement()
            {
                //arrange
                var stack = new BasicStack();
                double item; 

                
                stack.Push(5);
                stack.Push(555.55);
                stack.Push(111.11);
                //act 
                stack.Pop();
                item = stack.Pop();
                //assert 
                Assert.AreEqual(555.55, item);  
            }
        }
    }
}