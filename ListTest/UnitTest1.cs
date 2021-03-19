using ListTest
using NUnit.Framework;

namespace ListTest
{

    public class TestingListApp
    {

        [TestCase(3, 335)]

        public static void Add(int Mocknum, int expected)
        {
            int[] array = ArrayMock.GetMock(Mocknum);
            int actual = Array.Add(array);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(3, 4, 5)]
        ///[TestCase(2, 21)]
        public void Add_WhenStringValue_ShouldAddToEnd(int value, int mockNumb, int expectedMockNumb)
        {
            ArrayList<int> actualArrayList = ArrayMock.GetMock(mockNumb);
            actualArrayList.Add(value);
            ArrayList<int> expectedArrayList = ArrayMock.GetMock(expectedMockNumb, value);

            Assert.AreEqual(expectedArrayList, actualArrayList);
        }


        public class ArrayMock
        {
            public static int[] GetMock(int num)
            {
                int[] result = new int[0];
                switch (num)
                {
                    case 0:
                        result = new int[] { };
                        break;

                    case 1:
                        result = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        break;

                    case 2:
                        result = new int[] { 34, 5, 69, 127, 2, 101, 22, 16, 73, 44 };
                        break;

                    case 3:
                        result = new int[] { 0, 32, 13, 56, 1, 335, 6, 41, 8 };
                        break;

                    case 4:
                        result = new int[] { 2, 5};
                        break;
                    case 5:
                        result = new int[] { 2, 5, 3 };
                        break;
                }
                return result;
            }

        }







    }
}