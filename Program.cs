//  static void Main(string[] args) 
//     { 
//         int n = 100; 

//         for(int i=1;i<=n;i++){
//             Console.Write(i);
//         }

//     } 

Console.Write("Enter the maximum number: ");
int num = int.Parse(Console.ReadLine()); 
  
    for(int i=1;i<=num;i++)
    {
        string result="";        
        if(i%3==0){
            result="Fizz";
        }
        if(i%5==0){
            result="Buzz";
        }
        if(i%15==0){
            result="FizzBuzz";
        }
        /*If a number is a multiple of 7, print "Bang" instead of the number. 
        For numbers which are multiples of seven and three / five, 
        append Bang to what you'd have printed anyway. (E.g. 3 * 7 = 21: "FizzBang").*/
        if(i%7==0){
            result=result+"Bang";
        }
        /*
            If a number is a multiple of 11, print "Bong" instead of the number. Do not print anything else in these cases. (E.g. 3 * 11 = 33: "Bong")
        */
        if(i%11==0){
            result="Bong";
        }
        /*If a number is a multiple of 13, print "Fezz" instead of the number. 
            For multiples of most other numbers, the Fezz goes immediately in front of the first thing beginning with B, 
            or at the end if there are none. (E.g. 5 * 13 = 65: "FezzBuzz", 3 * 5 * 13 = 195: "FizzFezzBuzz"). 
            Note that Fezz should be printed even if Bong is also present (E.g. 11 * 13 = 143: "FezzBong")
        */
        if(i%13==0){
            int b_indx=result.IndexOf('B');
            if(result!="" && b_indx!=-1){
                result= result.Insert(b_indx, "Fezz");
            }
            else{
                result=result+"Fezz";
            }

        }
        /*If a number is a multiple of 17, 
            reverse the order in which any fizzes, buzzes, bangs etc. are printed. 
            (E.g. 3 * 5 * 17 = 255: "BuzzFizz")*/
        if(i%17==0){
            if(result!=""){
                 List<string> data= new List<string>();
                 for(int c=0;c<result.Length;c++){
                    data.Add(result.Substring(c,4));//data[0]=Fizz data[1]=Buzz
                    c=c+4-1;
                 }
                 data.Reverse();
                 result = string.Join("",data);
            }

        }
        
        if(result==""){
            Console.WriteLine(i);
        }
        else{
            Console.WriteLine(result);
        }
    }