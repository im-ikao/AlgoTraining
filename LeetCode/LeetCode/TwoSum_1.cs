namespace LeetCode;

public class TwoSum_1 
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var hashmap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            
            if (hashmap.TryGetValue(complement, out var value))
                return new int[] { value, i };

            if (hashmap.ContainsKey(nums[i]) == false)
                hashmap.Add(nums[i], i);
        }

        return null;
    }
}