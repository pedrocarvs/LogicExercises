

namespace LogicExercises.ExercisesHelper
{
    /// <summary>
    ///  time complexity? logaritmic
    ///  space complexity? O(n)
    /// </summary>
    public class Exercise3
    {
        public static bool AreStringsAnagrams(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            char[] charArray1 = word1.ToLower().ToCharArray();
            char[] charArray2 = word2.ToLower().ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            string NewWord1 = new string(charArray1);
            string NewWord2 = new string(charArray2);

            return NewWord1 == NewWord2;

        }
    }
}
