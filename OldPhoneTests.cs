using Xunit;

namespace OldPhonePad.Tests
{
    public class OldPhoneTests
    {
        [Theory]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "????")]
        public void OldPhonePad_ProducesExpectedOutput(string input, string expected)
        {
            var result = OldPhone.OldPhonePad(input);
            Assert.Equal(expected, result);
        }
    }
}
