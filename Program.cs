//Given an array of integers and array's length, write a method that returns its minimum element.


namespace Program{
    class IsPalindromeRecursionTask{
            static int MinimumElement( int [] arr, int size ){
               if (size == 1 ){

               return arr[0];

               }

                return  arr[size-1]< MinimumElement(arr , size -1)? arr[size-1] : MinimumElement( arr , size -1);
                
               
                  
                    
            }
        static void Main(string [] args){
            
            Console.WriteLine(MinimumElement(new int[] { 1, 2, 9, 5, 4 }, 5));                  // 2
            Console.WriteLine(MinimumElement(new int[] { -145, -6, 39, 96, -20, 0, -100 }, 7));  // -100
            Console.WriteLine(MinimumElement(new int[] { 820, 905, 999, 831, 920, 900 }, 6));   // 830
        }
    }
}