using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse) .ToList();

            string command = string.Empty;
            while((command = Console.ReadLine()) != "end")
            {
                switch(command)
                {
                    case "add":
                        {
                            nums = Add(nums);
                            break;
                        }

                    case "multiply":
                        {
                            nums = Multiply(nums);
                            break;
                        }

                    case "subtract":
                        {
                            nums = Subtract(nums);
                            break;
                        }
                    case "print":
                        {
                            Print(nums);
                            break;
                        }
                }
            }
        }

        static Func<List<int>, List<int>> Add = (List<int> nums) =>
        {
            for(int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] + 1;
            }
            return nums;
        };

        static Func<List<int>, List<int>> Multiply = (List<int> nums) =>
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] * 2;
            }
            return nums;
        };

        static Func<List<int>, List<int>> Subtract = (List<int> nums) =>
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] - 1;
            }
            return nums;
        };

        static Action<List<int>> Print = (List<int> nums) =>
        {
            Console.WriteLine(String.Join(" ", nums));
        };
    }
}