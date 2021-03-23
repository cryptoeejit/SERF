# Getting started - Building and running a SERF Full Node 

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
```

### Build and run the code
With this node, you can connect to SERF network, either on MainNet or TestNet.
So you have 4 options:

1. To run a <b>SERF</b> node on <b>MainNet</b>, do
```
cd SERF\src\SERF.Node
dotnet run
```  

2. To run a <b>SERF</b> node on <b>TestNet</b>, do
```
cd SERF\src\SERF.Node
dotnet run -testnet
```  

Use Wallet via your browser
-----------------------

A basic wallet is available using your favourite browser.  

* For SERF Mainnet: http://localhost:15113
* For SERF Testnet: http://localhost:25113

### Advanced options
