using ConcatLoopBasedEncryption;

Console.WriteLine(ConcatLoopBasedEncryptor.Encrypt("123456", 2));
Console.WriteLine(ConcatLoopBasedEncryptor.Encrypt("12345", 3));

Console.WriteLine(ConcatLoopBasedEncryptor.Decrypt("415263", 2));
Console.WriteLine(ConcatLoopBasedEncryptor.Decrypt("31425", 3));