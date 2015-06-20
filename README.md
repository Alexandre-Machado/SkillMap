# SkillMap
> [![Build Status](https://travis-ci.org/CWISoftware/SkillMap.svg)](https://travis-ci.org/CWISoftware/SkillMap)

## Help and Suport
* Chat: [![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/CWISoftware/SkillMap?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=body_badge)
* Tasks: [![Stories in Ready](https://badge.waffle.io/CWISoftware/SkillMap.png?label=ready&title=Ready)](https://waffle.io/CWISoftware/SkillMap)

## Dependencies
* Visual Studio 2015
* [Node.js](https://nodejs.org/)
* [EntityFramework7](http://www.bricelam.net/2014/09/14/migrations-on-k.html):

```PowerShell
dnu restore
cd src\CWI.SkillMap.Domain
dnx . ef

// apply database
dnx . ef migration apply

// add migration
dnx . ef migration add MyMigration
```