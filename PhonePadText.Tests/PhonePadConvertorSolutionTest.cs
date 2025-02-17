using JetBrains.Annotations;
using Xunit;

namespace PhonePadText.Tests;

[TestSubject(typeof(PhonePadConvertorSolution))]
public class PhonePadConvertorSolutionTest
{
    [Theory]
    // Base condition when no string is passed
    [InlineData("", "")]
    // Should Return the correct string 
    [InlineData("222", "C")] 
    [InlineData("33#", "E")] 
    [InlineData("227*#", "B")] 
    [InlineData("4433555 555666#", "HELLO")] 
    // Passing a null value
    [InlineData(null, "")] 
    [InlineData("8 88777444666*664#", "TURING")] 
    [InlineData("        #", "")] 
    [InlineData("*********  333333  ****      #", "")] 
    [InlineData("*********  333333 ***************       #", "")] 
    [InlineData("*********  333333 ***************     2233*  #", "B")] 
    // I am expecting the ideal behaviour to be in a cycle how it happens in the actual phone i.e A.B.C.A.B.C ...
    [InlineData("2222222  #", "A")] 
    [InlineData("2222222 *  #", "")] 
    
    public void PhonePadOutputTest(string input, string expected)
    {
        // Act
        string result = PhonePadConvertorSolution.OldPhonePad(input);

        // Assert
        Assert.Equal(expected, result);
    }
    
}