using System;

namespace Algorithms {

    public static class InsertionSort {

        public static int[] Sort (int[] nums) {

            if (nums == null || nums.Length <= 1)
                return nums;

            for (var i = 1; i < nums.Length; i++) {
                var key = nums[i];
                var j = i-1;

                while (j >= 0 && key < nums[j]) {
                    nums[j + 1] = nums[j];
                    --j;
                }

                nums[j + 1] = key;
            }

            return nums;

        }

    }

}
