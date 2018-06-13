namespace Algorithms.Test {

    using System.Text;
    using System;
    public static class Utils {
        public static bool IsSorted (int[] nums) {

            if (nums == null || nums.Length <= 1)
                return true;

            for(var i=0;i<nums.Length-1;i++){
                if(nums[i+1]<nums[i])
                    return false;
            }

            return true;
        }

        public static String PrintArrayElements(this int[] nums){

            StringBuilder result=new StringBuilder(); 

            for(var i=0;i<nums.Length;i++){
                result.Append(nums[i].ToString() + ", ");
            }

            return "**** Sorted Array is **** " +  result.ToString().TrimEnd(',',' ');
        }
    }    
}
