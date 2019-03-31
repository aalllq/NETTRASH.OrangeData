using System;

namespace NETTRASH.OrangeData.Nebula.Interfaces
{
    public interface ICommand
    {
        #region Interface members


        string Log { get; }

        ICommandResult Execute();



        #endregion
    }
}
