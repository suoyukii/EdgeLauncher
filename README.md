<h1 align="center">EdgeLauncher</h1>
<h4 align="center">Automatically close the Edge browser launcher for background processes</h4>

<p align="center">
  <a href="https://opensource.org/licenses/MIT">
    <img src="http://img.shields.io/badge/License-MIT%20License-1e90ff.svg"/>
  </a>
  <a href="https://dotnet.microsoft.com">
    <img src="http://img.shields.io/badge/.Net-8.0-1e90ff.svg"/>
  </a>
</p>

<p align="center">
  <a href="#features">Features</a> ·
  <a href="#install">Install</a> ·
  <a href="#usage">Usage</a> ·
  <a href="#usage">Thanks</a>
</p>

---

EdgeLauncher is a browser launcher that closes the background processes of the edge browser so that the memory occupied by the edge browser can be recycled by the system.

# Features

- Automatization
- Lightweight software

# Install

EdgeLauncher requires **.Net 8.0** to run successfully.

- [Download .Net 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0/runtime)
- [Download EdgeLauncher](https://github.com/suoyukii/EdgeLauncher/releases)

# Usage

When you open EdgeLauncher, it starts the edge browser, and after 30 seconds of closing the edge browser, it automatically closes all the processes of the edge browser.

- Run the following command on the console.

```shell
edgelauncher [url]
```