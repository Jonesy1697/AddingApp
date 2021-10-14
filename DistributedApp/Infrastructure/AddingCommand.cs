using System;
using AppliedSystems.Messaging.Messages;

namespace Infrastructure
{
    [MessageName(nameof(AddingCommand))]
    [Serializable]
    public class AddingCommand  : ICommand
    {
        public int TermOne { get; set; }
        public int TermTwo { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v1">Integer parsing to TermOne</param>
        /// <param name="v2">Integer parsing to TermTwo</param>
        public AddingCommand(int v1, int v2)
        {
            TermOne = v1;
            TermTwo = v2;
        }
    }
}
