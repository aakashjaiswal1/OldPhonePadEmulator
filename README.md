# Old Phone Pad Emulator
## This is a solution to the C# coding challenge posted here -> 
##### https://drive.google.com/file/d/1LMV0_YUqC2KqObQPnYd3mgQiIpUSVP7-/view

How to  Install ?

Clone the repo "git clone https://github.com/aakashjaiswal1/OldPhonePadEmulator.git"


Change into the directory "cd OldPhonePadEmulator"

Open the given project in you IDE (Rider discussed here)

After opening the project IDE will automatically detect .sln dependencies and set up the project.

Restore the dependencies using "dotnet restore"

## How to test the function to emulate phonePad ?

In the file PhonePadConvertor.cs modify the line WriteLine(OldPhonePad("222")) to test it with actual input.

The current UTs can be found at OldPhonePadEmulator/PhonePadText.Tests/PhonePadConvertorSolutionTest.cs
