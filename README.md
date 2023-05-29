# General Idea
This is a POC structure where multiple automated testing frameworks can be used interchangeably without no need to modify neither the tests nor POM methods.

Initially Selenium and Playwright frameworks are used with the basic actions of opening a page, clicking an element and writing to an input element.
# Setup
Selenium does not need any setup besides the Nuget packages that are referenced in the project. 

For Playwright additional setup is needed. The [documentation](https://playwright.dev/dotnet/docs/intro) can be used as a reference, but the following steps should be enough:
1. Move to `FrameworkPw` directory and run the following command so that `playwright.ps1` file is available in the `bin` directory:
``` 
dotnet build 
```
2. Run the following command to install the neccessary browsers:
```
pwsh bin/Debug/net7.0/playwright.ps1 install
```
# The Beauty
As you can see, test methods in `TestsPw` and `TestsSe` are identical and POM metods in `FrameworkPw/Pages/Google` and `FrameworkSe/Pages/Google` are identical as well. This means, that in order to completely change the testing framework the majority of the project could be left untouched and only `Driver` and `Common` classes would need to replaced.


