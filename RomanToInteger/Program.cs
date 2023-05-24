public class Solution
{
    public int RomanToInt(string s)
    {
        int returnInt = 0;
        List<int> listNumbers = new List<int>();
        foreach (char c in s)
        {
            switch (c)
            {
                case 'I':
                    listNumbers.Add(1);
                    break;
                case 'V':
                    listNumbers.Add(5);
                    break;
                case 'X':
                    listNumbers.Add(10);
                    break;
                case 'L':
                    listNumbers.Add(50);
                    break;
                case 'C':
                    listNumbers.Add(100);
                    break;
                case 'D':
                    listNumbers.Add(500);
                    break;
                case 'M':
                    listNumbers.Add(1000);
                    break;
            }
        }
        for (int i = 0; i < listNumbers.Count; i++)
        {
            if (i == listNumbers.Count - 1 || listNumbers[i] >= listNumbers[i + 1])
            {
                returnInt += listNumbers[i];
            }
            else
            {
                returnInt -= listNumbers[i];
            }
        }

        return returnInt;
    }
}