# HelloWorld 

Environment: VS 2015, .net 4.5

Projects: 
HelloWorldAPI : Web API that returns "Hello World" on get
HelloWorldAPI.tests : Unit tests to test Web API.
HelloWorldConsole : Console App that uses Factory Design Pattern to return correct Platform (according to key "Platform" in App.Config).


To connect console application to HelloWorldAPI 
------------------------------------------------
Right click on HelloWorldAPI and select debug
It will open a web application 
http://localhost:{portname}
So http://localhost:{portname}/api/helloworld/ will be the api to return "Hello World"

Keep it running.  
Go to HelloWorldConsole Project 
Open App.config file.
Change the value for key "UseAPI" to 1.
Change the value for "HelloWorldAPI" to api url. 
