namespace ConcatLoopBasedEncryption
{
    internal class ConcatLoopBasedEncryptor
    {
        public static string Encrypt(string stringToEncrypt, int numberOfIterations)
        {
            var subject = stringToEncrypt.AsEnumerable();

            for (int i = 0; i < numberOfIterations; i++)
            {
                var oddIndexedChars = subject.Where((c, i) => int.IsOddInteger(i));
                var evenIndexedChars = subject.Where((c, i) => int.IsEvenInteger(i));

                subject = oddIndexedChars.Concat(evenIndexedChars);
            }

            return string.Join("", subject);
        }
    }
}
