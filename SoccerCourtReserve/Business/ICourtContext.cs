using EFCoreCodeFirstSample.Models;
using System.Collections.Generic;

namespace SoccerCourtReserve.Business
{
    public interface ICourtContext
    {
        List<Court> GetCourtInfo();
    }
}