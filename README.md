# AddingApp
This project contains varying solutions for AddingApp, one being the single console solution, and another being the distributed console solution. This project was created to gain familiarity with C#, and also to gain familiarity with coding practices in Applied Systems.

## Getting Started
This project has varying levels of complexity, the DistributedApp is considerably more enhanced than the AddingApp, as it is built on the principles of the single console application, so it is advised reviewing this version before than accessing the DistributedApp.

Applications should build/run straight from loading in VisualStudio. However, to use the MSMQ functionality of the DistributedApp, follow the further steps within Prerequisites.

### Prerequisites
***Installing MSMQ on your machine***
* Open control panel
* Go to "Programs" and then "Programs and Features"
* Click "Turn Windows features on and off"
* Expand "Microsoft Message Queue (MSMQ) Server"
* Click "Microsoft Message Queue (MSMQ) Server Core"
* Click OK. If you are prompted to restart the computer, click OK to complete the installation.

***Create a test queue***
* Open Computer Management
* Under "Services and Applications" you should see "Message Queueing"
* Open that and you'll see three items - Outgoing Queues, Private Queues and System Queues.
* Right click on "Private Queues", select New > Private Queue, enter a name for your queue (e.g. "test_commands"). Ensure transactional is NOT clicked.

### Installing
No further installation steps are required, builds are completed in VisualStudio and all packages required are attached to the solutions.

## Editing & Testing
Further editing can be performed through VisualStudio. Tests have been attached to the solution, in the .Testing project libraries, and these SpecFlow tests can also be added to in VisualStudio.

## Built with
* [Visual Studio](https://visualstudio.microsoft.com/) - Microsoft Integrated Development Environment
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Application programming language
* [SpecFlow](https://specflow.org/) - Automated unit testing tools

## Authors
***Christopher Jones***
