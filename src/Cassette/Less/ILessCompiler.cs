﻿namespace Cassette.Less
{
    public interface ILessCompiler
    {
        string Compile(string lessSource, string sourceFilename, IFileSystem fileSystem);
    }
}