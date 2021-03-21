# Printing-with-recursion
Author: William Loughney


Goal: Print 1 to N without using loop constructs. This C# console app takes user inputs and will use recursion to print 1 - N or N - 1 depending on the user input.

Notes: 

- The app uses .NET's TPL to ensure work is distributed between multiple threads to avoid the issue of a stack overflow when one thread recursively calls the same method many times.
- Negative and large numbers are handled appropriately.
- Bad user input is handled appropriately.
- If you can provide a user input that breaks this code, please raise an issue, so I can see what I missed!

Usage:
 
 To use this application, open the .sln file in your IDE of choice, ensure .NET Core 3.1 is available on your computer, and run the Console Application project.

Enjoy!
