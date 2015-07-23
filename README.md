# SikuliDotNetExample
SikuliDotNetExample: Sikuli4Net

Pre requisites: Have installed .NET Framework 4.5.1 -> http://screencast.com/t/XJClbU12hAk


	1. Create a testing project
	2. Add references:
		a. System.Core: The reference can't be added from the Add references option. So, you should add it manually. Here is the part that needs back in the project file, open the .csproj file (NotePad), and after the last PropertyGroup node, add this node:  
	ItemGroup
    		Reference Include="System.Core"
  	ItemGroup

		b. Microsoft.Csharp (Add references - Framework) -> http://screencast.com/t/5emLMXTWmci
		c. NUnit framework -> http://screencast.com/t/Qm8RipAwWiT1
		d. Sikuli4Net -> http://screencast.com/t/wKAgokIKum
		f. Selenium WebDriver and Selenium WebDriver Support classes-> http://screencast.com/t/XNeax71eZB
		g. System  (Add references - Framework)  -> http://screencast.com/t/mZgQpNwNFKwh
		h. System.Drawing  (Add references - Framework) ->http://screencast.com/t/2AArsw3k5SR
		i. System.XML and System.Xml.Linq  (Add references - Framework)  -> http://screencast.com/t/IGHamBd8pAk3
		j. NUnit.Runners -> http://screencast.com/t/LynVkLg9vF. This reference should not be displayed in the "References" section, but you should see the folder "Packages" in the Testing project folder -> http://screencast.com/t/GD5QpiRAS

	3. Add a new folder to the Testing project (in this folder include the images that you want to use for the tests)

		a. Copy the images into it. Go to the project, and click on the "Refresh" button. Please, take into account that you will see the images ONLY, if you click on the "Show all files" button -> http://screencast.com/t/xJYH5o8OkfHr
		b. Include the images into the project -> http://screencast.com/t/fOFT8opWz
		c. Click on every image, right click and go to Properties. Set as "Copy always" the "Copy to output directory" option -> http://screencast.com/t/ZxEH2xMsCq

	4. Go to the Project folder -> packages -> NUnit.Runners... -> tools, and click on the nunit application -> http://screencast.com/t/3eBIp4llPi
	5. Create a test class, taking into account the following tips

		a. Use the library displayed in the image -> http://screencast.com/t/3ahecTpaXFW
		b. You should add, as variable, an APILauncher instance. Start and Stop the "service" before and after to execute the tests -> http://screencast.com/t/BXvGG2gSF

	6. Go to the NUnit application (Step 4)

		a. Go to Open project  ->  http://screencast.com/t/Iz7VZtEaM6KB
		b. Go to the Project folder, and select the .dll file generated  -> http://screencast.com/t/uJxKsL5OEmC
		c. Select the method to run, and click on the Run button  -> http://screencast.com/t/6DmkvvN2ccmf 

	7. The log can be found in Project path\bin\Debug\Sikuli4Net.Client.Logs\


