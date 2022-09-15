public class Program {
     static void Main (){
        string Input ;
        Console.Write("input Number:");
        Input = Console.ReadLine();
        if (double.TryParse(Input,out double Number)){
            if (Number != Math.Abs(Number)){
                Console.WriteLine("Please input a positive integer.");
            }
            else {
                if((Number%2) != 0){
                    Console.WriteLine("Please input an even positive integer.");
                }
                else{
                    Console.WriteLine("{0},{1}",Number/2,(Number/2)+1);
                }
            }
        }
        else{
            Console.WriteLine("Please input an integer.");
        }
     }
}