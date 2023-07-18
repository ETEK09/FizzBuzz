// write a public method that accepts a Number
// 1. access modifier
// 2. return type
// 3. Method Name 
// 4. Parameters
// 5. Scope

public string FizzBuzz(int number)
{
    var answer = "";

    // when the number is divisible by 3 return args word fizz
    if (number % 3 == 0)
    {

        answer = "fizz";

    }

    if (number % 5 == 0)
    {
        answer += "buzz";

    }

    return answer;


}



