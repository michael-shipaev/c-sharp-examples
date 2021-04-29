using Xunit;

namespace Tests
{
    public class SubArrayTests
    {
        [Theory]
        [MemberData(nameof(SubArrayIsInArrayTestData))]
        public void SubArrayIsInArray(int[] subArray, int[] array, bool expectedSubArrayIsInArray)
        {
            // ��� ����, ����� ��������� ��� ����� ����������
            // 1. �������� � ���� Solution �������� ������ xUnit
            // 2. ��� ���������� ����� � �������� �����, �������� �� ���������� ������� �����
            // 3. ������ � ���������� ������ ������ ������������ "static"
            // 4. ���������, ��� �����, ������� ���������� �����������, ���������� "SubArrayIsInArray" (�������������, ���� ��� �� ���)
            // 5. ������ � ���������� ������ ������������ "static"
            // 6. �������� � ������ ���� "NamespaceHere" �� ����� ��������� � "ClassNameHere" �� ��� ������ ������
            var testInstance = new NamespaceHere.ClassNameHere();
            // ����� ����������� ����� ���� "Test" / "Run All Tests" ��� �� ������ ������ ���� "Run Test(s)"
            var evaluatedSubArrayIsInArray = testInstance.SubArrayIsInArray(subArray, array);
            Assert.Equal(expectedSubArrayIsInArray, evaluatedSubArrayIsInArray);
        }

        public static object[][] SubArrayIsInArrayTestData()
        {
            return new object[][]
            {
                new object[] { null,             null,            false },
                new object[] { new int[] { 1 },  null,            false },
                new object[] { null,             new int[] { 1 }, false },

                new object[] { new int[] { },      new int[] { },      true  },
                new object[] { new int[] { },      new int[] { 1 },    true  },

                new object[] { new int[] { 1 },    new int[] { },      false },
                new object[] { new int[] { 1 },    new int[] { 1 },    true  },
                new object[] { new int[] { 1 },    new int[] { 1, 1 }, true  },
                new object[] { new int[] { 1, 1 }, new int[] { 1 },    false },
                new object[] { new int[] { 1, 1 }, new int[] { 1, 1 }, true  },
                new object[] { new int[] { 2, 1 }, new int[] { 2, 1 }, true  },
                new object[] { new int[] { 1, 2 }, new int[] { 12 },   false },

                new object[] { new int[] { 1 }, new int[] { 1, 2, 3 }, true },
                new object[] { new int[] { 1 }, new int[] { 2, 1, 3 }, true },
                new object[] { new int[] { 1 }, new int[] { 2, 3, 1 }, true },

                new object[] { new int[] { 2, 1 }, new int[] { 2, 1, 3, 4 }, true },
                new object[] { new int[] { 2, 1 }, new int[] { 3, 2, 1, 4 }, true },
                new object[] { new int[] { 2, 1 }, new int[] { 3, 4, 2, 1 }, true },

                new object[] { new int[] { 20, 10 }, new int[] { 20, 20, 10 }, true  },
                new object[] { new int[] { 20, 10 }, new int[] { 20, 20, 20 }, false },

                new object[] { new int[] { 1, 1, 1, 2 }, new int[] { 1, 1, 1, 1, 2 }, true  },
                new object[] { new int[] { 1, 1, 1, 2 }, new int[] { 2, 1, 1, 1 }, false }
            };
        }
    }
}
