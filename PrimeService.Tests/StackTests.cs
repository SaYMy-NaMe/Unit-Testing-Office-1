using NUnit.Framework;
using Prime.Services;  

namespace PrimeService.Tests  
{
    [TestFixture]
    public class StackTests
    {
        private Prime.Services.Stack<int> _stack;

         [SetUp]
        public void SetUp()
        {
            _stack = new Prime.Services.Stack<int>();  
        }

        // 1. Task: Create a Stack and verify that IsEmpty is true
        [Test]
        public void IsEmpty_StackIsEmpty_ReturnTrue()
        {
            Assert.IsTrue(_stack.IsEmpty());
        }

        // 2. Task: Push a single object on the Stack and verify that IsEmpty is false and size is one
        [Test]
        public void PushOneElement_SizeIsOne_IsEmptyIsFalse()
        {
            _stack.Push(1);
            Assert.IsFalse(_stack.IsEmpty());
            Assert.That(_stack.Size(), Is.EqualTo(1));
        }

        //3. Task: Push 3 elements on the stack, the size should be 3
        [Test]
        public void PushThreeElements_SizeIsThree()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            Assert.That(_stack.Size(), Is.EqualTo(3));
        }

        //4. Task: Pop an element from the stack with 3 elements, the size should be 2
        [Test]
        public void PopOneElement_SizeIsTwo()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            _stack.Pop();    
            Assert.That(_stack.Size(), Is.EqualTo(2));
        }

        //5. Task: Push a single object, Pop the object, and verify that IsEmpty is true and size is zero
        [Test]
        public void PushAndPop_ElementIsEqual_IsEmptyIsTrue()
        {
            _stack.Push(1);
            var popped = _stack.Pop();
            #pragma warning disable NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of Assert.AreEqual(expected, actual)
            Assert.That(popped, Is.EqualTo(1));
            Assert.IsTrue(_stack.IsEmpty());
        }

        //6. Task: Push a single object, remembering what it is; Pop the object, and verify that the two objects are equal
        [Test]
        public void PushAndPop_RememberedObject_IsEqual()
        {
            _stack.Push(1);
            var popped = _stack.Pop();
           Assert.That(popped, Is.EqualTo(1));
        }

        //7. Task: Push three objects, remembering what they are; Pop each one, and verify that they are removed in the reverse order
        [Test]
        public void PushThreeElements_PopInReverseOrder()
        {
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
            #pragma warning disable NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of Assert.AreEqual(expected, actual)
            Assert.That(_stack.Pop(), Is.EqualTo(3));
            Assert.That(_stack.Pop(), Is.EqualTo(2));
            Assert.That(_stack.Pop(), Is.EqualTo(1));
        }

        //8. Task: Pop a Stack that has no elements, it should result in underflow condition
        [Test]
        public void PopEmptyStack_ThrowsUnderflowException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        //9. Task: Push a single object and then call Top. Verify that IsEmpty is false
        [Test]
        public void PushAndTop_IsEmptyIsFalse()
        {
            _stack.Push(1);
            var top = _stack.Top();
            Assert.IsFalse(_stack.IsEmpty());
        }

        //10. Task: Push a single object, remembering what it is; and then call Top. Verify that the object that is returned is the same as the one that was pushed
        [Test]
        public void PushAndTop_RememberedObject_IsEqual()
        {
            _stack.Push(1);
            var top = _stack.Top();
            Assert.That(top, Is.EqualTo(1));
        }

        //11. Task: Call Top on a Stack with no elements, it should result in underflow condition
        [Test]
        public void TopEmptyStack_ThrowsUnderflowException()
        {
            Assert.That(() => _stack.Top(), Throws.InvalidOperationException);
        }
    }
}
