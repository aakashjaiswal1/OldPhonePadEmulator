# OldPhonePadEmulator

This is a solution to the C# coding challenge posted [here](https://drive.google.com/file/d/1LMV0_YUqC2KqObQPnYd3mgQiIpUSVP7-/view).

## How to Install?

1. Clone the repo:
   ```bash
   git clone https://github.com/aakashjaiswal1/OldPhonePadEmulator.git
   ```

2. Change into the directory:
   ```bash
   cd OldPhonePadEmulator
   ```

3. Open the given project in your IDE (Rider discussed here).  
   After opening the project, the IDE will automatically detect `.sln` dependencies and set up the project.

4. Restore the dependencies using:
   ```bash
   dotnet restore
   ```

## How to Test the Function to Emulate PhonePad?

In the file **`OldPhonePadEmulator/PhonePadText/PhonePadConverter.cs`**, modify the line:
```csharp
WriteLine(OldPhonePad("222"))
```
to test it with actual input.

The current unit tests can be found at:
```
OldPhonePadEmulator/PhonePadText.Tests/PhonePadConvertorSolutionTest.cs
```
