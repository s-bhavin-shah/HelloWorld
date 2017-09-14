# HelloWorld 

Environment: VS 2015, .net 4.5 <br />

Projects: <br />
HelloWorldAPI : Web API that returns "Hello World" on get <br />
HelloWorldAPI.tests : Unit tests to test Web API. <br />
HelloWorldConsole : Console App that uses Factory Design Pattern to return correct Platform (according to key "Platform" in App.Config).
<br /><br />
To connect console application to HelloWorldAPI <br />
------------------------------------------------<br />
Right click on HelloWorldAPI and select debug<br />
It will open a web application <br />
http://localhost:{portname}<br />
So http://localhost:{portname}/api/helloworld/ will be the api to return "Hello World"<br />
Keep it running.  <br />
Go to HelloWorldConsole Project <br />
Open App.config file.<br />
Change the value for key "UseAPI" to 1.<br />
Change the value for "HelloWorldAPI" to api url.<br /> 
