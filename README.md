# Getting started - Building and running a Stratis Full Node 

---------------

## Supported Platforms

* <b>Windows</b> - works from Windows 7 and later, on both x86 and x64 architecture. Most of the development and testing is happening here.
* <b>Linux</b> - works and Ubuntu 14.04 and later (x64). It's been known to run on some other distros so your mileage may vary.
* <b>MacOS</b> - works from OSX 10.12 and later. 

## Prerequisites

To install and run the node, you need
* [.NET Core 3.1](https://www.microsoft.com/net/download/core)
* [Git](https://git-scm.com/)

## Build instructions

### Get the repository and its dependencies

```
git clone https://github.com/cryptoeejit/SERF.git  
cd SERF/src
```

### Build and run the code
With this node, you can connect to SERF network, either on MainNet or TestNet.
So you have 4 options:

1. To run a <b>SERF</b> node on <b>MainNet</b>, do
```
cd SERF
dotnet run
```  

2. To run a <b>SERF</b> node on <b>TestNet</b>, do
```
cd SERF
dotnet run -testnet
```  

### Advanced options

You can get a list of command line arguments to pass to the node with the -help command line argument. For example:
```
cd SERF
dotnet run -help
```  

Use Wallet via your browser
-----------------------

A basic wallet is available using your favourite browser.

* For SERF Mainnet: http://localhost:15113
* For SERF Testnet: http://localhost:25113

Swagger Endpoints
-------------------

Once the node is running, a Swagger interface (web UI for testing an API) is available.

* For SERF: http://localhost:15113
* For SERF Testnet: http://localhost:25113
