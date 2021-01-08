# Twitter-Sentiment-Analysis
<p>
            Twitter Sentiment Analysis is a "Distributed Applications Programming" project aims to Design and Execute a distributed system using two methods:
        </p>
        <p>
            <br />
            1- Remoting.
            <br />
            2- WCF (Windows Communication Foundation).
        </p>
        <p>It contains two major characters: Admin - users</p>
        <h3>Admin:</h3> 
        <p>The admin is responsible for operating the system with multiple functions:</p>
        <b>Using Remoting method:</b>
        <ul>
            <li>Add user</li>
            <li>Remove user</li>
            <li>Add case</li>
            <li>Remove case</li>
            <li>Retrieve users by there IDs</li>
            <li>Retrieve cases by there IDs</li>
            <li>Retrieve cases that user participates with</li>
            <li>Retrieve users of a case</li>
            <li>Add Tweet Sentiment</li>
        </ul>
        <b>Using WCF method:</b>
        <ul>
            <li>Get a case with certain Sentiment</li>
            <li>User's Sentiment changes with time</li>
            <li>Distribution of users upon their Sentiments</li>
         </ul>
<h3>Users:</h3>
<b>Using Remoting method:</b>
<p>The users have the ability to add tweets and participate or contribute in the case put by the admin.</p>

<h2>installation and Using</h2>
<p>in order to run the project please make sure to follow these steps:</p>
<p>1- open database backup folder and use it to restore the database.</p>
<p>2- configure the connection string of each service:</p>
  <ul>
  <li>->for remoting service: edit the ConnectionString variable in TwitterSentimentService\TwitterSentimentService.cs</li>
  <li>->for wcf service: locate TwitterSentimentWcfServiceLibrary then double click on DataClasses1.dbml after that drag and drop the tables from the server explorer.</li>
</ul>
<p>3-install the plugins using nugget.</p> 
<p>4- build the solution.</p>
<p>5- run the remoting service which is located in \Twitter-Sentiment-Analysis-master\TwitterSentimentServer\bin\Debug\TwitterSentimentServer.exe</p>

<p>6-publish WcfServiceLibrary to Windows IIS</p>
<p>7-set Twitter SentimentWebsite as startup project</p>
<p>8-run the website by pressing Ctrl+f5 in vs code</p>
<p>9-The login page: http://localhost:52355/Users/Login</p>
<p>10-Enjoy</p>

<h2>References</h2>
<ul>
<li>Here you can find more about The Remoting method: https://en.wikipedia.org/wiki/.NET_Remoting </li>
<li>Here you can find more about Windows Communication Foundation(WCF) method: https://en.wikipedia.org/wiki/Windows_Communication_Foundation </li>
<li>The project Built using Asp.Net framework 4.7. For more info: https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet-framework</li>
</ul>
