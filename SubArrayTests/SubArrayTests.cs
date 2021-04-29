using Xunit;

namespace Tests
{
    public class SubArrayTests
    {
        [Theory]
        [MemberData(nameof(SubArrayIsInArrayTestData))]
        public void SubArrayIsInArray(int[] subArray, int[] array, bool expectedSubArrayIsInArray)
        {
            // Для того, чтобы запустить эти тесты необходимо
            // 1. Добавить в свой Solution тестовый проект xUnit
            // 2. Все содержимое файла с тестовым кодом, заменить на содержимое данного файла
            // 3. Убрать в объявлении своего класса спецификацию "static"
            // 4. Проверить, что метод, который собираемся тестировать, называется "SubArrayIsInArray" (переименовать, если это не так)
            // 5. Убрать в объявлении метода спецификацию "static"
            // 6. Заменить в строке ниже "NamespaceHere" на своий неймспейс и "ClassNameHere" на имя своего класса
            var testInstance = new NamespaceHere.ClassNameHere();
            // Тесты запускаются через меню "Test" / "Run All Tests" или по правой кнопке мыши "Run Test(s)"
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
