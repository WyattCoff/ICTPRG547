using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using ICTPRG547_Assessment1_WyattCoff;
using ICTPRG547_Assesment1_WyattCoff;

namespace DynamicDataStructuresTest
{
    [TestFixture]
    public class DynamicDataStructureTest
    {
        
        [SetUp]
        public void Setup()
        {
            studentList = new SingleLinkedList<Student>();
            studentDoublyList = new DoublyLinkedList<Student>();

            binaryTree = new BinaryTree();
            traversalResults = new List<int>();

            // Add 7 StudentIDs in a way that forms a balanced tree
            binaryTree.Add(42);
            binaryTree.Add(21);
            binaryTree.Add(54);
            binaryTree.Add(10);
            binaryTree.Add(30);
            binaryTree.Add(65);
            binaryTree.Add(70);
        }

        private SingleLinkedList<Student> studentList;

        [Test]
        public void AddFirst_ShouldAddStudentToHead()
        {
            var student = new Student("Test", "test@example.com", "123456789", new Address(), "0001", "IT", DateTime.Now);
            studentList.AddFirst(student);

            Assert.AreEqual(student, studentList.Head.Value);
        }

        [Test]
        public void AddLast_ShouldAddStudentToTail()
        {
            var student1 = new Student("First", "first@example.com", "123456789", new Address(), "0002", "IT", DateTime.Now);
            var student2 = new Student("Last", "last@example.com", "123456789", new Address(), "0003", "IT", DateTime.Now);

            studentList.AddFirst(student1);
            studentList.AddLast(student2);

            Assert.AreEqual(student2, studentList.Tail.Value);
        }

        [Test]
        public void Contains_ShouldReturnTrueIfStudentIsFound()
        {
            var student = new Student("FindMe", "findme@example.com", "123456789", new Address(), "0004", "IT", DateTime.Now);
            studentList.AddFirst(student);

            Assert.IsTrue(studentList.Contains(student));
        }

        [Test]
        public void RemoveFirst_ShouldRemoveHeadStudent()
        {
            var student1 = new Student("Head", "head@example.com", "123456789", new Address(), "0005", "IT", DateTime.Now);
            var student2 = new Student("Next", "next@example.com", "123456789", new Address(), "0006", "IT", DateTime.Now);

            studentList.AddFirst(student1);
            studentList.AddLast(student2);
            studentList.RemoveFirst();

            Assert.AreEqual(student2, studentList.Head.Value);
        }

        [Test]
        public void RemoveLast_ShouldRemoveTailStudent()
        {
            var student1 = new Student("First", "first@example.com", "123456789", new Address(), "0007", "IT", DateTime.Now);
            var student2 = new Student("Last", "last@example.com", "123456789", new Address(), "0008", "IT", DateTime.Now);

            studentList.AddFirst(student1);
            studentList.AddLast(student2);
            studentList.RemoveLast();

            Assert.AreEqual(student1, studentList.Tail.Value);
        }

        private DoublyLinkedList<Student> studentDoublyList;


        [Test]
        public void AddFirst_ShouldAddStudentToHead_DoublyLinkedList()
        {
            var student = new Student("Test", "test@example.com", "123456789", new Address(), "0001", "IT", DateTime.Now);
            studentDoublyList.AddFirst(student);

            Assert.AreEqual(student, studentDoublyList.Head.Value);
        }

        [Test]
        public void AddLast_ShouldAddStudentToTail_DoublyLinkedList()
        {
            var student1 = new Student("First", "first@example.com", "123456789", new Address(), "0002", "IT", DateTime.Now);
            var student2 = new Student("Last", "last@example.com", "123456789", new Address(), "0003", "IT", DateTime.Now);

            studentDoublyList.AddFirst(student1);
            studentDoublyList.AddLast(student2);

            Assert.AreEqual(student2, studentDoublyList.Tail.Value);
        }

        [Test]
        public void Contains_ShouldReturnTrueIfStudentIsFound_DoublyLinkedList()
        {
            var student = new Student("FindMe", "findme@example.com", "123456789", new Address(), "0004", "IT", DateTime.Now);
            studentDoublyList.AddFirst(student);

            Assert.IsTrue(studentDoublyList.Contains(student));
        }

        [Test]
        public void RemoveFirst_ShouldRemoveHeadStudent_DoublyLinkedList()
        {
            var student1 = new Student("Head", "head@example.com", "123456789", new Address(), "0005", "IT", DateTime.Now);
            var student2 = new Student("Next", "next@example.com", "123456789", new Address(), "0006", "IT", DateTime.Now);

            studentDoublyList.AddFirst(student1);
            studentDoublyList.AddLast(student2);
            studentDoublyList.RemoveFirst();

            Assert.AreEqual(student2, studentDoublyList.Head.Value);
        }

        [Test]
        public void RemoveLast_ShouldRemoveTailStudent_DoublyLinkedList()
        {
            var student1 = new Student("First", "first@example.com", "123456789", new Address(), "0007", "IT", DateTime.Now);
            var student2 = new Student("Last", "last@example.com", "123456789", new Address(), "0008", "IT", DateTime.Now);

            studentDoublyList.AddFirst(student1);
            studentDoublyList.AddLast(student2);
            studentDoublyList.RemoveLast();

            Assert.AreEqual(student1, studentDoublyList.Tail.Value);
        }

        private BinaryTree binaryTree;
        private List<int> traversalResults;

        private void CaptureTraversal(BinaryTreeNode node)
        {
            traversalResults.Add(node.Data);
        }

        [Test]
        public void TestPreOrderTraversal()
        {
            traversalResults.Clear();
            binaryTree.TraversePreOrder(binaryTree.Root, traversalResults.Add);
            var expectedOrder = new List<int> { 42, 21, 10, 30, 54, 65, 70 };
            Assert.AreEqual(expectedOrder, traversalResults);
        }

        [Test]
        public void TestInOrderTraversal()
        {
            traversalResults.Clear();
            binaryTree.TraverseInOrder(binaryTree.Root, traversalResults.Add);
            var expectedOrder = new List<int> { 10, 21, 30, 42, 54, 65, 70 };
            Assert.AreEqual(expectedOrder, traversalResults);
        }

        [Test]
        public void TestPostOrderTraversal()
        {
            traversalResults.Clear();
            binaryTree.TraversePostOrder(binaryTree.Root, traversalResults.Add);
            var expectedOrder = new List<int> { 10, 30, 21, 70, 65, 54, 42 };
            Assert.AreEqual(expectedOrder, traversalResults);
        }
    }

}
