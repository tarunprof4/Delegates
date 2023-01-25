# Delegates
Action and Func Delegates in C#


# Intended Audience
1+ yrs of development experience

# Tools
Visual Studio 2019 or later Community version

# Definition
Actions and Funcs are just pre-defined delegates in C#. 
Difference between Actions and Funcs- Actions can only take input parameters, while Funcs can take input and output parameters(return value). 

# Reason for Writing
I found it tough to get information over internet on real usage of delegates which clearly explains why delegates is the best fit for a particular scenario.

# General use case of delegates
When we need to execute some pre and post steps on operations(generally done while writing interceptors). 

# Real use case
We want to make database call and we want to do instrumentation on the same. Though there are softwares available in the
market for the same today, still this example is good to explain the concept. Below is the demonstration for the same.


We have created 2 projects Delegates and WithoutDelegates. We have also used serilog for logging and we can see logfile(log.txt) 
under bin\Debug\netcoreapp3.1 folder after running the code atleast once.

![Serilog-logfile](https://user-images.githubusercontent.com/116249623/214514449-f812aaa2-cd0e-43c4-9d23-1747d8c54593.JPG)


# Advantages of using Delegates
1. Helps avoid code duplication - Project WithoutDelegates Save1() and Save2() methods has to write same code again. However under Project Delegates 
only one place under DbInterceptor(GetQueryResults) code has to be written.

![CodeReuse](https://user-images.githubusercontent.com/116249623/214514789-6f7f84d6-11c3-4f96-b6d5-33389ce366c5.JPG)


2. Increases code maintainability- Helper class PreOperation has to return Stopwatch as of today. However it could be possible tomorrow as our usecase evolves
we need to return more fields. 

![CodeMaintain](https://user-images.githubusercontent.com/116249623/214514810-dd1cc9a7-b5b6-4c5d-b6a8-620ef3b69ec1.JPG)


Another real use case can be found here in this repo- https://github.com/tarunprof4/Bookmyslot-Api/tree/CleanArchitectureWithDDD

DistributedInMemoryCacheBusiness.cs GetFromCacheAsync method
This is used to check if the data is in cache. If not trigger the request processing again and save it back to cache. Next time the freshly saved data will be available from cache.


