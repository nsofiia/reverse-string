# reverse-string

is a simple game, which function is to reverse all possible input from the user.

**content:**
1. [introduction.](https://github.com/nsofiia/reverse-string/new/master?readme=1#in-game-introduction) 
2. [results.](https://github.com/nsofiia/reverse-string/new/master?readme=1#results) 
3. [plaindrome.](https://github.com/nsofiia/reverse-string/new/master?readme=1#palindrome-detection)


## introduction.

***reverse_string*** can handle introducing itself to the player:

<img width="261" alt="Screen Shot 2022-12-11 at 5 58 19 PM" src="https://user-images.githubusercontent.com/88280676/206937538-c90738d3-dd33-42c4-83a8-e4d760f6c118.png">


## Results
***reverse_string*** is producing results right avay, after input is submitted.
Results are executed by a **for** loop, combined with printing statement for current character.
Printing is strating from the very last character.

code

>for (int index = lastIndex; index > -1; index--) //starting from the last index and print each letter untill index is more than -1
{
Console.Write(initialInput[index]); //displaying the reversed order character by character
  
  
<img width="248" alt="Screen Shot 2022-12-11 at 5 58 41 PM" src="https://user-images.githubusercontent.com/88280676/206937588-223cfb84-d0df-4d5f-ba45-912a8b54ecbf.png">
 
  
## Palindrome detection
quick tip:
[palindrome](https://g.co/kgs/56WDgq)

The ***reverse_string*** game has a ***hidden feature*** which is revealed when input is a palindrome.
Detection is executed by **if** statement, to introduce a condition. 
Condition is checking whether last character is not equal to the first character, and so on, looping through input in both directions, comparing ascending order with the descending order of characters. 
When at least 1 pair of characters is not equal to each other - it is not a plalindorme. 
The **isPalindrome** variable is set to **false**. As a result - user is only getting the reversed input. Nothing else is printed.
When **if** consition is never executed - which means that all pairs of letters from input are equal - the 
>Yay, found a Palindrome!

message is printed additionally for user.

code
>if (initialInput[index] != initialInput[lastIndex - index]) // palindrome check - if letter from the end not equal to letter from the beginning
                {
                    isPalindrome = false; //when at least 1 letter is not equal - isPalindrome switches to false
                }
              
              
reverse_string Palindrome detection:

<img width="266" alt="Screen Shot 2022-12-11 at 6 15 51 PM" src="https://user-images.githubusercontent.com/88280676/206937691-0afb9ec5-aa4a-4d90-80c8-1b9d25de59c0.png">
