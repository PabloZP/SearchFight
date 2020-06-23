# SearchFight
Cignium Challenge

Search words entered in search engines and compare number of results.

The executable file SearchFight.exe is in the folder: PjChallenge\bin\Debug.
 In the command line ( User must type: SearchFight)
Besides the console project called SearchFight, just as a plus, the solution includes a desktop project called PjChallenge. 

You can open the solution and alternate executing the Desktop project ot the Console Project.
Both projects call the core which is in business layer called "BL".
There are another layer BE for domain objects. And a Common Layer for common methods called by other layers.

Elements must be separated by spaces. An element can contain 2 or more words if they are inside *double* quotes


Solution is in C#. It shows some programmkhg concepts like Polymorphism. Modularity, inheritance, etc.

The first search engine used is Google. I got an API key and context id. But according the Google's rules the number of results are constrained to 10 results. 
So I mocked the existing results with some random functions to avoid that getting always 10 as number of results in order to make sense for the comparison. 
Anyway the complete code how I call the Google API can be seen in the GoogleEngine class.

Then I tried the second search engine: I tried yahoo, bing and yandex but there was not possibly, due to lack of documentation
 or by asking my credit card number to get an API Key. So I mock results of Yahoo by some random functions.

At the end the 2 search engines show results and a comparison is shown.
