
namespace Lab4.ConsoleApp.NullableTypes
{
    public class WorkingWithNullable
    {
        public void LocalNullableVariables()
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

            // string? s = "oops";
        }
    }

    public class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}
