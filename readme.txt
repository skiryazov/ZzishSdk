Zzish .NET SDK by Lexicum

The package contains the open source API library and a demo client and that demonstrates how the library is used in a project and also allows the developer
to test the connection (combination of Zzish server availability, internet connection on dev machine, firewall permissiveness and App ID validity).

The .NET solution contains two projects that implement these two resources:
- Lexicum.ZzishApiClient - that's the API library wrapper, feel free to use the compiled version as binary (Lexicum.ZzishApiClient.dll) or look at the code 
in order to figure out how to connect yourself
- ZzishTest - A windows app that shows how the library is used and allows for connection testing by simly clicking a few buttons

For quick integration the package also contains a pre-combiled release configuration binary that you can reference in your project staight away. This is
included in the main folder of the solution as Lexicum.ZzishApiClient.dll
Note that if you haven't already referenced JSON.NET you'll need to do so. The binary is included in the same location for your convenience.


Before you begin

1. You'll need a valid App ID - if you don't have one yet get it at https://www.zzish.com/developer/apps/
2. Create a class in order to obtain a group code - https://www.zzish.com/learning-hub/

When you have these two tokens you're good to go:

1. Present your App ID
When using the demo app (ZzishTest project) you'll need to add the App ID in the AppSettings value for key "ZzishAppId" in the App.config file of the win 
app project (not the library itself).
Alternatively, when using the app as a binary you'll need to add the whole AppSettings entry to your own config file

2. Present a sample class group code
This can be done in a few different ways:
A) Add it to the same app.config file in the demo app - this will make it the default code to use and you won't need to provide a code every time you run 
the demo. You can still change the code on the fly.
B) Type or paste the code in the relevant textbox when you run the demo app.
C) When integrating the binaries directly you'll need to pass the code to every call to the RegisterActivity method

3. Click the three buttons at the top, from left to right to register a user, activity and action. You'll need to do all three to see the results on the
teacher dashboard

4. Go to the teacher dashboard and open the class matching the code you input in step 2. The dashboard updates the data live but sometimes it takes a while 
so better refresh just in case. You should see an activity from student Kunyo Conev (or whatever name you provided). If you do - the connection is working.


The code is free software distributed under the Apache License 2.0, read the full text of the license here http://www.apache.org/licenses/LICENSE-2.0
