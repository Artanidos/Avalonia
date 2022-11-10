# Install .NET 6 on Linux

I have tried to install dotnet using SNAP which does not work well for me.
I went into errors trying to run an app.

Here is the way that worked well for me.

Go to the website to find your distribution.
https://learn.microsoft.com/en-us/dotnet/core/install/

I am running Ubuntu so I clicked on Linux - Ubuntu.
https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu

On the following page I have choosed my Ubuntu version, which was 20.04.
https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#2004

And here I found the instructions.


## Add the Microsoft package signing key
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

## Install the SDK
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-6.0


## Install the runtime
sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-6.0

## Install Templates
dotnet new -i Avalonia.Templates

## Create the first App
dotnet new avalonia.app -o MyApp
cd MyApp
dotnet run