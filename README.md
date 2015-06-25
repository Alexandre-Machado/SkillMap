# SkillMap
> Travis: [![Build Status](https://travis-ci.org/CWISoftware/SkillMap.svg)](https://travis-ci.org/CWISoftware/SkillMap) AppVeyor: [![Build status](https://ci.appveyor.com/api/projects/status/uhepnks44ihrg139?svg=true)](https://ci.appveyor.com/project/alexandre-machado/skillmap)


## Help and Suport
* Chat: [![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/CWISoftware/SkillMap?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=body_badge)
* Tasks: [![Stories in Ready](https://badge.waffle.io/CWISoftware/SkillMap.png?label=ready&title=Ready)](https://waffle.io/CWISoftware/SkillMap)

## Dependencies
1. Framework: [ASP.NET 5](#ASPNET5)
2. IDE: [Visual Studio 2015] (#visualstudio15)
3. Platform Build: [Node.js](https://nodejs.org/)
4. Database: Sql Server width [Entity Framework 7](#ef7)

<a name="ASPNET5"></a>
### ASP.NET 5
Install the [ASP.NET 5](https://github.com/aspnet/Home)

<a name="visualstudio15"></a>
### Visual Studio 2015
Visual Studio 2015 ([Community 2015 RC](http://go.microsoft.com/fwlink/?LinkId=524433) | [Enterprise 2015 RC](http://go.microsoft.com/fwlink/?LinkId=521794))

<a name="ef7"></a>
### Node.js

<a name="ef7"></a>
### Entity Framework 7
[EF7](http://www.bricelam.net/2014/09/14/migrations-on-k.html):

```
dnu restore
cd src\CWI.SkillMap.Domain
dnx . ef

// apply database migrations
dnx . ef migration apply

// add migration
dnx . ef migration add MyMigration
```
## Plugins/Addons

* http://codepen.io/anon/pen/XbzYaZ