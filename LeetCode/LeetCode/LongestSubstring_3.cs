namespace LeetCode;

public class LongestSubstring_3
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s) == true)
            return 0;
        
        if (s.Length == 1)
            return 1;

        var current = new HashSet<char>();
        var maxLength = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            current.Add(s[i]);
            
            if (current.Contains(s[i]) == true)
            {
                if (maxLength <= current.Count)
                    maxLength = current.Count;
                
                current.Clear();
            }
            
            for (int j = i + 1; j < s.Length; j++)
            {
                if (current.Contains(s[j]) == true)
                    break;
                
                current.Add(s[j]);
            }
            
        }

        return maxLength;
    }
    
    // Simplest implementation
    public int LengthOfLongestSubstring2(string s)
    {
        if (string.IsNullOrEmpty(s) == true)
            return 0;
        
        if (s.Length == 1)
            return 1;
        
        var array = new HashSet<char>[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            array[i] = new HashSet<char>() { s[i] };
            
            for (int j = i + 1; j < s.Length; j++)
            {
                if (array[i].Contains(s[j]) == true)
                    break;
                
                if (array[i].Contains(s[j]) == false)
                    array[i].Add(s[j]);
            }
        }

        return array.Max(x => x.Count);
    }
}