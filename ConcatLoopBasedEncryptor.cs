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

        public static string Decrypt(string stringToDecrypt, int numberOfIterations)
        {
            if (string.IsNullOrWhiteSpace(stringToDecrypt))
            {
                return stringToDecrypt;
            }

            var subject = stringToDecrypt.ToArray();

            for (int i = 0; i < numberOfIterations; i++)
            {
            var oddChars = subject[..(subject.Length / 2)];
            var evenChars = subject[(subject.Length / 2)..];

            char[] result = new char[stringToDecrypt.Length];

                for (int j = 0; j < subject.Length; j++)
                {
                    if (int.IsEvenInteger(j))
                    {
                        result[j] = evenChars[j / 2];
                    }
                    else
                    {
                        int oddCharIndex = (int)Math.Floor(j / 2f);
                        result[j] = oddChars[oddCharIndex];
                    }
                }
                subject = result.ToArray();
            }

            return string.Join("", subject);
        }
    }
}
