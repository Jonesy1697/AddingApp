using System;

namespace Infrastructure
{
    public interface IOutputWriter
    {
        void PrintInt(int output);
        void PrintString(string output);
        void PrintError(string output);
    }
}