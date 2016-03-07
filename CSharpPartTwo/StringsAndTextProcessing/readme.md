1.	Describe the strings in C#. What is typical for the string data type? 
Describe the most important methods of the String class.
2.	Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" -> "elpmas".
3.	Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
4.	Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem4.png)
	The result is: 9.
5.	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem5a.png)
		The expected result:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem5b.png)
6.	Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
7.	Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
8.	Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem8a.png)
		The expected result is:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem8b.png)
		Consider that the sentences are separated by "." and the words – by non-letter symbols.
9.	We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem9.png)
10.	Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input : Hi!
		Expected output : \u0048\u0069\u0021
11.	Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
12.	Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
		and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
13.	Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
14.	A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
15.	Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem15.png)
16.	Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem16.png)
17.	Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
18.	Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
19.	Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.
20.	Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
21.	Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
22.	Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
23.	Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
24.	Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
25.	Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
![Screenshot](https://github.com/madbadPi/TelerikAcademy/blob/master/CSharpPartTwo/StringsAndTextProcessing/problem25.png)



