# T4Example

* The `Person.cs` file can be thought of as the input.
* The `EqualityClassTemplate.tt` acts as a template.  You have to import it in a separate `.tt` file to generate a class.
* The `EqualityPerson.tt` is a template which calls `EqualityClassTemplate.tt`, passing in arguments, and produces `EqualityPerson.cs` as its output.

## Setting up `EqualityClassTemplate.tt`

Make sure to blank out the "Custom Tool" property of the file.  

To change this property, click on the file in the Solution Explorer and go to the properties window.

## `hostspecific` being set to `true`

In order to have `this.Host` reference in the `.tt` file (it is being used in `EqualityClassTemplate.tt`), you have to set `hostspecific` to `true` at the top of the `.tt` file:

```
<#@ template debug="false" hostspecific="true" language="C#" #>
```

## Getting Intellisense

Since I am using Tangible's T4 Editor, it does not provide full code completion (you have to pay for it).

An easy workaround is to create a new C# console project and add the `EnvDTE` assembly.  Then you can use code like so to check the what properties exist on the interfaces:

```c#
var dte = null as EnvDTE.DTE;
```

## Useful Links

* [Creating Mixins with T4 in Visual Studio](https://faithlife.codes/blog/2009/04/creating_mixins_with_t4_in_visual_studio/) - the inspiration for this project
* [Generating async WCF OperationContract signatures with a T4 template](https://weblogs.thinktecture.com/cweyer/2009/06/generating-async-wcf-operationcontract-signatures-with-a-t4-template.html) - source for the code of such methods as `GetEnvDTE`.
* [Project Metadata Generation using T4](https://www.codeproject.com/Articles/42036/Project-Metadata-Generation-using-T4) - shows a different way to generate classes using T4
